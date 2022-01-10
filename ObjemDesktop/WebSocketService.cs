using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using WebSocketSharp;
using WebSocketSharp.Server;
using ObjemDesktop.VolumeManaging;
using System.Text.Encodings.Web;
using ObjemDesktop.WebsocketMessageType;

namespace ObjemDesktop
{
    class WebSocketService : WebSocketBehavior
    {
        protected override void OnMessage(MessageEventArgs e)
        {
            try
            {
                WebsocketMessage message = JsonSerializer.Deserialize<WebsocketMessage>(e.Data,new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
                Console.WriteLine(e.Data);

                switch (message.EventName)
                {
                    case "requestSession":
                        {
                            VolumeManager volumeManager = VolumeManager.Instance;
                            var serializeOptions = new JsonSerializerOptions
                            {
                                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                                WriteIndented = true,
                                Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
                                Converters =
                                {
                                    new IconToDataURLJsonConverter()
                                }
                            };
                            var sendMessage = new WebsocketSendMessage("session", volumeManager.list);
                            string jsonString = JsonSerializer.Serialize(sendMessage, serializeOptions);
                            Send(jsonString);
                        }
                        break;

                    case "setVolume":
                        {
                            Console.WriteLine(message.Data);
                            VolumeChangeRequest request = JsonSerializer.Deserialize<VolumeChangeRequest>(message.Data.ToString(), new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
                            VolumeManager volumeManager = VolumeManager.Instance;
                            volumeManager.setVolume(request.ProcessId, request.Volume);
                        }
                        break;
                }
            }
            catch(Exception error)
            {
                //ignore
                Console.WriteLine("cannnot parse");
            }
        }

        protected override void OnOpen()
        {
            MainWindow.Instance.setStatuslabel(Sessions.Count);
        }

        protected override void OnClose(CloseEventArgs e)
        {
            MainWindow.Instance.setStatuslabel(Sessions.Count);
            base.OnClose(e);
        }
    }
}
