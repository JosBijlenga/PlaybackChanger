using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace PlaybackChanger_Installer.Pages
{
    public partial class PageInstall : UserControl
    {
        private InstallConfig _config;
        private Navigator _navigator;
        private Installer _installer;
        private bool _installed = false;

        public PageInstall(Control parent, InstallConfig config, Navigator navigator)
        {
            InitializeComponent();
            this.Visible = false;
            this.Parent = parent;
            this.Dock = DockStyle.Fill;
            _config = config;
            _navigator = navigator;
        }

        private void FillUIWithConfig()
        {
            this.SuspendLayout();
            try
            {
                textBoxInstallLocation.Text = _config.InstallLocation;
                checkBoxDesktop.Checked = _config.DesktopShortcut;
                checkBoxStartmenu.Checked = _config.StartmenuShortcut;
                checkBoxSystemStart.Checked = _config.StartOnSystemStart;

                RunChecksHasError();
            }
            finally
            {
                this.ResumeLayout(true);
            }
        }

        private bool RunChecksHasError()
        {
            bool validPath = IsValidPath(_config.InstallLocation);
            bool isRunning = IsAppRunning();
            bool packageExists = InstallPackageExists();

            bool anyError = (!validPath || isRunning || !packageExists);
            panelErrors.Visible = anyError;
            flatButtonInstall.Enabled = !(!validPath || isRunning || !packageExists);
            panelIncorrectPath.Visible = !validPath;
            panelStillRunning.Visible = isRunning;
            panelNoPackage.Visible = !packageExists;
            return anyError;
        }

        private bool InstallPackageExists()
        {
            var packagePath = Path.Combine(Environment.CurrentDirectory, "Package.7z");
            return File.Exists(packagePath);
        }

        private void StartInstall()
        {
            if (RunChecksHasError())
                return;

            _config.InstallPackage = Path.Combine(Environment.CurrentDirectory, "Package.7z");
            flatButtonInstall.Enabled = false;
            flatButtonInstallCancel.Hide();
            borderPanelProgressInstall.Show();
            _installer = _navigator.GetInstaller();

            var worker = new BackgroundWorker();
            worker.ProgressChanged += Worker_ProgressChanged;
            worker.RunWorkerCompleted += Worker_RunWorkerCompleted;

            _installer.Start(worker);
        }

        private void Worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            _installed = true;
            flatButtonInstall.Text = "Finish";
            flatButtonInstall.Enabled = true;
            _navigator.InstallerDone();
        }

        private void Worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            labelProgress.Text = e.UserState as string;
            progressBarInstall.Value = e.ProgressPercentage;
        }

        private void FlatButtonInstallCancel_Click(object sender, EventArgs e)
        {
            _navigator.CancelInstall(false);
        }
        private void FlatButtonInstall_Click(object sender, EventArgs e)
        {
            if (!_installed)
                StartInstall();
            else
            {
                _navigator.CancelInstall(true);
                if (checkBoxStartOnFinish.Checked)
                {
                    try
                    {
                        Process.Start(Path.Combine(_config.InstallLocation, string.Format("{0}.exe", AppInfo.Name)));
                    }
                    catch (Exception)
                    {
                        // swallow, hehe
                    }
                }
            }
        }

        private void PageInstall_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
                FillUIWithConfig();
            else
                flatButtonInstall.Enabled = false;
        }

        private bool IsAppRunning()
        {
            var mutex = new System.Threading.Mutex(true, AppInfo.UID, out bool created);
            mutex.Close();
            return !created;
        }

        private bool IsValidPath(string path)
        {
            try
            {
                var fullPath = Path.GetFullPath(_config.InstallLocation);
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void TimerCheckRunning_Tick(object sender, EventArgs e)
        {
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
    }
}
