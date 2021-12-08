using System;
using WebSocketSharp;
using WebSocketSharp.Server;

namespace ObjemDesktop
{
    class WSServer
    {
        public delegate void OnOpenDelegate(object sender);
        public delegate void onCloseDelegate(object sender);
        public delegate void onMessageDelegate(object sender, String message);

        public event OnOpenDelegate OnOpen;
        public event onCloseDelegate OnClose;
        public event onMessageDelegate OnMessage;

        public WebSocketServer Server = null;

        private static WSServer instance = new WSServer();

        class Service: WebSocketBehavior
        {
            protected override void OnMessage(MessageEventArgs e)
            {
                Console.WriteLine(e.Data);
            }

            protected override void OnOpen()
            {
                Console.WriteLine("OnOpen");
            }
        }

        private WSServer() {
            Server = new WebSocketServer("ws://127.0.0.1:8000");
            Server.AddWebSocketService<Service>("/");

        }

        public static WSServer Instance
        {
            get
            {   
                return instance;
            }
        }
        public void Start(string ipaddress)
        {
            Server.Start();
            }
    }
}
