using Microsoft.Win32;
using System;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;
using System.Net;
using System.Security.Cryptography.X509Certificates;

namespace ObjemDesktop
{
    public partial class MainWindow : Form
    {   
        private static  MainWindow instance;
        private readonly List<IPConboBoxValue> list = new List<IPConboBoxValue> { };
        private MainWindow()
        {
            new NotifyIcon
            {
                Visible = true,
                Icon = new Icon(AppDomain.CurrentDomain.BaseDirectory + @"\resources\favicon.ico")
            };
            Console.WriteLine("new");
            InitializeComponent();
        }

        public static MainWindow Instance
        {
            get { 
                if(instance is null) instance = new MainWindow();
                return instance;
            }
        }


        private void MainWindow_Load(object sender, EventArgs e)
        {
            List<IPAddress> ipAddresses = IPAddressUtil.GetIPAdressList();
            ipAddresses.ForEach((ip) => {
                Image qrcode = QrGenerater.Generate(ip.ToString(), QRCodeBox.Width, QRCodeBox.Height);
                X509Certificate2 cert = new X509Certificate2($"certs\\{ip}.pfx");
                list.Add(new IPConboBoxValue(ip,qrcode,cert));
            });
            IpAddressComboBox.DisplayMember = "ipaddress";
            IpAddressComboBox.DataSource=list.ToArray();
            QRCodeBox.Image = list[0].QRCode;
            SetStatuslabel(0);
        }

        private void OpenSettingsBtn_Click(object sender, EventArgs e)
        {
            new SettingWindow().ShowDialog();   
        }

        private void IpAddressComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            WSServer WSS = WSServer.Instance;
            IPConboBoxValue selected = (IPConboBoxValue)IpAddressComboBox.SelectedItem;
            WSS.ServerCertificate = selected.Certificate;
            WSS.Restart();
            QRCodeBox.Image = selected.QRCode;
        }

        public void SetStatuslabel(int count)
        {
            if (count >= 1)
            {
                Invoke((MethodInvoker)(() => status.Text = String.Format("connected {0} client",count)));
            }
            else
            {
                Invoke((MethodInvoker)(() => status.Text = "Not connected"));
            }
        }
    }
}
