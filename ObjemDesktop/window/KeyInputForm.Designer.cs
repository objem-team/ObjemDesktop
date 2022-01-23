using System.ComponentModel;

namespace ObjemDesktop.window
{
    partial class KeyInputForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.InputKeyLabel = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Button();
            this.AlertLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // InputKeyLabel
            // 
            this.InputKeyLabel.Location = new System.Drawing.Point(12, 31);
            this.InputKeyLabel.Name = "InputKeyLabel";
            this.InputKeyLabel.Size = new System.Drawing.Size(220, 44);
            this.InputKeyLabel.TabIndex = 0;
            this.InputKeyLabel.Text = "キーを入力してください";
            this.InputKeyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(81, 107);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(78, 20);
            this.CloseButton.TabIndex = 1;
            this.CloseButton.Text = "閉じる";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CloseButton_MouseClick);
            // 
            // AlertLabel
            // 
            this.AlertLabel.Location = new System.Drawing.Point(21, 85);
            this.AlertLabel.Name = "AlertLabel";
            this.AlertLabel.Size = new System.Drawing.Size(198, 19);
            this.AlertLabel.TabIndex = 2;
            this.AlertLabel.Text = "登録できるキーは5つまでです";
            this.AlertLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AlertLabel.Visible = false;
            // 
            // KeyInputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 139);
            this.Controls.Add(this.AlertLabel);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.InputKeyLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "KeyInputForm";
            this.Text = "KeyInputForm";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyInputForm_KeyUp);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label AlertLabel;

        private System.Windows.Forms.Button CloseButton;

        private System.Windows.Forms.Label InputKeyLabel;

        #endregion
    }
}