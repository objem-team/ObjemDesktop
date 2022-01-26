using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using WebSocketSharp.Server;

namespace ObjemDesktop
{
    public sealed class WSServer
    {
        public WebSocketServer Server { get; set; }
        public X509Certificate2 ServerCertificate { get; set; }
        private static WSServer _instance;
        public int Port { get; set; }
        public static WSServer Instance
        {
            get 
            {
                if (_instance is null) _instance = new WSServer();
                return _instance;
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
