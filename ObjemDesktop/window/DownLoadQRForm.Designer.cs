
namespace ObjemDesktop.window
{
    partial class DownLoadQRForm
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
            this.DownloadQR = new System.Windows.Forms.PictureBox();
            this.DownloadLinkLabel = new System.Windows.Forms.LinkLabel();
            this.CloseBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DownloadQR)).BeginInit();
            this.SuspendLayout();
            // 
            // DownloadQR
            // 
            this.DownloadQR.Location = new System.Drawing.Point(12, 12);
            this.DownloadQR.Name = "DownloadQR";
            this.DownloadQR.Size = new System.Drawing.Size(300, 300);
            this.DownloadQR.TabIndex = 0;
            this.DownloadQR.TabStop = false;
            // 
            // DownloadLinkLabel
            // 
            this.DownloadLinkLabel.AutoSize = true;
            this.DownloadLinkLabel.Location = new System.Drawing.Point(12, 334);
            this.DownloadLinkLabel.Name = "DownloadLinkLabel";
            this.DownloadLinkLabel.Size = new System.Drawing.Size(56, 12);
            this.DownloadLinkLabel.TabIndex = 1;
            this.DownloadLinkLabel.TabStop = true;
            this.DownloadLinkLabel.Text = "linkLabel1";
            this.DownloadLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.DownloadLinkLabel_LinkClicked);
            // 
            // CloseBtn
            // 
            this.CloseBtn.Location = new System.Drawing.Point(110, 357);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(75, 23);
            this.CloseBtn.TabIndex = 2;
            this.CloseBtn.Text = "閉じる";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // DownLoadQRForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 385);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.DownloadLinkLabel);
            this.Controls.Add(this.DownloadQR);
            this.Name = "DownLoadQRForm";
            this.Text = "DownLoadQRForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DownLoadQRForm_FormClosed);
            this.Load += new System.EventHandler(this.DownLoadQRForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DownloadQR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox DownloadQR;
        private System.Windows.Forms.LinkLabel DownloadLinkLabel;
        private System.Windows.Forms.Button CloseBtn;
    }
}