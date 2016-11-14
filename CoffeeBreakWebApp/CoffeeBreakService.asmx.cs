using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace CoffeeBreakWebApp
{
    /// <summary>
    /// Descrizione di riepilogo per CoffeeBreakService
    /// </summary>
    [WebService(Namespace = "http://localhost:55675/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Per consentire la chiamata di questo servizio Web dallo script utilizzando ASP.NET AJAX, rimuovere il commento dalla riga seguente. 
    [System.Web.Script.Services.ScriptService]
    public class CoffeeBreakService : System.Web.Services.WebService
    {
        public static bool playSound = false;
        public static bool openSpotify = false;

        [WebMethod]
        public void UpdateMessage()
        {
            HttpRequest Request = HttpContext.Current.Request;
            string username = Request["usrcfgsend"];
            string proximity = Request["proximity"];

            if (!String.IsNullOrEmpty(username))
            {
                //Aggiorno il file con il nome
                System.IO.File.WriteAllText(Server.MapPath("~/coffeBreak/myname.txt"), username);
            }

            if (!String.IsNullOrEmpty(proximity) && proximity.Equals("i"))
            {
                playSound = true;
                openSpotify = true;
            }
            else
            {
                playSound = false;
                openSpotify = false;
            }
        }

        [WebMethod]
        public void SetPlay(bool p)
        {
            playSound = p;
        }

        [WebMethod]
        public void SetOpenSpotify(bool s)
        {
            openSpotify = s;
        }

        public static bool GetPlay()
        {
            return playSound;
        }

        public static bool GetOpenSpotify()
        {
            return openSpotify;
        }
    }
}
