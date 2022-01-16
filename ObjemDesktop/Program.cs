using CSCore.CoreAudioAPI;
using ObjemDesktop.VolumeManaging;
using ObjemDesktop.WebsocketMessageType;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebSocketSharp.Server;

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
            VolumeManager VolumeManager = VolumeManager.Instance;
            VolumeManager.OnSessionCreated += onSessionCreated;
            VolumeManager.OnSessionExpired += onSessionExpired;
            VolumeManager.OnVolumeChange += onVolumeChanged;
            WSServer WSS = WSServer.Instance;
            int WSSPort = 8000;
            WSS.Start(WSSPort);
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
