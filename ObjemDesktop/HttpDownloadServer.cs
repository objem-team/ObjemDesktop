using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ObjemDesktop.window
{
    class HttpDownloadServer
    {
        private byte[] Binary;
        private Thread Thread;
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

            Thread = new Thread(new ThreadStart(() =>
            {

                HttpListener Listener = new HttpListener();
                Listener.Prefixes.Clear();
                Listener.Prefixes.Add($"http://+:{Port}/");
                Listener.Start();
                while (true)
                {
                    HttpListenerContext context = Listener.GetContext();
                    HttpListenerResponse response = context.Response;
                    response.Headers.Add("Content-Disposition", "attachment;filename = \"CAcert.crt\"");
                    response.ContentLength64 = Binary.Length;
                    Stream output = response.OutputStream;
                    output.Write(Binary, 0, Binary.Length);
                    // You must close the output stream.
                    output.Close();
                }
            }));
            Thread.Start();

        }

        public void stop()
        {
            Thread.CurrentThread.Interrupt();
        }
    }
}
