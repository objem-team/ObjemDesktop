using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ObjemDesktop.window
{
    public partial class KeyInputForm : ReturnableValueForm<List<Keys>>
    {
        private List<Keys> Keys { get; }
        public KeyInputForm(Action<List<Keys>> callback):base(callback)
        {
            Keys = new List<Keys>();
            InitializeComponent();
        }

        private void KeyInputForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (Keys.Count >= 5)
            {
                AlertLabel.Visible = true;
                return;
            }
            e.Handled = false;
            Keys.Add(e.KeyCode);
            InputKeyLabel.Text = String.Join("+",Keys.Select(k=>Enum.GetName(typeof(Keys),k)));
        }

        private void CloseButton_MouseClick(object sender, MouseEventArgs e)
        {
            Callback(Keys);
            Close();
        }
    }
}