using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebSocketSharp;
using WebSocketSharp.Server;

namespace ObjemDesktop
{
    class WebSocketService : WebSocketBehavior
    {
        protected override void OnMessage(MessageEventArgs e)
        {
            EventManager manager = EventManager.Instance;
            manager.onMessage(e);
        }

        protected override void OnOpen()
        {
            EventManager manager = EventManager.Instance;
            manager.onOpen();
        }

        protected override void OnClose(CloseEventArgs e)
        {
            EventManager manager = EventManager.Instance;
            manager.onClose();
            base.OnClose(e);
        }
    }
}
