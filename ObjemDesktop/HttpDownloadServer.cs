using System.IO;
using WebSocketSharp.Server;

namespace ObjemDesktop
{
    class HttpDownloadServer
    {
        private HttpServer _server;
        private readonly byte[] _binary;
        private readonly int _port;
        public HttpDownloadServer(string filePath,int port)
        {
            FileStream fs = new FileStream(filePath, FileMode.Open);
            BinaryReader bReader = new BinaryReader(fs);
            _binary = new byte[fs.Length];
            bReader.Read(_binary, 0, (int)fs.Length);
            _port = port;
        }
        public HttpDownloadServer(byte[] binary, int port)
        {
            _binary = binary;
            _port = port;

        }
        public void Start()
        {
            _server = new HttpServer(_port);
            _server.OnGet += (sender, e) =>
            {
                var response = e.Response;
                response.AddHeader("Content-Disposition", "attachment;filename = \"CAcert.crt\"");
                response.ContentType = "application/octet-stream";
                response.ContentLength64 = _binary.Length;
                response.Close(_binary, true);
            };
            _server.Start();

        }




        public void Stop()
        {
            _server.Stop();
        }
    }
}
