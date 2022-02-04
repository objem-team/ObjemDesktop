using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.Json;
using WebSocketSharp;
using WebSocketSharp.Server;
using ObjemDesktop.VolumeManaging;
using System.Text.Encodings.Web;
using ObjemDesktop.Config;
using ObjemDesktop.WebsocketMessageType;
using ObjemDesktop.window;

namespace ObjemDesktop
{
    class WebSocketService : WebSocketBehavior
    {
        protected override void OnMessage(MessageEventArgs e)
        {
            try
            {
                WebsocketMessage message = JsonSerializer.Deserialize<WebsocketMessage>(e.Data, new JsonSerializerOptions {PropertyNameCaseInsensitive = true});
                if (message is null) return;
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
                                new IconToDataUrlJsonConverter()
                            }
                        };
                        var sendMessage = new WebsocketSendMessage("session", volumeManager.List);
                        string jsonString = JsonSerializer.Serialize(sendMessage, serializeOptions);
                        Send(jsonString);
                    }
                        break;

                    case "setVolume":
                    {
                        VolumeChangeRequest request = JsonSerializer.Deserialize<VolumeChangeRequest>(
                            message.Data.ToString(), new JsonSerializerOptions {PropertyNameCaseInsensitive = true});
                        if (request is null) return;
                        VolumeManager volumeManager = VolumeManager.Instance;
                        volumeManager.SetVolume(request.ProcessId, request.Volume, request.IsMuted);
                    }
                        break;
                    case "requestShortcuts":
                    {
                        var serializeOptions = new JsonSerializerOptions
                        {
                            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                            WriteIndented = true,
                            Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
                        };
                        var guids = Properties.Settings.Default.EnabledShortcuts.Cast<string>().ToList();
                        var sendMessage = new WebsocketSendMessage("shortcuts", JsonSerializer.Serialize(guids));
                        string jsonString = JsonSerializer.Serialize(sendMessage, serializeOptions);
                        Send(jsonString);
                        break;
                    }
                    case "requestShortcutIcon":
                    {
                        var guid = Guid.Parse(message.Data.ToString());
                        if (!File.Exists($"icons/{guid}.png")) return;
                        var serializeOptions = new JsonSerializerOptions
                        {
                            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                            WriteIndented = true,
                            Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
                            Converters =
                            {
                                new BitmapToDataUrlJsonConverte()
                            }
                        };
                        var sendMessage = new WebsocketSendMessage("shortcutIcon", new Shortcut(guid,new Bitmap($"icons/{guid}.png")));
                        string jsonString = JsonSerializer.Serialize(sendMessage, serializeOptions);
                        Send(jsonString);
                        break;
                    }
                    case "doshortcut":
                        try
                        {
                            var guid = Guid.Parse(message.Data.ToString());
                            var shortcut = UserShortcuts.Instance.Shortcuts.Find(s => s.Guid.Equals(guid));
                            shortcut.Execute();
                        }
                        catch (Exception)
                        {
                            //ignore
                        }

                        break;
                }
            }
            catch (Exception)
            {
                //ignore
                Console.WriteLine("can not parse");
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