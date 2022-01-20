using System.IO;
using WebSocketSharp.Server;

namespace ObjemDesktop.window
{
    class HttpDownloadServer
    {
        private HttpServer Server;
        private readonly byte[] Binary;
        private readonly int Port;
        public HttpDownloadServer(string filePath,int port)
        {
            FileStream fs = new FileStream(filePath, FileMode.Open);
            BinaryReader bReader = new BinaryReader(fs);
            Binary = new byte[fs.Length];
            bReader.Read(Binary, 0, (int)fs.Length);
            Port = port;
        }
        public HttpDownloadServer(byte[] binary, int port)
        {
            Binary = binary;
            Port = port;

        }
        public void Start()
        {
            Server = new HttpServer(Port);
            Server.OnGet += (sender, e) =>
            {
                var request = e.Request;
                var response = e.Response;
                response.AddHeader("Content-Disposition", "attachment;filename = \"CAcert.crt\"");
                response.ContentType = "application/octet-stream";
                response.ContentLength64 = Binary.Length;
                response.Close(Binary, true);
            };
            Server.Start();

        }




        public void Stop()
        {
            Server.Stop();
        }
    }
}
