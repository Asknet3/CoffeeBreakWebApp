using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
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



        [WebMethod]
        public void SendSocket()
        {
            const int PORT_NO = 5000;
            TcpClient client = new TcpClient();
            IPEndPoint IP_End = new IPEndPoint(IPAddress.Parse("127.0.0.1"), PORT_NO);
    
            StreamReader STR;
            StreamWriter STW;
            string receive;
            string text_to_send;
            

        //---data to send to the server---
        string textToSend = "Ciaoooooo sono le " + DateTime.Now.ToString();

            try
            {
                client = new TcpClient();
                client.Connect(IP_End);
                if (client.Connected)
                {
                    STW = new StreamWriter(client.GetStream());
                    STR = new StreamReader(client.GetStream());
                    STW.AutoFlush = true;

                    STW.WriteLine(textToSend);
                    
                    
                    //backgroundWorker1.RunWorkerAsync(); // Start receiving data in background 
                }

            }
            catch (Exception x)
            {
                Console.Write(x.Message.ToString());
            }
            
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
