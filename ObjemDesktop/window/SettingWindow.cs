﻿using ObjemDesktop.window;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjemDesktop
{
    public partial class SettingWindow : Form
    {
        private bool RestartFlag = false;
        public SettingWindow()
        {
            InitializeComponent();
        }

        private void SettingWindow_Load(object sender, EventArgs e)
        {

        }

        private void ReGenerateCACertBtn_Click(object sender, EventArgs e)
        {
            var message = "CA証明書を再作成してもよろしいですか？\nアクセスする端末にCA証明書を再インストールする必要があります。\n Certsフォルダのファイルがすべて削除されます。\n※この操作はもとに戻せません。";
            if (MessageBox.Show(message,"再作成",MessageBoxButtons.OKCancel).Equals(DialogResult.OK))
            {
                DirectoryInfo info = new DirectoryInfo(@"certs\");
                info.EnumerateFiles().ToList().ForEach(f => f.Delete());
                Certificate.CertificateUtil.ExportAsPfx(Certificate.Certificate.CreateCACerttificate(), @"\certs\CAcert.pfx");
                MessageBox.Show("再作成が完了しました\n");
                RestartFlag = true;
            }
        }

        private List<string> getCertFilesip()
        {
            var files = Directory.GetFiles("certs\\", "*.*.*.*.pfx").ToList();
            var ipList = files.Select(f => Regex.Match(f, @"(([1-9]?[0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])\.){3}([1-9]?[0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])").ToString()).ToList();
            return ipList;
        }

        private void FileExportBtn_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(new ThreadStart(() => save()));
            t.SetApartmentState(ApartmentState.STA);
            t.Start();

        }
        private void save()
        {
            saveCACertFileDialog.FileName = "ObjemCAcert.crt";
            saveCACertFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            saveCACertFileDialog.Filter = "証明書(*.crt;*.cer)|*.crt;*.cer|すべてのファイル(*.*)|*.*";
            if (saveCACertFileDialog.ShowDialog().Equals(DialogResult.OK))
            {
                var cert = new X509Certificate2(@"certs\CAcert.pfx");
                var path = saveCACertFileDialog.FileName;
                Certificate.CertificateUtil.ExportAsPem(cert, path);
            }
                
        }

        private void DownLoadQRCodeBtn_Click(object sender, EventArgs e)
        {
            if (Program.IsAdministrator())
            {
                DownLoadQRForm form = new DownLoadQRForm();
                form.ShowDialog();
            }
            else
            {
                var message = "管理者権限で起動されていません、再起動しますか？";
                if (MessageBox.Show(message, "再起動", MessageBoxButtons.YesNo).Equals(DialogResult.Yes))
                {
                    // Restart and run as admin
                    var exeName = Process.GetCurrentProcess().MainModule.FileName;
                    ProcessStartInfo startInfo = new ProcessStartInfo(exeName);
                    startInfo.Verb = "runas";
                    startInfo.Arguments = "restart";
                    Process.Start(startInfo);
                    Application.Exit();
                }
                else
                {
                    //なにもしない
                }
            }

        }
        
    }
}
