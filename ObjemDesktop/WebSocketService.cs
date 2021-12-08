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
            Console.WriteLine(e.Data);
        }

        protected override void OnOpen()
        {
            Console.WriteLine("Connected!!");
        }

        protected override void OnClose(CloseEventArgs e)
        {
            base.OnClose(e);
        }
    }
}
