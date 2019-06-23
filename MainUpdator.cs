using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zUpdator
{
    public partial class MainUpdator : Form
    {
        private bool isUpdating = false;
        private bool updated = false;
        private string filename = "";

        private async Task taskDelay(int delayMs)
        {
            await Task.Delay(delayMs);
        }

        public MainUpdator(string curVersion, string newVersion, string filename)
        {
            InitializeComponent();

            // stop launcher
            KillLauncher("arma3Launcher");

            // set vars
            this.txt_curversion.Text = curVersion.Split('=')[1];
            this.txt_latestversion.Text = newVersion.Split('=')[1];
            this.filename = filename.Split('=')[1];

            this.txt_releaseInfo.Text = "Getting release description...";
            this.getGitRealeasInfo();
        }

        private async void getGitRealeasInfo()
        {
            var client = new Octokit.GitHubClient(new Octokit.ProductHeaderValue("zUpdator"));
            var releases = await client.Repository.Release.GetAll("serialtasted", "arma3Launcher");
            foreach (var release in releases)
            {
                if (release.TagName == this.txt_latestversion.Text)
                {
                    this.txt_releaseInfo.Text = release.Name + Environment.NewLine;
                    this.txt_releaseInfo.Text += string.Format("Release date: {0:00}/{1:00}/{2:0000}", release.PublishedAt.Value.Day, release.PublishedAt.Value.Month, release.PublishedAt.Value.Year) + Environment.NewLine;
                    this.txt_releaseInfo.Text += Environment.NewLine;
                    this.txt_releaseInfo.Text += release.Body;
                    return;
                }
            }
        }

        private async void Update_client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            if (!e.Cancelled)
            {
                this.label1.Text = "Download complete";
                this.isUpdating = false;
                this.updated = true;
                this.UseWaitCursor = false;

                try
                {
                    var fass = new ProcessStartInfo();
                    fass.WorkingDirectory = Application.ExecutablePath.Remove(Application.ExecutablePath.Length - Process.GetCurrentProcess().MainModule.ModuleName.Length);
                    fass.FileName = this.filename;

                    var process = new Process();
                    process.StartInfo = fass;
                    process.Start();

                    await this.taskDelay(1500);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    this.Close();
                }
            }
        }

        private void Update_client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            this.progressBar1.Value = e.ProgressPercentage;
            this.label1.Text = "Downloading: " + this.filename;
        }

        private async void KillLauncher(string exeName)
        {
            await taskDelay(1500);

            Process[] pname = Process.GetProcessesByName(exeName);

            while (pname.Length != 0)
            {
                MessageBox.Show(exeName + " is running, the updater will now end it.");
                try
                {
                    pname[0].Kill();
                }
                catch
                {
                    MessageBox.Show("Could not close the launcher automatically. Please close it and then press \"OK\".");
                }

                await taskDelay(1500);
                pname = Process.GetProcessesByName(exeName);
            };
        }

        private void Updator_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isUpdating)
                e.Cancel = true;
            else if (!updated && MessageBox.Show("Do you really want to stop the update process?", "Launcher is updating", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.No)
                e.Cancel = true;
        }

        private void sysbtn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sysbtn_close_MouseDown(object sender, MouseEventArgs e)
        {
            sysbtn_close.Image = Properties.Resources.bgclose3;
        }

        private void sysbtn_close_MouseEnter(object sender, EventArgs e)
        {
            sysbtn_close.Image = Properties.Resources.bgclose2;
        }

        private void sysbtn_close_MouseLeave(object sender, EventArgs e)
        {
            sysbtn_close.Image = Properties.Resources.bgclose1;
        }

        private void sysbtn_git_MouseDown(object sender, MouseEventArgs e)
        {
            sysbtn_git.Image = Properties.Resources.bggit3;
        }

        private void sysbtn_git_MouseEnter(object sender, EventArgs e)
        {
            sysbtn_git.Image = Properties.Resources.bggit2;
        }

        private void sysbtn_git_MouseLeave(object sender, EventArgs e)
        {
            sysbtn_git.Image = Properties.Resources.bggit1;
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            this.isUpdating = true;
            string url = "https://github.com/serialtasted/arma3Launcher/releases/download/" + this.txt_latestversion.Text + "/arma3Launcher.exe";
            this.btn_update.Enabled = false;
            this.UseWaitCursor = true;

            using (var update_client = new WebClient())
            {
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;

                update_client.DownloadProgressChanged += Update_client_DownloadProgressChanged;
                update_client.DownloadFileCompleted += Update_client_DownloadFileCompleted;

                // start download
                update_client.DownloadFileAsync(
                    new Uri(url),
                    Application.ExecutablePath.Remove(Application.ExecutablePath.Length - Process.GetCurrentProcess().MainModule.ModuleName.Length) + this.filename
                );
            }

            txt_curFile.Text = "Downloading from: " + url;
        }

        private void sysbtn_git_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/serialtasted/arma3Launcher/releases/tag/" + txt_latestversion.Text);
        }
    }
}
