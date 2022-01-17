using CSCore.CoreAudioAPI;
using ObjemDesktop.Certificate;
using ObjemDesktop.VolumeManaging;
using ObjemDesktop.WebsocketMessageType;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebSocketSharp.Server;
using ObjemDesktop.Certificate;
using System.Security.Cryptography.X509Certificates;
using System.Net;

namespace ObjemDesktop
{
    static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [MTAThread]
        static void Main()
        {
            //証明書を取得
            var ipList = IPAddressUtil.getIPAdressList();
            var DIR = "certs";
            var CA_CERT_PATH = $"{DIR}\\CAcert.pfx";
            if (!Directory.Exists(DIR)) Directory.CreateDirectory(DIR);

            if (!File.Exists(CA_CERT_PATH))
            {
               var cert = Certificate.Certificate.CreateCACerttificate();
               CertificateUtil.ExportAsPfx(cert, CA_CERT_PATH);
            }
            var CAcert = new X509Certificate2(CA_CERT_PATH);
            List<IPAddress> notExitsts = ipList.FindAll(ip => !File.Exists($"{DIR}\\{ip}{X509CertificateExtensionType.Crt}"));
            notExitsts.ForEach(ip => 
            {
                var cert = Certificate.Certificate.CreateSignedServerCertificate(CAcert, ip);
                CertificateUtil.ExportAsPfx(cert, $"{DIR}\\{ip}.pfx");
            });

            VolumeManager VolumeManager = VolumeManager.Instance;
            VolumeManager.OnSessionCreated += onSessionCreated;
            VolumeManager.OnSessionExpired += onSessionExpired;
            VolumeManager.OnVolumeChange += onVolumeChanged;
            WSServer WSS = WSServer.Instance;
            WSS.ServerCertificate = new X509Certificate2($"{DIR}\\{ipList[0]}.pfx");
            WSS.Port = 8000;
            WSS.Start();
            //Console.WriteLine(Environment.CommandLine.IndexOf("--no-window"));
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (Environment.CommandLine.IndexOf("--no-window") != -1)
            {
                //最小化で起動    
                MainWindow _MainWindow = MainWindow.Instance;
                Application.Run();
            }
            Application.Run(MainWindow.Instance);
        }

        static void onSessionCreated(object sender,SessionCreatedEventArgs args)
        {
            VolumeManager VolumeManager = VolumeManager.Instance;
            VolumeManager.addSession(args.NewSession);
            WebSocketUtil.broadCastSessions();
        }

        static void onSessionExpired(object sender, SessionExpiredEventArg arg)
        {
            VolumeManager VolumeManager = VolumeManager.Instance;
            VolumeManager.list.Remove(arg.VolumeController);
            WebSocketUtil.broadCastSessions();
        }

        static void  onVolumeChanged(object sender,VolumeChangedEventArgs arg)
        {
            Console.WriteLine(arg.VolumeController.Name);
            WebSocketUtil.SendNewVolume(arg);
        }

    }
}
