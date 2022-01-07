using System;
using WebSocketSharp;
using WebSocketSharp.Server;

namespace ObjemDesktop
{
    public sealed class WSServer
    {
        public WebSocketServer Server;
        private static WSServer instance;
        public static WSServer Instance
        {
            get 
            {
                if (instance is null) instance = new WSServer();
                return instance;
            }
        }
        public void Start(int port)
        {
            Server = new WebSocketServer(port);
            Server.AddWebSocketService<WebSocketService>("/");
            Server.Start();
        }
    }
}
