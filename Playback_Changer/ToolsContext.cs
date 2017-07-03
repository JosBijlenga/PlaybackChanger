using System;
using System.Windows.Forms;
using Playback_Changer.Controllers;
using Playback_Changer.Forms;
using Playback_Changer.Helpers;

namespace Playback_Changer
{
    public class PlaybackChangerContext : ApplicationContext
    {
        private KeyboardHook _keyboardHook;
        private QuickviewForm _view;
        public SettingsForm SettingsForm;
        private UpdateController _updateController;

        private NotifyIcon TrayIcon;
        private ContextMenuStrip TrayIconMenuStrip;
        private ToolStripMenuItem ContextMenuStripOpen;
        private ToolStripMenuItem ContextMenuStripSettings;
        private ToolStripMenuItem ContextMenuStripClose;

        public DeviceController DeviceController;
        public UpdateController UpdateController
        {
            get { return _updateController; }
        }

        public PlaybackChangerContext(bool showQuickview)
        {
            InitializeComponents();

            TrayIcon.Visible = true;

            if (SettingsManager.Settings.FirstLaunch)
            {
                TrayIcon.ShowBalloonTip(10000, "", Properties.Resources.TrayIconBalloonText, ToolTipIcon.Info);
                SettingsManager.Settings.FirstLaunch = false;
            }
            else
            {
                if (showQuickview)
                    _view.Show();
            }
        }

        private void UpdateController_UpdateAvailable(object sender, UpdateController.UpdateAvailableEventArgs e)
        {
            _view.ShowUpdateDownload(e.VersionInfo);
        }

        private void _updateController_InstallAvailable(object sender, UpdateController.InstallAvailableEventArgs e)
        {
            _view.ShowUpdateInstall(new Eo.VersionInfo(e.Version));
        }

        private void _updateController_UpdateFailure(object sender, UpdateController.UpdateFailureEventArgs e)
        {
            _view.ShowWarning();
        }

        private void _updateController_NoUpdateAvailable(object sender, UpdateController.NoUpdateAvailableEventArgs e)
        {
            _view.ShowNoUpdate();
        }

        private void InitializeComponents()
        {
            DeviceController = new DeviceController();

            _view = new QuickviewForm(this);
            _view.FormClosing += _view_FormClosing;

            SettingsForm = new SettingsForm(this);

            TrayIconMenuStrip = new ContextMenuStrip();
            ContextMenuStripOpen = new ToolStripMenuItem();
            ContextMenuStripSettings = new ToolStripMenuItem();
            ContextMenuStripClose = new ToolStripMenuItem();
            TrayIcon = new NotifyIcon();
            _updateController = new UpdateController();
            _updateController.UpdateAvailable += UpdateController_UpdateAvailable;
            _updateController.InstallAvailable += _updateController_InstallAvailable;
            _updateController.UpdateFailure += _updateController_UpdateFailure;
            _updateController.NoUpdateAvailable += _updateController_NoUpdateAvailable;

            //
            // ContextMenuStripOpen
            //
            ContextMenuStripOpen.Name = "ContextMenuStripOpen";
            ContextMenuStripOpen.Text = "Open";
            ContextMenuStripOpen.Click += ContextMenuStripOpen_Click;
            //
            // ContextMenuStripSettings
            //
            ContextMenuStripSettings.Name = "ContextMenuStripSettings";
            ContextMenuStripSettings.Text = "Settings";
            ContextMenuStripSettings.Click += ContextMenuStripSettings_Click; ;
            //
            // ContextMenuStripClose
            //
            ContextMenuStripClose.Name = "ToolStripMenuItemClose";
            ContextMenuStripClose.Text = "Exit Playback Changer";
            ContextMenuStripClose.Click += ContextMenuStripClose_Click;
            //
            // TrayIconMenuStrip
            //
            TrayIconMenuStrip.Items.AddRange(new ToolStripItem[] {
                ContextMenuStripOpen,
                ContextMenuStripSettings,
                ContextMenuStripClose
            });
            TrayIconMenuStrip.Name = "TrayIconMenuStrip";
            //
            // TrayIcon
            //
            TrayIcon.Text = "Playback Changer";
            TrayIcon.Icon = Properties.Resources.icon;
            TrayIcon.MouseClick += _notifyIcon_MouseClick;

            TrayIcon.ContextMenuStrip = TrayIconMenuStrip;

            _keyboardHook = new KeyboardHook();
            _keyboardHook.Activated += _keyboardHook_Activated;
            _keyboardHook.HotkeyPressed += _keyboardHook_HotkeyPressed;

            this.ThreadExit += PlaybackChangerContext_ThreadExit;
        }

        private void PlaybackChangerContext_ThreadExit(object sender, EventArgs e)
        {
            TrayIcon.Dispose();
        }

        private void ExitApp()
        {
            _view.MayClose = true;
            SettingsForm.MayClose = true;
            Program.Quit();
        }

        private void ShowWindow()
        {
            if (!SettingsForm.Visible)
            {
                _view.WindowState = FormWindowState.Minimized;
                _view.Show();
                _view.WindowState = FormWindowState.Normal;
                _view.Activate();
            }
            else
            {
                SettingsForm.Show();
            }
        }

        private void ContextMenuStripOpen_Click(object sender, EventArgs e)
        {
            ShowWindow();
        }

        private void ContextMenuStripSettings_Click(object sender, EventArgs e)
        {
            SettingsForm.Show();
        }

        private void ContextMenuStripClose_Click(object sender, EventArgs e)
        {
            _view.MayClose = true;
            ExitApp();
        }

        private void _view_FormClosing(object sender, FormClosingEventArgs e)
        {
            ExitApp();
        }

        private void _notifyIcon_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                ShowWindow();
        }

        private void _keyboardHook_HotkeyPressed(KeyboardHook.HotkeyEventArgs e)
        {
            DeviceController.ActivateDeviceByHotkey(e.Key);
        }

        private void _keyboardHook_Activated(KeyboardHook.ActivatedEventArgs e)
        {
            ShowWindow();
        }
    }
}
