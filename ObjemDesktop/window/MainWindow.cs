using Microsoft.Win32;
using System;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using ObjemDesktop.Certificate;

namespace ObjemDesktop
{
    public partial class MainWindow : Form
    {   
        private static  MainWindow instance;
        private static bool didLoaded;
        private NotifyIcon notifyIcon;
        private SettingWindow SettingWindow = new SettingWindow();
        private List<IPConboBoxValue> list = new List<IPConboBoxValue> { };
        private MainWindow()
        {
            notifyIcon = new NotifyIcon();
            notifyIcon.Visible = true;
            notifyIcon.Icon = new Icon(AppDomain.CurrentDomain.BaseDirectory + @"\resources\favicon.ico");
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
            
            
            List<IPAddress> ipAddresses = IPAddressUtil.getIPAdressList();
            ipAddresses.ForEach((ip) => {
                Image qrcode = QrGenerater.Generate(ip.ToString(), QRCodeBox.Width, QRCodeBox.Height);
                X509Certificate2 cert = new X509Certificate2($"certs\\{ip}.pfx");
                list.Add(new IPConboBoxValue(ip,qrcode,cert));
            });
            IpAddressComboBox.DisplayMember = "ipaddress";
            IpAddressComboBox.DataSource=list.ToArray();
            QRCodeBox.Image = list[0].QRCode;
            setStatuslabel(0);
        }

        private void OpenSettingsBtn_Click(object sender, EventArgs e)
        {
            SettingWindow.ShowDialog();    
        }

        private void IpAddressComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            WSServer WSS = WSServer.Instance;
            IPConboBoxValue selected = (IPConboBoxValue)IpAddressComboBox.SelectedItem;
            WSS.ServerCertificate = selected.Certificate;
            WSS.Restart();
            QRCodeBox.Image = selected.QRCode;
        }

        public void setStatuslabel(int count)
        {
            if (count >= 1)
            {
                //Invoke((MethodInvoker)(() => status.Text = String.Format("connected {0} client",count)));
            }
            else
            {
              // Invoke((MethodInvoker)(() => status.Text = "Not connected"));
            }
        }
    }
}
