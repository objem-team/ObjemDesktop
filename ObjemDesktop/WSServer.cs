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
        public WebSocketServer Server;
        private static WSServer instance;
        public static WSServer Instance
        {
            get 
            {
                if (instance is null) instance = new WSServer();
                return instance;
            }
        }
        public void Start(int port)
        {
            Server = new WebSocketServer(port,true);
            Server.AddWebSocketService<WebSocketService>("/");
            Server.SslConfiguration.ClientCertificateRequired = false;
            Server.SslConfiguration.EnabledSslProtocols = System.Security.Authentication.SslProtocols.None;
            Server.SslConfiguration.CheckCertificateRevocation = false;
            Server.SslConfiguration.ClientCertificateValidationCallback = (object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) => { return true; };
            Server.SslConfiguration.ServerCertificate = new X509Certificate2("cert.pfx", "password");
            Server.Start();
        }
    }
}
