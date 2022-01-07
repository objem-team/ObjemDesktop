using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjemDesktop
{
    class WebsocketMessage
    {
        public string EventName { get; set; }
        public string Data { get; set; }

        public WebsocketMessage(string eventName, string data) {
            EventName = eventName;
            Data = data;
        }
    }
}
