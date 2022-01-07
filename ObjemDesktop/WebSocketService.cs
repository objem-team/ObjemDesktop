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
                WebsocketMessage message = JsonSerializer.Deserialize<WebsocketMessage>(e.Data);
                Console.WriteLine(message.EventName);

                switch (message.EventName)
                {
                    case "requestSession":
                        {
                            VolumeManager volumeManager = VolumeManager.Instance;
                            var serializeOptions = new JsonSerializerOptions
                            {
                                WriteIndented = true,
                                Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
                                Converters =
                            {
                                new IconToBase64JsonConverter()
                            }
                            };

                            string jsonString = JsonSerializer.Serialize(volumeManager.list, serializeOptions);
                            Sessions.Broadcast(jsonString);
                        }
                        break;

                    case "setVolume":
                        {
                            VolumeChangeRequest request = JsonSerializer.Deserialize<VolumeChangeRequest>(message.Data);
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
