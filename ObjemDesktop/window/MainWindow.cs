using Microsoft.Win32;
using System;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;
using System.Net;

namespace ObjemDesktop
{
    public partial class MainWindow : Form
    {   
        private static  MainWindow instance;
        private NotifyIcon notifyIcon;
        private SettingWindow SettingWindow = new SettingWindow();
        private List<QrPair> list = new List<QrPair> { };
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

            List<IPAddress> ipAddresses = IpAddress.IpAdress();
            ipAddresses.ForEach((ip) => {
                var qrcode = QrGenerater.Generate(ip.ToString(), QRCodeBox.Width, QRCodeBox.Height);
                list.Add(new QrPair(ip,qrcode));
            });
            IpAddressComboBox.DisplayMember = "ipaddress";
            IpAddressComboBox.DataSource=list.ToArray();
            QRCodeBox.Image = list[0].qrcode;
            setStatuslabel(0);
        }

        private void OpenSettingsBtn_Click(object sender, EventArgs e)
        {
            SettingWindow.ShowDialog();     
        }

        private void IpAddressComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            QrPair selected = (QrPair)IpAddressComboBox.SelectedItem;
            QRCodeBox.Image = selected.qrcode;
        }

        public void setStatuslabel(int count)
        {
            if (count >= 1)
            {
                this.Invoke((MethodInvoker)(() => status.Text = String.Format("connected {0} client",count)));
            }
            else
            {
                this.Invoke((MethodInvoker)(() => status.Text = "Not connected"));
            }
        }
    }
}
