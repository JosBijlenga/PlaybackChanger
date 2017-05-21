using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlaybackChanger_Installer.Pages
{
    public partial class PageOptions : UserControl
    {
        private InstallConfig _config;
        private Navigator _navigator;

        public PageOptions(Control parent, InstallConfig config, Navigator navigator)
        {
            InitializeComponent();
            this.Visible = false;
            this.Parent = parent;
            this.Dock = DockStyle.Fill;
            _config = config;
            _navigator = navigator;

            _config.DesktopShortcut = checkBoxDesktop.Checked;
            _config.StartmenuShortcut = checkBoxStartmenu.Checked;
            _config.StartOnSystemStart = checkBoxSystemStart.Checked;
        }

        private void FlatButtonOptionsNext_Click(object sender, EventArgs e)
        {
            _navigator.NavigateToInstall();
        }
        private void FlatButtonOptionsCancel_Click(object sender, EventArgs e)
        {
            _navigator.CancelInstall(false);
        }

        private void CheckBoxDesktop_CheckedChanged(object sender, EventArgs e)
        {
            _config.DesktopShortcut = ((CheckBox)sender).Checked;
        }
        private void CheckBoxStartmenu_CheckedChanged(object sender, EventArgs e)
        {
            _config.StartmenuShortcut = ((CheckBox)sender).Checked;
        }
        private void CheckBoxSystemStart_CheckedChanged(object sender, EventArgs e)
        {
            _config.StartOnSystemStart = ((CheckBox)sender).Checked;
        }
    }
}
