using ObjemDesktop.window;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using ObjemDesktop.Config;

namespace ObjemDesktop
{
    public partial class SettingWindow : Form
    {
        private bool RestartFlag = false;

        public SettingWindow()
        {
            InitializeComponent();
        }

        private void SettingWindow_Load(object sender, EventArgs e)
        {
            DownloadServerIPComboBox.DataSource = IPAddressUtil.GetIPAdressList();
            _loadShortcuts();
        }

        private void ReGenerateCACertBtn_Click(object sender, EventArgs e)
        {
            var message =
                "CA証明書を再作成してもよろしいですか？\nアクセスする端末にCA証明書を再インストールする必要があります。\n Certsフォルダのファイルがすべて削除されます。\n※この操作はもとに戻せません。";
            if (MessageBox.Show(message, "再作成", MessageBoxButtons.OKCancel).Equals(DialogResult.OK))
            {
                DirectoryInfo info = new DirectoryInfo(@"certs\");
                info.EnumerateFiles().ToList().ForEach(f => f.Delete());
                Certificate.CertificateUtil.ExportAsPfx(Certificate.Certificate.CreateCACerttificate(),
                    @"certs\CAcert.pfx");
                MessageBox.Show("再作成が完了しました\n");
                RestartFlag = true;
            }
        }

        private List<string> GetCertFilesip()
        {
            var files = Directory.GetFiles("certs\\", "*.*.*.*.pfx").ToList();
            var ipList = files.Select(f =>
                Regex.Match(f,
                        @"(([1-9]?[0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])\.){3}([1-9]?[0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])")
                    .ToString()).ToList();
            return ipList;
        }

        private void FileExportBtn_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(new ThreadStart(() => SaveCertificate()));
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
            DownLoadQRForm form = new DownLoadQRForm((IPAddress) DownloadServerIPComboBox.SelectedItem);
            form.ShowDialog();
        }

        private void AddShortcutBtn_Click(object sender, EventArgs e)
        {
            AddShortcut addShortcut = new AddShortcut();
            addShortcut.ShowDialog();
            _loadShortcuts();
        }

        private void _loadShortcuts()
        {
            ShortcutsListBox.Items.Clear();
            foreach (var shortcut in UserShortcuts.Instance.Shortcuts)
            {
                ShortcutsListBox.Items.Add(shortcut.Name);
            }
        }

        private void ApplyBtn_Click(object sender, EventArgs e)
        {
            UserShortcuts.Instance.Save();
        }

        private void EditShortcutBtn_Click(object sender, EventArgs e)
        {
            var index = ShortcutsListBox.SelectedIndex >= 0 ? ShortcutsListBox.SelectedIndex : 0;
            AddShortcut addShortcut = new AddShortcut(UserShortcuts.Instance.Shortcuts[index]);
            addShortcut.ShowDialog();
            _loadShortcuts();
        }

        private void SettingWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            /*
             * todo IOが増えないように変更前の値をディープコピーして持っておく
             * ↓あんまよくない↓
             */
            UserShortcuts.Instance.Reload();
        }
    }
}