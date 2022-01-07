using ObjemDesktop.VolumeManaging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;


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
            VolumeManager _VolumeManager = VolumeManager.Instance;
            WSServer WSS = new WSServer();
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
    }
}
