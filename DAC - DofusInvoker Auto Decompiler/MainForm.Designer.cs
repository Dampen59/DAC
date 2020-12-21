namespace DAC___DofusInvoker_Auto_Decompiler
{
    partial class MainForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_BrowseAnkamaLauncher = new System.Windows.Forms.Button();
            this.txt_AnkamaLauncherPath = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_BrowseSavePath = new System.Windows.Forms.Button();
            this.txt_SavePath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_BrowseJPEXS = new System.Windows.Forms.Button();
            this.txt_JPEXSPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_BrowseDofusInvoker = new System.Windows.Forms.Button();
            this.txt_DofusInvokerPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.folderBrowse_DofusInvoker = new System.Windows.Forms.FolderBrowserDialog();
            this.folderBrowse_JPEXS = new System.Windows.Forms.FolderBrowserDialog();
            this.btn_StartMonitor = new System.Windows.Forms.Button();
            this.folderBrowse_SavePath = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chk_UploadViaFTP = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_ftpPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_ftpUser = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_ftpHost = new System.Windows.Forms.TextBox();
            this.folderBrowse_AnkamaLauncher = new System.Windows.Forms.FolderBrowserDialog();
            this.timer_AnkamaLauncher = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_BrowseAnkamaLauncher);
            this.groupBox1.Controls.Add(this.txt_AnkamaLauncherPath);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btn_BrowseSavePath);
            this.groupBox1.Controls.Add(this.txt_SavePath);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btn_BrowseJPEXS);
            this.groupBox1.Controls.Add(this.txt_JPEXSPath);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btn_BrowseDofusInvoker);
            this.groupBox1.Controls.Add(this.txt_DofusInvokerPath);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(751, 200);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Setup";
            // 
            // btn_BrowseAnkamaLauncher
            // 
            this.btn_BrowseAnkamaLauncher.Location = new System.Drawing.Point(648, 167);
            this.btn_BrowseAnkamaLauncher.Name = "btn_BrowseAnkamaLauncher";
            this.btn_BrowseAnkamaLauncher.Size = new System.Drawing.Size(97, 20);
            this.btn_BrowseAnkamaLauncher.TabIndex = 11;
            this.btn_BrowseAnkamaLauncher.Text = "Browse";
            this.btn_BrowseAnkamaLauncher.UseVisualStyleBackColor = true;
            this.btn_BrowseAnkamaLauncher.Click += new System.EventHandler(this.btn_BrowseAnkamaLauncher_Click);
            // 
            // txt_AnkamaLauncherPath
            // 
            this.txt_AnkamaLauncherPath.Location = new System.Drawing.Point(9, 167);
            this.txt_AnkamaLauncherPath.Name = "txt_AnkamaLauncherPath";
            this.txt_AnkamaLauncherPath.ReadOnly = true;
            this.txt_AnkamaLauncherPath.Size = new System.Drawing.Size(633, 20);
            this.txt_AnkamaLauncherPath.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(174, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Path to Ankama Launcher directory";
            // 
            // btn_BrowseSavePath
            // 
            this.btn_BrowseSavePath.Location = new System.Drawing.Point(648, 119);
            this.btn_BrowseSavePath.Name = "btn_BrowseSavePath";
            this.btn_BrowseSavePath.Size = new System.Drawing.Size(97, 20);
            this.btn_BrowseSavePath.TabIndex = 8;
            this.btn_BrowseSavePath.Text = "Browse";
            this.btn_BrowseSavePath.UseVisualStyleBackColor = true;
            this.btn_BrowseSavePath.Click += new System.EventHandler(this.btn_BrowseSavePath_Click);
            // 
            // txt_SavePath
            // 
            this.txt_SavePath.Location = new System.Drawing.Point(9, 119);
            this.txt_SavePath.Name = "txt_SavePath";
            this.txt_SavePath.ReadOnly = true;
            this.txt_SavePath.Size = new System.Drawing.Size(633, 20);
            this.txt_SavePath.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Path to save decompiled files";
            // 
            // btn_BrowseJPEXS
            // 
            this.btn_BrowseJPEXS.Location = new System.Drawing.Point(648, 76);
            this.btn_BrowseJPEXS.Name = "btn_BrowseJPEXS";
            this.btn_BrowseJPEXS.Size = new System.Drawing.Size(97, 20);
            this.btn_BrowseJPEXS.TabIndex = 5;
            this.btn_BrowseJPEXS.Text = "Browse";
            this.btn_BrowseJPEXS.UseVisualStyleBackColor = true;
            this.btn_BrowseJPEXS.Click += new System.EventHandler(this.btn_BrowseJPEXS_Click);
            // 
            // txt_JPEXSPath
            // 
            this.txt_JPEXSPath.Location = new System.Drawing.Point(9, 76);
            this.txt_JPEXSPath.Name = "txt_JPEXSPath";
            this.txt_JPEXSPath.ReadOnly = true;
            this.txt_JPEXSPath.Size = new System.Drawing.Size(633, 20);
            this.txt_JPEXSPath.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Path to JPEXS directory";
            // 
            // btn_BrowseDofusInvoker
            // 
            this.btn_BrowseDofusInvoker.Location = new System.Drawing.Point(648, 33);
            this.btn_BrowseDofusInvoker.Name = "btn_BrowseDofusInvoker";
            this.btn_BrowseDofusInvoker.Size = new System.Drawing.Size(97, 20);
            this.btn_BrowseDofusInvoker.TabIndex = 2;
            this.btn_BrowseDofusInvoker.Text = "Browse";
            this.btn_BrowseDofusInvoker.UseVisualStyleBackColor = true;
            this.btn_BrowseDofusInvoker.Click += new System.EventHandler(this.btn_BrowseDofusInvoker_Click);
            // 
            // txt_DofusInvokerPath
            // 
            this.txt_DofusInvokerPath.Location = new System.Drawing.Point(9, 33);
            this.txt_DofusInvokerPath.Name = "txt_DofusInvokerPath";
            this.txt_DofusInvokerPath.ReadOnly = true;
            this.txt_DofusInvokerPath.Size = new System.Drawing.Size(633, 20);
            this.txt_DofusInvokerPath.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Path to DofusInvoker.swf directory";
            // 
            // folderBrowse_JPEXS
            // 
            this.folderBrowse_JPEXS.RootFolder = System.Environment.SpecialFolder.ProgramFilesX86;
            // 
            // btn_StartMonitor
            // 
            this.btn_StartMonitor.Location = new System.Drawing.Point(12, 443);
            this.btn_StartMonitor.Name = "btn_StartMonitor";
            this.btn_StartMonitor.Size = new System.Drawing.Size(751, 23);
            this.btn_StartMonitor.TabIndex = 1;
            this.btn_StartMonitor.Text = "Start";
            this.btn_StartMonitor.UseVisualStyleBackColor = true;
            this.btn_StartMonitor.Click += new System.EventHandler(this.btn_StartMonitor_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Location = new System.Drawing.Point(12, 232);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(745, 205);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "After-Decompilation settings";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chk_UploadViaFTP);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txt_ftpPassword);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txt_ftpUser);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txt_ftpHost);
            this.groupBox3.Location = new System.Drawing.Point(9, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 173);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            // 
            // chk_UploadViaFTP
            // 
            this.chk_UploadViaFTP.AutoSize = true;
            this.chk_UploadViaFTP.Location = new System.Drawing.Point(40, 14);
            this.chk_UploadViaFTP.Name = "chk_UploadViaFTP";
            this.chk_UploadViaFTP.Size = new System.Drawing.Size(121, 17);
            this.chk_UploadViaFTP.TabIndex = 4;
            this.chk_UploadViaFTP.Text = "Upload files via FTP";
            this.chk_UploadViaFTP.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(74, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Password";
            // 
            // txt_ftpPassword
            // 
            this.txt_ftpPassword.Location = new System.Drawing.Point(6, 146);
            this.txt_ftpPassword.Name = "txt_ftpPassword";
            this.txt_ftpPassword.Size = new System.Drawing.Size(188, 20);
            this.txt_ftpPassword.TabIndex = 6;
            this.txt_ftpPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_ftpPassword.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(73, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Username";
            // 
            // txt_ftpUser
            // 
            this.txt_ftpUser.Location = new System.Drawing.Point(6, 97);
            this.txt_ftpUser.Name = "txt_ftpUser";
            this.txt_ftpUser.Size = new System.Drawing.Size(188, 20);
            this.txt_ftpUser.TabIndex = 4;
            this.txt_ftpUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(82, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Host";
            // 
            // txt_ftpHost
            // 
            this.txt_ftpHost.Location = new System.Drawing.Point(6, 50);
            this.txt_ftpHost.Name = "txt_ftpHost";
            this.txt_ftpHost.Size = new System.Drawing.Size(188, 20);
            this.txt_ftpHost.TabIndex = 2;
            this.txt_ftpHost.Text = "ftp://127.0.0.1/";
            this.txt_ftpHost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timer_AnkamaLauncher
            // 
            this.timer_AnkamaLauncher.Interval = 30000;
            this.timer_AnkamaLauncher.Tick += new System.EventHandler(this.timer_AnkamaLauncher_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 474);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_StartMonitor);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DAC - DofusInvoker Auto Decompiler";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_BrowseJPEXS;
        private System.Windows.Forms.TextBox txt_JPEXSPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_BrowseDofusInvoker;
        private System.Windows.Forms.TextBox txt_DofusInvokerPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowse_DofusInvoker;
        private System.Windows.Forms.FolderBrowserDialog folderBrowse_JPEXS;
        private System.Windows.Forms.Button btn_StartMonitor;
        private System.Windows.Forms.Button btn_BrowseSavePath;
        private System.Windows.Forms.TextBox txt_SavePath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FolderBrowserDialog folderBrowse_SavePath;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_ftpPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_ftpUser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_ftpHost;
        private System.Windows.Forms.CheckBox chk_UploadViaFTP;
        private System.Windows.Forms.Button btn_BrowseAnkamaLauncher;
        private System.Windows.Forms.TextBox txt_AnkamaLauncherPath;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.FolderBrowserDialog folderBrowse_AnkamaLauncher;
        private System.Windows.Forms.Timer timer_AnkamaLauncher;
    }
}

