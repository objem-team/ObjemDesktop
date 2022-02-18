using CSCore.CoreAudioAPI;
using ObjemDesktop.Certificate;
using ObjemDesktop.VolumeManaging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Security.Cryptography.X509Certificates;
using System.Net;
using System.Security.Principal;
using ObjemDesktop.Properties;
using ObjemDesktop.window;

namespace ObjemDesktop
{
    static class Program
    {
        static OMFService service = null;
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [MTAThread]
        static void Main()
        {
            StartService();
            service = new OMFService();
            //Console.WriteLine(Environment.CommandLine.IndexOf("--no-window"));
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (Environment.CommandLine.IndexOf("--no-window", StringComparison.Ordinal) != -1)
            {
                //最小化で起動    
                MainWindow mainWindow = MainWindow.Instance;
                Application.Run();
            }
            Console.WriteLine(WSServer.Instance.Server.WebSocketServices.Count);
            Application.Run(MainWindow.Instance);
            
        }

       public static void StartService()
        {
            
            //証明書を取得
            var ipList = IPAddressUtil.GetIpAdressList();
            const string DIR = "certs";
            var caCertPath = $"{DIR}\\CAcert.pfx";


            if (!Directory.Exists(DIR)) Directory.CreateDirectory(DIR);

            if (!File.Exists(caCertPath))
            {
                var cert = Certificate.Certificate.CreateCertificate();
                CertificateUtil.ExportAsPfx(cert, caCertPath);
            }
            var cAcert = new X509Certificate2(caCertPath);
            List<IPAddress> notExitsts = ipList.FindAll(ip => !File.Exists($"{DIR}\\{ip}{X509CertificateExtensionType.Crt}"));
            notExitsts.ForEach(ip => 
            {
                var cert = Certificate.Certificate.CreateSignedServerCertificate(cAcert, ip);
                CertificateUtil.ExportAsPfx(cert, $"{DIR}\\{ip}.pfx");
            });

            var foundIndex = 0;
            if(Settings.Default.ServerIpAddress != null)
            {
                try
                {
                    foundIndex = ipList.FindIndex(ip => ip.Equals(IPAddress.Parse(Settings.Default.ServerIpAddress)));
                }
                catch (Exception) { 
                    //Ignore
                   }
            }
            
            var index = foundIndex < 0 ? 0 : foundIndex;
            VolumeManager.initialize();
            var volumeManager = VolumeManager.Instance;
            volumeManager.OnSessionCreated += OnSessionCreated;
            volumeManager.OnSessionExpired += OnSessionExpired;
            volumeManager.OnVolumeChange += OnVolumeChanged;
            
            var wss = WSServer.Instance;
            if(wss.Server != null && wss.Server.IsListening) wss.Server.Stop();
            wss.ServerCertificate = new X509Certificate2($"{DIR}\\{ipList[index]}.pfx");
            wss.Port = 8000;
            wss.Start();

        }


        static void OnSessionCreated(object sender,SessionCreatedEventArgs args)
        {
            VolumeManager VolumeManager = VolumeManager.Instance;
            VolumeManager.AddSession(args.NewSession);
            WebSocketUtil.BroadCastSessions();
        }

        static void OnSessionExpired(object sender, SessionExpiredEventArg arg)
        {
            VolumeManager VolumeManager = VolumeManager.Instance;
            VolumeManager.List.Remove(arg.VolumeController);
            WebSocketUtil.BroadCastSessions();
        }

        static void  OnVolumeChanged(object sender,VolumeChangedEventArgs arg)
        {
            WebSocketUtil.SendNewVolume(arg);
        }
    }
}
