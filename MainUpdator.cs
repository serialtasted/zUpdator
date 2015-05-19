using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Net;
using System.Threading;
using System.Windows.Forms;

namespace zUpdator
{
    public partial class MainUpdator : Form
    {
        private bool isUpdating = false;

        private bool isActive = true;

        private string filename = "";
        private string aux_newVersion = "";
        WebClient client_update = new WebClient();
        Uri download_url;

        void Execute()
        {
            isUpdating = true;
            UseWaitCursor = true;

            client_update.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_update_DownloadProgressChanged);
            client_update.DownloadFileCompleted += new AsyncCompletedEventHandler(client_update_DownloadFileCompleted);

            client_update.DownloadFileAsync(download_url, Application.StartupPath + "\\" + filename);
        }

        public MainUpdator(string curVersion, string newVersion)
        {
            InitializeComponent();
            KillLauncher("spNLauncher_Arma3");
            
            txt_curversion.Text = curVersion;
            txt_latestversion.Text = newVersion;
            filename = "spNLauncher_Arma3.exe";

            if (newVersion.Contains("(Beta Release)"))
                aux_newVersion = newVersion.Replace(" (Beta Release)", "");
            else if (newVersion.Contains("(Alpha Release)"))
                aux_newVersion = newVersion.Replace(" (Alpha Release)", "");

            download_url = new Uri("https://github.com/serialtasted/spNLauncher/releases/download/" + aux_newVersion + "/spNLauncher_Arma3.exe");

            Execute();
        }

        void client_update_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            if (progressBar1.Value == 100)
            {
                label1.Text = "Download complete";
                isUpdating = false;

                UseWaitCursor = false;

                try
                {
                    var fass = new ProcessStartInfo();
                    fass.FileName = filename;

                    var process = new Process();
                    process.StartInfo = fass;
                    process.Start();

                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    this.Close();
                }
            }
        }

        void client_update_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
            label1.Text = "Downloading: " + filename;
        }

        void KillLauncher(string exeName)
        {
            Thread.Sleep(1000);

            Process[] pname = Process.GetProcessesByName(exeName);

            while (pname.Length != 0)
            {
                MessageBox.Show("spN Launcher is running, the updater will now end it.");
                try
                {
                    pname[0].Kill();
                }
                catch
                {
                    MessageBox.Show("Could not close spN Launcher automatically. Please close it and then press \"OK\".");
                }

                Thread.Sleep(500);
                pname = Process.GetProcessesByName(exeName);
            };
        }

        private void Updator_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isUpdating)
            {
                MessageBox.Show("One does not simply cancel the update process.", "Unable to cancel", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                e.Cancel = true;
            }
        }

        private void sysbtn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sysbtn_close_MouseDown(object sender, MouseEventArgs e)
        {
            sysbtn_close.Image = Properties.Resources.bgclose4;
        }

        private void sysbtn_close_MouseEnter(object sender, EventArgs e)
        {
            sysbtn_close.Image = Properties.Resources.bgclose2;
        }

        private void sysbtn_close_MouseLeave(object sender, EventArgs e)
        {
            if (isActive)
                sysbtn_close.Image = Properties.Resources.bgclose1;
            else
                sysbtn_close.Image = Properties.Resources.bgclose3;
        }
    }
}
