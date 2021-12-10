
namespace ObjemDesktop
{
    partial class SettingWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CancelButton = new System.Windows.Forms.Button();
            this.OKButton = new System.Windows.Forms.Button();
            this.OBSTabPage = new System.Windows.Forms.TabPage();
            this.WebSocketURL = new System.Windows.Forms.TextBox();
            this.WebSocketURLLabel = new System.Windows.Forms.Label();
            this.GestureTabPage = new System.Windows.Forms.TabPage();
            this.EnableGestureCheckBox = new System.Windows.Forms.CheckBox();
            this.GestureSettingBox = new System.Windows.Forms.GroupBox();
            this.Fader2Label = new System.Windows.Forms.Label();
            this.Fader1Label = new System.Windows.Forms.Label();
            this.Feader2GestureComboBox = new System.Windows.Forms.ComboBox();
            this.Feader1GestureComboBox = new System.Windows.Forms.ComboBox();
            this.GestureDescriptionLabel = new System.Windows.Forms.Label();
            this.ShortcutsTabPage = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ShortcutNametextBox1 = new System.Windows.Forms.TextBox();
            this.ShortcutName = new System.Windows.Forms.Label();
            this.ShortcutsListView = new System.Windows.Forms.ListView();
            this.GeneralTabPage = new System.Windows.Forms.TabPage();
            this.DisableProcessAddButton = new System.Windows.Forms.Button();
            this.DisableProcessListBox = new System.Windows.Forms.ListBox();
            this.DisableProcessLabel = new System.Windows.Forms.Label();
            this.StartUpOptionLabel = new System.Windows.Forms.Label();
            this.StartupCheckBox = new System.Windows.Forms.CheckBox();
            this.SettingTab = new System.Windows.Forms.TabControl();
            this.KeyboardShortcutRadioButton = new System.Windows.Forms.RadioButton();
            this.LaunchApplicationRadioButton = new System.Windows.Forms.RadioButton();
            this.SendCommandRadioButton = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.OBSTabPage.SuspendLayout();
            this.GestureTabPage.SuspendLayout();
            this.GestureSettingBox.SuspendLayout();
            this.ShortcutsTabPage.SuspendLayout();
            this.GeneralTabPage.SuspendLayout();
            this.SettingTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(539, 372);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(4);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(100, 29);
            this.CancelButton.TabIndex = 1;
            this.CancelButton.Text = "キャンセル";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // OKButton
            // 
            this.OKButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.OKButton.Location = new System.Drawing.Point(433, 372);
            this.OKButton.Margin = new System.Windows.Forms.Padding(4);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(84, 29);
            this.OKButton.TabIndex = 2;
            this.OKButton.Text = "適用";
            this.OKButton.UseVisualStyleBackColor = false;
            // 
            // OBSTabPage
            // 
            this.OBSTabPage.Controls.Add(this.WebSocketURL);
            this.OBSTabPage.Controls.Add(this.WebSocketURLLabel);
            this.OBSTabPage.Location = new System.Drawing.Point(4, 25);
            this.OBSTabPage.Margin = new System.Windows.Forms.Padding(4);
            this.OBSTabPage.Name = "OBSTabPage";
            this.OBSTabPage.Padding = new System.Windows.Forms.Padding(4);
            this.OBSTabPage.Size = new System.Drawing.Size(619, 313);
            this.OBSTabPage.TabIndex = 3;
            this.OBSTabPage.Text = "OBS設定";
            this.OBSTabPage.UseVisualStyleBackColor = true;
            // 
            // WebSocketURL
            // 
            this.WebSocketURL.Location = new System.Drawing.Point(29, 59);
            this.WebSocketURL.Margin = new System.Windows.Forms.Padding(4);
            this.WebSocketURL.Name = "WebSocketURL";
            this.WebSocketURL.Size = new System.Drawing.Size(455, 22);
            this.WebSocketURL.TabIndex = 1;
            // 
            // WebSocketURLLabel
            // 
            this.WebSocketURLLabel.AutoSize = true;
            this.WebSocketURLLabel.Location = new System.Drawing.Point(27, 28);
            this.WebSocketURLLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.WebSocketURLLabel.Name = "WebSocketURLLabel";
            this.WebSocketURLLabel.Size = new System.Drawing.Size(105, 15);
            this.WebSocketURLLabel.TabIndex = 0;
            this.WebSocketURLLabel.Text = "WebSocketURL";
            // 
            // GestureTabPage
            // 
            this.GestureTabPage.Controls.Add(this.EnableGestureCheckBox);
            this.GestureTabPage.Controls.Add(this.GestureSettingBox);
            this.GestureTabPage.Controls.Add(this.GestureDescriptionLabel);
            this.GestureTabPage.Location = new System.Drawing.Point(4, 25);
            this.GestureTabPage.Margin = new System.Windows.Forms.Padding(4);
            this.GestureTabPage.Name = "GestureTabPage";
            this.GestureTabPage.Padding = new System.Windows.Forms.Padding(4);
            this.GestureTabPage.Size = new System.Drawing.Size(619, 313);
            this.GestureTabPage.TabIndex = 2;
            this.GestureTabPage.Text = "ジェスチャー";
            this.GestureTabPage.UseVisualStyleBackColor = true;
            // 
            // EnableGestureCheckBox
            // 
            this.EnableGestureCheckBox.AutoSize = true;
            this.EnableGestureCheckBox.Checked = true;
            this.EnableGestureCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.EnableGestureCheckBox.Location = new System.Drawing.Point(40, 52);
            this.EnableGestureCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.EnableGestureCheckBox.Name = "EnableGestureCheckBox";
            this.EnableGestureCheckBox.Size = new System.Drawing.Size(152, 19);
            this.EnableGestureCheckBox.TabIndex = 6;
            this.EnableGestureCheckBox.Text = "ジェスチャーの有効化";
            this.EnableGestureCheckBox.UseVisualStyleBackColor = true;
            // 
            // GestureSettingBox
            // 
            this.GestureSettingBox.Controls.Add(this.Fader2Label);
            this.GestureSettingBox.Controls.Add(this.Fader1Label);
            this.GestureSettingBox.Controls.Add(this.Feader2GestureComboBox);
            this.GestureSettingBox.Controls.Add(this.Feader1GestureComboBox);
            this.GestureSettingBox.Location = new System.Drawing.Point(40, 94);
            this.GestureSettingBox.Margin = new System.Windows.Forms.Padding(4);
            this.GestureSettingBox.Name = "GestureSettingBox";
            this.GestureSettingBox.Padding = new System.Windows.Forms.Padding(4);
            this.GestureSettingBox.Size = new System.Drawing.Size(551, 195);
            this.GestureSettingBox.TabIndex = 5;
            this.GestureSettingBox.TabStop = false;
            // 
            // Fader2Label
            // 
            this.Fader2Label.AutoSize = true;
            this.Fader2Label.Location = new System.Drawing.Point(9, 99);
            this.Fader2Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Fader2Label.Name = "Fader2Label";
            this.Fader2Label.Size = new System.Drawing.Size(51, 15);
            this.Fader2Label.TabIndex = 3;
            this.Fader2Label.Text = "Feder2";
            // 
            // Fader1Label
            // 
            this.Fader1Label.AutoSize = true;
            this.Fader1Label.Location = new System.Drawing.Point(9, 18);
            this.Fader1Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Fader1Label.Name = "Fader1Label";
            this.Fader1Label.Size = new System.Drawing.Size(50, 15);
            this.Fader1Label.TabIndex = 2;
            this.Fader1Label.Text = "Fader1";
            // 
            // Feader2GestureComboBox
            // 
            this.Feader2GestureComboBox.FormattingEnabled = true;
            this.Feader2GestureComboBox.Location = new System.Drawing.Point(27, 138);
            this.Feader2GestureComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.Feader2GestureComboBox.Name = "Feader2GestureComboBox";
            this.Feader2GestureComboBox.Size = new System.Drawing.Size(480, 23);
            this.Feader2GestureComboBox.TabIndex = 1;
            // 
            // Feader1GestureComboBox
            // 
            this.Feader1GestureComboBox.FormattingEnabled = true;
            this.Feader1GestureComboBox.Location = new System.Drawing.Point(27, 49);
            this.Feader1GestureComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.Feader1GestureComboBox.Name = "Feader1GestureComboBox";
            this.Feader1GestureComboBox.Size = new System.Drawing.Size(480, 23);
            this.Feader1GestureComboBox.TabIndex = 0;
            // 
            // GestureDescriptionLabel
            // 
            this.GestureDescriptionLabel.AutoSize = true;
            this.GestureDescriptionLabel.Location = new System.Drawing.Point(37, 18);
            this.GestureDescriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GestureDescriptionLabel.Name = "GestureDescriptionLabel";
            this.GestureDescriptionLabel.Size = new System.Drawing.Size(345, 15);
            this.GestureDescriptionLabel.TabIndex = 4;
            this.GestureDescriptionLabel.Text = "フェーダーのノブを2回タップ時のショートカットを設定します。\r\n";
            // 
            // ShortcutsTabPage
            // 
            this.ShortcutsTabPage.Controls.Add(this.label2);
            this.ShortcutsTabPage.Controls.Add(this.label1);
            this.ShortcutsTabPage.Controls.Add(this.button4);
            this.ShortcutsTabPage.Controls.Add(this.button3);
            this.ShortcutsTabPage.Controls.Add(this.textBox1);
            this.ShortcutsTabPage.Controls.Add(this.SendCommandRadioButton);
            this.ShortcutsTabPage.Controls.Add(this.button2);
            this.ShortcutsTabPage.Controls.Add(this.LaunchApplicationRadioButton);
            this.ShortcutsTabPage.Controls.Add(this.button1);
            this.ShortcutsTabPage.Controls.Add(this.KeyboardShortcutRadioButton);
            this.ShortcutsTabPage.Controls.Add(this.ShortcutNametextBox1);
            this.ShortcutsTabPage.Controls.Add(this.ShortcutName);
            this.ShortcutsTabPage.Controls.Add(this.ShortcutsListView);
            this.ShortcutsTabPage.Location = new System.Drawing.Point(4, 25);
            this.ShortcutsTabPage.Margin = new System.Windows.Forms.Padding(4);
            this.ShortcutsTabPage.Name = "ShortcutsTabPage";
            this.ShortcutsTabPage.Padding = new System.Windows.Forms.Padding(4);
            this.ShortcutsTabPage.Size = new System.Drawing.Size(619, 313);
            this.ShortcutsTabPage.TabIndex = 1;
            this.ShortcutsTabPage.Text = "ショートカット";
            this.ShortcutsTabPage.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(516, 279);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "キャンセル";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(413, 279);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "登録";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ShortcutNametextBox1
            // 
            this.ShortcutNametextBox1.Location = new System.Drawing.Point(387, 14);
            this.ShortcutNametextBox1.Name = "ShortcutNametextBox1";
            this.ShortcutNametextBox1.Size = new System.Drawing.Size(205, 22);
            this.ShortcutNametextBox1.TabIndex = 7;
            // 
            // ShortcutName
            // 
            this.ShortcutName.AutoSize = true;
            this.ShortcutName.Location = new System.Drawing.Point(270, 17);
            this.ShortcutName.Name = "ShortcutName";
            this.ShortcutName.Size = new System.Drawing.Size(111, 15);
            this.ShortcutName.TabIndex = 6;
            this.ShortcutName.Text = "ショートカット名称";
            // 
            // ShortcutsListView
            // 
            this.ShortcutsListView.HideSelection = false;
            this.ShortcutsListView.Location = new System.Drawing.Point(7, 8);
            this.ShortcutsListView.Margin = new System.Windows.Forms.Padding(4);
            this.ShortcutsListView.Name = "ShortcutsListView";
            this.ShortcutsListView.Size = new System.Drawing.Size(247, 294);
            this.ShortcutsListView.TabIndex = 0;
            this.ShortcutsListView.UseCompatibleStateImageBehavior = false;
            // 
            // GeneralTabPage
            // 
            this.GeneralTabPage.Controls.Add(this.DisableProcessAddButton);
            this.GeneralTabPage.Controls.Add(this.DisableProcessListBox);
            this.GeneralTabPage.Controls.Add(this.DisableProcessLabel);
            this.GeneralTabPage.Controls.Add(this.StartUpOptionLabel);
            this.GeneralTabPage.Controls.Add(this.StartupCheckBox);
            this.GeneralTabPage.Location = new System.Drawing.Point(4, 25);
            this.GeneralTabPage.Margin = new System.Windows.Forms.Padding(4);
            this.GeneralTabPage.Name = "GeneralTabPage";
            this.GeneralTabPage.Padding = new System.Windows.Forms.Padding(4);
            this.GeneralTabPage.Size = new System.Drawing.Size(619, 313);
            this.GeneralTabPage.TabIndex = 0;
            this.GeneralTabPage.Text = "一般";
            this.GeneralTabPage.UseVisualStyleBackColor = true;
            // 
            // DisableProcessAddButton
            // 
            this.DisableProcessAddButton.Location = new System.Drawing.Point(487, 266);
            this.DisableProcessAddButton.Margin = new System.Windows.Forms.Padding(4);
            this.DisableProcessAddButton.Name = "DisableProcessAddButton";
            this.DisableProcessAddButton.Size = new System.Drawing.Size(91, 24);
            this.DisableProcessAddButton.TabIndex = 4;
            this.DisableProcessAddButton.Text = "追加";
            this.DisableProcessAddButton.UseVisualStyleBackColor = true;
            // 
            // DisableProcessListBox
            // 
            this.DisableProcessListBox.FormattingEnabled = true;
            this.DisableProcessListBox.ItemHeight = 15;
            this.DisableProcessListBox.Location = new System.Drawing.Point(43, 134);
            this.DisableProcessListBox.Margin = new System.Windows.Forms.Padding(4);
            this.DisableProcessListBox.Name = "DisableProcessListBox";
            this.DisableProcessListBox.Size = new System.Drawing.Size(533, 124);
            this.DisableProcessListBox.TabIndex = 3;
            // 
            // DisableProcessLabel
            // 
            this.DisableProcessLabel.AutoSize = true;
            this.DisableProcessLabel.Location = new System.Drawing.Point(28, 101);
            this.DisableProcessLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DisableProcessLabel.Name = "DisableProcessLabel";
            this.DisableProcessLabel.Size = new System.Drawing.Size(384, 15);
            this.DisableProcessLabel.TabIndex = 2;
            this.DisableProcessLabel.Text = "プロセスの無効化(Webアプリ及びハードウェアには表示されません)";
            // 
            // StartUpOptionLabel
            // 
            this.StartUpOptionLabel.AutoSize = true;
            this.StartUpOptionLabel.Location = new System.Drawing.Point(25, 21);
            this.StartUpOptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StartUpOptionLabel.Name = "StartUpOptionLabel";
            this.StartUpOptionLabel.Size = new System.Drawing.Size(70, 15);
            this.StartUpOptionLabel.TabIndex = 1;
            this.StartUpOptionLabel.Text = "セットアップ";
            // 
            // StartupCheckBox
            // 
            this.StartupCheckBox.AutoSize = true;
            this.StartupCheckBox.Location = new System.Drawing.Point(31, 50);
            this.StartupCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.StartupCheckBox.Name = "StartupCheckBox";
            this.StartupCheckBox.Size = new System.Drawing.Size(232, 19);
            this.StartupCheckBox.TabIndex = 0;
            this.StartupCheckBox.Text = "システム起動時のObjem自動起動";
            this.StartupCheckBox.UseVisualStyleBackColor = true;
            // 
            // SettingTab
            // 
            this.SettingTab.AccessibleRole = System.Windows.Forms.AccessibleRole.Sound;
            this.SettingTab.Controls.Add(this.GeneralTabPage);
            this.SettingTab.Controls.Add(this.ShortcutsTabPage);
            this.SettingTab.Controls.Add(this.GestureTabPage);
            this.SettingTab.Controls.Add(this.OBSTabPage);
            this.SettingTab.Location = new System.Drawing.Point(16, 22);
            this.SettingTab.Margin = new System.Windows.Forms.Padding(4);
            this.SettingTab.Name = "SettingTab";
            this.SettingTab.SelectedIndex = 0;
            this.SettingTab.Size = new System.Drawing.Size(627, 342);
            this.SettingTab.TabIndex = 0;
            // 
            // KeyboardShortcutRadioButton
            // 
            this.KeyboardShortcutRadioButton.AutoSize = true;
            this.KeyboardShortcutRadioButton.Location = new System.Drawing.Point(300, 74);
            this.KeyboardShortcutRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.KeyboardShortcutRadioButton.Name = "KeyboardShortcutRadioButton";
            this.KeyboardShortcutRadioButton.Size = new System.Drawing.Size(161, 19);
            this.KeyboardShortcutRadioButton.TabIndex = 1;
            this.KeyboardShortcutRadioButton.TabStop = true;
            this.KeyboardShortcutRadioButton.Text = "キーボードショートカット";
            this.KeyboardShortcutRadioButton.UseVisualStyleBackColor = true;
            // 
            // LaunchApplicationRadioButton
            // 
            this.LaunchApplicationRadioButton.AutoSize = true;
            this.LaunchApplicationRadioButton.Location = new System.Drawing.Point(300, 139);
            this.LaunchApplicationRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.LaunchApplicationRadioButton.Name = "LaunchApplicationRadioButton";
            this.LaunchApplicationRadioButton.Size = new System.Drawing.Size(144, 19);
            this.LaunchApplicationRadioButton.TabIndex = 2;
            this.LaunchApplicationRadioButton.TabStop = true;
            this.LaunchApplicationRadioButton.Text = "アプリケーション起動";
            this.LaunchApplicationRadioButton.UseVisualStyleBackColor = true;
            // 
            // SendCommandRadioButton
            // 
            this.SendCommandRadioButton.AutoSize = true;
            this.SendCommandRadioButton.Location = new System.Drawing.Point(300, 208);
            this.SendCommandRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.SendCommandRadioButton.Name = "SendCommandRadioButton";
            this.SendCommandRadioButton.Size = new System.Drawing.Size(101, 19);
            this.SendCommandRadioButton.TabIndex = 3;
            this.SendCommandRadioButton.TabStop = true;
            this.SendCommandRadioButton.Text = "コマンド送信";
            this.SendCommandRadioButton.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(300, 235);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(292, 22);
            this.textBox1.TabIndex = 10;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(516, 165);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 11;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(516, 99);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 12;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(328, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(331, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "label2";
            // 
            // SettingWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 416);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SettingTab);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingWindow";
            this.Text = "設定";
            this.OBSTabPage.ResumeLayout(false);
            this.OBSTabPage.PerformLayout();
            this.GestureTabPage.ResumeLayout(false);
            this.GestureTabPage.PerformLayout();
            this.GestureSettingBox.ResumeLayout(false);
            this.GestureSettingBox.PerformLayout();
            this.ShortcutsTabPage.ResumeLayout(false);
            this.ShortcutsTabPage.PerformLayout();
            this.GeneralTabPage.ResumeLayout(false);
            this.GeneralTabPage.PerformLayout();
            this.SettingTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.TabPage OBSTabPage;
        private System.Windows.Forms.TextBox WebSocketURL;
        private System.Windows.Forms.Label WebSocketURLLabel;
        private System.Windows.Forms.TabPage GestureTabPage;
        private System.Windows.Forms.CheckBox EnableGestureCheckBox;
        private System.Windows.Forms.GroupBox GestureSettingBox;
        private System.Windows.Forms.Label Fader2Label;
        private System.Windows.Forms.Label Fader1Label;
        private System.Windows.Forms.ComboBox Feader2GestureComboBox;
        private System.Windows.Forms.ComboBox Feader1GestureComboBox;
        private System.Windows.Forms.Label GestureDescriptionLabel;
        private System.Windows.Forms.TabPage ShortcutsTabPage;
        private System.Windows.Forms.ListView ShortcutsListView;
        private System.Windows.Forms.TabPage GeneralTabPage;
        private System.Windows.Forms.Button DisableProcessAddButton;
        private System.Windows.Forms.ListBox DisableProcessListBox;
        private System.Windows.Forms.Label DisableProcessLabel;
        private System.Windows.Forms.Label StartUpOptionLabel;
        private System.Windows.Forms.CheckBox StartupCheckBox;
        private System.Windows.Forms.TabControl SettingTab;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox ShortcutNametextBox1;
        private System.Windows.Forms.Label ShortcutName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton SendCommandRadioButton;
        private System.Windows.Forms.RadioButton LaunchApplicationRadioButton;
        private System.Windows.Forms.RadioButton KeyboardShortcutRadioButton;
    }
}