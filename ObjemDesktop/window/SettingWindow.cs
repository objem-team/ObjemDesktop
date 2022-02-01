using ObjemDesktop.window;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Windows.Forms;
using ObjemDesktop.Config;
using ObjemDesktop.Shortcuts;

using System.Text.RegularExpressions;
using System.Collections.Specialized;

namespace ObjemDesktop
{
    public partial class SettingWindow : Form
    {
        private bool RestartFlag = false;
        private readonly List<ShortcutBase> _shortcuts;
        private readonly List<IPAddress> _ipAddress;
        public SettingWindow()
        {
            //Instance.Shortcutsを直接参照させない
            _shortcuts = UserShortcuts.Instance.Shortcuts.ToList();
            InitializeComponent();

            _ipAddress = IPAddressUtil.GetIpAdressList();
        }

        private void SettingWindow_Load(object sender, EventArgs e)
        {
            DownloadServerIPComboBox.DataSource = IPAddressUtil.GetIpAdressList();
            _loadShortcuts();

            //初期表示
            StartupCheckBox.Checked = Properties.Settings.Default.AutoStartup;


            ServerIpAddressComboBox.Items.AddRange(_ipAddress.ToArray());
            if (Properties.Settings.Default.ServerIpAddress != null)
            {
                int index = _ipAddress.FindIndex(n => n.ToString() == Properties.Settings.Default.ServerIpAddress);
                index = index >= 0 ? index : 0;
                ServerIpAddressComboBox.SelectedIndex = index;
            }


            //未
            if (Properties.Settings.Default.DisabledProcess != null)
            {
                string[] DisabledList = Properties.Settings.Default.DisabledProcess.Cast<string>().ToArray();
                DisableProcessListBox.Items.AddRange(DisabledList);
            }


            //未
            if (Properties.Settings.Default.EnabledShortcuts != null)
            {
                string[] EnabledList = Properties.Settings.Default.EnabledShortcuts.Cast<string>().ToArray();
                SelectedShortCutListview.Items.AddRange(EnabledList);
            }

            Feader1GestureComboBox.Items.AddRange(_shortcuts.ToArray());
            if (Properties.Settings.Default.Fader1GestureGuid != null && _shortcuts.Count>0)
            {
                var index = _shortcuts.FindIndex(s => s.Guid.ToString() == Properties.Settings.Default.Fader1GestureGuid);
                index = index >= 0 ? index : 0;
                Feader1GestureComboBox.SelectedIndex = index;
            }

            Feader2GestureComboBox.Items.AddRange(_shortcuts.ToArray());
            if (Properties.Settings.Default.Fader2GestureGUID != null && _shortcuts.Count > 0)
            {
                var index = _shortcuts.FindIndex(s => s.Guid.ToString() == Properties.Settings.Default.Fader2GestureGUID);
                index = index >= 0 ? index : 0;
                Feader2GestureComboBox.SelectedIndex = index;
            }


            EnableGestureCheckBox.Checked = (Properties.Settings.Default.IsEnableGesture);

            if (Properties.Settings.Default.OBSWebSocketURL != null)
            {
                WebSocketURL.Text = (Properties.Settings.Default.OBSWebSocketURL);
            }

        }

        private void ReGenerateCACertBtn_Click(object sender, EventArgs e)
        {
            var message =
                "CA証明書を再作成してもよろしいですか？\nアクセスする端末にCA証明書を再インストールする必要があります。\n Certsフォルダのファイルがすべて削除されます。\n※この操作はもとに戻せません。";
            if (MessageBox.Show(message, "再作成", MessageBoxButtons.OKCancel).Equals(DialogResult.OK))
            {
                DirectoryInfo info = new DirectoryInfo(@"certs\");
                info.EnumerateFiles().ToList().ForEach(f => f.Delete());
                Certificate.CertificateUtil.ExportAsPfx(Certificate.Certificate.CreateCertificate(),
                    @"certs\CAcert.pfx");
                MessageBox.Show("再作成が完了しました\n");
                RestartFlag = true;
            }
        }

        private void FileExportBtn_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(SaveCertificate);
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
        }

        private void SaveCertificate()
        {
            saveCACertFileDialog.FileName = "ObjemCAcert.crt";
            saveCACertFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            saveCACertFileDialog.Filter = "証明書(*.crt;*.cer)|*.crt;*.cer|すべてのファイル(*.*)|*.*";
            if (saveCACertFileDialog.ShowDialog().Equals(DialogResult.OK))
            {
                var cert = new X509Certificate2(@"certs\CAcert.pfx");
                var path = saveCACertFileDialog.FileName;
                Certificate.CertificateUtil.ExportAsPem(cert, path);
            }
        }

        private void DownLoadQRCodeBtn_Click(object sender, EventArgs e)
        {
            DownLoadQrForm form = new DownLoadQrForm((IPAddress) DownloadServerIPComboBox.SelectedItem);
            form.ShowDialog();
        }

        private void EditShortcutBtn_Click(object sender, EventArgs e)
        {
            var index = ShortcutsListBox.SelectedIndex >= 0 ? ShortcutsListBox.SelectedIndex : 0;
            AddShortcut addShortcut = new AddShortcut(_shortcuts[index], shortcut =>
            {
                ListUtil.AddOrReplace(_shortcuts, shortcut);
            });
            addShortcut.ShowDialog();
            _loadShortcuts();
        }
        private void AddShortcutBtn_Click(object sender, EventArgs e)
        {
            AddShortcut addShortcut = new AddShortcut(shortcut =>
            {
                ListUtil.AddOrReplace(_shortcuts, shortcut);
            });
            addShortcut.ShowDialog();
            _loadShortcuts();
        }
        

        private void ApplyBtn_Click(object sender, EventArgs e)
        {
            UserShortcuts.Instance.Shortcuts = _shortcuts;
            Close();

            //保存
            Properties.Settings.Default.AutoStartup = StartupCheckBox.Checked;
            Properties.Settings.Default.ServerIpAddress = ServerIpAddressComboBox.Text;

            Properties.Settings.Default.Fader1GestureGuid = Feader1GestureComboBox.Text;
            Properties.Settings.Default.Fader2GestureGUID = Feader2GestureComboBox.Text;
            Properties.Settings.Default.IsEnableGesture = EnableGestureCheckBox.Checked;
            Properties.Settings.Default.OBSWebSocketURL = WebSocketURL.Text;
            Properties.Settings.Default.Save();
        }
        
        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void _loadShortcuts()
        {
            ShortcutsListBox.Items.Clear();
            ShortcutsListBox.DisplayMember = "name";
            ShortcutsListBox.Items.AddRange(_shortcuts.ToArray());
            Feader1GestureComboBox.Items.Clear();
            Feader1GestureComboBox.Items.AddRange(_shortcuts.ToArray());
                
        }


    }
}