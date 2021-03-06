
namespace ObjemDesktop.window
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
            this.components = new System.ComponentModel.Container();
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
            this.ShortcutsLabel = new System.Windows.Forms.Label();
            this.EnableShortcutsLabel = new System.Windows.Forms.Label();
            this.EnabledShortcutsListBox = new System.Windows.Forms.ListBox();
            this.ShortcutsListBox = new System.Windows.Forms.ListBox();
            this.ShortcutsListBoxContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.DeleteShortcutListBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.DisableProcessListBoxContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.DeleteDisableProcessMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DisableProcessLabel = new System.Windows.Forms.Label();
            this.StartupCheckBox = new System.Windows.Forms.CheckBox();
            this.SettingTab = new System.Windows.Forms.TabControl();
            this.StreamCommentUrlTab = new System.Windows.Forms.TabPage();
            this.TwitchStreamUrlTextBox = new System.Windows.Forms.TextBox();
            this.YoutubeStreamUrlTextBox = new System.Windows.Forms.TextBox();
            this.TwitchLabel = new System.Windows.Forms.Label();
            this.YouTubeLabel = new System.Windows.Forms.Label();
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
            this.SelectDisableApplicationDialog = new System.Windows.Forms.OpenFileDialog();
            this.OBSTabPage.SuspendLayout();
            this.GestureTabPage.SuspendLayout();
            this.GestureSettingBox.SuspendLayout();
            this.ShortcutsTabPage.SuspendLayout();
            this.ShortcutsListBoxContextMenu.SuspendLayout();
            this.GeneralTabPage.SuspendLayout();
            this.DisableProcessListBoxContextMenu.SuspendLayout();
            this.SettingTab.SuspendLayout();
            this.StreamCommentUrlTab.SuspendLayout();
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
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // ApplyBtn
            // 
            this.ApplyBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ApplyBtn.Location = new System.Drawing.Point(325, 298);
            this.ApplyBtn.Name = "ApplyBtn";
            this.ApplyBtn.Size = new System.Drawing.Size(63, 23);
            this.ApplyBtn.TabIndex = 2;
            this.ApplyBtn.Text = "適用";
            this.ApplyBtn.UseVisualStyleBackColor = false;
            this.ApplyBtn.Click += new System.EventHandler(this.ApplyBtn_Click);
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
            this.EnableGestureCheckBox.CheckedChanged += new System.EventHandler(this.EnableGestureCheckBox_CheckedChanged);
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
            this.ShortcutsTabPage.Controls.Add(this.ShortcutsLabel);
            this.ShortcutsTabPage.Controls.Add(this.EnableShortcutsLabel);
            this.ShortcutsTabPage.Controls.Add(this.EnabledShortcutsListBox);
            this.ShortcutsTabPage.Controls.Add(this.ShortcutsListBox);
            this.ShortcutsTabPage.Controls.Add(this.EditShortcutBtn);
            this.ShortcutsTabPage.Controls.Add(this.orderUpBtn);
            this.ShortcutsTabPage.Controls.Add(this.orderDown);
            this.ShortcutsTabPage.Controls.Add(this.AddShortcutBtn);
            this.ShortcutsTabPage.Controls.Add(this.RemoveFromEnableListBtn);
            this.ShortcutsTabPage.Controls.Add(this.AddToEnableBtn);
            this.ShortcutsTabPage.Location = new System.Drawing.Point(4, 22);
            this.ShortcutsTabPage.Name = "ShortcutsTabPage";
            this.ShortcutsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ShortcutsTabPage.Size = new System.Drawing.Size(462, 248);
            this.ShortcutsTabPage.TabIndex = 1;
            this.ShortcutsTabPage.Text = "ショートカット";
            this.ShortcutsTabPage.UseVisualStyleBackColor = true;
            // 
            // ShortcutsLabel
            // 
            this.ShortcutsLabel.Location = new System.Drawing.Point(19, 16);
            this.ShortcutsLabel.Name = "ShortcutsLabel";
            this.ShortcutsLabel.Size = new System.Drawing.Size(175, 14);
            this.ShortcutsLabel.TabIndex = 11;
            this.ShortcutsLabel.Text = "ショートカット一覧";
            // 
            // EnableShortcutsLabel
            // 
            this.EnableShortcutsLabel.Location = new System.Drawing.Point(277, 16);
            this.EnableShortcutsLabel.Name = "EnableShortcutsLabel";
            this.EnableShortcutsLabel.Size = new System.Drawing.Size(157, 12);
            this.EnableShortcutsLabel.TabIndex = 10;
            this.EnableShortcutsLabel.Text = "表示されるショートカット";
            // 
            // EnabledShortcutsListBox
            // 
            this.EnabledShortcutsListBox.FormattingEnabled = true;
            this.EnabledShortcutsListBox.ItemHeight = 12;
            this.EnabledShortcutsListBox.Location = new System.Drawing.Point(277, 31);
            this.EnabledShortcutsListBox.Name = "EnabledShortcutsListBox";
            this.EnabledShortcutsListBox.Size = new System.Drawing.Size(179, 172);
            this.EnabledShortcutsListBox.TabIndex = 9;
            // 
            // ShortcutsListBox
            // 
            this.ShortcutsListBox.ContextMenuStrip = this.ShortcutsListBoxContextMenu;
            this.ShortcutsListBox.FormattingEnabled = true;
            this.ShortcutsListBox.ItemHeight = 12;
            this.ShortcutsListBox.Location = new System.Drawing.Point(19, 31);
            this.ShortcutsListBox.Name = "ShortcutsListBox";
            this.ShortcutsListBox.Size = new System.Drawing.Size(177, 172);
            this.ShortcutsListBox.TabIndex = 8;
            // 
            // ShortcutsListBoxContextMenu
            // 
            this.ShortcutsListBoxContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DeleteShortcutListBoxToolStripMenuItem});
            this.ShortcutsListBoxContextMenu.Name = "ShortcutsListBoxContextMenu";
            this.ShortcutsListBoxContextMenu.Size = new System.Drawing.Size(99, 26);
            // 
            // DeleteShortcutListBoxToolStripMenuItem
            // 
            this.DeleteShortcutListBoxToolStripMenuItem.Name = "DeleteShortcutListBoxToolStripMenuItem";
            this.DeleteShortcutListBoxToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.DeleteShortcutListBoxToolStripMenuItem.Text = "削除";
            this.DeleteShortcutListBoxToolStripMenuItem.Click += new System.EventHandler(this.DeleteShortcutListBoxToolStripMenuItem_Click);
            // 
            // EditShortcutBtn
            // 
            this.EditShortcutBtn.Location = new System.Drawing.Point(17, 217);
            this.EditShortcutBtn.Name = "EditShortcutBtn";
            this.EditShortcutBtn.Size = new System.Drawing.Size(75, 23);
            this.EditShortcutBtn.TabIndex = 7;
            this.EditShortcutBtn.Text = "編集";
            this.EditShortcutBtn.UseVisualStyleBackColor = true;
            this.EditShortcutBtn.Click += new System.EventHandler(this.EditShortcutBtn_Click);
            // 
            // orderUpBtn
            // 
            this.orderUpBtn.Location = new System.Drawing.Point(388, 217);
            this.orderUpBtn.Name = "orderUpBtn";
            this.orderUpBtn.Size = new System.Drawing.Size(51, 23);
            this.orderUpBtn.TabIndex = 6;
            this.orderUpBtn.Tag = "";
            this.orderUpBtn.Text = "↑";
            this.orderUpBtn.UseVisualStyleBackColor = true;
            this.orderUpBtn.Click += new System.EventHandler(this.orderUpBtn_Click);
            // 
            // orderDown
            // 
            this.orderDown.Location = new System.Drawing.Point(309, 217);
            this.orderDown.Name = "orderDown";
            this.orderDown.Size = new System.Drawing.Size(51, 23);
            this.orderDown.TabIndex = 5;
            this.orderDown.Text = "↓";
            this.orderDown.UseVisualStyleBackColor = true;
            this.orderDown.Click += new System.EventHandler(this.orderDown_Click);
            // 
            // AddShortcutBtn
            // 
            this.AddShortcutBtn.Location = new System.Drawing.Point(122, 217);
            this.AddShortcutBtn.Name = "AddShortcutBtn";
            this.AddShortcutBtn.Size = new System.Drawing.Size(75, 23);
            this.AddShortcutBtn.TabIndex = 4;
            this.AddShortcutBtn.Text = "追加";
            this.AddShortcutBtn.UseVisualStyleBackColor = true;
            this.AddShortcutBtn.Click += new System.EventHandler(this.AddShortcutBtn_Click);
            // 
            // RemoveFromEnableListBtn
            // 
            this.RemoveFromEnableListBtn.Location = new System.Drawing.Point(203, 148);
            this.RemoveFromEnableListBtn.Name = "RemoveFromEnableListBtn";
            this.RemoveFromEnableListBtn.Size = new System.Drawing.Size(54, 23);
            this.RemoveFromEnableListBtn.TabIndex = 3;
            this.RemoveFromEnableListBtn.Text = "←";
            this.RemoveFromEnableListBtn.UseVisualStyleBackColor = true;
            this.RemoveFromEnableListBtn.Click += new System.EventHandler(this.RemoveFromEnableListBtn_Click);
            // 
            // AddToEnableBtn
            // 
            this.AddToEnableBtn.Location = new System.Drawing.Point(203, 72);
            this.AddToEnableBtn.Name = "AddToEnableBtn";
            this.AddToEnableBtn.Size = new System.Drawing.Size(55, 23);
            this.AddToEnableBtn.TabIndex = 2;
            this.AddToEnableBtn.Text = "→";
            this.AddToEnableBtn.UseVisualStyleBackColor = true;
            this.AddToEnableBtn.Click += new System.EventHandler(this.AddToEnableBtn_Click);
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
            this.DisableProcessAddButton.Click += new System.EventHandler(this.DisableProcessAddButton_Click);
            // 
            // DisableProcessListBox
            // 
            this.DisableProcessListBox.ContextMenuStrip = this.DisableProcessListBoxContextMenu;
            this.DisableProcessListBox.FormattingEnabled = true;
            this.DisableProcessListBox.ItemHeight = 12;
            this.DisableProcessListBox.Location = new System.Drawing.Point(33, 119);
            this.DisableProcessListBox.Name = "DisableProcessListBox";
            this.DisableProcessListBox.Size = new System.Drawing.Size(394, 88);
            this.DisableProcessListBox.TabIndex = 3;
            // 
            // DisableProcessListBoxContextMenu
            // 
            this.DisableProcessListBoxContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DeleteDisableProcessMenuItem});
            this.DisableProcessListBoxContextMenu.Name = "DisableProcessListBoxContextMenu";
            this.DisableProcessListBoxContextMenu.Size = new System.Drawing.Size(99, 26);
            // 
            // DeleteDisableProcessMenuItem
            // 
            this.DeleteDisableProcessMenuItem.Name = "DeleteDisableProcessMenuItem";
            this.DeleteDisableProcessMenuItem.Size = new System.Drawing.Size(98, 22);
            this.DeleteDisableProcessMenuItem.Text = "削除";
            this.DeleteDisableProcessMenuItem.Click += new System.EventHandler(this.DeleteDisableProcessMenuItem_Click);
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
            this.StartupCheckBox.Enabled = false;
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
            this.SettingTab.Controls.Add(this.StreamCommentUrlTab);
            this.SettingTab.Controls.Add(this.OBSTabPage);
            this.SettingTab.Controls.Add(this.CertificateTabPage);
            this.SettingTab.Location = new System.Drawing.Point(12, 18);
            this.SettingTab.Name = "SettingTab";
            this.SettingTab.SelectedIndex = 0;
            this.SettingTab.Size = new System.Drawing.Size(470, 274);
            this.SettingTab.TabIndex = 1;
            // 
            // StreamCommentUrlTab
            // 
            this.StreamCommentUrlTab.Controls.Add(this.TwitchStreamUrlTextBox);
            this.StreamCommentUrlTab.Controls.Add(this.YoutubeStreamUrlTextBox);
            this.StreamCommentUrlTab.Controls.Add(this.TwitchLabel);
            this.StreamCommentUrlTab.Controls.Add(this.YouTubeLabel);
            this.StreamCommentUrlTab.Location = new System.Drawing.Point(4, 22);
            this.StreamCommentUrlTab.Name = "StreamCommentUrlTab";
            this.StreamCommentUrlTab.Size = new System.Drawing.Size(462, 248);
            this.StreamCommentUrlTab.TabIndex = 5;
            this.StreamCommentUrlTab.Text = "配信コメントウィジェット";
            this.StreamCommentUrlTab.UseVisualStyleBackColor = true;
            // 
            // TwitchStreamUrlTextBox
            // 
            this.TwitchStreamUrlTextBox.Location = new System.Drawing.Point(101, 134);
            this.TwitchStreamUrlTextBox.Name = "TwitchStreamUrlTextBox";
            this.TwitchStreamUrlTextBox.Size = new System.Drawing.Size(343, 19);
            this.TwitchStreamUrlTextBox.TabIndex = 3;
            // 
            // YoutubeStreamUrlTextBox
            // 
            this.YoutubeStreamUrlTextBox.Location = new System.Drawing.Point(101, 54);
            this.YoutubeStreamUrlTextBox.Name = "YoutubeStreamUrlTextBox";
            this.YoutubeStreamUrlTextBox.Size = new System.Drawing.Size(343, 19);
            this.YoutubeStreamUrlTextBox.TabIndex = 2;
            // 
            // TwitchLabel
            // 
            this.TwitchLabel.Location = new System.Drawing.Point(19, 137);
            this.TwitchLabel.Name = "TwitchLabel";
            this.TwitchLabel.Size = new System.Drawing.Size(76, 14);
            this.TwitchLabel.TabIndex = 1;
            this.TwitchLabel.Text = "Twitch";
            // 
            // YouTubeLabel
            // 
            this.YouTubeLabel.Location = new System.Drawing.Point(19, 57);
            this.YouTubeLabel.Name = "YouTubeLabel";
            this.YouTubeLabel.Size = new System.Drawing.Size(64, 19);
            this.YouTubeLabel.TabIndex = 0;
            this.YouTubeLabel.Text = "Youtube";
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
            // DownloadServerIPComboBox
            // 
            this.DownloadServerIPComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DownloadServerIPComboBox.FormattingEnabled = true;
            this.DownloadServerIPComboBox.Location = new System.Drawing.Point(268, 26);
            this.DownloadServerIPComboBox.Name = "DownloadServerIPComboBox";
            this.DownloadServerIPComboBox.Size = new System.Drawing.Size(121, 20);
            this.DownloadServerIPComboBox.TabIndex = 8;
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
            // CACertExportLabel
            // 
            this.CACertExportLabel.AutoSize = true;
            this.CACertExportLabel.Location = new System.Drawing.Point(25, 72);
            this.CACertExportLabel.Name = "CACertExportLabel";
            this.CACertExportLabel.Size = new System.Drawing.Size(139, 12);
            this.CACertExportLabel.TabIndex = 7;
            this.CACertExportLabel.Text = "CA証明書をエクスポートする";
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
            // SettingWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 333);
            this.Controls.Add(this.ApplyBtn);
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
            this.ShortcutsListBoxContextMenu.ResumeLayout(false);
            this.GeneralTabPage.ResumeLayout(false);
            this.GeneralTabPage.PerformLayout();
            this.DisableProcessListBoxContextMenu.ResumeLayout(false);
            this.SettingTab.ResumeLayout(false);
            this.StreamCommentUrlTab.ResumeLayout(false);
            this.StreamCommentUrlTab.PerformLayout();
            this.CertificateTabPage.ResumeLayout(false);
            this.CertificateTabPage.PerformLayout();
            this.DownloadCAGroup.ResumeLayout(false);
            this.DownloadCAGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Label YouTubeLabel;
        private System.Windows.Forms.Label TwitchLabel;
        private System.Windows.Forms.TextBox YoutubeStreamUrlTextBox;
        private System.Windows.Forms.TextBox TwitchStreamUrlTextBox;

        private System.Windows.Forms.TabPage StreamCommentUrlTab;

        private System.Windows.Forms.Label EnableShortcutsLabel;
        private System.Windows.Forms.Label ShortcutsLabel;

        private System.Windows.Forms.ListBox EnabledShortcutsListBox;

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
        private System.Windows.Forms.OpenFileDialog SelectDisableApplicationDialog;
        private System.Windows.Forms.ContextMenuStrip ShortcutsListBoxContextMenu;
        private System.Windows.Forms.ToolStripMenuItem DeleteShortcutListBoxToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip DisableProcessListBoxContextMenu;
        private System.Windows.Forms.ToolStripMenuItem DeleteDisableProcessMenuItem;
    }
}