using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlaybackChanger_Installer
{
    public partial class FormMain : Form
    {
        private Controls.BorderPanel _currentNavBorderPanel;
        private InstallConfig _config;
        private UserControl[] _pages;
        private UserControl _currentPage;
        private Navigator _navigator;

        public bool MayClose { get; set; }
        public bool _showConfirmation = true;

        public FormMain()
        {
            InitializeComponent();

            this.Text = string.Format("{0} installer", AppInfo.Name);

            MayClose = false;

            _config = new InstallConfig();
            _navigator = new Navigator(this);

            _pages = new UserControl[3];
            _pages[0] = new Pages.PageLocation(panelMain, _config, _navigator);
            _pages[1] = new Pages.PageOptions(panelMain, _config, _navigator);
            _pages[2] = new Pages.PageInstall(panelMain, _config, _navigator);

            _currentNavBorderPanel = borderPanelStepOne;
            _currentPage = _pages[0];
            FocusStep(borderPanelStepOne, _pages[0]);
        }

        private void UnfocusPreviousStep()
        {
            _currentNavBorderPanel.BorderColor = Color.FromArgb(215, 215, 215);
            _currentNavBorderPanel.LeftBorderWidth = 3;
            _currentPage.Hide();
        }
        private void FocusStep(Controls.BorderPanel panelNav, UserControl page)
        {
            page.Show();
            panelNav.BorderColor = Color.FromArgb(51, 153, 255);
            panelNav.LeftBorderWidth = 5;
        }
        private void FocusUnfocusStep(Controls.BorderPanel panelNav, UserControl page)
        {
            if (page == _currentPage) return;

            panelMain.SuspendLayout();
            flowLayoutPanelNav.SuspendLayout();
            try
            {
                FocusStep(panelNav, page);
                UnfocusPreviousStep();

                _currentNavBorderPanel = panelNav;
                _currentPage = page;
            }
            finally
            {
                panelMain.ResumeLayout(true);
                flowLayoutPanelNav.ResumeLayout(true);
            }
        }

        private void StepOne_Click(object sender, EventArgs e)
        {
            NavigateToLocation();
        }
        private void StepTwo_Click(object sender, EventArgs e)
        {
            NavigateToOptions();
        }
        private void StepThree_Click(object sender, EventArgs e)
        {
            NavigateToInstall();
        }

        public void NavigateToLocation()
        {
            FocusUnfocusStep(borderPanelStepOne, _pages[0]);
        }
        public void NavigateToOptions()
        {
            FocusUnfocusStep(borderPanelStepTwo, _pages[1]);
        }
        public void NavigateToInstall()
        {
            FocusUnfocusStep(borderPanelStepThree, _pages[2]);
        }
        public Installer GetInstaller()
        {
            flowLayoutPanelNav.Enabled = false;
            return new Installer(_config);
        }
        public void InstallerDone()
        {
            _showConfirmation = false;
            MayClose = true;
        }
        public void CancelApplication(object caller, bool force)
        {
            if (force)
            {
                _showConfirmation = false;
                MayClose = true;
                this.Close();
            }
            else
            {
                using (new CenterWinDialog(this))
                {
                    var result = MessageBox.Show(
                        this,
                        "Are you sure that you want to cancel the installation?",
                        "Cancel install",
                        MessageBoxButtons.YesNoCancel,
                        MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        _showConfirmation = false;
                        MayClose = true;
                        this.Close();
                    }
                    else
                    {
                        MayClose = false;
                        _showConfirmation = true;
                    }
                }
            }
        }
        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_showConfirmation)
                CancelApplication(this, false);
            e.Cancel = !MayClose;
        }
    }
}
