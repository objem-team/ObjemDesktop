﻿
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
            this.KeyBoardShortcutRadioBtn = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ShortcutNameLabel = new System.Windows.Forms.Label();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.ShortcutGroupBox.SuspendLayout();
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
            this.ShortcutGroupBox.Controls.Add(this.KeyBoardShortcutRadioBtn);
            this.ShortcutGroupBox.Location = new System.Drawing.Point(12, 40);
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
            // KeyBoardShortcutRadioBtn
            // 
            this.KeyBoardShortcutRadioBtn.AutoSize = true;
            this.KeyBoardShortcutRadioBtn.Location = new System.Drawing.Point(16, 23);
            this.KeyBoardShortcutRadioBtn.Name = "KeyBoardShortcutRadioBtn";
            this.KeyBoardShortcutRadioBtn.Size = new System.Drawing.Size(130, 16);
            this.KeyBoardShortcutRadioBtn.TabIndex = 0;
            this.KeyBoardShortcutRadioBtn.TabStop = true;
            this.KeyBoardShortcutRadioBtn.Text = "キーボードショートカット";
            this.KeyBoardShortcutRadioBtn.UseVisualStyleBackColor = true;
            this.KeyBoardShortcutRadioBtn.CheckedChanged += new System.EventHandler(this.KeyBoardShortcutRadioBtn_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(125, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(276, 19);
            this.textBox1.TabIndex = 1;
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
            this.SaveBtn.Location = new System.Drawing.Point(235, 268);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(75, 23);
            this.SaveBtn.TabIndex = 3;
            this.SaveBtn.Text = "保存";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(336, 268);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn.TabIndex = 4;
            this.CancelBtn.Text = "キャンセル";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // AddShortcut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 303);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.ShortcutNameLabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ShortcutGroupBox);
            this.Name = "AddShortcut";
            this.Text = "AddShortcutDialog";
            this.ShortcutGroupBox.ResumeLayout(false);
            this.ShortcutGroupBox.PerformLayout();
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
        private System.Windows.Forms.RadioButton KeyBoardShortcutRadioBtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label ShortcutNameLabel;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button CancelBtn;
    }
}