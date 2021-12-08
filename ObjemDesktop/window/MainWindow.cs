using Microsoft.Win32;
using System;
using System.Windows.Forms;
using System.Drawing;

namespace ObjemDesktop
{
    public partial class MainWindow : Form
    {
        private NotifyIcon notifyIcon;
        private const string WSAddress = "ws://127.0.0.1:8000";
        public SettingWindow SettingWindow = new SettingWindow();
        public MainWindow()
        {
            notifyIcon = new NotifyIcon();
            notifyIcon.Visible = true;
            notifyIcon.Icon = new Icon(AppDomain.CurrentDomain.BaseDirectory+@"\resources\favicon.ico");
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            QRCodeBox.Image = QrGenerater.Generate(WSAddress,QRCodeBox.Width,QRCodeBox.Height);
        }

        private void OpenSettingsBtn_Click(object sender, EventArgs e)
        {
            SettingWindow.ShowDialog();     
        }
    }
}
