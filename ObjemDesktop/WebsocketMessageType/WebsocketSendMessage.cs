using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjemDesktop.WebsocketMessageType
{
    class WebsocketSendMessage
    {
        public string EventName { get; set; }
        public object Data { get; set; }

        public WebsocketSendMessage(string eventName, object data)
        {
            EventName = eventName;
            Data = data;
        }
    }
}
