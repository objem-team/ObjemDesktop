
namespace ObjemDesktop.window
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.QRCodeBox = new System.Windows.Forms.PictureBox();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.OpenSettingsBtn = new System.Windows.Forms.Button();
            this.status = new System.Windows.Forms.Label();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.Label();
            this.DoubleClickToolTip = new System.Windows.Forms.ToolTip(this.components);
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
            this.StatusLabel.Location = new System.Drawing.Point(17, 380);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(48, 12);
            this.StatusLabel.TabIndex = 1;
            this.StatusLabel.Text = "Status : ";
            // 
            // OpenSettingsBtn
            // 
            this.OpenSettingsBtn.Location = new System.Drawing.Point(97, 409);
            this.OpenSettingsBtn.Name = "OpenSettingsBtn";
            this.OpenSettingsBtn.Size = new System.Drawing.Size(124, 23);
            this.OpenSettingsBtn.TabIndex = 2;
            this.OpenSettingsBtn.Text = "Open Settings";
            this.OpenSettingsBtn.UseVisualStyleBackColor = true;
            this.OpenSettingsBtn.Click += new System.EventHandler(this.OpenSettingsBtn_Click);
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Location = new System.Drawing.Point(72, 380);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(37, 12);
            this.status.TabIndex = 4;
            this.status.Text = "status";
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Location = new System.Drawing.Point(95, 339);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(45, 12);
            this.AddressLabel.TabIndex = 5;
            this.AddressLabel.Text = "address";
            this.DoubleClickToolTip.SetToolTip(this.AddressLabel, "\r\n\r\n");
            // 
            // address
            // 
            this.address.AutoSize = true;
            this.address.Location = new System.Drawing.Point(19, 339);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(64, 12);
            this.address.TabIndex = 6;
            this.address.Text = "ip address :";
            // 
            // DoubleClickToolTip
            // 
            this.DoubleClickToolTip.ToolTipTitle = "ダブルクリックでコピーできます";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 461);
            this.Controls.Add(this.address);
            this.Controls.Add(this.AddressLabel);
            this.Controls.Add(this.status);
            this.Controls.Add(this.OpenSettingsBtn);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.QRCodeBox);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(340, 500);
            this.MinimumSize = new System.Drawing.Size(340, 500);
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
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.Label address;
        private System.Windows.Forms.ToolTip DoubleClickToolTip;
    }
}

