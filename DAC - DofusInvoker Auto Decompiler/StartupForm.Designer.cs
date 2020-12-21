namespace DAC___DofusInvoker_Auto_Decompiler
{
    partial class StartupForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.progress_detectDependancies = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.link_DACGit = new System.Windows.Forms.LinkLabel();
            this.bg_detectDependancies = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(83, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(634, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "DAC - DofusInvoker Auto Decompiler";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(719, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Veuillez patienter pendant la détection des dépendances requises";
            // 
            // progress_detectDependancies
            // 
            this.progress_detectDependancies.Location = new System.Drawing.Point(12, 136);
            this.progress_detectDependancies.Name = "progress_detectDependancies";
            this.progress_detectDependancies.Size = new System.Drawing.Size(776, 23);
            this.progress_detectDependancies.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(260, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Dampen59#4187 - 2020 - ";
            // 
            // link_DACGit
            // 
            this.link_DACGit.AutoSize = true;
            this.link_DACGit.Location = new System.Drawing.Point(386, 170);
            this.link_DACGit.Name = "link_DACGit";
            this.link_DACGit.Size = new System.Drawing.Size(152, 13);
            this.link_DACGit.TabIndex = 4;
            this.link_DACGit.TabStop = true;
            this.link_DACGit.Text = "DofusInvoker Auto Decompiler";
            this.link_DACGit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_DACGit_LinkClicked);
            // 
            // bg_detectDependancies
            // 
            this.bg_detectDependancies.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bg_detectDependancies_DoWork);
            // 
            // StartupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 190);
            this.Controls.Add(this.link_DACGit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.progress_detectDependancies);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StartupForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StartupForm";
            this.Load += new System.EventHandler(this.StartupForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel link_DACGit;
        private System.ComponentModel.BackgroundWorker bg_detectDependancies;
        private System.Windows.Forms.ProgressBar progress_detectDependancies;
    }
}