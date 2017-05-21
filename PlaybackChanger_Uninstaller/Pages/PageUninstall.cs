using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PlaybackChanger_Installer;
using System.Diagnostics;

namespace PlaybackChanger_Uninstaller.Pages
{
    public partial class PageUninstall : UserControl
    {
        private InstallConfig _config;
        private Navigator _navigator;
        private Uninstaller _uninstaller;

        private const string ConfirmUninstall = "Are you sure you want to uninstall {0} and all files associated?";
        private const string NoInstall = "{0} is not installed on this system.";
        private const string NotFound = "{0} not found";

        private bool _successfulUninstall = false;
        private bool _installed = false;

        public PageUninstall(Control parent, InstallConfig config, Navigator navigator)
        {
            InitializeComponent();
            this.Visible = false;
            this.Parent = parent;
            this.Dock = DockStyle.Fill;
            _config = config;
            _navigator = navigator;

            string installFolder = RegHelper.GetRegInstallPath();
            if (string.IsNullOrWhiteSpace(installFolder))
            {
                textBoxInstallLocation.Text = string.Format(NotFound, AppInfo.Name);
                labelConfirm.Text = string.Format(NoInstall, AppInfo.Name);
            }
            else
            {
                _config.InstallLocation = installFolder;
                textBoxInstallLocation.Text = installFolder;

                labelConfirm.MaximumSize = new Size(460, 0);
                labelConfirm.Text = string.Format(ConfirmUninstall, AppInfo.Name);

                flatButtonUninstall.Enabled = true;
                _installed = true;
            }
        }

        private bool IsAppRunning()
        {
            var mutex = new System.Threading.Mutex(true, AppInfo.UID, out bool created);
            mutex.Close();
            return !created;
        }

        private void FlatButtonUninstallCancel_Click(object sender, EventArgs e)
        {
            _navigator.CancelInstall();
        }

        private void FlatButtonUninstall_Click(object sender, EventArgs e)
        {
            if (!_successfulUninstall)
            {
                timerCheckRunning.Stop();

                labelProgress.Text = "Uninstalling";
                progressBarInstall.Value = 0;
                progressBarInstall.SetState(1);
                progressBarInstall.Style = ProgressBarStyle.Marquee;

                flatButtonUninstall.Enabled = false;
                flatButtonUninstallCancel.Hide();
                borderPanelProgressInstall.Show();

                Timer t = new Timer()
                {
                    Interval = 1000
                };
                t.Tick += delegate
                {
                    _uninstaller = new Uninstaller(_config);

                    progressBarInstall.Style = ProgressBarStyle.Continuous;

                    var worker = new BackgroundWorker();
                    worker.ProgressChanged += Worker_ProgressChanged;
                    worker.RunWorkerCompleted += Worker_RunWorkerCompleted;

                    _uninstaller.Start(worker);

                    t.Stop();
                    t.Dispose();
                };
                t.Start();
            }
            else
            {
                RemoveArtifact();
                _navigator.CancelInstall();
            }
        }

        private void SetUninstallError(string message)
        {
            labelProgress.Text = message;
            progressBarInstall.SetState(2);

            _successfulUninstall = false;

            flatButtonUninstall.Text = "Retry";
            flatButtonUninstall.Enabled = true;
            flatButtonUninstallCancel.Show();

            timerCheckRunning.Start();
        }

        private void SetUninstallSuccess()
        {
            labelProgress.Text = "Done";
            progressBarInstall.SetState(1);

            _successfulUninstall = true;

            flatButtonUninstall.Text = "Finish";
            flatButtonUninstall.Enabled = true;
        }

        private void Worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            var result = (e.Result as string);
            if (result != null)
                SetUninstallError(result);
            else
                SetUninstallSuccess();
        }

        private void Worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            labelProgress.Text = e.UserState as string;
            labelProgress.Update();
            progressBarInstall.Value = e.ProgressPercentage;
            Console.WriteLine("Progress: " + e.ProgressPercentage);
        }

        private void RemoveArtifact()
        {
            try
            {
                // Remove uninstaller
                ProcessStartInfo Info = new ProcessStartInfo()
                {
                    Arguments = string.Format("/C choice /C Y /N /D Y /T 3 & del \"{0}\"",
                               Application.ExecutablePath),
                    WindowStyle = ProcessWindowStyle.Hidden,
                    CreateNoWindow = true,
                    FileName = "cmd.exe"
                };
                Process.Start(Info);
            }
            catch{ }
        }

        private void TimerCheckRunning_Tick(object sender, EventArgs e)
        {
            if (!_installed)
                return;

            this.SuspendLayout();
            try
            {
                RunChecksHasError();
            }
            finally
            {
                this.ResumeLayout(true);
            }
        }

        private bool RunChecksHasError()
        {
            bool isRunning = IsAppRunning();

            bool anyError = isRunning;
            panelErrors.Visible = anyError;
            flatButtonUninstall.Enabled = !isRunning;
            panelStillRunning.Visible = isRunning;
            return anyError;
        }
    }
}
