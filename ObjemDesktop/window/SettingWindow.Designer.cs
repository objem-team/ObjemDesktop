
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
            this.ApplyBtn = new System.Windows.Forms.Button();
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
            this.SelectedShortCutListview = new System.Windows.Forms.ListBox();
            this.ShortcutsListBox = new System.Windows.Forms.ListBox();
            this.EditShortcutBtn = new System.Windows.Forms.Button();
            this.orderUpBtn = new System.Windows.Forms.Button();
            this.orderDown = new System.Windows.Forms.Button();
            this.AddShortcutBtn = new System.Windows.Forms.Button();
            this.RemoveFromEnableListBtn = new System.Windows.Forms.Button();
            this.AddToEnableBtn = new System.Windows.Forms.Button();
            this.GeneralTabPage = new System.Windows.Forms.TabPage();
            this.ServerIpAdressLabel = new System.Windows.Forms.Label();
            this.ServerIpAddressComboBox = new System.Windows.Forms.ComboBox();
            this.DisableProcessAddButton = new System.Windows.Forms.Button();
            this.DisableProcessListBox = new System.Windows.Forms.ListBox();
            this.DisableProcessLabel = new System.Windows.Forms.Label();
            this.StartupCheckBox = new System.Windows.Forms.CheckBox();
            this.SettingTab = new System.Windows.Forms.TabControl();
            this.CertificateTabPage = new System.Windows.Forms.TabPage();
            this.DownloadCAGroup = new System.Windows.Forms.GroupBox();
            this.DownloadServerIPComboBox = new System.Windows.Forms.ComboBox();
            this.DownloadServerIPLabel = new System.Windows.Forms.Label();
            this.DownLoadQRCodeBtn = new System.Windows.Forms.Button();
            this.CACertExportLabel = new System.Windows.Forms.Label();
            this.FileExportBtn = new System.Windows.Forms.Button();
            this.ReGenerateCACertBtn = new System.Windows.Forms.Button();
            this.ReGenerateCACertLabel = new System.Windows.Forms.Label();
            this.saveCACertFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.OBSTabPage.SuspendLayout();
            this.GestureTabPage.SuspendLayout();
            this.GestureSettingBox.SuspendLayout();
            this.ShortcutsTabPage.SuspendLayout();
            this.GeneralTabPage.SuspendLayout();
            this.SettingTab.SuspendLayout();
            this.CertificateTabPage.SuspendLayout();
            this.DownloadCAGroup.SuspendLayout();
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
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // ApplyBtn
            // 
            this.ApplyBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ApplyBtn.Location = new System.Drawing.Point(433, 372);
            this.ApplyBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ApplyBtn.Name = "ApplyBtn";
            this.ApplyBtn.Size = new System.Drawing.Size(84, 29);
            this.ApplyBtn.TabIndex = 2;
            this.ApplyBtn.Text = "適用";
            this.ApplyBtn.UseVisualStyleBackColor = false;
            this.ApplyBtn.Click += new System.EventHandler(this.ApplyBtn_Click);
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
            this.ShortcutsTabPage.Controls.Add(this.SelectedShortCutListview);
            this.ShortcutsTabPage.Controls.Add(this.ShortcutsListBox);
            this.ShortcutsTabPage.Controls.Add(this.EditShortcutBtn);
            this.ShortcutsTabPage.Controls.Add(this.orderUpBtn);
            this.ShortcutsTabPage.Controls.Add(this.orderDown);
            this.ShortcutsTabPage.Controls.Add(this.AddShortcutBtn);
            this.ShortcutsTabPage.Controls.Add(this.RemoveFromEnableListBtn);
            this.ShortcutsTabPage.Controls.Add(this.AddToEnableBtn);
            this.ShortcutsTabPage.Location = new System.Drawing.Point(4, 25);
            this.ShortcutsTabPage.Margin = new System.Windows.Forms.Padding(4);
            this.ShortcutsTabPage.Name = "ShortcutsTabPage";
            this.ShortcutsTabPage.Padding = new System.Windows.Forms.Padding(4);
            this.ShortcutsTabPage.Size = new System.Drawing.Size(619, 313);
            this.ShortcutsTabPage.TabIndex = 1;
            this.ShortcutsTabPage.Text = "ショートカット";
            this.ShortcutsTabPage.UseVisualStyleBackColor = true;
            // 
            // SelectedShortCutListview
            // 
            this.SelectedShortCutListview.FormattingEnabled = true;
            this.SelectedShortCutListview.IntegralHeight = false;
            this.SelectedShortCutListview.ItemHeight = 15;
            this.SelectedShortCutListview.Location = new System.Drawing.Point(352, 39);
            this.SelectedShortCutListview.Name = "SelectedShortCutListview";
            this.SelectedShortCutListview.Size = new System.Drawing.Size(255, 224);
            this.SelectedShortCutListview.TabIndex = 9;
            // 
            // ShortcutsListBox
            // 
            this.ShortcutsListBox.FormattingEnabled = true;
            this.ShortcutsListBox.ItemHeight = 15;
            this.ShortcutsListBox.Location = new System.Drawing.Point(25, 39);
            this.ShortcutsListBox.Margin = new System.Windows.Forms.Padding(4);
            this.ShortcutsListBox.Name = "ShortcutsListBox";
            this.ShortcutsListBox.Size = new System.Drawing.Size(235, 214);
            this.ShortcutsListBox.TabIndex = 8;
            // 
            // EditShortcutBtn
            // 
            this.EditShortcutBtn.Location = new System.Drawing.Point(23, 271);
            this.EditShortcutBtn.Margin = new System.Windows.Forms.Padding(4);
            this.EditShortcutBtn.Name = "EditShortcutBtn";
            this.EditShortcutBtn.Size = new System.Drawing.Size(100, 29);
            this.EditShortcutBtn.TabIndex = 7;
            this.EditShortcutBtn.Text = "編集";
            this.EditShortcutBtn.UseVisualStyleBackColor = true;
            this.EditShortcutBtn.Click += new System.EventHandler(this.EditShortcutBtn_Click);
            // 
            // orderUpBtn
            // 
            this.orderUpBtn.Location = new System.Drawing.Point(389, 272);
            this.orderUpBtn.Margin = new System.Windows.Forms.Padding(4);
            this.orderUpBtn.Name = "orderUpBtn";
            this.orderUpBtn.Size = new System.Drawing.Size(68, 29);
            this.orderUpBtn.TabIndex = 6;
            this.orderUpBtn.Tag = "";
            this.orderUpBtn.Text = "↓";
            this.orderUpBtn.UseVisualStyleBackColor = true;
            // 
            // orderDown
            // 
            this.orderDown.Location = new System.Drawing.Point(517, 272);
            this.orderDown.Margin = new System.Windows.Forms.Padding(4);
            this.orderDown.Name = "orderDown";
            this.orderDown.Size = new System.Drawing.Size(68, 29);
            this.orderDown.TabIndex = 5;
            this.orderDown.Text = "↑";
            this.orderDown.UseVisualStyleBackColor = true;
            // 
            // AddShortcutBtn
            // 
            this.AddShortcutBtn.Location = new System.Drawing.Point(163, 271);
            this.AddShortcutBtn.Margin = new System.Windows.Forms.Padding(4);
            this.AddShortcutBtn.Name = "AddShortcutBtn";
            this.AddShortcutBtn.Size = new System.Drawing.Size(100, 29);
            this.AddShortcutBtn.TabIndex = 4;
            this.AddShortcutBtn.Text = "追加";
            this.AddShortcutBtn.UseVisualStyleBackColor = true;
            this.AddShortcutBtn.Click += new System.EventHandler(this.AddShortcutBtn_Click);
            // 
            // RemoveFromEnableListBtn
            // 
            this.RemoveFromEnableListBtn.Location = new System.Drawing.Point(271, 185);
            this.RemoveFromEnableListBtn.Margin = new System.Windows.Forms.Padding(4);
            this.RemoveFromEnableListBtn.Name = "RemoveFromEnableListBtn";
            this.RemoveFromEnableListBtn.Size = new System.Drawing.Size(72, 29);
            this.RemoveFromEnableListBtn.TabIndex = 3;
            this.RemoveFromEnableListBtn.Text = "←";
            this.RemoveFromEnableListBtn.UseVisualStyleBackColor = true;
            // 
            // AddToEnableBtn
            // 
            this.AddToEnableBtn.Location = new System.Drawing.Point(271, 90);
            this.AddToEnableBtn.Margin = new System.Windows.Forms.Padding(4);
            this.AddToEnableBtn.Name = "AddToEnableBtn";
            this.AddToEnableBtn.Size = new System.Drawing.Size(73, 29);
            this.AddToEnableBtn.TabIndex = 2;
            this.AddToEnableBtn.Text = "→";
            this.AddToEnableBtn.UseVisualStyleBackColor = true;
            // 
            // GeneralTabPage
            // 
            this.GeneralTabPage.Controls.Add(this.ServerIpAdressLabel);
            this.GeneralTabPage.Controls.Add(this.ServerIpAddressComboBox);
            this.GeneralTabPage.Controls.Add(this.DisableProcessAddButton);
            this.GeneralTabPage.Controls.Add(this.DisableProcessListBox);
            this.GeneralTabPage.Controls.Add(this.DisableProcessLabel);
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
            // ServerIpAdressLabel
            // 
            this.ServerIpAdressLabel.AutoSize = true;
            this.ServerIpAdressLabel.Location = new System.Drawing.Point(41, 66);
            this.ServerIpAdressLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ServerIpAdressLabel.Name = "ServerIpAdressLabel";
            this.ServerIpAdressLabel.Size = new System.Drawing.Size(125, 15);
            this.ServerIpAdressLabel.TabIndex = 6;
            this.ServerIpAdressLabel.Text = "サーバーのIPアドレス";
            // 
            // ServerIpAddressComboBox
            // 
            this.ServerIpAddressComboBox.FormattingEnabled = true;
            this.ServerIpAddressComboBox.Location = new System.Drawing.Point(259, 62);
            this.ServerIpAddressComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.ServerIpAddressComboBox.Name = "ServerIpAddressComboBox";
            this.ServerIpAddressComboBox.Size = new System.Drawing.Size(309, 23);
            this.ServerIpAddressComboBox.TabIndex = 5;
            // 
            // DisableProcessAddButton
            // 
            this.DisableProcessAddButton.Location = new System.Drawing.Point(488, 272);
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
            this.DisableProcessListBox.Location = new System.Drawing.Point(44, 149);
            this.DisableProcessListBox.Margin = new System.Windows.Forms.Padding(4);
            this.DisableProcessListBox.Name = "DisableProcessListBox";
            this.DisableProcessListBox.Size = new System.Drawing.Size(524, 109);
            this.DisableProcessListBox.TabIndex = 3;
            // 
            // DisableProcessLabel
            // 
            this.DisableProcessLabel.AutoSize = true;
            this.DisableProcessLabel.Location = new System.Drawing.Point(41, 110);
            this.DisableProcessLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DisableProcessLabel.Name = "DisableProcessLabel";
            this.DisableProcessLabel.Size = new System.Drawing.Size(384, 15);
            this.DisableProcessLabel.TabIndex = 2;
            this.DisableProcessLabel.Text = "プロセスの無効化(Webアプリ及びハードウェアには表示されません)";
            // 
            // StartupCheckBox
            // 
            this.StartupCheckBox.AutoSize = true;
            this.StartupCheckBox.Location = new System.Drawing.Point(44, 22);
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
            this.SettingTab.Controls.Add(this.CertificateTabPage);
            this.SettingTab.Location = new System.Drawing.Point(16, 22);
            this.SettingTab.Margin = new System.Windows.Forms.Padding(4);
            this.SettingTab.Name = "SettingTab";
            this.SettingTab.SelectedIndex = 0;
            this.SettingTab.Size = new System.Drawing.Size(627, 342);
            this.SettingTab.TabIndex = 1;
            // 
            // CertificateTabPage
            // 
            this.CertificateTabPage.Controls.Add(this.DownloadCAGroup);
            this.CertificateTabPage.Controls.Add(this.CACertExportLabel);
            this.CertificateTabPage.Controls.Add(this.FileExportBtn);
            this.CertificateTabPage.Controls.Add(this.ReGenerateCACertBtn);
            this.CertificateTabPage.Controls.Add(this.ReGenerateCACertLabel);
            this.CertificateTabPage.Location = new System.Drawing.Point(4, 25);
            this.CertificateTabPage.Margin = new System.Windows.Forms.Padding(4);
            this.CertificateTabPage.Name = "CertificateTabPage";
            this.CertificateTabPage.Size = new System.Drawing.Size(619, 313);
            this.CertificateTabPage.TabIndex = 4;
            this.CertificateTabPage.Text = "証明書";
            this.CertificateTabPage.UseVisualStyleBackColor = true;
            // 
            // DownloadCAGroup
            // 
            this.DownloadCAGroup.Controls.Add(this.DownloadServerIPComboBox);
            this.DownloadCAGroup.Controls.Add(this.DownloadServerIPLabel);
            this.DownloadCAGroup.Controls.Add(this.DownLoadQRCodeBtn);
            this.DownloadCAGroup.Location = new System.Drawing.Point(36, 146);
            this.DownloadCAGroup.Margin = new System.Windows.Forms.Padding(4);
            this.DownloadCAGroup.Name = "DownloadCAGroup";
            this.DownloadCAGroup.Padding = new System.Windows.Forms.Padding(4);
            this.DownloadCAGroup.Size = new System.Drawing.Size(548, 111);
            this.DownloadCAGroup.TabIndex = 9;
            this.DownloadCAGroup.TabStop = false;
            this.DownloadCAGroup.Text = "他の端末へ転送する";
            // 
            // DownloadServerIPComboBox
            // 
            this.DownloadServerIPComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DownloadServerIPComboBox.FormattingEnabled = true;
            this.DownloadServerIPComboBox.Location = new System.Drawing.Point(357, 32);
            this.DownloadServerIPComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.DownloadServerIPComboBox.Name = "DownloadServerIPComboBox";
            this.DownloadServerIPComboBox.Size = new System.Drawing.Size(160, 23);
            this.DownloadServerIPComboBox.TabIndex = 8;
            // 
            // DownloadServerIPLabel
            // 
            this.DownloadServerIPLabel.AutoSize = true;
            this.DownloadServerIPLabel.Location = new System.Drawing.Point(159, 36);
            this.DownloadServerIPLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DownloadServerIPLabel.Name = "DownloadServerIPLabel";
            this.DownloadServerIPLabel.Size = new System.Drawing.Size(150, 15);
            this.DownloadServerIPLabel.TabIndex = 7;
            this.DownloadServerIPLabel.Text = "表示するQRのIPアドレス";
            // 
            // DownLoadQRCodeBtn
            // 
            this.DownLoadQRCodeBtn.Location = new System.Drawing.Point(421, 75);
            this.DownLoadQRCodeBtn.Margin = new System.Windows.Forms.Padding(4);
            this.DownLoadQRCodeBtn.Name = "DownLoadQRCodeBtn";
            this.DownLoadQRCodeBtn.Size = new System.Drawing.Size(97, 29);
            this.DownLoadQRCodeBtn.TabIndex = 6;
            this.DownLoadQRCodeBtn.Text = "開始";
            this.DownLoadQRCodeBtn.UseVisualStyleBackColor = true;
            this.DownLoadQRCodeBtn.Click += new System.EventHandler(this.DownLoadQRCodeBtn_Click);
            // 
            // CACertExportLabel
            // 
            this.CACertExportLabel.AutoSize = true;
            this.CACertExportLabel.Location = new System.Drawing.Point(33, 90);
            this.CACertExportLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CACertExportLabel.Name = "CACertExportLabel";
            this.CACertExportLabel.Size = new System.Drawing.Size(173, 15);
            this.CACertExportLabel.TabIndex = 7;
            this.CACertExportLabel.Text = "CA証明書をエクスポートする";
            // 
            // FileExportBtn
            // 
            this.FileExportBtn.Location = new System.Drawing.Point(457, 84);
            this.FileExportBtn.Margin = new System.Windows.Forms.Padding(4);
            this.FileExportBtn.Name = "FileExportBtn";
            this.FileExportBtn.Size = new System.Drawing.Size(127, 29);
            this.FileExportBtn.TabIndex = 5;
            this.FileExportBtn.Text = "エクスポート";
            this.FileExportBtn.UseVisualStyleBackColor = true;
            this.FileExportBtn.Click += new System.EventHandler(this.FileExportBtn_Click);
            // 
            // ReGenerateCACertBtn
            // 
            this.ReGenerateCACertBtn.Location = new System.Drawing.Point(487, 26);
            this.ReGenerateCACertBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ReGenerateCACertBtn.Name = "ReGenerateCACertBtn";
            this.ReGenerateCACertBtn.Size = new System.Drawing.Size(100, 29);
            this.ReGenerateCACertBtn.TabIndex = 3;
            this.ReGenerateCACertBtn.Text = "再作成";
            this.ReGenerateCACertBtn.UseVisualStyleBackColor = true;
            this.ReGenerateCACertBtn.Click += new System.EventHandler(this.ReGenerateCACertBtn_Click);
            // 
            // ReGenerateCACertLabel
            // 
            this.ReGenerateCACertLabel.AutoSize = true;
            this.ReGenerateCACertLabel.Location = new System.Drawing.Point(33, 32);
            this.ReGenerateCACertLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ReGenerateCACertLabel.Name = "ReGenerateCACertLabel";
            this.ReGenerateCACertLabel.Size = new System.Drawing.Size(299, 15);
            this.ReGenerateCACertLabel.TabIndex = 1;
            this.ReGenerateCACertLabel.Text = "CA証明書の再作成(この操作はもとに戻せません)";
            // 
            // SettingWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 416);
            this.Controls.Add(this.ApplyBtn);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SettingTab);
            this.Margin = new System.Windows.Forms.Padding(4);
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
            this.GeneralTabPage.ResumeLayout(false);
            this.GeneralTabPage.PerformLayout();
            this.SettingTab.ResumeLayout(false);
            this.CertificateTabPage.ResumeLayout(false);
            this.CertificateTabPage.PerformLayout();
            this.DownloadCAGroup.ResumeLayout(false);
            this.DownloadCAGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.ListBox ShortcutsListBox;

        #endregion
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button ApplyBtn;
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
        private System.Windows.Forms.TabPage GeneralTabPage;
        private System.Windows.Forms.Button DisableProcessAddButton;
        private System.Windows.Forms.ListBox DisableProcessListBox;
        private System.Windows.Forms.Label DisableProcessLabel;
        private System.Windows.Forms.CheckBox StartupCheckBox;
        private System.Windows.Forms.TabControl SettingTab;
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
        private System.Windows.Forms.Button orderUpBtn;
        private System.Windows.Forms.Button orderDown;
        private System.Windows.Forms.Button AddShortcutBtn;
        private System.Windows.Forms.Button RemoveFromEnableListBtn;
        private System.Windows.Forms.Button AddToEnableBtn;
        private System.Windows.Forms.Button EditShortcutBtn;
        private System.Windows.Forms.ListBox SelectedShortCutListview;
    }
}