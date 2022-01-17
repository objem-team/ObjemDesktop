using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WebSocketSharp.Server;

namespace ObjemDesktop.window
{
    class HttpDownloadServer
    {
        private HttpServer Server;
        private byte[] Binary;
        private int Port;
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
        public void start()
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




        public void stop()
        {
            Server.Stop();
        }
    }
}
