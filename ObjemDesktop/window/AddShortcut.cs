using ObjemDesktop.Shortcuts;
using ObjemDesktop.Shortcuts.Command;
using ObjemDesktop.Shortcuts.Keyboard;
using ObjemDesktop.Shortcuts.LaunchApp;
using System;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace ObjemDesktop.window
{
    public partial class AddShortcut : ReturnableValueForm<ShortcutBase>
    {
        private ShortcutBase _shortcut;
        private readonly bool _isOverWrite;
        private ushort[] _keys;
        private string _path;
        private string _command;
        private bool _isDialogShowing;

        public AddShortcut(Action<ShortcutBase> callback):base(callback)
        {
            InitializeComponent();
            ActivateKeyboardShortcutInputs();
        }

        public AddShortcut(ShortcutBase shortcut,Action<ShortcutBase> callback):base(callback)
        {
            
            InitializeComponent();
            _shortcut = shortcut;
            _isOverWrite = true;
            var typeName = shortcut.GetType().Name;
            ShortcutNameInput.Text = shortcut.Name;
            switch (typeName)
            {
                case "KeyBoardShortcut":
                    ActivateKeyboardShortcutInputs((KeyBoardShortcut) _shortcut);
                    break;
                case "LaunchAppShortcut":
                    ActivateLaunchAppShortcutInputs((LaunchAppShortcut) _shortcut);
                    break;
                case "CommandShortcut":
                    ActivateCommandShortcutInputs((CommandShortcut) _shortcut);
                    break;
            }

        }

        private void ActivateKeyboardShortcutInputs(KeyBoardShortcut shortcut)
        {
            _keys = shortcut.Keys;
            ActivateKeyboardShortcutInputs();
        }

        private void ActivateKeyboardShortcutInputs()
        {
            KeyboardShortcutRadioBtn.Checked = true;
            addKeyBoardShortcut.Enabled = true;
            KeyboardShortcutLabel.Text = _keys is null ? "" : String.Join("+", _keys.Select(k => Enum.GetName(typeof(Keys), k)));

            LaunchAppShortcutRadioBtn.Checked = false;
            LaunchAppPathTextBox.Enabled = false;
            LaunchAppPathTextBox.Text = "";
            SelectAppShortcutBtn.Enabled = false;

            CommandShortcutRadioBtn.Checked = false;
            CommandTextBox.Enabled = false;
            CommandTextBox.Text = "";
        }

        private void ActivateLaunchAppShortcutInputs(LaunchAppShortcut shortcut)
        {
            _path = shortcut.Path;
            ActivateLaunchAppShortcutInputs();
        }

        private void ActivateLaunchAppShortcutInputs()
        {
            KeyboardShortcutRadioBtn.Checked = false;
            addKeyBoardShortcut.Enabled = false;
            KeyboardShortcutLabel.Text = "";

            LaunchAppShortcutRadioBtn.Checked = true;
            LaunchAppPathTextBox.Enabled = true;
            LaunchAppPathTextBox.Text = _path ?? "";

            SelectAppShortcutBtn.Enabled = true;

            CommandShortcutRadioBtn.Checked = false;
            CommandTextBox.Enabled = false;
            CommandTextBox.Text = "";
        }

        private void ActivateCommandShortcutInputs(CommandShortcut shortcut)
        {
            _command = shortcut.Command;
            ActivateCommandShortcutInputs();
        }

        private void ActivateCommandShortcutInputs()
        {
            KeyboardShortcutRadioBtn.Checked = false;
            addKeyBoardShortcut.Enabled = false;
            KeyboardShortcutLabel.Text = "";

            LaunchAppShortcutRadioBtn.Checked = false;
            LaunchAppPathTextBox.Enabled = false;
            LaunchAppPathTextBox.Text = "";
            SelectAppShortcutBtn.Enabled = false;

            CommandShortcutRadioBtn.Checked = true;
            CommandTextBox.Enabled = true;
            CommandTextBox.Text = _command ?? "";
        }

        private void KeyBoardShortcutRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (!KeyboardShortcutRadioBtn.Checked) return;
            ActivateKeyboardShortcutInputs();
        }

        private void LaunchAppShortcutRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (!LaunchAppShortcutRadioBtn.Checked) return;
            ActivateLaunchAppShortcutInputs();
        }

        private void CommandShortcutRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (!CommandShortcutRadioBtn.Checked) return;
            ActivateCommandShortcutInputs();
        }


        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (ShortcutNameInput.Text.Length < 1)
            {
                MessageBox.Show("ショートカット名を入力してください");
                return;
            }
            var fc = ShortcutGroupBox.Controls.OfType<RadioButton>().Where(button => button.Checked).ToArray()[0];
            var shortcutName = ShortcutNameInput.Text;
            switch (fc.Name)
            {
                case string name when name.StartsWith("Keyboard"):
                    if (_keys is null)
                    {
                        MessageBox.Show("キーボードショートカットが設定されていません。");
                        return;
                    }

                    if (_isOverWrite)
                    {
                        _shortcut = new KeyBoardShortcut(this._shortcut.Guid, shortcutName,
                            _keys);
                    }
                    else
                    {
                        _shortcut = new KeyBoardShortcut(Guid.NewGuid(), shortcutName, _keys);
                    }

                    break;
                case string name when name.StartsWith("LaunchApp"):
                    if (_path is null)
                    {
                        MessageBox.Show("起動するアプリが設定されていません。");
                        return;
                    }
                    _shortcut = _isOverWrite ? new LaunchAppShortcut(_shortcut.Guid, shortcutName, LaunchAppPathTextBox.Text) : new LaunchAppShortcut(Guid.NewGuid(), shortcutName, LaunchAppPathTextBox.Text);

                    break;
                case string name when name.StartsWith("Command"):
                    if (CommandTextBox.Text.Length < 1)
                    {
                        MessageBox.Show("コマンドが設定されていません。");
                        return;
                    }
                    _shortcut = _isOverWrite ? new CommandShortcut(_shortcut.Guid, shortcutName, CommandTextBox.Text) : new CommandShortcut(Guid.NewGuid(), shortcutName, CommandTextBox.Text);

                    break;
            }
            
            Callback(_shortcut);
            Close();
        }

        private void addKeyBoardShortcut_Click(object sender, EventArgs e)
        {
            var dialog = new KeyInputForm(keys =>
            {
                _keys = keys.Select(k => (ushort) k).ToArray();
                KeyboardShortcutLabel.Text = String.Join("+", _keys.Select(k => Enum.GetName(typeof(Keys), k)));
            });
            dialog.ShowDialog();
        }

        private void SelectAppShortcutBtn_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(OpenSelectApplicationDialog);
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
        }

        private void OpenSelectApplicationDialog()
        {
            if(_isDialogShowing) return;
            SelectApplicationDialog.Filter = "exeファイル|*.exe|ショートカット|*.lnk;*url";
            SelectApplicationDialog.Title = "開くファイルを選択してください";
            SelectApplicationDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            SelectApplicationDialog.RestoreDirectory = true;
            SelectApplicationDialog.CheckFileExists = true;
            _isDialogShowing = true;
            if (SelectApplicationDialog.ShowDialog() == DialogResult.OK)
            {
                Invoke((MethodInvoker)(() =>
                {
                    _path = SelectApplicationDialog.FileName;
                    LaunchAppPathTextBox.Text = _path;
                }));
            }

            _isDialogShowing = false;
        }
    }
}