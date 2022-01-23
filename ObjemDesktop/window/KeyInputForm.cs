using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ObjemDesktop.window
{
    public partial class KeyInputForm : Form
    {
        public List<Keys> Keys { get; }
        public KeyInputForm()
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
            Console.WriteLine(e.KeyCode);
        }

        private void CloseButton_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }
    }
}