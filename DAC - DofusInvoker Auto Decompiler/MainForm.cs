using DAC___DofusInvoker_Auto_Decompiler.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAC___DofusInvoker_Auto_Decompiler
{
    public partial class MainForm : Form
    {

        DirectoryInfo _dirInfosMessages;
        DirectoryInfo _dirInfosTypes;
        SortedDictionary<int, string> messagesDictionnary = new SortedDictionary<int, string>();
        SortedDictionary<int, string> typesDictionnary = new SortedDictionary<int, string>();

        public MainForm()
        {
            InitializeComponent();

            // Load settings
            if (Settings.Default.DofusInvokerPath != String.Empty)
            {
                txt_DofusInvokerPath.Text = Settings.Default.DofusInvokerPath;
            }

            if (Settings.Default.JPEXSPath != String.Empty)
            {
                txt_JPEXSPath.Text = Settings.Default.JPEXSPath;
            }

            if (Settings.Default.SavePath != String.Empty)
            {
                txt_SavePath.Text = Settings.Default.SavePath;
            }

            if (Settings.Default.AnkamaLauncherPath != String.Empty)
            {
                txt_AnkamaLauncherPath.Text = Settings.Default.AnkamaLauncherPath;
            }
        }

        private void btn_BrowseDofusInvoker_Click(object sender, EventArgs e)
        {
            folderBrowse_DofusInvoker.ShowDialog();

            if (!File.Exists(folderBrowse_DofusInvoker.SelectedPath + @"\DofusInvoker.swf"))
            {
                MessageBox.Show("Impossible de trouver le fichier DofusInvoker.swf dans le répertoire sélectionné !");
                return;
            }
            else
            {
                txt_DofusInvokerPath.Text = folderBrowse_DofusInvoker.SelectedPath;
                Settings.Default.DofusInvokerPath = folderBrowse_DofusInvoker.SelectedPath;
                Settings.Default.Save();
            }
        }

        private void btn_BrowseJPEXS_Click(object sender, EventArgs e)
        {
            folderBrowse_JPEXS.ShowDialog();

            if (!File.Exists(folderBrowse_JPEXS.SelectedPath + @"\ffdec.exe"))
            {
                MessageBox.Show("Impossible de trouver le fichier ffdec.exe dans le répertoire sélectionné !");
                return;
            }
            else
            {
                txt_JPEXSPath.Text = folderBrowse_JPEXS.SelectedPath;
                Settings.Default.JPEXSPath = folderBrowse_JPEXS.SelectedPath;
                Settings.Default.Save();
            }
        }

        private void btn_BrowseAnkamaLauncher_Click(object sender, EventArgs e)
        {
            folderBrowse_AnkamaLauncher.ShowDialog();

            if (!File.Exists(folderBrowse_AnkamaLauncher.SelectedPath + @"\Ankama Launcher.exe"))
            {
                MessageBox.Show("Impossible de trouver le fichier 'Ankama Launcher.exe' dans le répertoire sélectionné !");
                return;
            }
            else
            {
                txt_AnkamaLauncherPath.Text = folderBrowse_AnkamaLauncher.SelectedPath;
                Settings.Default.AnkamaLauncherPath = folderBrowse_AnkamaLauncher.SelectedPath;
                Settings.Default.Save();
            }
        }

        private void MonitorDirectory(string path)
        {
            FileSystemWatcher fileSystemWatcher = new FileSystemWatcher();

            fileSystemWatcher.Path = path;

            fileSystemWatcher.Created += (sender, e) => FileSystemWatcher_Created(sender, e, this);

            fileSystemWatcher.EnableRaisingEvents = true;
        }

        private static void FileSystemWatcher_Created(object sender, FileSystemEventArgs e, MainForm prmMainForm)
        {
            if (e.FullPath.Contains("DofusInvoker.swf"))
            {
                prmMainForm.DecompileSaveDofusInvoker();
            }
        }

        private void btn_StartMonitor_Click(object sender, EventArgs e)
        {
            MonitorDirectory(Settings.Default.DofusInvokerPath);
            btn_StartMonitor.Text = "Monitoring activé !";
            btn_StartMonitor.Enabled = false;

            // On démarre le launcher si il n'est pas lancé ainsi que son timer associé
            CheckAnkamaLauncherState();
            timer_AnkamaLauncher.Start();
        }

        private void DecompileSaveDofusInvoker()
        {
            // Récupération du numéro de version
            StreamReader readerVersion = new StreamReader($"{Settings.Default.DofusInvokerPath}/VERSION");
            String dofusInvokerVersion = readerVersion.ReadToEnd().Replace("\n", "");
            readerVersion.Close();

            String timeStamp = GetTimestamp(DateTime.Now);
            String savePath = $"{Settings.Default.SavePath}/{timeStamp}-{dofusInvokerVersion}";

            Process process = new Process
            {
                StartInfo =
                {
                    UseShellExecute = true,
                    RedirectStandardOutput = false,
                    RedirectStandardError = false,
                    CreateNoWindow = false,
                    FileName = "cmd.exe",
                    Arguments = $"/C java -jar \"{Settings.Default.JPEXSPath}/ffdec.jar\" -selectclass com.ankamagames.dofus.network.** -export script \"{savePath}\" {Settings.Default.DofusInvokerPath}/DofusInvoker.swf"
                }
            };

            process.Start();
            process.WaitForExit();

            // Sauvegarde du DofusInvoker
            File.Copy(Settings.Default.DofusInvokerPath + @"\DofusInvoker.swf", $"{savePath}\\DofusInvoker.swf");

            // Sauvegarde du fichier VERSION
            File.Copy(Settings.Default.DofusInvokerPath + @"\VERSION", $"{savePath}\\VERSION");

            // Génération de la liste des identifiants des Messages
            _dirInfosMessages = new DirectoryInfo(savePath + "/scripts/com/ankamagames/dofus/network/messages");

            foreach (var file in _dirInfosMessages.GetFiles("*.as", SearchOption.AllDirectories))
            {
                string line = String.Empty;
                using (StreamReader fileReader = new StreamReader(file.FullName))
                {
                    while ((line = fileReader.ReadLine()) != null)
                    {
                        if (line.Contains("public static const protocolId:uint ="))
                        {
                            messagesDictionnary.Add(Convert.ToInt32(line.Replace("public static const protocolId:uint =", "").Replace(";", "").Replace(" ", "")), file.Name.Replace(".as", ""));

                        }
                    }
                }
            }

            using (StreamWriter file = new StreamWriter(savePath + "/MessagesList.txt"))
                foreach (var entry in messagesDictionnary)
                    file.WriteLine("[{0} {1}]", entry.Key, entry.Value);


            // Génération de la liste des identifiants des Types

            _dirInfosTypes = new DirectoryInfo(savePath + "/scripts/com/ankamagames/dofus/network/types");

            foreach (var file in _dirInfosTypes.GetFiles("*.as", SearchOption.AllDirectories))
            {
                string line = String.Empty;
                using (StreamReader fileReader = new StreamReader(file.FullName))
                {
                    while ((line = fileReader.ReadLine()) != null)
                    {
                        if (line.Contains("public static const protocolId:uint ="))
                        {
                            typesDictionnary.Add(Convert.ToInt32(line.Replace("public static const protocolId:uint =", "").Replace(";", "").Replace(" ", "")), file.Name.Replace(".as", ""));

                        }
                    }
                }
            }

            using (StreamWriter file = new StreamWriter(savePath + "/TypesList.txt"))
                foreach (var entry in typesDictionnary)
                    file.WriteLine("[{0} {1}]", entry.Key, entry.Value);

            // Nettoyage des listes
            messagesDictionnary.Clear();
            typesDictionnary.Clear();

            // Upload si nécessaire
            if (chk_UploadViaFTP.Checked)
            {
                // On crée une archive et on upload
                ZipFile.CreateFromDirectory($"{savePath}", $"{Settings.Default.SavePath}/{timeStamp}-{dofusInvokerVersion}.zip");
                FTPUploadFile("/test", $"{timeStamp}-{dofusInvokerVersion}.zip", $"{Settings.Default.SavePath}/{timeStamp}-{dofusInvokerVersion}.zip");
            }

        }

        private void FTPUploadFile(string prmUploadPath, string prmFilename, string prmFilePath)
        {
            FTP ftpClient = new FTP(txt_ftpHost.Text, txt_ftpUser.Text, txt_ftpPassword.Text);

            ftpClient.upload(prmUploadPath + "/" + prmFilename, prmFilePath);

            ftpClient = null;
        }

        private void btn_BrowseSavePath_Click(object sender, EventArgs e)
        {
            folderBrowse_SavePath.ShowDialog();
            txt_SavePath.Text = folderBrowse_SavePath.SelectedPath;
            Settings.Default.SavePath = folderBrowse_SavePath.SelectedPath;
            Settings.Default.Save();
        }

        public static String GetTimestamp(DateTime value)
        {
            return value.ToString("yyyy-MM-dd-HH-mm-ss");
        }

        private void timer_AnkamaLauncher_Tick(object sender, EventArgs e)
        {
            // On vérifie si le process Ankama Launcher.exe est toujours lancé
            Process[] ankamaLauncherProcess = Process.GetProcessesByName("Ankama Launcher");
            if (ankamaLauncherProcess.Length == 0)
            {
                // Le processus Ankama Launcher.exe n'est pas démarré alors qu'il devrait l'être... On le relance.
                Process.Start(Settings.Default.AnkamaLauncherPath + "/Ankama Launcher.exe");
            }
        }

        private void CheckAnkamaLauncherState()
        {
            Process[] ankamaLauncherProcess = Process.GetProcessesByName("Ankama Launcher");
            if (ankamaLauncherProcess.Length == 0) Process.Start(Settings.Default.AnkamaLauncherPath + "/Ankama Launcher.exe");
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
