using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Windows.Forms;
using ObjemDesktop.Config;
using ObjemDesktop.Shortcuts;

namespace ObjemDesktop.window
{
    public partial class SettingWindow : Form
    {
        private bool RestartFlag = false;
        private readonly BindingList<ShortcutBase> _shortcuts;
        private readonly BindingList<ShortcutBase> _shortcuts2;
        private BindingList<ShortcutBase> _enableShortcuts;
        private readonly List<IPAddress> _ipAddress;
        private readonly BindingList<string> _disabledList;
        private bool _isDialogShowing;
        private Dictionary<string, Bitmap> _unsavedImages = new Dictionary<string, Bitmap>();

        public SettingWindow()
        {
            _shortcuts = new BindingList<ShortcutBase>(UserShortcuts.Instance.Shortcuts.ToList());
            _shortcuts2 = new BindingList<ShortcutBase>(UserShortcuts.Instance.Shortcuts.ToList());
            _shortcuts.ListChanged += (s, e) =>_syncShortcutDataSource();
            _ipAddress = IPAddressUtil.GetIpAdressList();

            _disabledList = new BindingList<string>(new List<string>());
            if (Properties.Settings.Default.DisabledProcess != null)
            {
                _disabledList = new BindingList<string>(Properties.Settings.Default.DisabledProcess.Cast<string>().ToList());
            }

            _enableShortcuts = new BindingList<ShortcutBase>(new List<ShortcutBase>());
            if (Properties.Settings.Default.EnabledShortcuts != null)
            {
                var guids = Properties.Settings.Default.EnabledShortcuts.Cast<string>().ToArray();
                var shortcuts = new List<ShortcutBase>();
                foreach (var guid in guids)
                {
                    var shortcut = _shortcuts.FirstOrDefault(s => s.Guid.ToString().Equals(guid));
                    if (shortcut is null) return;
                    shortcuts.Add(shortcut);
                }
                _enableShortcuts = new BindingList<ShortcutBase>(shortcuts);
            }

            InitializeComponent();
        }

        private void SettingWindow_Load(object sender, EventArgs e)
        {
            DownloadServerIPComboBox.DataSource = IPAddressUtil.GetIpAdressList();
            _loadShortcuts();

            //ipアドレスListBox表示
            StartupCheckBox.Checked = Properties.Settings.Default.AutoStartup;
            ServerIpAddressComboBox.DataSource = _ipAddress.ToList();
            if (Properties.Settings.Default.ServerIpAddress != null)
            {
                int index = _ipAddress.FindIndex(n => n.ToString() == Properties.Settings.Default.ServerIpAddress);
                index = index >= 0 ? index : 0;
                ServerIpAddressComboBox.SelectedIndex = index;
            }

            //無効化したプロセス一覧
            DisableProcessListBox.DataSource = _disabledList;

            //有効化されてるショートカット
            EnabledShortcutsListBox.DataSource = _enableShortcuts;
            EnabledShortcutsListBox.DisplayMember = "name";


            //フェーダージェスチャーの選択
            if (Properties.Settings.Default.Fader1GestureGuid != null && _shortcuts.Count > 0)
            {
                var index = BindingListUtil.FindIndex(_shortcuts,
                    (item) => item.Guid.ToString() == Properties.Settings.Default.Fader1GestureGuid);
                index = index >= 0 ? index : 0;
                Feader1GestureComboBox.SelectedIndex = index;
            }


            if (Properties.Settings.Default.Fader2GestureGUID != null && _shortcuts.Count > 0)
            {
                var index = BindingListUtil.FindIndex(_shortcuts,
                    (item) => item.Guid.ToString() == Properties.Settings.Default.Fader2GestureGUID);
                index = index >= 0 ? index : 0;
                Feader2GestureComboBox.SelectedIndex = index;
            }

            //ジェスチャーのチェックボックス
            EnableGestureCheckBox.Checked = Properties.Settings.Default.IsEnableGesture;

            //OBSのURL
            if (Properties.Settings.Default.OBSWebSocketURL != null)
            {
                WebSocketURL.Text = Properties.Settings.Default.OBSWebSocketURL;
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
            AddShortcut addShortcut = new AddShortcut(_shortcuts[index],addShotrcut);
            addShortcut.ShowDialog();
        }

        private void AddShortcutBtn_Click(object sender, EventArgs e)
        {
            AddShortcut addShortcut = new AddShortcut(addShotrcut);
            addShortcut.ShowDialog();
        }

        public void addShotrcut((ShortcutBase shortcut,Bitmap Icon) pair)
        {
            BindingListUtil.AddOrReplace(_shortcuts, pair.shortcut);
            if (_unsavedImages.ContainsKey(pair.shortcut.Guid.ToString()))
            {
                _unsavedImages[pair.shortcut.Guid.ToString()] = pair.Icon;
            }
            _unsavedImages.Add(pair.shortcut.Guid.ToString(),pair.Icon);
        }


        private void ApplyBtn_Click(object sender, EventArgs e)
        {
            UserShortcuts.Instance.Shortcuts = _shortcuts.ToList();
            UserShortcuts.Instance.Save();

            if (!Directory.Exists("icons"))
            {
                Directory.CreateDirectory("icons");
            }
            
            foreach (var pair in _unsavedImages)
            {
                pair.Value.Save($"icons/{pair.Key}.png",ImageFormat.Png);
                pair.Value.Dispose();
            }
            
            //保存
            var enabledShortcutsGuids = new StringCollection();
            enabledShortcutsGuids.AddRange(_enableShortcuts.Select(shortcut => shortcut.Guid.ToString()).ToArray());
            var disabledList = new StringCollection();
            disabledList.AddRange(_disabledList.ToArray());
            Properties.Settings.Default.AutoStartup = StartupCheckBox.Checked;
            Properties.Settings.Default.ServerIpAddress = ServerIpAddressComboBox.Text;
            if (Feader1GestureComboBox.SelectedIndex >= 0) Properties.Settings.Default.Fader1GestureGuid = _shortcuts[Feader1GestureComboBox.SelectedIndex].Guid.ToString();
            if (Feader2GestureComboBox.SelectedIndex >= 0) Properties.Settings.Default.Fader2GestureGUID = _shortcuts[Feader2GestureComboBox.SelectedIndex].Guid.ToString();
            Properties.Settings.Default.EnabledShortcuts = enabledShortcutsGuids;
            Properties.Settings.Default.DisabledProcess = disabledList;
            Properties.Settings.Default.IsEnableGesture = EnableGestureCheckBox.Checked;
            Properties.Settings.Default.OBSWebSocketURL = WebSocketURL.Text;
            Properties.Settings.Default.Save();
            
            Close();
            
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void _loadShortcuts()
        {
            ShortcutsListBox.Items.Clear();
            ShortcutsListBox.DataSource = _shortcuts;
            ShortcutsListBox.DisplayMember = "name";
            Feader1GestureComboBox.Items.Clear();
            Feader1GestureComboBox.DataSource = _shortcuts;
            Feader1GestureComboBox.DisplayMember = "name";
            Feader2GestureComboBox.Items.Clear();
            Feader2GestureComboBox.DataSource = _shortcuts2;
            Feader2GestureComboBox.DisplayMember = "name";
        }

        //DataSourceを同じ参照に行うと選択される値も同期されるため更新されるたびに値を更新する
        private void _syncShortcutDataSource()
        {
            _shortcuts2.Clear();
            foreach (var shortcut in _shortcuts)
            {
                _shortcuts2.Add(shortcut);
            }
            var guids = _enableShortcuts.Select(s=>s.Guid).ToArray();
            _enableShortcuts.Clear();
            foreach (var guid in guids)
            {
                var shortcut = _shortcuts.FirstOrDefault(s => s.Guid.Equals(guid));
               if (shortcut is null) return;
               _enableShortcuts.Add(shortcut);
            }
            
        }

        private void EnableGestureCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            foreach (var combobox in GestureSettingBox.Controls.OfType<ComboBox>())
            {
                combobox.Enabled = EnableGestureCheckBox.Checked;
            }
        }

        private void AddToEnableBtn_Click(object sender, EventArgs e)
        {
            if (ShortcutsListBox.SelectedIndex >= 0 && _shortcuts.Count> ShortcutsListBox.SelectedIndex)
            {
                var shortcut = _shortcuts[ShortcutsListBox.SelectedIndex];
                if (_enableShortcuts.Contains(shortcut)) return;
                _enableShortcuts.Add(_shortcuts[ShortcutsListBox.SelectedIndex]);
            }
        }

        private void RemoveFromEnableListBtn_Click(object sender, EventArgs e)
        {
            if (EnabledShortcutsListBox.SelectedIndex >= 0 && _enableShortcuts.Count > EnabledShortcutsListBox.SelectedIndex)
            {
                _enableShortcuts.RemoveAt(EnabledShortcutsListBox.SelectedIndex);
            }
        }

        private void DisableProcessAddButton_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(OpenSelectDisableApplicationDialog);
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
        }
        private void OpenSelectDisableApplicationDialog()
        {
            if(_isDialogShowing) return;
            SelectDisableApplicationDialog.Filter = "exeファイル|*.exe";
            SelectDisableApplicationDialog.Title = "無効にするアプリケーションを選択してください";
            SelectDisableApplicationDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            SelectDisableApplicationDialog.RestoreDirectory = true;
            SelectDisableApplicationDialog.CheckFileExists = true;
            _isDialogShowing = true;
            if (SelectDisableApplicationDialog.ShowDialog() == DialogResult.OK)
            {
                Invoke((MethodInvoker)(() =>
                {
                    _disabledList.Add(SelectDisableApplicationDialog.FileName);
                }));
            }

            _isDialogShowing = false;
        }

        private void DeleteDisableProcessMenuItem_Click(object sender, EventArgs e)
        {
            if (DisableProcessListBox.SelectedIndex < 0) return;
            _disabledList.RemoveAt(DisableProcessListBox.SelectedIndex);
        }

        private void DeleteShortcutListBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ShortcutsListBox.SelectedIndex < 0) return;
            _shortcuts.RemoveAt(ShortcutsListBox.SelectedIndex);
        }

        private void orderUpBtn_Click(object sender, EventArgs e)
        {
            if (EnabledShortcutsListBox.SelectedIndex - 1 < 0) return;
            BindingListUtil.Replace(_enableShortcuts,EnabledShortcutsListBox.SelectedIndex,EnabledShortcutsListBox.SelectedIndex-1);
            EnabledShortcutsListBox.SelectedIndex -= 1;
        }

        private void orderDown_Click(object sender, EventArgs e)
        {
            if (EnabledShortcutsListBox.SelectedIndex >= _enableShortcuts.Count-1) return;
            BindingListUtil.Replace(_enableShortcuts,EnabledShortcutsListBox.SelectedIndex,EnabledShortcutsListBox.SelectedIndex+1);
            EnabledShortcutsListBox.SelectedIndex += 1;
        }
    }
}