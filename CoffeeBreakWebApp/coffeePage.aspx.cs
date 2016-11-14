using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CoffeeBreakWebApp
{
    public partial class coffeePage : System.Web.UI.Page
    {
        String domain ="http://asknet.redirectme.net/";

        protected void Page_Load(object sender, EventArgs e)
        {
            bool play = CoffeeBreakService.GetPlay();
            bool openSpotify = CoffeeBreakService.GetOpenSpotify();

            bool spotifyinitialStatus = false; ;
            if (!IsPostBack)
                spotifyinitialStatus = true;
            

              if(play)
            {
                ClientScript.RegisterStartupScript(GetType(), "key_dello_script", "$(document).ready(function () {audioElement.play()});", true);

                //Label1.Text = play.ToString();

                //---------------   Resetto a False la riproduzione del suono
                Uri address = new Uri(domain + "CoffeeBreakService.asmx/SetPlay");
                NameValueCollection nameValueCollection = new NameValueCollection();
                nameValueCollection["p"] = "false";
                var webClient = new WebClient();
                webClient.UploadValues(address, "POST", nameValueCollection);
                // --------------
            }       
            
            if(openSpotify && spotifyinitialStatus) // Verifico che spotify sia chiuso e solo in questo caso lo apro
            {
                //System.Diagnostics.Process.Start(Server.MapPath("~/Asset/autoplaySpotify.vbs"));
                System.Diagnostics.Process.Start(@"C:\Users\asknet\AppData\Roaming\Spotify\autoplaySpotify.vbs");

                //---------------   Resetto a False l'apertura di Spotify
                Uri address = new Uri(domain + "CoffeeBreakService.asmx/SetOpenSpotify");
                NameValueCollection nameValueCollection = new NameValueCollection();
                nameValueCollection["s"] = "false";
                var webClient = new WebClient();
                webClient.UploadValues(address, "POST", nameValueCollection);
                // --------------

                spotifyinitialStatus = false; // Avviso che ho già avviato Spotify
            }
        }
    }
}