using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAC___DofusInvoker_Auto_Decompiler.Properties; // Settings

namespace DAC___DofusInvoker_Auto_Decompiler
{
    public partial class StartupForm : Form
    {

        private MainForm _mainForm;

        public StartupForm()
        {
            InitializeComponent();
        }

        private void link_DACGit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/Dampen59/DAC");
        }

        private void StartupForm_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            bg_detectDependancies.RunWorkerAsync();
            bg_detectDependancies.RunWorkerCompleted += DetectFinish;
        }

        private void bg_detectDependancies_DoWork(object sender, DoWorkEventArgs e)
        {
            // Ankama Launcher detection
            string supposedAnkamaLauncherPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Programs\\zaap\\Ankama Launcher.exe";

            if (File.Exists(supposedAnkamaLauncherPath))
            {
                // The launcher is in it's default path
                Settings.Default.AnkamaLauncherPath = supposedAnkamaLauncherPath.Replace("\\Ankama Launcher.exe", "");
                Settings.Default.Save();
                progress_detectDependancies.Value += 33;
            } else
            {
                MessageBox.Show("Ankama Launcher est introuvable.", "Dépendance manquante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                bg_detectDependancies.CancelAsync();
                return;
            }

            // DofusInvoker.swf Detection
            string supposedDofusInvokerPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Ankama\\zaap\\dofus\\DofusInvoker.swf";

            if (File.Exists(supposedDofusInvokerPath))
            {
                // DofusInvoker is in it's default path
                Settings.Default.DofusInvokerPath = supposedDofusInvokerPath.Replace("\\DofusInvoker.swf", "");
                Settings.Default.Save();
                progress_detectDependancies.Value += 33;
            }
            else
            {
                MessageBox.Show("Dofus 2 introuvable.", "Dépendance manquante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                bg_detectDependancies.CancelAsync();
                return;
            }

            // JPEXS detection
            string supposedJPEXSPath = ProgramFilesx86() + "\\FFDec\\ffdec.exe";

            if (File.Exists(supposedJPEXSPath))
            {
                // JPEXS is in it's default path
                Settings.Default.JPEXSPath = supposedJPEXSPath.Replace("\\ffdec.exe", "");
                Settings.Default.Save();
                progress_detectDependancies.Value = progress_detectDependancies.Maximum;
            }
            else
            {
                MessageBox.Show("JPEXS introuvable.", "Dépendance manquante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                bg_detectDependancies.CancelAsync();
                return;
            }
            
        }

        private void DetectFinish(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled != true)
            {
                _mainForm = new MainForm();
                this.Hide();
                _mainForm.Show();
            }
        }

        static string ProgramFilesx86()
        {
            if (8 == IntPtr.Size
                || (!String.IsNullOrEmpty(Environment.GetEnvironmentVariable("PROCESSOR_ARCHITEW6432"))))
            {
                return Environment.GetEnvironmentVariable("ProgramFiles(x86)");
            }

            return Environment.GetEnvironmentVariable("ProgramFiles");
        }

    }
}
