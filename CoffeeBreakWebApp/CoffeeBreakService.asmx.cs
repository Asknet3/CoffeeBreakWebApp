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
        [WebMethod]
        public void UpdateMessage()
        {
            HttpRequest Request = HttpContext.Current.Request;
            string username = Request["usrcfgsend"];

            if(!String.IsNullOrEmpty(username))
            {
                //Aggiorno il file con il nome
                System.IO.File.WriteAllText(Server.MapPath("~/coffeBreak/myname.txt"), username);
            }            
        }
    }
}
