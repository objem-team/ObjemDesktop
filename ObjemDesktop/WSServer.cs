using Fleck;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjemDesktop
{
    public sealed class WSServer
    {
        public delegate void OnOpenDelegate(object sender);
        public delegate void onCloseDelegate(object sender);
        public delegate void onMessageDelegate(object sender, String message);

        public event OnOpenDelegate OnOpen;
        public event onCloseDelegate OnClose;
        public event onMessageDelegate OnMessage;

        public WebSocketServer Server = null;

        private static WSServer instance = new WSServer();

        private WSServer() { }

        public static WSServer Instance
        {
            get
            {
                return instance;
            }
        }
        public void Start(string ipaddress)
        {
            Server = new WebSocketServer(ipaddress);
            Server.Start(socket =>
            {
                socket.OnOpen = () => OnOpen?.Invoke(this);
                socket.OnClose = () => OnClose?.Invoke(this);
                socket.OnMessage = message => OnMessage?.Invoke(this, message);
            });
        }
    }
}
