using System;
using System.Globalization;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using WebSocketSharp;
using WebSocketSharp.Server;

namespace ObjemDesktop
{
    public sealed class WSServer
    {
        public WebSocketServer Server { get; set; }
        public X509Certificate2 ServerCertificate { get; set; }
        private static WSServer instance;
        public int Port { get; set; }
        public static WSServer Instance
        {
            get 
            {
                if (instance is null) instance = new WSServer();
                return instance;
            }
        }
        public void Start()
        {
            Server = new WebSocketServer(Port, true);
            Server.AddWebSocketService<WebSocketService>("/");
            Server.SslConfiguration.ClientCertificateRequired = false;
            Server.SslConfiguration.EnabledSslProtocols = System.Security.Authentication.SslProtocols.Tls12;
            Server.SslConfiguration.ClientCertificateValidationCallback = (object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) => { return true; };
            Server.SslConfiguration.ServerCertificate = ServerCertificate;
            Server.Start();
        }

        public void Restart()
        {
            Server.Stop();
            Start();
        }
    }
}
