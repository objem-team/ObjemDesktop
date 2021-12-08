using System;
using WebSocketSharp;
using WebSocketSharp.Server;

namespace ObjemDesktop
{
    public sealed class WSServer
    {
        public WebSocketServer Server = null;
        private static WSServer instance = new WSServer();
        private WSServer() {
        }
        public static WSServer Instance
        {
            get {return instance;}
        }
        public void Start(int port)
        {
            Server = new WebSocketServer(port);
            Server.AddWebSocketService<WebSocketService>("/");
            Server.Start();
        }
    }
}
