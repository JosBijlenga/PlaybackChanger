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
using Microsoft.WindowsAPICodePack.Dialogs;

namespace PlaybackChanger_Installer.Pages
{
    public partial class PageLocation : UserControl
    {
        private InstallConfig _config;
        private Navigator _navigator;

        public PageLocation(Control parent, InstallConfig config, Navigator navigator)
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
                installFolder = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86);
                installFolder = Path.Combine(installFolder, AppInfo.Name);
            }
            textBoxInstallLocation.Text = installFolder;
            textBoxInstallLocation.Select(textBoxInstallLocation.Text.Length, 0);
        }

        private void SetInstallLocation(string location)
        {
            string installPath = location;
            try
            {
                installPath = Path.GetFullPath(location);
                panelIncorrectPath.Hide();
            }
            catch
            {
                panelIncorrectPath.Show();
            }
            finally
            {
                textBoxInstallLocation.Text = installPath;
                _config.InstallLocation = installPath;
            }
        }

        private void FlatButtonLocationNext_Click(object sender, EventArgs e)
        {
            _navigator.NavigateToOptions();
        }
        private void FlatButtonLocationCancel_Click(object sender, EventArgs e)
        {
            _navigator.CancelInstall(false);
        }

        private void FlatButtonBrowse_Click(object sender, EventArgs e)
        {
            using (var browser = new CommonOpenFileDialog()
            {
                IsFolderPicker = true,
                Title = "Install location",
                Multiselect = false,
                DefaultDirectory = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86),
                ShowHiddenItems = false
            })
            {
                var result = browser.ShowDialog();
                if (result == CommonFileDialogResult.Ok)
                    SetInstallLocation(browser.FileName);
            }
        }

        private void TextBoxInstallLocation_Leave(object sender, EventArgs e)
        {
            //if (_installLocation != textBoxInstallLocation.Text.Trim())
            //SetInstallLocation(textBoxInstallLocation.Text.Trim());
        }

        private void TextBoxInstallLocation_TextChanged(object sender, EventArgs e)
        {
            SetInstallLocation(textBoxInstallLocation.Text.Trim());
        }
    }
}
