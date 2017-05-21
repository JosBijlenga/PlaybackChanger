using System;
using System.Windows.Forms;
using Playback_Changer.Helpers;
using Playback_Changer.Controllers;

namespace Playback_Changer.Forms
{
    public partial class SettingsForm : Form
    {
        private PlaybackChangerContext _context;
        private bool _startOnSystemStart;

        public bool MayClose { get; set; }

        public SettingsForm(PlaybackChangerContext context)
        {
            InitializeComponent();

            _context = context;

            _startOnSystemStart = SettingsManager.Settings.StartOnSystemStart;

            borderPanelColorLegendDefault.BackColor = Constants.DefaultColor;
            borderPanelColorLegendActive.BackColor = Constants.ActiveColor;
            borderPanelColorLegendIgnored.BackColor = Constants.IgnoredColor;
            borderPanelColorLegendUnplugged.BackColor = Constants.UnpluggedColor;
            borderPanelColorLegendDisabled.BackColor = Constants.DisabledColor;
            borderPanelColorLegendNotPresent.BackColor = Constants.NotPresentColor;
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            ControlHelper.SetToggleSwitchWithoutAnimation(bmToggleSwitchStartOnSystemStart, SettingsManager.Settings.StartOnSystemStart);

            flatButtonActivationKey.Text = SettingsManager.Settings.ActivateKey.ToString();
        }

        private void FlatButtonActivationKey_Click(object sender, EventArgs e)
        {
            var dialog = new PressKeyForm(this);
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var key = dialog.PressedKey;
                if (key != Keys.None)
                {
                    SettingsManager.Settings.ActivateKey = key;
                    flatButtonActivationKey.Text = key.ToString();
                }
            }
        }
        private void BmToggleSwitchStartOnSystemStart_CheckedChanged(object sender, EventArgs e)
        {
            SettingsManager.Settings.StartOnSystemStart = bmToggleSwitchStartOnSystemStart.Checked;
        }

        private void FlatButtonOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SettingsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_startOnSystemStart != bmToggleSwitchStartOnSystemStart.Checked)
            {
                if (bmToggleSwitchStartOnSystemStart.Checked)
                {
                    var path = PlaybackChanger_Installer.RegHelper.GetRegInstallPath();
                    if (!string.IsNullOrEmpty(path))
                        PlaybackChanger_Installer.RegHelper.SetRegRun(path);
                }
                else
                {
                    PlaybackChanger_Installer.RegHelper.RemoveRegRun();
                }
            }

            e.Cancel = !MayClose;
            this.Hide();
        }

        private void FlatButtonUnbindActivationKey_Click(object sender, EventArgs e)
        {
            SettingsManager.Settings.ActivateKey = Keys.None;
            flatButtonActivationKey.Text = Keys.None.ToString();
        }

        private void SettingsForm_Activated(object sender, EventArgs e)
        {
            _context.DeviceController.RefreshDevices();
            var devices = _context.DeviceController.Devices;
            borderPanelDevicesList.SuspendLayout();
            try
            {
                borderPanelDevicesList.Controls.Clear();
                // Backwards loop to show devices in the right order
                for (int i = devices.Length - 1; i >= 0; i--)
                    devices[i].AddToControl(borderPanelDevicesList, Eo.VisualDeviceStyling.GetSettingStyling());
            }
            finally
            {
                borderPanelDevicesList.VerticalScroll.Value = 0;
                borderPanelDevicesList.ResumeLayout(true);
            }
        }
    }
}
