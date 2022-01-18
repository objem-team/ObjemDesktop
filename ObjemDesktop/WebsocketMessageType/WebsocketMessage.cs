namespace ObjemDesktop
{
    class WebsocketMessage
    {
        public string EventName { get; set; }
        public object Data { get; set; }

        public WebsocketMessage(string eventName, object data) {
            EventName = eventName;
            Data = data;
        }
    }
}
