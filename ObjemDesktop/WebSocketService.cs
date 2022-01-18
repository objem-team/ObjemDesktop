﻿using System;
using System.Text.Json;
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
                            VolumeChangeRequest request = JsonSerializer.Deserialize<VolumeChangeRequest>(message.Data.ToString(), new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
                            VolumeManager volumeManager = VolumeManager.Instance;
                            volumeManager.SetVolume(request.ProcessId, request.Volume,request.IsMuted);
                        }
                        break;
                }
            }
            catch(Exception)
            {
                //ignore
                Console.WriteLine("cannnot parse");
            }
        }

        protected override void OnOpen()
        {
            MainWindow.Instance.SetStatuslabel(Sessions.Count);
        }

        protected override void OnClose(CloseEventArgs e)
        {
            MainWindow.Instance.SetStatuslabel(Sessions.Count);
            base.OnClose(e);
        }
    }
}
