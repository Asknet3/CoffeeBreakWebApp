using Microsoft.Win32.TaskScheduler;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
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
                //var user = System.Security.Principal.WindowsIdentity.GetCurrent().User;
                //var userName = user.Translate(typeof(System.Security.Principal.NTAccount));

                //ProcessStartInfo info = new ProcessStartInfo();
                //info.FileName = @"C:\WebSite\CoffeeBreakWebApp\Asset\autoplaySpotify.vbs";

                //info.WorkingDirectory = System.IO.Path.GetDirectoryName(info.FileName);




                //Process.Start(@"C:\PSTools\PsExec.exe notepad");

                //Process.Start(HttpContext.Current.Server.MapPath("~/Asset/autoplaySpotify.vbs"));
                //Process.Start(@"C:\Users\asknet\AppData\Roaming\Spotify\autoplaySpotify.vbs");
                //Process.Start(@"C:\WebSite\CoffeeBreakWebApp\Asset\autoplaySpotify.vbs");




                CreateProcessAsUserWrapper.LaunchChildProcess(@"C:\Users\asknet\AppData\Roaming\Spotify\Spotify.exe");
               // ProcessAsCurrentUser.CreateProcessAsCurrentUser(@"C:\Windows\notepad.exe");




                //string m_stattransfer_loc = @"C:\Program Files (x86)\Notepad++\notepad++.exe";
                //string m_stattransfer_file = @"C:\WebSite\CoffeeBreakWebApp\Asset\";



                //ProcessStartInfo processInfo = new ProcessStartInfo("\"" + m_stattransfer_loc + "\"");

                //processInfo.Arguments = "\"" + m_stattransfer_file + "\"";
                //processInfo.RedirectStandardOutput = true;
                //processInfo.RedirectStandardError = true;
                //processInfo.UseShellExecute = false;
                //processInfo.ErrorDialog = false;
                ////processInfo.CreateNoWindow = true;
                //processInfo.WindowStyle = ProcessWindowStyle.Normal;
                //processInfo.WorkingDirectory = @"C:\Program Files (x86)\Notepad++\";


                //Process batchProcess = new Process();
                //batchProcess.StartInfo = processInfo;
                //batchProcess.Start();











                //log.InnerHtml = userName + System.IO.Path.GetDirectoryName(info.FileName);

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










