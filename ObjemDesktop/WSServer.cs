using Fleck;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public void start()
        {
            var server = new WebSocketServer("ws://127.0.0.1:8000");
            server.Start(socket =>
            {
                socket.OnOpen = () => OnOpen?.Invoke(this);
                socket.OnClose = () => OnClose?.Invoke(this);
                socket.OnMessage = message => OnMessage?.Invoke(this,message);
            });
        }
    }
}
