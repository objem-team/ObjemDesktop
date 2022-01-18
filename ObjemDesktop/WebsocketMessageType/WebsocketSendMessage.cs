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
