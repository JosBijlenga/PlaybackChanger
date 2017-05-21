using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PlaybackChanger_Installer;
using PlaybackChanger_Installer.Controls;

namespace PlaybackChanger_Uninstaller
{
    public partial class FormMain : Form
    {
        private BorderPanel _currentNavBorderPanel;
        private InstallConfig _config;
        private UserControl[] _pages;
        private UserControl _currentPage;
        private Navigator _navigator;

        public FormMain()
        {
            InitializeComponent();

            this.Text = string.Format("{0} uninstaller", AppInfo.Name);

            _config = new InstallConfig();
            _navigator = new Navigator(this);

            _pages = new UserControl[3];
            _pages[0] = new Pages.PageUninstall(panelMain, _config, _navigator);

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
        private void FocusStep(BorderPanel panelNav, UserControl page)
        {
            page.Show();
            panelNav.BorderColor = Color.FromArgb(51, 153, 255);
            panelNav.LeftBorderWidth = 5;
        }
        private void FocusUnfocusStep(BorderPanel panelNav, UserControl page)
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

        public void NavigateToLocation()
        {
            FocusUnfocusStep(borderPanelStepOne, _pages[0]);
        }
        public void CancelApplication()
        {
            this.Close();
        }
    }
}
