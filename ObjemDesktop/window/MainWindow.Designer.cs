﻿
namespace ObjemDesktop
{
    partial class MainWindow
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.QRCodeBox = new System.Windows.Forms.PictureBox();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.OpenSettingsBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.QRCodeBox)).BeginInit();
            this.SuspendLayout();
            // 
            // QRCodeBox
            // 
            this.QRCodeBox.Location = new System.Drawing.Point(12, 12);
            this.QRCodeBox.Name = "QRCodeBox";
            this.QRCodeBox.Size = new System.Drawing.Size(300, 300);
            this.QRCodeBox.TabIndex = 0;
            this.QRCodeBox.TabStop = false;
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Location = new System.Drawing.Point(17, 338);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(48, 12);
            this.StatusLabel.TabIndex = 1;
            this.StatusLabel.Text = "Status : ";
            // 
            // OpenSettingsBtn
            // 
            this.OpenSettingsBtn.Location = new System.Drawing.Point(86, 372);
            this.OpenSettingsBtn.Name = "OpenSettingsBtn";
            this.OpenSettingsBtn.Size = new System.Drawing.Size(124, 23);
            this.OpenSettingsBtn.TabIndex = 2;
            this.OpenSettingsBtn.Text = "Open Settings";
            this.OpenSettingsBtn.UseVisualStyleBackColor = true;
            this.OpenSettingsBtn.Click += new System.EventHandler(this.OpenSettingsBtn_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 401);
            this.Controls.Add(this.OpenSettingsBtn);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.QRCodeBox);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(340, 440);
            this.MinimumSize = new System.Drawing.Size(340, 440);
            this.Name = "MainWindow";
            this.Text = "Objem";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.QRCodeBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox QRCodeBox;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Button OpenSettingsBtn;
    }
}

