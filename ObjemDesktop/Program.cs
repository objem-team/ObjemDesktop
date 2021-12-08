using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjemDesktop
{
    static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Console.WriteLine(Environment.CommandLine.IndexOf("--no-window"));
            WSServer WSS = WSServer.Instance;
            WSS.OnOpen += (sender) => { Console.WriteLine("onopen"); };

            string WSAddress = "ws://0.0.0.0:8000";
            WSS.Start(WSAddress);
            if (Environment.CommandLine.IndexOf("--no-window") != 0)
            {
                //最小化で起動    
                new MainWindow();
                Application.Run();
            }
            Application.Run(new MainWindow());
        }
    }
}
