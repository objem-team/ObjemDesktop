using ObjemDesktop.VolumeManaging;
using ObjemDesktop.WebsocketMessageType;
using System.Text.Encodings.Web;
using System.Text.Json;
using WebSocketSharp.Server;

namespace ObjemDesktop
{
    class WebSocketUtil
    {
        public static JsonSerializerOptions serializeOptions  = new JsonSerializerOptions
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            WriteIndented = true,
            Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
            Converters =
                {
                    new IconToDataUrlJsonConverter()
                }
        };

        public static void BroadCastSessions()
        {
            var wss = WSServer.Instance;
            WebSocketServiceHost webSocketService = wss.Server.WebSocketServices["/"];
            var volumeManager = VolumeManager.Instance;
            var sendMessage = new WebsocketSendMessage("session", volumeManager.List);
            var jsonString = JsonSerializer.Serialize(sendMessage, serializeOptions);
            webSocketService.Sessions.Broadcast(jsonString);
        }

        public static void SendNewVolume(VolumeChangedEventArgs arg)
        {
            VolumeChangeMessage message = new VolumeChangeMessage(arg.VolumeController.ProcessId, arg.NewVolume, arg.IsMuted);
            WSServer wss = WSServer.Instance;
            WebSocketServiceHost webSocketService = wss.Server.WebSocketServices["/"];
            var sendMessage = new WebsocketSendMessage("newvolume",message);
            string jsonString = JsonSerializer.Serialize(sendMessage, serializeOptions);
            webSocketService.Sessions.Broadcast(jsonString);
        }
    }
}
