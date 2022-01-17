
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
            this.addShortcutGroupBox = new System.Windows.Forms.GroupBox();
            this.KeyboardShortcutRadioButton = new System.Windows.Forms.RadioButton();
            this.LaunchApplicationShortcutLabel = new System.Windows.Forms.Label();
            this.LaunchApplicationRadioButton = new System.Windows.Forms.RadioButton();
            this.KeyboardShortcutLabel = new System.Windows.Forms.Label();
            this.SendCommandRadioButton = new System.Windows.Forms.RadioButton();
            this.OpenKeyboardShortcutSettingButton = new System.Windows.Forms.Button();
            this.CommandTextBox = new System.Windows.Forms.TextBox();
            this.OpenLaunchApplicationShortSettingButton = new System.Windows.Forms.Button();
            this.AddShortcutButton = new System.Windows.Forms.Button();
            this.ShortcutNametextBox1 = new System.Windows.Forms.TextBox();
            this.ShortcutName = new System.Windows.Forms.Label();
            this.ShortcutsListView = new System.Windows.Forms.ListView();
            this.GeneralTabPage = new System.Windows.Forms.TabPage();
            this.ServerIpAdressLabel = new System.Windows.Forms.Label();
            this.ServerIpAddressComboBox = new System.Windows.Forms.ComboBox();
            this.DisableProcessAddButton = new System.Windows.Forms.Button();
            this.DisableProcessListBox = new System.Windows.Forms.ListBox();
            this.DisableProcessLabel = new System.Windows.Forms.Label();
            this.StartupCheckBox = new System.Windows.Forms.CheckBox();
            this.SettingTab = new System.Windows.Forms.TabControl();
            this.CertificateTabPage = new System.Windows.Forms.TabPage();
            this.CACertExportLabel = new System.Windows.Forms.Label();
            this.DownLoadQRCodeBtn = new System.Windows.Forms.Button();
            this.FileExportBtn = new System.Windows.Forms.Button();
            this.ReGenerateCACertBtn = new System.Windows.Forms.Button();
            this.ReGenerateCACertLabel = new System.Windows.Forms.Label();
            this.saveCACertFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.DownloadCAGroup = new System.Windows.Forms.GroupBox();
            this.DownloadServerIPLabel = new System.Windows.Forms.Label();
            this.DownloadServerIPComboBox = new System.Windows.Forms.ComboBox();
            this.OBSTabPage.SuspendLayout();
            this.GestureTabPage.SuspendLayout();
            this.GestureSettingBox.SuspendLayout();
            this.ShortcutsTabPage.SuspendLayout();
            this.addShortcutGroupBox.SuspendLayout();
            this.GeneralTabPage.SuspendLayout();
            this.SettingTab.SuspendLayout();
            this.CertificateTabPage.SuspendLayout();
            this.DownloadCAGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(404, 298);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 1;
            this.CancelButton.Text = "キャンセル";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // OKButton
            // 
            this.OKButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.OKButton.Location = new System.Drawing.Point(325, 298);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(63, 23);
            this.OKButton.TabIndex = 2;
            this.OKButton.Text = "適用";
            this.OKButton.UseVisualStyleBackColor = false;
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
            this.OBSTabPage.Text = "OBS設定";
            this.OBSTabPage.UseVisualStyleBackColor = true;
            // 
            // WebSocketURL
            // 
            this.WebSocketURL.Location = new System.Drawing.Point(22, 47);
            this.WebSocketURL.Name = "WebSocketURL";
            this.WebSocketURL.Size = new System.Drawing.Size(342, 19);
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
            this.GestureTabPage.Text = "ジェスチャー";
            this.GestureTabPage.UseVisualStyleBackColor = true;
            // 
            // EnableGestureCheckBox
            // 
            this.EnableGestureCheckBox.AutoSize = true;
            this.EnableGestureCheckBox.Checked = true;
            this.EnableGestureCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.EnableGestureCheckBox.Location = new System.Drawing.Point(30, 42);
            this.EnableGestureCheckBox.Name = "EnableGestureCheckBox";
            this.EnableGestureCheckBox.Size = new System.Drawing.Size(123, 16);
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
            this.GestureDescriptionLabel.Location = new System.Drawing.Point(28, 14);
            this.GestureDescriptionLabel.Name = "GestureDescriptionLabel";
            this.GestureDescriptionLabel.Size = new System.Drawing.Size(276, 12);
            this.GestureDescriptionLabel.TabIndex = 4;
            this.GestureDescriptionLabel.Text = "フェーダーのノブを2回タップ時のショートカットを設定します。\r\n";
            // 
            // ShortcutsTabPage
            // 
            this.ShortcutsTabPage.Controls.Add(this.addShortcutGroupBox);
            this.ShortcutsTabPage.Controls.Add(this.AddShortcutButton);
            this.ShortcutsTabPage.Controls.Add(this.ShortcutNametextBox1);
            this.ShortcutsTabPage.Controls.Add(this.ShortcutName);
            this.ShortcutsTabPage.Controls.Add(this.ShortcutsListView);
            this.ShortcutsTabPage.Location = new System.Drawing.Point(4, 22);
            this.ShortcutsTabPage.Name = "ShortcutsTabPage";
            this.ShortcutsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ShortcutsTabPage.Size = new System.Drawing.Size(462, 248);
            this.ShortcutsTabPage.TabIndex = 1;
            this.ShortcutsTabPage.Text = "ショートカット";
            this.ShortcutsTabPage.UseVisualStyleBackColor = true;
            // 
            // addShortcutGroupBox
            // 
            this.addShortcutGroupBox.Controls.Add(this.KeyboardShortcutRadioButton);
            this.addShortcutGroupBox.Controls.Add(this.LaunchApplicationShortcutLabel);
            this.addShortcutGroupBox.Controls.Add(this.LaunchApplicationRadioButton);
            this.addShortcutGroupBox.Controls.Add(this.KeyboardShortcutLabel);
            this.addShortcutGroupBox.Controls.Add(this.SendCommandRadioButton);
            this.addShortcutGroupBox.Controls.Add(this.OpenKeyboardShortcutSettingButton);
            this.addShortcutGroupBox.Controls.Add(this.CommandTextBox);
            this.addShortcutGroupBox.Controls.Add(this.OpenLaunchApplicationShortSettingButton);
            this.addShortcutGroupBox.Location = new System.Drawing.Point(206, 35);
            this.addShortcutGroupBox.Name = "addShortcutGroupBox";
            this.addShortcutGroupBox.Size = new System.Drawing.Size(239, 173);
            this.addShortcutGroupBox.TabIndex = 15;
            this.addShortcutGroupBox.TabStop = false;
            // 
            // KeyboardShortcutRadioButton
            // 
            this.KeyboardShortcutRadioButton.AutoSize = true;
            this.KeyboardShortcutRadioButton.Location = new System.Drawing.Point(6, 18);
            this.KeyboardShortcutRadioButton.Name = "KeyboardShortcutRadioButton";
            this.KeyboardShortcutRadioButton.Size = new System.Drawing.Size(130, 16);
            this.KeyboardShortcutRadioButton.TabIndex = 1;
            this.KeyboardShortcutRadioButton.TabStop = true;
            this.KeyboardShortcutRadioButton.Text = "キーボードショートカット";
            this.KeyboardShortcutRadioButton.UseVisualStyleBackColor = true;
            // 
            // LaunchApplicationShortcutLabel
            // 
            this.LaunchApplicationShortcutLabel.AutoSize = true;
            this.LaunchApplicationShortcutLabel.Location = new System.Drawing.Point(29, 97);
            this.LaunchApplicationShortcutLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LaunchApplicationShortcutLabel.Name = "LaunchApplicationShortcutLabel";
            this.LaunchApplicationShortcutLabel.Size = new System.Drawing.Size(137, 12);
            this.LaunchApplicationShortcutLabel.TabIndex = 14;
            this.LaunchApplicationShortcutLabel.Text = "LaunchApplicationShortcu";
            // 
            // LaunchApplicationRadioButton
            // 
            this.LaunchApplicationRadioButton.AutoSize = true;
            this.LaunchApplicationRadioButton.Location = new System.Drawing.Point(6, 70);
            this.LaunchApplicationRadioButton.Name = "LaunchApplicationRadioButton";
            this.LaunchApplicationRadioButton.Size = new System.Drawing.Size(116, 16);
            this.LaunchApplicationRadioButton.TabIndex = 2;
            this.LaunchApplicationRadioButton.TabStop = true;
            this.LaunchApplicationRadioButton.Text = "アプリケーション起動";
            this.LaunchApplicationRadioButton.UseVisualStyleBackColor = true;
            // 
            // KeyboardShortcutLabel
            // 
            this.KeyboardShortcutLabel.AutoSize = true;
            this.KeyboardShortcutLabel.Location = new System.Drawing.Point(27, 38);
            this.KeyboardShortcutLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.KeyboardShortcutLabel.Name = "KeyboardShortcutLabel";
            this.KeyboardShortcutLabel.Size = new System.Drawing.Size(95, 12);
            this.KeyboardShortcutLabel.TabIndex = 13;
            this.KeyboardShortcutLabel.Text = "KeyboardShortcut";
            // 
            // SendCommandRadioButton
            // 
            this.SendCommandRadioButton.AutoSize = true;
            this.SendCommandRadioButton.Location = new System.Drawing.Point(6, 125);
            this.SendCommandRadioButton.Name = "SendCommandRadioButton";
            this.SendCommandRadioButton.Size = new System.Drawing.Size(82, 16);
            this.SendCommandRadioButton.TabIndex = 3;
            this.SendCommandRadioButton.TabStop = true;
            this.SendCommandRadioButton.Text = "コマンド送信";
            this.SendCommandRadioButton.UseVisualStyleBackColor = true;
            // 
            // OpenKeyboardShortcutSettingButton
            // 
            this.OpenKeyboardShortcutSettingButton.Location = new System.Drawing.Point(168, 38);
            this.OpenKeyboardShortcutSettingButton.Margin = new System.Windows.Forms.Padding(2);
            this.OpenKeyboardShortcutSettingButton.Name = "OpenKeyboardShortcutSettingButton";
            this.OpenKeyboardShortcutSettingButton.Size = new System.Drawing.Size(56, 18);
            this.OpenKeyboardShortcutSettingButton.TabIndex = 12;
            this.OpenKeyboardShortcutSettingButton.Text = "編集";
            this.OpenKeyboardShortcutSettingButton.UseVisualStyleBackColor = true;
            // 
            // CommandTextBox
            // 
            this.CommandTextBox.Location = new System.Drawing.Point(6, 147);
            this.CommandTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.CommandTextBox.Name = "CommandTextBox";
            this.CommandTextBox.Size = new System.Drawing.Size(220, 19);
            this.CommandTextBox.TabIndex = 10;
            // 
            // OpenLaunchApplicationShortSettingButton
            // 
            this.OpenLaunchApplicationShortSettingButton.Location = new System.Drawing.Point(168, 91);
            this.OpenLaunchApplicationShortSettingButton.Margin = new System.Windows.Forms.Padding(2);
            this.OpenLaunchApplicationShortSettingButton.Name = "OpenLaunchApplicationShortSettingButton";
            this.OpenLaunchApplicationShortSettingButton.Size = new System.Drawing.Size(56, 18);
            this.OpenLaunchApplicationShortSettingButton.TabIndex = 11;
            this.OpenLaunchApplicationShortSettingButton.Text = "選択";
            this.OpenLaunchApplicationShortSettingButton.UseVisualStyleBackColor = true;
            // 
            // AddShortcutButton
            // 
            this.AddShortcutButton.Font = new System.Drawing.Font("MS UI Gothic", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.AddShortcutButton.Location = new System.Drawing.Point(382, 213);
            this.AddShortcutButton.Margin = new System.Windows.Forms.Padding(2);
            this.AddShortcutButton.Name = "AddShortcutButton";
            this.AddShortcutButton.Size = new System.Drawing.Size(63, 18);
            this.AddShortcutButton.TabIndex = 8;
            this.AddShortcutButton.Text = "追加";
            this.AddShortcutButton.UseVisualStyleBackColor = true;
            // 
            // ShortcutNametextBox1
            // 
            this.ShortcutNametextBox1.Location = new System.Drawing.Point(290, 11);
            this.ShortcutNametextBox1.Margin = new System.Windows.Forms.Padding(2);
            this.ShortcutNametextBox1.Name = "ShortcutNametextBox1";
            this.ShortcutNametextBox1.Size = new System.Drawing.Size(155, 19);
            this.ShortcutNametextBox1.TabIndex = 7;
            // 
            // ShortcutName
            // 
            this.ShortcutName.AutoSize = true;
            this.ShortcutName.Location = new System.Drawing.Point(202, 14);
            this.ShortcutName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ShortcutName.Name = "ShortcutName";
            this.ShortcutName.Size = new System.Drawing.Size(87, 12);
            this.ShortcutName.TabIndex = 6;
            this.ShortcutName.Text = "ショートカット名称";
            // 
            // ShortcutsListView
            // 
            this.ShortcutsListView.HideSelection = false;
            this.ShortcutsListView.Location = new System.Drawing.Point(5, 6);
            this.ShortcutsListView.Name = "ShortcutsListView";
            this.ShortcutsListView.Size = new System.Drawing.Size(186, 236);
            this.ShortcutsListView.TabIndex = 0;
            this.ShortcutsListView.UseCompatibleStateImageBehavior = false;
            // 
            // GeneralTabPage
            // 
            this.GeneralTabPage.Controls.Add(this.ServerIpAdressLabel);
            this.GeneralTabPage.Controls.Add(this.ServerIpAddressComboBox);
            this.GeneralTabPage.Controls.Add(this.DisableProcessAddButton);
            this.GeneralTabPage.Controls.Add(this.DisableProcessListBox);
            this.GeneralTabPage.Controls.Add(this.DisableProcessLabel);
            this.GeneralTabPage.Controls.Add(this.StartupCheckBox);
            this.GeneralTabPage.Location = new System.Drawing.Point(4, 22);
            this.GeneralTabPage.Name = "GeneralTabPage";
            this.GeneralTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.GeneralTabPage.Size = new System.Drawing.Size(462, 248);
            this.GeneralTabPage.TabIndex = 0;
            this.GeneralTabPage.Text = "一般";
            this.GeneralTabPage.UseVisualStyleBackColor = true;
            // 
            // ServerIpAdressLabel
            // 
            this.ServerIpAdressLabel.AutoSize = true;
            this.ServerIpAdressLabel.Location = new System.Drawing.Point(31, 53);
            this.ServerIpAdressLabel.Name = "ServerIpAdressLabel";
            this.ServerIpAdressLabel.Size = new System.Drawing.Size(101, 12);
            this.ServerIpAdressLabel.TabIndex = 6;
            this.ServerIpAdressLabel.Text = "サーバーのIPアドレス";
            // 
            // ServerIpAddressComboBox
            // 
            this.ServerIpAddressComboBox.FormattingEnabled = true;
            this.ServerIpAddressComboBox.Location = new System.Drawing.Point(194, 50);
            this.ServerIpAddressComboBox.Name = "ServerIpAddressComboBox";
            this.ServerIpAddressComboBox.Size = new System.Drawing.Size(233, 20);
            this.ServerIpAddressComboBox.TabIndex = 5;
            // 
            // DisableProcessAddButton
            // 
            this.DisableProcessAddButton.Location = new System.Drawing.Point(366, 218);
            this.DisableProcessAddButton.Name = "DisableProcessAddButton";
            this.DisableProcessAddButton.Size = new System.Drawing.Size(68, 19);
            this.DisableProcessAddButton.TabIndex = 4;
            this.DisableProcessAddButton.Text = "追加";
            this.DisableProcessAddButton.UseVisualStyleBackColor = true;
            // 
            // DisableProcessListBox
            // 
            this.DisableProcessListBox.FormattingEnabled = true;
            this.DisableProcessListBox.ItemHeight = 12;
            this.DisableProcessListBox.Location = new System.Drawing.Point(33, 119);
            this.DisableProcessListBox.Name = "DisableProcessListBox";
            this.DisableProcessListBox.Size = new System.Drawing.Size(394, 88);
            this.DisableProcessListBox.TabIndex = 3;
            // 
            // DisableProcessLabel
            // 
            this.DisableProcessLabel.AutoSize = true;
            this.DisableProcessLabel.Location = new System.Drawing.Point(31, 88);
            this.DisableProcessLabel.Name = "DisableProcessLabel";
            this.DisableProcessLabel.Size = new System.Drawing.Size(309, 12);
            this.DisableProcessLabel.TabIndex = 2;
            this.DisableProcessLabel.Text = "プロセスの無効化(Webアプリ及びハードウェアには表示されません)";
            // 
            // StartupCheckBox
            // 
            this.StartupCheckBox.AutoSize = true;
            this.StartupCheckBox.Location = new System.Drawing.Point(33, 18);
            this.StartupCheckBox.Name = "StartupCheckBox";
            this.StartupCheckBox.Size = new System.Drawing.Size(188, 16);
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
            this.SettingTab.Controls.Add(this.CertificateTabPage);
            this.SettingTab.Location = new System.Drawing.Point(12, 18);
            this.SettingTab.Name = "SettingTab";
            this.SettingTab.SelectedIndex = 0;
            this.SettingTab.Size = new System.Drawing.Size(470, 274);
            this.SettingTab.TabIndex = 1;
            // 
            // CertificateTabPage
            // 
            this.CertificateTabPage.Controls.Add(this.DownloadCAGroup);
            this.CertificateTabPage.Controls.Add(this.CACertExportLabel);
            this.CertificateTabPage.Controls.Add(this.FileExportBtn);
            this.CertificateTabPage.Controls.Add(this.ReGenerateCACertBtn);
            this.CertificateTabPage.Controls.Add(this.ReGenerateCACertLabel);
            this.CertificateTabPage.Location = new System.Drawing.Point(4, 22);
            this.CertificateTabPage.Name = "CertificateTabPage";
            this.CertificateTabPage.Size = new System.Drawing.Size(462, 248);
            this.CertificateTabPage.TabIndex = 4;
            this.CertificateTabPage.Text = "証明書";
            this.CertificateTabPage.UseVisualStyleBackColor = true;
            // 
            // CACertExportLabel
            // 
            this.CACertExportLabel.AutoSize = true;
            this.CACertExportLabel.Location = new System.Drawing.Point(25, 72);
            this.CACertExportLabel.Name = "CACertExportLabel";
            this.CACertExportLabel.Size = new System.Drawing.Size(139, 12);
            this.CACertExportLabel.TabIndex = 7;
            this.CACertExportLabel.Text = "CA証明書をエクスポートする";
            // 
            // DownLoadQRCodeBtn
            // 
            this.DownLoadQRCodeBtn.Location = new System.Drawing.Point(316, 60);
            this.DownLoadQRCodeBtn.Name = "DownLoadQRCodeBtn";
            this.DownLoadQRCodeBtn.Size = new System.Drawing.Size(73, 23);
            this.DownLoadQRCodeBtn.TabIndex = 6;
            this.DownLoadQRCodeBtn.Text = "開始";
            this.DownLoadQRCodeBtn.UseVisualStyleBackColor = true;
            this.DownLoadQRCodeBtn.Click += new System.EventHandler(this.DownLoadQRCodeBtn_Click);
            // 
            // FileExportBtn
            // 
            this.FileExportBtn.Location = new System.Drawing.Point(343, 67);
            this.FileExportBtn.Name = "FileExportBtn";
            this.FileExportBtn.Size = new System.Drawing.Size(95, 23);
            this.FileExportBtn.TabIndex = 5;
            this.FileExportBtn.Text = "エクスポート";
            this.FileExportBtn.UseVisualStyleBackColor = true;
            this.FileExportBtn.Click += new System.EventHandler(this.FileExportBtn_Click);
            // 
            // ReGenerateCACertBtn
            // 
            this.ReGenerateCACertBtn.Location = new System.Drawing.Point(365, 21);
            this.ReGenerateCACertBtn.Name = "ReGenerateCACertBtn";
            this.ReGenerateCACertBtn.Size = new System.Drawing.Size(75, 23);
            this.ReGenerateCACertBtn.TabIndex = 3;
            this.ReGenerateCACertBtn.Text = "再作成";
            this.ReGenerateCACertBtn.UseVisualStyleBackColor = true;
            this.ReGenerateCACertBtn.Click += new System.EventHandler(this.ReGenerateCACertBtn_Click);
            // 
            // ReGenerateCACertLabel
            // 
            this.ReGenerateCACertLabel.AutoSize = true;
            this.ReGenerateCACertLabel.Location = new System.Drawing.Point(25, 26);
            this.ReGenerateCACertLabel.Name = "ReGenerateCACertLabel";
            this.ReGenerateCACertLabel.Size = new System.Drawing.Size(240, 12);
            this.ReGenerateCACertLabel.TabIndex = 1;
            this.ReGenerateCACertLabel.Text = "CA証明書の再作成(この操作はもとに戻せません)";
            // 
            // DownloadCAGroup
            // 
            this.DownloadCAGroup.Controls.Add(this.DownloadServerIPComboBox);
            this.DownloadCAGroup.Controls.Add(this.DownloadServerIPLabel);
            this.DownloadCAGroup.Controls.Add(this.DownLoadQRCodeBtn);
            this.DownloadCAGroup.Location = new System.Drawing.Point(27, 117);
            this.DownloadCAGroup.Name = "DownloadCAGroup";
            this.DownloadCAGroup.Size = new System.Drawing.Size(411, 89);
            this.DownloadCAGroup.TabIndex = 9;
            this.DownloadCAGroup.TabStop = false;
            this.DownloadCAGroup.Text = "他の端末へ転送する";
            // 
            // DownloadServerIPLabel
            // 
            this.DownloadServerIPLabel.AutoSize = true;
            this.DownloadServerIPLabel.Location = new System.Drawing.Point(119, 29);
            this.DownloadServerIPLabel.Name = "DownloadServerIPLabel";
            this.DownloadServerIPLabel.Size = new System.Drawing.Size(120, 12);
            this.DownloadServerIPLabel.TabIndex = 7;
            this.DownloadServerIPLabel.Text = "表示するQRのIPアドレス";
            // 
            // DownloadServerIPComboBox
            // 
            this.DownloadServerIPComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DownloadServerIPComboBox.FormattingEnabled = true;
            this.DownloadServerIPComboBox.Location = new System.Drawing.Point(268, 26);
            this.DownloadServerIPComboBox.Name = "DownloadServerIPComboBox";
            this.DownloadServerIPComboBox.Size = new System.Drawing.Size(121, 20);
            this.DownloadServerIPComboBox.TabIndex = 8;
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
            this.Text = "設定";
            this.Load += new System.EventHandler(this.SettingWindow_Load);
            this.OBSTabPage.ResumeLayout(false);
            this.OBSTabPage.PerformLayout();
            this.GestureTabPage.ResumeLayout(false);
            this.GestureTabPage.PerformLayout();
            this.GestureSettingBox.ResumeLayout(false);
            this.GestureSettingBox.PerformLayout();
            this.ShortcutsTabPage.ResumeLayout(false);
            this.ShortcutsTabPage.PerformLayout();
            this.addShortcutGroupBox.ResumeLayout(false);
            this.addShortcutGroupBox.PerformLayout();
            this.GeneralTabPage.ResumeLayout(false);
            this.GeneralTabPage.PerformLayout();
            this.SettingTab.ResumeLayout(false);
            this.CertificateTabPage.ResumeLayout(false);
            this.CertificateTabPage.PerformLayout();
            this.DownloadCAGroup.ResumeLayout(false);
            this.DownloadCAGroup.PerformLayout();
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
        private System.Windows.Forms.CheckBox StartupCheckBox;
        private System.Windows.Forms.TabControl SettingTab;
        private System.Windows.Forms.Button AddShortcutButton;
        private System.Windows.Forms.TextBox ShortcutNametextBox1;
        private System.Windows.Forms.Label ShortcutName;
        private System.Windows.Forms.Label LaunchApplicationShortcutLabel;
        private System.Windows.Forms.Label KeyboardShortcutLabel;
        private System.Windows.Forms.Button OpenKeyboardShortcutSettingButton;
        private System.Windows.Forms.Button OpenLaunchApplicationShortSettingButton;
        private System.Windows.Forms.TextBox CommandTextBox;
        private System.Windows.Forms.RadioButton SendCommandRadioButton;
        private System.Windows.Forms.RadioButton LaunchApplicationRadioButton;
        private System.Windows.Forms.RadioButton KeyboardShortcutRadioButton;
        private System.Windows.Forms.GroupBox addShortcutGroupBox;
        private System.Windows.Forms.TabPage CertificateTabPage;
        private System.Windows.Forms.Button ReGenerateCACertBtn;
        private System.Windows.Forms.Label ReGenerateCACertLabel;
        private System.Windows.Forms.Label ServerIpAdressLabel;
        private System.Windows.Forms.ComboBox ServerIpAddressComboBox;
        private System.Windows.Forms.Label CACertExportLabel;
        private System.Windows.Forms.Button DownLoadQRCodeBtn;
        private System.Windows.Forms.Button FileExportBtn;
        private System.Windows.Forms.SaveFileDialog saveCACertFileDialog;
        private System.Windows.Forms.GroupBox DownloadCAGroup;
        private System.Windows.Forms.ComboBox DownloadServerIPComboBox;
        private System.Windows.Forms.Label DownloadServerIPLabel;
    }
}