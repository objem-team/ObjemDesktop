using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebSocketSharp;

namespace ObjemDesktop
{
    class EventManager
    {
        private static EventManager manager = new EventManager();

        public delegate void OnOpenDelegate(object sender);
        public delegate void onCloseDelegate(object sender);
        public delegate void onMessageDelegate(object sender, MessageEventArgs e);

        public event OnOpenDelegate OnOpenEvent;
        public event onCloseDelegate OnCloseEvent;
        public event onMessageDelegate OnMessageEvent;
        private EventManager(){}
        public static EventManager Instance
        {
            get { return manager; }
        }

        public void onOpen()
        {
            OnOpenEvent?.Invoke(this);
        }

        public void onClose()
        {
            OnCloseEvent?.Invoke(this);
        }

        public void onMessage(MessageEventArgs e)
        {
            OnMessageEvent?.Invoke(this,e);
        }
    }
}
