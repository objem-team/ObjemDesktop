using System;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows.Forms;

namespace ObjemDesktop.window
{
    public partial class DownLoadQRForm : Form
    {
        private HttpDownloadServer DownloadServer;
        private string url;
        public DownLoadQRForm()
        {
            InitializeComponent();
        }

        private void DownLoadQRForm_Load(object sender, EventArgs e)
        {
            int port = 4000;
            url = $"http://localhost:{port}";
            var QR = QrGenerater.Generate(url, DownloadQR.Width, DownloadQR.Height);
            var cert = Certificate.CertificateUtil.ExportToPemString(new X509Certificate2(@"certs\CAcert.pfx"));

            byte[] binary = Encoding.UTF8.GetBytes(cert);

            DownloadQR.Image = QR;
            DownloadLinkLabel.Text = url;
            DownloadServer = new HttpDownloadServer(binary, port);
            DownloadServer.start();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            DownloadServer.stop();
            this.Close();
        }

        private void DownLoadQRForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            DownloadServer.stop();
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
