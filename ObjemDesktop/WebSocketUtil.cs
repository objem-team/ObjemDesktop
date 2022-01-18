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
                    new IconToDataURLJsonConverter()
                }
        };

        public static void BroadCastSessions()
        {
            WSServer WSS = WSServer.Instance;
            WebSocketServiceHost WebSocketService = WSS.Server.WebSocketServices["/"];
            VolumeManager volumeManager = VolumeManager.Instance;
            var sendMessage = new WebsocketSendMessage("session", volumeManager.list);
            string jsonString = JsonSerializer.Serialize(sendMessage, serializeOptions);
            WebSocketService.Sessions.Broadcast(jsonString);
        }

        public static void SendNewVolume(VolumeChangedEventArgs arg)
        {
            VolumeChangeMessage message = new VolumeChangeMessage(arg.VolumeController.ProcessId, arg.NewVolume, arg.IsMuted);
            WSServer WSS = WSServer.Instance;
            WebSocketServiceHost WebSocketService = WSS.Server.WebSocketServices["/"];
            var sendMessage = new WebsocketSendMessage("newvolume",message);
            string jsonString = JsonSerializer.Serialize(sendMessage, serializeOptions);
            WebSocketService.Sessions.Broadcast(jsonString);
        }
    }
}
