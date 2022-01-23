using ObjemDesktop.Shortcuts;
using ObjemDesktop.Shortcuts.Command;
using ObjemDesktop.Shortcuts.Keyboard;
using ObjemDesktop.Shortcuts.LaunchApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ObjemDesktop.Config;

namespace ObjemDesktop.window
{
    public partial class AddShortcut : Form
    {
        private ShortcutBase _shortcut;
        private bool _isOverWrite = false;
        private ushort[] _keys;

        public AddShortcut()
        {
            InitializeComponent();
        }

        public AddShortcut(ShortcutBase shortcut)
        {
            _shortcut = shortcut;
            _isOverWrite = true;
            var typeName = typeof(Shortcut).Name;
            switch (typeName)
            {
                case "KeyBoadShortcut":
                    activateKeyboardShortcutInputs((KeyBoadShortcut) _shortcut);
                    break;
                case "LaunchAppShortcut":
                    activateLaunchAppShortcutInputs((LaunchAppShortcut) _shortcut);
                    break;
                case "CommandShortcut":
                    activateCommandShortcutInputs((CommandShortcut) _shortcut);
                    break;
                default:
                    Console.WriteLine(typeName);
                    break;
            }

            InitializeComponent();
        }

        private void activateKeyboardShortcutInputs(KeyBoadShortcut shortcut)
        {
            _keys = shortcut.Keys;
            activateKeyboardShortcutInputs();
        }

        private void activateKeyboardShortcutInputs()
        {
            KeyboardShortcutRadioBtn.Checked = true;
            addKeyBoardShortcut.Enabled = true;
            KeyboardShortcutLabel.Text = String.Join("+",_keys.Select(k=>Enum.GetName(typeof(Keys),k)));

            LaunchAppShortcutRadioBtn.Checked = false;
            LaunchAppPathTextBox.Enabled = false;
            LaunchAppPathTextBox.Text = "";
            SelectAppShortcutBtn.Enabled = false;

            CommandShortcutRadioBtn.Checked = false;
            CommandTextBox.Enabled = false;
            CommandTextBox.Text = "";
        }

        private void activateLaunchAppShortcutInputs(LaunchAppShortcut shortcut)
        {
            KeyboardShortcutRadioBtn.Checked = false;
            addKeyBoardShortcut.Enabled = false;
            KeyboardShortcutLabel.Text = "";

            LaunchAppShortcutRadioBtn.Checked = true;
            LaunchAppPathTextBox.Enabled = true;
            LaunchAppPathTextBox.Text = shortcut.Path;
            SelectAppShortcutBtn.Enabled = true;

            CommandShortcutRadioBtn.Checked = false;
            CommandTextBox.Enabled = false;
            CommandTextBox.Text = "";
        }

        private void activateLaunchAppShortcutInputs()
        {
            KeyboardShortcutRadioBtn.Checked = false;
            addKeyBoardShortcut.Enabled = false;
            KeyboardShortcutLabel.Text = "";

            LaunchAppShortcutRadioBtn.Checked = true;
            LaunchAppPathTextBox.Enabled = true;
            LaunchAppPathTextBox.Text = "";
            SelectAppShortcutBtn.Enabled = true;

            CommandShortcutRadioBtn.Checked = false;
            CommandTextBox.Enabled = false;
            CommandTextBox.Text = "";
        }

        private void activateCommandShortcutInputs(CommandShortcut shortcut)
        {
            KeyboardShortcutRadioBtn.Checked = false;
            addKeyBoardShortcut.Enabled = false;
            KeyboardShortcutLabel.Text = "";

            LaunchAppShortcutRadioBtn.Checked = false;
            LaunchAppPathTextBox.Enabled = false;
            LaunchAppPathTextBox.Text = "";
            SelectAppShortcutBtn.Enabled = false;

            CommandShortcutRadioBtn.Checked = false;
            CommandTextBox.Enabled = false;
            CommandTextBox.Text = shortcut.Command;
        }

        private void activateCommandShortcutInputs()
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
            CommandTextBox.Text = "";
        }

        private void KeyBoardShortcutRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (!KeyboardShortcutRadioBtn.Checked) return;
            activateKeyboardShortcutInputs();
        }

        private void LaunchAppShortcutRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (!LaunchAppShortcutRadioBtn.Checked) return;
            activateLaunchAppShortcutInputs();
        }

        private void CommandShortcutRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (!CommandShortcutRadioBtn.Checked) return;
            activateCommandShortcutInputs();
        }


        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            var fc = ShortcutGroupBox.Controls.OfType<RadioButton>().Where(button => button.Checked).ToArray()[0];
            var shortcutName = ShortcutNameInput.Text;
            switch (fc.Name)
            {
                case string name when name.StartsWith("Keyboard"):
                    if (_isOverWrite)
                    {
                        _shortcut = new KeyBoadShortcut(this._shortcut.Guid, shortcutName,
                            new Keys[] {Keys.LWin, Keys.D});
                    }
                    else
                    {
                        _shortcut = new KeyBoadShortcut(Guid.NewGuid(), shortcutName, new Keys[] {Keys.LWin, Keys.D});
                    }

                    break;
                case string name when name.StartsWith("LaunchApp"):
                    if (_isOverWrite)
                    {
                        _shortcut = new LaunchAppShortcut(this._shortcut.Guid, shortcutName, LaunchAppPathTextBox.Text);
                    }
                    else
                    {
                        _shortcut = new LaunchAppShortcut(Guid.NewGuid(), shortcutName, LaunchAppPathTextBox.Text);
                    }

                    break;
                case string name when name.StartsWith("Command"):
                    if (_isOverWrite)
                    {
                        _shortcut = new CommandShortcut(this._shortcut.Guid, shortcutName, CommandTextBox.Text);
                    }
                    else
                    {
                        _shortcut = new CommandShortcut(Guid.NewGuid(), shortcutName, CommandTextBox.Text);
                    }

                    break;
            }
            UserShortcuts.Instance.AddOrReplace(_shortcut);
        }

        private void addKeyBoardShortcut_Click(object sender, EventArgs e)
        {
            var dialog = new KeyInputForm();
            dialog.ShowDialog();
            _keys = dialog.Keys.Select(keys =>(ushort)keys).ToArray();
            KeyboardShortcutLabel.Text = String.Join("+",_keys.Select(k=>Enum.GetName(typeof(Keys),k)));
        }
    }
}