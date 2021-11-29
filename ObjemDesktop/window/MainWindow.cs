using Microsoft.Win32;
using System;
using System.Windows.Forms;

namespace ObjemDesktop
{
    public partial class MainWindow : Form
    {
        private const string WSAddress = "ws://127.0.0.1:8000";
        public SettingWindow SettingWindow = new SettingWindow();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            QRCodeBox.Image = QrGenerater.Generate(WSAddress,QRCodeBox.Width,QRCodeBox.Height);
            WSServer WSS = WSServer.Instance;
            WSS.Start(WSAddress);
        }

        private void OpenSettingsBtn_Click(object sender, EventArgs e)
        {
            SettingWindow.ShowDialog();     
        }
    }
}
