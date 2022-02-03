
namespace ObjemDesktop.window
{
    partial class AddShortcut
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
            this.ShortcutGroupBox = new System.Windows.Forms.GroupBox();
            this.addKeyBoardShortcut = new System.Windows.Forms.Button();
            this.KeyboardShortcutLabel = new System.Windows.Forms.Label();
            this.SelectAppShortcutBtn = new System.Windows.Forms.Button();
            this.LaunchAppPathTextBox = new System.Windows.Forms.TextBox();
            this.CommandTextBox = new System.Windows.Forms.TextBox();
            this.CommandShortcutRadioBtn = new System.Windows.Forms.RadioButton();
            this.LaunchAppShortcutRadioBtn = new System.Windows.Forms.RadioButton();
            this.KeyboardShortcutRadioBtn = new System.Windows.Forms.RadioButton();
            this.ShortcutNameInput = new System.Windows.Forms.TextBox();
            this.ShortcutNameLabel = new System.Windows.Forms.Label();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.SelectApplicationDialog = new System.Windows.Forms.OpenFileDialog();
            this.Iconlabel = new System.Windows.Forms.Label();
            this.IconButton = new System.Windows.Forms.Button();
            this.Icon = new System.Windows.Forms.PictureBox();
            this.ShortcutGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.Icon)).BeginInit();
            this.SuspendLayout();
            // 
            // ShortcutGroupBox
            // 
            this.ShortcutGroupBox.Controls.Add(this.addKeyBoardShortcut);
            this.ShortcutGroupBox.Controls.Add(this.KeyboardShortcutLabel);
            this.ShortcutGroupBox.Controls.Add(this.SelectAppShortcutBtn);
            this.ShortcutGroupBox.Controls.Add(this.LaunchAppPathTextBox);
            this.ShortcutGroupBox.Controls.Add(this.CommandTextBox);
            this.ShortcutGroupBox.Controls.Add(this.CommandShortcutRadioBtn);
            this.ShortcutGroupBox.Controls.Add(this.LaunchAppShortcutRadioBtn);
            this.ShortcutGroupBox.Controls.Add(this.KeyboardShortcutRadioBtn);
            this.ShortcutGroupBox.Location = new System.Drawing.Point(12, 86);
            this.ShortcutGroupBox.Name = "ShortcutGroupBox";
            this.ShortcutGroupBox.Size = new System.Drawing.Size(389, 216);
            this.ShortcutGroupBox.TabIndex = 0;
            this.ShortcutGroupBox.TabStop = false;
            // 
            // addKeyBoardShortcut
            // 
            this.addKeyBoardShortcut.Location = new System.Drawing.Point(308, 34);
            this.addKeyBoardShortcut.Name = "addKeyBoardShortcut";
            this.addKeyBoardShortcut.Size = new System.Drawing.Size(75, 23);
            this.addKeyBoardShortcut.TabIndex = 7;
            this.addKeyBoardShortcut.Text = "選択";
            this.addKeyBoardShortcut.UseVisualStyleBackColor = true;
            this.addKeyBoardShortcut.Click += new System.EventHandler(this.addKeyBoardShortcut_Click);
            // 
            // KeyboardShortcutLabel
            // 
            this.KeyboardShortcutLabel.AutoSize = true;
            this.KeyboardShortcutLabel.Location = new System.Drawing.Point(32, 46);
            this.KeyboardShortcutLabel.Name = "KeyboardShortcutLabel";
            this.KeyboardShortcutLabel.Size = new System.Drawing.Size(135, 12);
            this.KeyboardShortcutLabel.TabIndex = 6;
            this.KeyboardShortcutLabel.Text = "設定されたショートカットキー";
            // 
            // SelectAppShortcutBtn
            // 
            this.SelectAppShortcutBtn.Location = new System.Drawing.Point(308, 104);
            this.SelectAppShortcutBtn.Name = "SelectAppShortcutBtn";
            this.SelectAppShortcutBtn.Size = new System.Drawing.Size(75, 23);
            this.SelectAppShortcutBtn.TabIndex = 5;
            this.SelectAppShortcutBtn.Text = "選択";
            this.SelectAppShortcutBtn.UseVisualStyleBackColor = true;
            this.SelectAppShortcutBtn.Click += new System.EventHandler(this.SelectAppShortcutBtn_Click);
            // 
            // LaunchAppPathTextBox
            // 
            this.LaunchAppPathTextBox.Location = new System.Drawing.Point(34, 104);
            this.LaunchAppPathTextBox.Name = "LaunchAppPathTextBox";
            this.LaunchAppPathTextBox.Size = new System.Drawing.Size(244, 19);
            this.LaunchAppPathTextBox.TabIndex = 4;
            // 
            // CommandTextBox
            // 
            this.CommandTextBox.Location = new System.Drawing.Point(32, 172);
            this.CommandTextBox.Name = "CommandTextBox";
            this.CommandTextBox.Size = new System.Drawing.Size(327, 19);
            this.CommandTextBox.TabIndex = 3;
            // 
            // CommandShortcutRadioBtn
            // 
            this.CommandShortcutRadioBtn.AutoSize = true;
            this.CommandShortcutRadioBtn.Location = new System.Drawing.Point(16, 141);
            this.CommandShortcutRadioBtn.Name = "CommandShortcutRadioBtn";
            this.CommandShortcutRadioBtn.Size = new System.Drawing.Size(165, 16);
            this.CommandShortcutRadioBtn.TabIndex = 2;
            this.CommandShortcutRadioBtn.TabStop = true;
            this.CommandShortcutRadioBtn.Text = "コマンドショートカット(cmd.exe)";
            this.CommandShortcutRadioBtn.UseVisualStyleBackColor = true;
            this.CommandShortcutRadioBtn.CheckedChanged += new System.EventHandler(this.CommandShortcutRadioBtn_CheckedChanged);
            // 
            // LaunchAppShortcutRadioBtn
            // 
            this.LaunchAppShortcutRadioBtn.AutoSize = true;
            this.LaunchAppShortcutRadioBtn.Location = new System.Drawing.Point(16, 82);
            this.LaunchAppShortcutRadioBtn.Name = "LaunchAppShortcutRadioBtn";
            this.LaunchAppShortcutRadioBtn.Size = new System.Drawing.Size(130, 16);
            this.LaunchAppShortcutRadioBtn.TabIndex = 1;
            this.LaunchAppShortcutRadioBtn.TabStop = true;
            this.LaunchAppShortcutRadioBtn.Text = "アプリ起動ショートカット";
            this.LaunchAppShortcutRadioBtn.UseVisualStyleBackColor = true;
            this.LaunchAppShortcutRadioBtn.CheckedChanged += new System.EventHandler(this.LaunchAppShortcutRadioBtn_CheckedChanged);
            // 
            // KeyboardShortcutRadioBtn
            // 
            this.KeyboardShortcutRadioBtn.AutoSize = true;
            this.KeyboardShortcutRadioBtn.Location = new System.Drawing.Point(16, 23);
            this.KeyboardShortcutRadioBtn.Name = "KeyboardShortcutRadioBtn";
            this.KeyboardShortcutRadioBtn.Size = new System.Drawing.Size(130, 16);
            this.KeyboardShortcutRadioBtn.TabIndex = 0;
            this.KeyboardShortcutRadioBtn.TabStop = true;
            this.KeyboardShortcutRadioBtn.Text = "キーボードショートカット";
            this.KeyboardShortcutRadioBtn.UseVisualStyleBackColor = true;
            this.KeyboardShortcutRadioBtn.CheckedChanged += new System.EventHandler(this.KeyBoardShortcutRadioBtn_CheckedChanged);
            // 
            // ShortcutNameInput
            // 
            this.ShortcutNameInput.Location = new System.Drawing.Point(125, 15);
            this.ShortcutNameInput.Name = "ShortcutNameInput";
            this.ShortcutNameInput.Size = new System.Drawing.Size(276, 19);
            this.ShortcutNameInput.TabIndex = 1;
            // 
            // ShortcutNameLabel
            // 
            this.ShortcutNameLabel.AutoSize = true;
            this.ShortcutNameLabel.Location = new System.Drawing.Point(26, 18);
            this.ShortcutNameLabel.Name = "ShortcutNameLabel";
            this.ShortcutNameLabel.Size = new System.Drawing.Size(75, 12);
            this.ShortcutNameLabel.TabIndex = 2;
            this.ShortcutNameLabel.Text = "ショートカット名";
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(235, 314);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(75, 23);
            this.SaveBtn.TabIndex = 3;
            this.SaveBtn.Text = "保存";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(336, 314);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn.TabIndex = 4;
            this.CancelBtn.Text = "キャンセル";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // SelectApplicationDialog
            // 
            this.SelectApplicationDialog.FileName = "openFileDialog1";
            // 
            // Iconlabel
            // 
            this.Iconlabel.AutoSize = true;
            this.Iconlabel.Location = new System.Drawing.Point(26, 57);
            this.Iconlabel.Name = "Iconlabel";
            this.Iconlabel.Size = new System.Drawing.Size(40, 12);
            this.Iconlabel.TabIndex = 5;
            this.Iconlabel.Text = "アイコン";
            // 
            // IconButton
            // 
            this.IconButton.Location = new System.Drawing.Point(320, 52);
            this.IconButton.Name = "IconButton";
            this.IconButton.Size = new System.Drawing.Size(75, 23);
            this.IconButton.TabIndex = 6;
            this.IconButton.Text = "参照";
            this.IconButton.UseVisualStyleBackColor = true;
            this.IconButton.Click += new System.EventHandler(this.IconButton_Click);
            // 
            // Icon
            // 
            this.Icon.Location = new System.Drawing.Point(253, 40);
            this.Icon.Name = "Icon";
            this.Icon.Size = new System.Drawing.Size(48, 48);
            this.Icon.TabIndex = 7;
            this.Icon.TabStop = false;
            // 
            // AddShortcut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 344);
            this.Controls.Add(this.Icon);
            this.Controls.Add(this.IconButton);
            this.Controls.Add(this.Iconlabel);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.ShortcutNameLabel);
            this.Controls.Add(this.ShortcutNameInput);
            this.Controls.Add(this.ShortcutGroupBox);
            this.Name = "AddShortcut";
            this.Text = "AddShortcutDialog";
            this.ShortcutGroupBox.ResumeLayout(false);
            this.ShortcutGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.Icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.GroupBox ShortcutGroupBox;
        private System.Windows.Forms.Button addKeyBoardShortcut;
        private System.Windows.Forms.Label KeyboardShortcutLabel;
        private System.Windows.Forms.Button SelectAppShortcutBtn;
        private System.Windows.Forms.TextBox LaunchAppPathTextBox;
        private System.Windows.Forms.TextBox CommandTextBox;
        private System.Windows.Forms.RadioButton CommandShortcutRadioBtn;
        private System.Windows.Forms.RadioButton LaunchAppShortcutRadioBtn;
        private System.Windows.Forms.RadioButton KeyboardShortcutRadioBtn;
        private System.Windows.Forms.TextBox ShortcutNameInput;
        private System.Windows.Forms.Label ShortcutNameLabel;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.OpenFileDialog SelectApplicationDialog;
        private System.Windows.Forms.Label Iconlabel;
        private System.Windows.Forms.Button IconButton;
        private System.Windows.Forms.PictureBox Icon;
    }
}