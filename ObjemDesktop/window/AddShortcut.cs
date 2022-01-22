using ObjemDesktop.Shortcuts;
using ObjemDesktop.Shortcuts.Command;
using ObjemDesktop.Shortcuts.Keyboard;
using ObjemDesktop.Shortcuts.LaunchApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ObjemDesktop.window
{
    public partial class AddShortcut : Form
    {
        private ShortcutBase _shortcut;
        private bool _isOverWrite = false;
        
        public AddShortcut() {
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
                    activateKeyboardShortcutInputs((KeyBoadShortcut)_shortcut);
                    break;
                case "LaunchAppShortcut":
                    activateLaunchAppShortcutInputs((LaunchAppShortcut)_shortcut);
                    break;
                case "CommandShortcut":
                    activateCommandShortcutInputs((CommandShortcut)_shortcut);
                    break;
                default:
                    Console.WriteLine(typeName);
                    break;
            }
            InitializeComponent();
        }
        private void activateKeyboardShortcutInputs(KeyBoadShortcut shortcut)
        {
            KeyBoardShortcutRadioBtn.Checked = true;
            addKeyBoardShortcut.Enabled = true;
            KeyboardShortcutLabel.Text = shortcut.Name;

            LaunchAppShortcutRadioBtn.Checked = false;
            LaunchAppPathTextBox.Enabled = false;
            LaunchAppPathTextBox.Text = "";
            SelectAppShortcutBtn.Enabled = false;

            CommandShortcutRadioBtn.Checked = false;
            CommandTextBox.Enabled = false;
            CommandTextBox.Text = "";

        }
        private void activateKeyboardShortcutInputs()
        {
            KeyBoardShortcutRadioBtn.Checked = true;
            addKeyBoardShortcut.Enabled = true;
            KeyboardShortcutLabel.Text = "";

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
            KeyBoardShortcutRadioBtn.Checked = false;
            addKeyBoardShortcut.Enabled = false;
            KeyboardShortcutLabel.Text = "";

            LaunchAppShortcutRadioBtn.Checked = true;
            LaunchAppPathTextBox.Enabled = true;
            LaunchAppPathTextBox.Text = shortcut.path;
            SelectAppShortcutBtn.Enabled = true;

            CommandShortcutRadioBtn.Checked = false;
            CommandTextBox.Enabled = false;
            CommandTextBox.Text = "";
        }
        private void activateLaunchAppShortcutInputs()
        {
            KeyBoardShortcutRadioBtn.Checked = false;
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
            KeyBoardShortcutRadioBtn.Checked = false;
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
            KeyBoardShortcutRadioBtn.Checked = false;
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
            if (!KeyBoardShortcutRadioBtn.Checked) return;
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
            
        }
    }
}
