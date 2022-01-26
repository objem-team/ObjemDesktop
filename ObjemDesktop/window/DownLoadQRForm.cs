using System;
using System.Diagnostics;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows.Forms;

namespace ObjemDesktop.window
{
    public partial class DownLoadQrForm : Form
    {
        private readonly IPAddress _ipAddress;
        private HttpDownloadServer _downloadServer;
        private string _url;
        public DownLoadQrForm(IPAddress address)
        {
            _ipAddress = address;
            InitializeComponent();
        }

        private void DownLoadQRForm_Load(object sender, EventArgs e)
        {
            int port = 4000;
            _url = $"{_ipAddress}:{port}";
            var qr = QrGenerater.Generate(_url, DownloadQR.Width, DownloadQR.Height);
            var cert = Certificate.CertificateUtil.ExportToPemString(new X509Certificate2(@"certs\CAcert.pfx"));

            byte[] binary = Encoding.UTF8.GetBytes(cert);

            DownloadQR.Image = qr;
            DownloadLinkLabel.Text = _url;
            _downloadServer = new HttpDownloadServer(binary, port);
            _downloadServer.Start();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            _downloadServer.Stop();
            this.Close();
        }

        private void DownLoadQRForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _downloadServer.Stop();
        }

        private void DownloadLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo info = new ProcessStartInfo()
            {
                FileName = _url,
                UseShellExecute = true,
            };
            Process.Start(info);
        }
    }
}
