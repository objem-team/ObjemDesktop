
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
            this.SettingTab = new System.Windows.Forms.TabControl();
            this.GeneralTabPage = new System.Windows.Forms.TabPage();
            this.DisableProcessAddButton = new System.Windows.Forms.Button();
            this.DisableProcessListBox = new System.Windows.Forms.ListBox();
            this.DisableProcessLabel = new System.Windows.Forms.Label();
            this.StartUpOptionLabel = new System.Windows.Forms.Label();
            this.StartupCheckBox = new System.Windows.Forms.CheckBox();
            this.ShortcutsTabPage = new System.Windows.Forms.TabPage();
            this.SendCommandRadioButton = new System.Windows.Forms.RadioButton();
            this.LaunchApplicationRadioButton = new System.Windows.Forms.RadioButton();
            this.KeyboardShortcutRadioButton = new System.Windows.Forms.RadioButton();
            this.ShortcutsListView = new System.Windows.Forms.ListView();
            this.GestureTabPage = new System.Windows.Forms.TabPage();
            this.EnableGestureCheckBox = new System.Windows.Forms.CheckBox();
            this.GestureSettingBox = new System.Windows.Forms.GroupBox();
            this.Fader2Label = new System.Windows.Forms.Label();
            this.Fader1Label = new System.Windows.Forms.Label();
            this.Feader2GestureComboBox = new System.Windows.Forms.ComboBox();
            this.Feader1GestureComboBox = new System.Windows.Forms.ComboBox();
            this.GestureDescriptionLabel = new System.Windows.Forms.Label();
            this.OBSTabPage = new System.Windows.Forms.TabPage();
            this.WebSocketURL = new System.Windows.Forms.TextBox();
            this.WebSocketURLLabel = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.OKButton = new System.Windows.Forms.Button();
            this.SettingTab.SuspendLayout();
            this.GeneralTabPage.SuspendLayout();
            this.ShortcutsTabPage.SuspendLayout();
            this.GestureTabPage.SuspendLayout();
            this.GestureSettingBox.SuspendLayout();
            this.OBSTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // SettingTab
            // 
            this.SettingTab.Controls.Add(this.GeneralTabPage);
            this.SettingTab.Controls.Add(this.ShortcutsTabPage);
            this.SettingTab.Controls.Add(this.GestureTabPage);
            this.SettingTab.Controls.Add(this.OBSTabPage);
            this.SettingTab.Location = new System.Drawing.Point(12, 12);
            this.SettingTab.Name = "SettingTab";
            this.SettingTab.SelectedIndex = 0;
            this.SettingTab.Size = new System.Drawing.Size(470, 274);
            this.SettingTab.TabIndex = 0;
            // 
            // GeneralTabPage
            // 
            this.GeneralTabPage.Controls.Add(this.DisableProcessAddButton);
            this.GeneralTabPage.Controls.Add(this.DisableProcessListBox);
            this.GeneralTabPage.Controls.Add(this.DisableProcessLabel);
            this.GeneralTabPage.Controls.Add(this.StartUpOptionLabel);
            this.GeneralTabPage.Controls.Add(this.StartupCheckBox);
            this.GeneralTabPage.Location = new System.Drawing.Point(4, 22);
            this.GeneralTabPage.Name = "GeneralTabPage";
            this.GeneralTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.GeneralTabPage.Size = new System.Drawing.Size(462, 248);
            this.GeneralTabPage.TabIndex = 0;
            this.GeneralTabPage.Text = "General";
            this.GeneralTabPage.UseVisualStyleBackColor = true;
            // 
            // DisableProcessAddButton
            // 
            this.DisableProcessAddButton.Location = new System.Drawing.Point(365, 213);
            this.DisableProcessAddButton.Name = "DisableProcessAddButton";
            this.DisableProcessAddButton.Size = new System.Drawing.Size(68, 19);
            this.DisableProcessAddButton.TabIndex = 4;
            this.DisableProcessAddButton.Text = "Add";
            this.DisableProcessAddButton.UseVisualStyleBackColor = true;
            // 
            // DisableProcessListBox
            // 
            this.DisableProcessListBox.FormattingEnabled = true;
            this.DisableProcessListBox.ItemHeight = 12;
            this.DisableProcessListBox.Location = new System.Drawing.Point(32, 107);
            this.DisableProcessListBox.Name = "DisableProcessListBox";
            this.DisableProcessListBox.Size = new System.Drawing.Size(401, 100);
            this.DisableProcessListBox.TabIndex = 3;
            // 
            // DisableProcessLabel
            // 
            this.DisableProcessLabel.AutoSize = true;
            this.DisableProcessLabel.Location = new System.Drawing.Point(21, 81);
            this.DisableProcessLabel.Name = "DisableProcessLabel";
            this.DisableProcessLabel.Size = new System.Drawing.Size(263, 12);
            this.DisableProcessLabel.TabIndex = 2;
            this.DisableProcessLabel.Text = "Disalbe Process(Not visible on web and hardware)";
            // 
            // StartUpOptionLabel
            // 
            this.StartUpOptionLabel.AutoSize = true;
            this.StartUpOptionLabel.Location = new System.Drawing.Point(19, 17);
            this.StartUpOptionLabel.Name = "StartUpOptionLabel";
            this.StartUpOptionLabel.Size = new System.Drawing.Size(42, 12);
            this.StartUpOptionLabel.TabIndex = 1;
            this.StartUpOptionLabel.Text = "Startup";
            // 
            // StartupCheckBox
            // 
            this.StartupCheckBox.AutoSize = true;
            this.StartupCheckBox.Location = new System.Drawing.Point(32, 41);
            this.StartupCheckBox.Name = "StartupCheckBox";
            this.StartupCheckBox.Size = new System.Drawing.Size(185, 16);
            this.StartupCheckBox.TabIndex = 0;
            this.StartupCheckBox.Text = " Run Objem  at system startup.";
            this.StartupCheckBox.UseVisualStyleBackColor = true;
            // 
            // ShortcutsTabPage
            // 
            this.ShortcutsTabPage.Controls.Add(this.SendCommandRadioButton);
            this.ShortcutsTabPage.Controls.Add(this.LaunchApplicationRadioButton);
            this.ShortcutsTabPage.Controls.Add(this.KeyboardShortcutRadioButton);
            this.ShortcutsTabPage.Controls.Add(this.ShortcutsListView);
            this.ShortcutsTabPage.Location = new System.Drawing.Point(4, 22);
            this.ShortcutsTabPage.Name = "ShortcutsTabPage";
            this.ShortcutsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ShortcutsTabPage.Size = new System.Drawing.Size(462, 248);
            this.ShortcutsTabPage.TabIndex = 1;
            this.ShortcutsTabPage.Text = "Shortcuts";
            this.ShortcutsTabPage.UseVisualStyleBackColor = true;
            // 
            // SendCommandRadioButton
            // 
            this.SendCommandRadioButton.AutoSize = true;
            this.SendCommandRadioButton.Location = new System.Drawing.Point(210, 156);
            this.SendCommandRadioButton.Name = "SendCommandRadioButton";
            this.SendCommandRadioButton.Size = new System.Drawing.Size(98, 16);
            this.SendCommandRadioButton.TabIndex = 3;
            this.SendCommandRadioButton.TabStop = true;
            this.SendCommandRadioButton.Text = "SendCommand";
            this.SendCommandRadioButton.UseVisualStyleBackColor = true;
            // 
            // LaunchApplicationRadioButton
            // 
            this.LaunchApplicationRadioButton.AutoSize = true;
            this.LaunchApplicationRadioButton.Location = new System.Drawing.Point(210, 87);
            this.LaunchApplicationRadioButton.Name = "LaunchApplicationRadioButton";
            this.LaunchApplicationRadioButton.Size = new System.Drawing.Size(116, 16);
            this.LaunchApplicationRadioButton.TabIndex = 2;
            this.LaunchApplicationRadioButton.TabStop = true;
            this.LaunchApplicationRadioButton.Text = "LaunchApplication";
            this.LaunchApplicationRadioButton.UseVisualStyleBackColor = true;
            // 
            // KeyboardShortcutRadioButton
            // 
            this.KeyboardShortcutRadioButton.AutoSize = true;
            this.KeyboardShortcutRadioButton.Location = new System.Drawing.Point(210, 18);
            this.KeyboardShortcutRadioButton.Name = "KeyboardShortcutRadioButton";
            this.KeyboardShortcutRadioButton.Size = new System.Drawing.Size(113, 16);
            this.KeyboardShortcutRadioButton.TabIndex = 1;
            this.KeyboardShortcutRadioButton.TabStop = true;
            this.KeyboardShortcutRadioButton.Text = "KeyboardShortcut";
            this.KeyboardShortcutRadioButton.UseVisualStyleBackColor = true;
            // 
            // ShortcutsListView
            // 
            this.ShortcutsListView.HideSelection = false;
            this.ShortcutsListView.Location = new System.Drawing.Point(6, 6);
            this.ShortcutsListView.Name = "ShortcutsListView";
            this.ShortcutsListView.Size = new System.Drawing.Size(186, 236);
            this.ShortcutsListView.TabIndex = 0;
            this.ShortcutsListView.UseCompatibleStateImageBehavior = false;
            // 
            // GestureTabPage
            // 
            this.GestureTabPage.Controls.Add(this.EnableGestureCheckBox);
            this.GestureTabPage.Controls.Add(this.GestureSettingBox);
            this.GestureTabPage.Controls.Add(this.GestureDescriptionLabel);
            this.GestureTabPage.Location = new System.Drawing.Point(4, 22);
            this.GestureTabPage.Name = "GestureTabPage";
            this.GestureTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.GestureTabPage.Size = new System.Drawing.Size(462, 248);
            this.GestureTabPage.TabIndex = 2;
            this.GestureTabPage.Text = "Gesture";
            this.GestureTabPage.UseVisualStyleBackColor = true;
            // 
            // EnableGestureCheckBox
            // 
            this.EnableGestureCheckBox.AutoSize = true;
            this.EnableGestureCheckBox.Location = new System.Drawing.Point(30, 42);
            this.EnableGestureCheckBox.Name = "EnableGestureCheckBox";
            this.EnableGestureCheckBox.Size = new System.Drawing.Size(98, 16);
            this.EnableGestureCheckBox.TabIndex = 6;
            this.EnableGestureCheckBox.Text = "EnableGesture";
            this.EnableGestureCheckBox.UseVisualStyleBackColor = true;
            // 
            // GestureSettingBox
            // 
            this.GestureSettingBox.Controls.Add(this.Fader2Label);
            this.GestureSettingBox.Controls.Add(this.Fader1Label);
            this.GestureSettingBox.Controls.Add(this.Feader2GestureComboBox);
            this.GestureSettingBox.Controls.Add(this.Feader1GestureComboBox);
            this.GestureSettingBox.Location = new System.Drawing.Point(30, 75);
            this.GestureSettingBox.Name = "GestureSettingBox";
            this.GestureSettingBox.Size = new System.Drawing.Size(413, 156);
            this.GestureSettingBox.TabIndex = 5;
            this.GestureSettingBox.TabStop = false;
            // 
            // Fader2Label
            // 
            this.Fader2Label.AutoSize = true;
            this.Fader2Label.Location = new System.Drawing.Point(7, 79);
            this.Fader2Label.Name = "Fader2Label";
            this.Fader2Label.Size = new System.Drawing.Size(40, 12);
            this.Fader2Label.TabIndex = 3;
            this.Fader2Label.Text = "Feder2";
            // 
            // Fader1Label
            // 
            this.Fader1Label.AutoSize = true;
            this.Fader1Label.Location = new System.Drawing.Point(7, 14);
            this.Fader1Label.Name = "Fader1Label";
            this.Fader1Label.Size = new System.Drawing.Size(40, 12);
            this.Fader1Label.TabIndex = 2;
            this.Fader1Label.Text = "Fader1";
            // 
            // Feader2GestureComboBox
            // 
            this.Feader2GestureComboBox.FormattingEnabled = true;
            this.Feader2GestureComboBox.Location = new System.Drawing.Point(20, 110);
            this.Feader2GestureComboBox.Name = "Feader2GestureComboBox";
            this.Feader2GestureComboBox.Size = new System.Drawing.Size(361, 20);
            this.Feader2GestureComboBox.TabIndex = 1;
            // 
            // Feader1GestureComboBox
            // 
            this.Feader1GestureComboBox.FormattingEnabled = true;
            this.Feader1GestureComboBox.Location = new System.Drawing.Point(20, 39);
            this.Feader1GestureComboBox.Name = "Feader1GestureComboBox";
            this.Feader1GestureComboBox.Size = new System.Drawing.Size(361, 20);
            this.Feader1GestureComboBox.TabIndex = 0;
            // 
            // GestureDescriptionLabel
            // 
            this.GestureDescriptionLabel.AutoSize = true;
            this.GestureDescriptionLabel.Location = new System.Drawing.Point(17, 14);
            this.GestureDescriptionLabel.Name = "GestureDescriptionLabel";
            this.GestureDescriptionLabel.Size = new System.Drawing.Size(312, 12);
            this.GestureDescriptionLabel.TabIndex = 4;
            this.GestureDescriptionLabel.Text = "When the fader knob is touched twice, Shortcut is executed.";
            // 
            // OBSTabPage
            // 
            this.OBSTabPage.Controls.Add(this.WebSocketURL);
            this.OBSTabPage.Controls.Add(this.WebSocketURLLabel);
            this.OBSTabPage.Location = new System.Drawing.Point(4, 22);
            this.OBSTabPage.Name = "OBSTabPage";
            this.OBSTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.OBSTabPage.Size = new System.Drawing.Size(462, 248);
            this.OBSTabPage.TabIndex = 3;
            this.OBSTabPage.Text = "OBS";
            this.OBSTabPage.UseVisualStyleBackColor = true;
            // 
            // WebSocketURL
            // 
            this.WebSocketURL.Location = new System.Drawing.Point(22, 47);
            this.WebSocketURL.Name = "WebSocketURL";
            this.WebSocketURL.Size = new System.Drawing.Size(393, 19);
            this.WebSocketURL.TabIndex = 1;
            // 
            // WebSocketURLLabel
            // 
            this.WebSocketURLLabel.AutoSize = true;
            this.WebSocketURLLabel.Location = new System.Drawing.Point(20, 22);
            this.WebSocketURLLabel.Name = "WebSocketURLLabel";
            this.WebSocketURLLabel.Size = new System.Drawing.Size(83, 12);
            this.WebSocketURLLabel.TabIndex = 0;
            this.WebSocketURLLabel.Text = "WebSocketURL";
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(407, 298);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 1;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(313, 298);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 2;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            // 
            // SettingWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 333);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SettingTab);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingWindow";
            this.Text = "SettingWindow";
            this.SettingTab.ResumeLayout(false);
            this.GeneralTabPage.ResumeLayout(false);
            this.GeneralTabPage.PerformLayout();
            this.ShortcutsTabPage.ResumeLayout(false);
            this.ShortcutsTabPage.PerformLayout();
            this.GestureTabPage.ResumeLayout(false);
            this.GestureTabPage.PerformLayout();
            this.GestureSettingBox.ResumeLayout(false);
            this.GestureSettingBox.PerformLayout();
            this.OBSTabPage.ResumeLayout(false);
            this.OBSTabPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl SettingTab;
        private System.Windows.Forms.TabPage GeneralTabPage;
        private System.Windows.Forms.TabPage ShortcutsTabPage;
        private System.Windows.Forms.Label DisableProcessLabel;
        private System.Windows.Forms.Label StartUpOptionLabel;
        private System.Windows.Forms.CheckBox StartupCheckBox;
        private System.Windows.Forms.TabPage GestureTabPage;
        private System.Windows.Forms.Button DisableProcessAddButton;
        private System.Windows.Forms.ListBox DisableProcessListBox;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.RadioButton SendCommandRadioButton;
        private System.Windows.Forms.RadioButton LaunchApplicationRadioButton;
        private System.Windows.Forms.RadioButton KeyboardShortcutRadioButton;
        private System.Windows.Forms.ListView ShortcutsListView;
        private System.Windows.Forms.TabPage OBSTabPage;
        private System.Windows.Forms.GroupBox GestureSettingBox;
        private System.Windows.Forms.Label Fader2Label;
        private System.Windows.Forms.Label Fader1Label;
        private System.Windows.Forms.ComboBox Feader2GestureComboBox;
        private System.Windows.Forms.ComboBox Feader1GestureComboBox;
        private System.Windows.Forms.Label GestureDescriptionLabel;
        private System.Windows.Forms.CheckBox EnableGestureCheckBox;
        private System.Windows.Forms.TextBox WebSocketURL;
        private System.Windows.Forms.Label WebSocketURLLabel;
    }
}