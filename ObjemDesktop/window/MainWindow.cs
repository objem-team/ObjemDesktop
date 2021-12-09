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
        private NotifyIcon notifyIcon;
        private const string WSAddress = "ws://127.0.0.1:8000";
        private SettingWindow SettingWindow = new SettingWindow();
        private List<QrPair> list = new List<QrPair> { };
        public MainWindow()
        {
            notifyIcon = new NotifyIcon();
            notifyIcon.Visible = true;
            notifyIcon.Icon = new Icon(AppDomain.CurrentDomain.BaseDirectory+@"\resources\favicon.ico");
            InitializeComponent();
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
    }
}
