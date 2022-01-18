using System;
using System.Diagnostics;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows.Forms;

namespace ObjemDesktop.window
{
    public partial class DownLoadQRForm : Form
    {
        private readonly IPAddress IPAddress;
        private HttpDownloadServer DownloadServer;
        private string url;
        public DownLoadQRForm(IPAddress address)
        {
            IPAddress = address;
            InitializeComponent();
        }

        private void DownLoadQRForm_Load(object sender, EventArgs e)
        {
            int port = 4000;
            url = $"{IPAddress}:{port}";
            var QR = QrGenerater.Generate(url, DownloadQR.Width, DownloadQR.Height);
            var cert = Certificate.CertificateUtil.ExportToPemString(new X509Certificate2(@"certs\CAcert.pfx"));

            byte[] binary = Encoding.UTF8.GetBytes(cert);

            DownloadQR.Image = QR;
            DownloadLinkLabel.Text = url;
            DownloadServer = new HttpDownloadServer(binary, port);
            DownloadServer.Start();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            DownloadServer.Stop();
            this.Close();
        }

        private void DownLoadQRForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            DownloadServer.Stop();
        }

        private void DownloadLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo info = new ProcessStartInfo()
            {
                FileName = url,
                UseShellExecute = true,
            };
            Process.Start(info);
        }
    }
}
