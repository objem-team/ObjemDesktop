using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using ObjemDesktop.Properties;

namespace ObjemDesktop.window
{
    public partial class MainWindow : Form
    {   
        private static  MainWindow _instance;
        private bool isLoad = false;
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
            
            isLoad = true;
            _setDefaultValue();
            SetStatuslabel(WSServer.Instance.Server.WebSocketServices.SessionCount);
        }

        private void _setDefaultValue()
        {
            _list.Clear();
            List<IPAddress> ipAddresses = IPAddressUtil.GetIpAdressList();
            ipAddresses.ForEach((ip) => {
                Image qrcode = QrGenerater.Generate(ip.ToString(), QRCodeBox.Width, QRCodeBox.Height);
                X509Certificate2 cert = new X509Certificate2($"certs\\{ip}.pfx");
                _list.Add(new IpComboBoxValue(ip,qrcode,cert));
            });
            var index = 0;
            var arr = new int[] { };
            try
            {
                arr = _list.Select((item, i) => new { Items = item, Index = i })
                    .Where(obj => obj.Items.IpAddress.Equals(IPAddress.Parse(Settings.Default.ServerIpAddress)))
                    .Select(obj => obj.Index).ToArray();
            }
            catch (Exception)
            {
                //ignore
            }
            index = arr.Length > 0 ? arr[0] : 0;
            AddressLabel.Text = _list[index].IpAddress.ToString();
            QRCodeBox.Image = _list[index].QrCode;
        }
        
        private void OpenSettingsBtn_Click(object sender, EventArgs e)
        {
            new SettingWindow().ShowDialog();
            Program.StartService();
            _setDefaultValue();
        }

        public void SetStatuslabel(int count)
        {
            if (!isLoad) return;
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
