using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace ObjemDesktop.window
{
    public partial class MainWindow : Form
    {   
        private static  MainWindow _instance;
        private readonly List<IpComboBoxValue> _list = new List<IpComboBoxValue>();
        private MainWindow()
        {
            new NotifyIcon
            {
                Visible = true,
                Icon = new Icon(AppDomain.CurrentDomain.BaseDirectory + @"\resources\favicon.ico")
            };
            InitializeComponent();
        }

        public static MainWindow Instance => _instance ?? (_instance = new MainWindow());


        private void MainWindow_Load(object sender, EventArgs e)
        {
            List<IPAddress> ipAddresses = IPAddressUtil.GetIpAdressList();
            ipAddresses.ForEach((ip) => {
                Image qrcode = QrGenerater.Generate(ip.ToString(), QRCodeBox.Width, QRCodeBox.Height);
                X509Certificate2 cert = new X509Certificate2($"certs\\{ip}.pfx");
                _list.Add(new IpComboBoxValue(ip,qrcode,cert));
            });
            IpAddressComboBox.DisplayMember = "IpAddress";
            IpAddressComboBox.DataSource=_list.ToArray();
            QRCodeBox.Image = _list[0].QrCode;
            SetStatuslabel(0);
        }

        private void OpenSettingsBtn_Click(object sender, EventArgs e)
        {
            new SettingWindow().ShowDialog();   
        }

        private void IpAddressComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            WSServer wss = WSServer.Instance;
            IpComboBoxValue selected = (IpComboBoxValue)IpAddressComboBox.SelectedItem;
            wss.ServerCertificate = selected.Certificate;
            wss.Restart();
            QRCodeBox.Image = selected.QrCode;
        }

        public void SetStatuslabel(int count)
        {
            if (count >= 1)
            {
                Invoke((MethodInvoker)(() => status.Text = $"connected {count} client"));
            }
            else
            {
                Invoke((MethodInvoker)(() => status.Text = "Not connected"));
            }
        }
    }
}
