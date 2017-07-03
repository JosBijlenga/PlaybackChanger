using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Playback_Changer.Controllers;
using Playback_Changer.Enums;
using Playback_Changer.Helpers;
using Playback_Changer.Eo;
using System.ComponentModel;
using System.IO;

namespace Playback_Changer.Forms
{
    public partial class QuickviewForm : Form
    {
        private Color _backColor;
        private Color _borderColor;
        private Color _foreColor;

        private Color _deviceControlBackColor;
        private Color _deviceControlHoverColor;

        private const int OFFSET = 12;
        private const int HEIGHT = 280;
        private const int WIDTH = 360;

        private PlaybackChangerContext _context;

        /// <summary>
        /// Flag if the window may be closed.
        /// </summary>
        private bool _mayClose = false;
        public bool MayClose
        {
            get
            {
                return _mayClose;
            }
            set
            {
                _mayClose = value;
            }
        }

        public QuickviewForm(PlaybackChangerContext context)
        {
            InitializeComponent();

            buttonUpdate.Tag = new VersionTag(null, string.Empty, Enums.Constants.UpdateType.check);

            _context = context;

            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.DoubleBuffer, true);

            this.Location = SetQuickviewLocation();
            buttonSettings.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);

            SetColors();
            var devices = _context.DeviceController.Devices;
            PopulateDevices(devices);
        }

        private Point SetQuickviewLocation()
        {
            int x = 0;
            int y = 0;
            Taskbar taskbar = TaskbarHelper.Taskbar;

            switch (TaskbarHelper.Taskbar.Position)
            {
                case TaskbarPosition.Left:
                    x = Screen.PrimaryScreen.WorkingArea.Left + OFFSET;
                    y = Screen.PrimaryScreen.WorkingArea.Bottom - HEIGHT;
                    break;
                case TaskbarPosition.Right:
                    x = Screen.PrimaryScreen.WorkingArea.Right - WIDTH - OFFSET;
                    y = Screen.PrimaryScreen.WorkingArea.Bottom - Height;
                    break;
                case TaskbarPosition.Top:
                    x = Screen.PrimaryScreen.WorkingArea.Right - WIDTH;
                    y = Screen.PrimaryScreen.WorkingArea.Top + OFFSET;
                    break;
                case TaskbarPosition.Bottom:
                default:
                    x = Screen.PrimaryScreen.WorkingArea.Right - WIDTH;
                    y = Screen.PrimaryScreen.WorkingArea.Bottom - HEIGHT - OFFSET;
                    break;
            }
            return new Point(x, y);
        }

        /// <summary>
        /// Populate the devicePanel with deviceControls.
        /// </summary>
        /// <param name="deviceControls">The deviceControls to fill the panel with.</param>
        private void PopulateDevices(Eo.VisualDevice[] devices)
        {
            panelDevices.SuspendLayout();
            try
            {
                panelDevices.Controls.Clear();
                // Backwards loop to show devices in the right order
                for (int i = devices.Length - 1; i >= 0; i--)
                {
                    if (devices[i].State == Eo.DeviceState.Active && !devices[i].Ignored)
                    {
                        devices[i].AddToControl(panelDevices, new Eo.VisualDeviceStyling()
                        {
                            BackColor = _deviceControlBackColor,
                            ForeColor = Color.White,
                            ShowBorder = false,
                            ShowPopover = false
                        });
                    }
                }
            }
            finally
            {
                panelDevices.VerticalScroll.Value = 0;
                panelDevices.ResumeLayout(true);
            }
        }

        /// <summary>
        /// Set the View colors to match Windows Theme.
        /// </summary>
        /// <returns>Returns if the colors have changed.</returns>
        private bool SetColors()
        {
            bool changed = false;
            // This
            _backColor = ImmersiveColorHelper.GetColor(ImmersiveColors.ImmersiveStartBackground);
            _borderColor = ImmersiveColorHelper.GetColor(ImmersiveColors.ImmersiveControlDarkToggleTrackBackgroundDisabled);
            _foreColor = ImmersiveColorHelper.GetColor(ImmersiveColors.ImmersiveStartPrimaryText);
            changed = (_backColor != this.BackColor);
            this.BackColor = _backColor;
            borderPanelMain.BorderColor = _borderColor;
            this.ForeColor = _foreColor;
            linkLabelRefresh.LinkColor = _foreColor;
            linkLabelRefresh.ActiveLinkColor = _foreColor;

            // DeviceControl
            _deviceControlBackColor = ImmersiveColorHelper.GetColor(ImmersiveColors.ImmersiveStartSystemTilesBackground);
            _deviceControlHoverColor = ImmersiveColorHelper.GetColor(ImmersiveColors.ImmersiveStartHoverBackground);
            panelDevices.BackColor = _deviceControlBackColor;

            return changed;
        }

        // Delegate required to make access to ShowUpdateDownload cross-thread supported
        delegate void ShowUpdateDownloadDelegate(Eo.VersionInfo versionInfo);
        /// <summary>
        /// Notify the user that an update is available for download.
        /// </summary>
        /// <param name="versionInfo">Information about the version that is available for download.</param>
        public void ShowUpdateDownload(VersionInfo versionInfo)
        {
            if (this.buttonUpdate.InvokeRequired)
            {
                var d = new ShowUpdateDownloadDelegate(ShowUpdateDownload);
                this.Invoke(d, new object[] { versionInfo });
            }
            else
            {
                buttonUpdate.BackgroundImage = Properties.Resources.download_install;
                buttonUpdate.Tag = new VersionTag(versionInfo.Version, versionInfo.Url, Enums.Constants.UpdateType.download);
                toolTip.SetToolTip(buttonUpdate, string.Format("New version {0} is available for download", versionInfo.Version));
                buttonUpdate.Visible = true;
                pictureBoxUpdate.Visible = false;
            }
        }

        delegate void ShowNoUpdateDownloadDelegate();
        public void ShowNoUpdate()
        {
            if (this.buttonUpdate.InvokeRequired)
            {
                var d = new ShowNoUpdateDownloadDelegate(ShowNoUpdate);
                this.Invoke(d, null);
            }
            else
            {
                pictureBoxUpdate.Image = Properties.Resources.frown;
                toolTip.SetToolTip(pictureBoxUpdate, "No updates available");
                // Hide frown after 10 seconds
                Timer t = new Timer()
                {
                    Interval = 1000 * 10 // 10 seconds
                };
                t.Tick += delegate
                {
                    pictureBoxUpdate.Visible = false;
                    buttonUpdate.Visible = true;
                    t.Stop();
                    t.Dispose();
                };
                t.Start();
            }
        }

        // Delegate required to make access to ShowUpdateInstall cross-thread supported
        delegate void ShowUpdateInstallDelegate(VersionInfo versionInfo);
        /// <summary>
        /// Notify the user that a downloaded update is ready to be installed.
        /// </summary>
        /// <param name="version">The version ready to be installed.</param>
        public void ShowUpdateInstall(VersionInfo versionInfo)
        {
            if (this.buttonUpdate.InvokeRequired)
            {
                var d = new ShowUpdateInstallDelegate(ShowUpdateInstall);
                this.Invoke(d, new object[] { versionInfo });
            }
            else
            {
                buttonUpdate.BackgroundImage = Properties.Resources.install_small;
                buttonUpdate.Tag = new VersionTag(versionInfo.Version, versionInfo.Url, Enums.Constants.UpdateType.install);
                toolTip.SetToolTip(buttonUpdate, string.Format("Downloaded version {0} is ready to be installed", versionInfo.Version));
                buttonUpdate.Visible = true;
                pictureBoxUpdate.Visible = false;
            }
        }

        // Delegate required to make access to ShowWarning cross-thread supported
        delegate void ShowWarningDelegate();
        public void ShowWarning()
        {
            if (this.buttonUpdate.InvokeRequired)
            {
                var d = new ShowWarningDelegate(ShowWarning);
                this.Invoke(d, null);
            }
            else
            {
                buttonUpdate.BackgroundImage = Properties.Resources.warning;
                var tag = buttonUpdate.Tag as VersionTag;
                if (tag.Tag.Equals(Enums.Constants.UpdateType.download))
                {
                    toolTip.SetToolTip(buttonUpdate, "Something went wrong while trying to download the update. Click to try again");
                }
                else if (tag.Tag.Equals(Enums.Constants.UpdateType.install))
                {
                    toolTip.SetToolTip(buttonUpdate, "Something went wrong while trying to install the update. Click to try again");
                }
                else
                {
                    toolTip.SetToolTip(buttonUpdate, "Something went wrong. Click to try again");
                }
                buttonUpdate.Visible = true;
                pictureBoxUpdate.Visible = false;
            }
        }

        #region Events

        /// <summary>
        /// The window was activated/gained focus.
        /// Update the colors for they could have changed, repopulated accordingly.
        /// </summary>
        private void View_Activated(object sender, EventArgs e)
        {
            Timer t = new Timer()
            {
                Interval = 250
            };
            t.Tick += delegate
            {
                t.Stop();
                t.Dispose();

                _context.DeviceController.RefreshDevices();
                PopulateDevices(_context.DeviceController.Devices);
            };
            this.Location = SetQuickviewLocation();
            SetColors();
            t.Start();
        }

        /// <summary>
        /// Hide the window on focus loss. Behave like a system tray app.
        /// </summary>
        private void View_Deactivate(object sender, EventArgs e)
        {
            this.Hide();
        }

        /// <summary>
        /// Prevent the window from snapping to top right corner.
        /// </summary>
        private void View_Move(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        /// <summary>
        /// Refresh the devices.
        /// </summary>
        private void LinkLabelRefresh_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _context.DeviceController.RefreshDevices();
            PopulateDevices(_context.DeviceController.Devices);
        }

        /// <summary>
        /// Handle form closing. Cancel closing when it is not allowed yet.
        /// </summary>
        private void View_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = !MayClose;
        }

        /// <summary>
        /// Show the settings form.
        /// </summary>
        private void SettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _context.SettingsForm.ShowDialog();
        }

        /// <summary>
        /// User explicitly closed the app, so allow closing and close.
        /// </summary>
        private void ExitPlaybackChangerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MayClose = true;
            this.Close();
        }

        /// <summary>
        /// Show the contextmenustrip for the settings.
        /// </summary>
        private void ButtonSettings_Click(object sender, EventArgs e)
        {
            var pos = Cursor.Position;
            contextMenuStrip.Show(new Point(pos.X - contextMenuStrip.Width, pos.Y));
        }

        /// <summary>
        /// User clicked the download/install button.
        /// </summary>
        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            var tag = buttonUpdate.Tag as VersionTag;
            switch (tag.Tag)
            {
                case Enums.Constants.UpdateType.download:
                case Enums.Constants.UpdateType.downloadRetry:
                    DownloadClicked(tag);
                    break;
                case Enums.Constants.UpdateType.install:
                case Enums.Constants.UpdateType.installRetry:
                    InstallClicked(tag);
                    break;
                case Enums.Constants.UpdateType.check:
                    CheckClicked();
                    break;
                default:
                    break;
            }
        }

        private void CheckClicked()
        {
            pictureBoxUpdate.Visible = true;
            buttonUpdate.Visible = false;
            // check for updates.
            _context.UpdateController.CheckForUpdate(true);
        }

        private void DownloadClicked(VersionTag tag)
        {
            toolTip.SetToolTip(pictureBoxUpdate, "Downloading");
            pictureBoxUpdate.Image = Properties.Resources.Ring;
            pictureBoxUpdate.Visible = true;
            buttonUpdate.Visible = false;
            // download the update.
            _context.UpdateController.DownloadUpdate(tag);
        }

        private BackgroundWorker worker;
        private void InstallClicked(VersionTag tag)
        {
            toolTip.SetToolTip(pictureBoxUpdate, "Installing");
            pictureBoxUpdate.Image = Properties.Resources.Ring;
            pictureBoxUpdate.Visible = true;
            buttonUpdate.Visible = false;
            // install the update.
            worker = new BackgroundWorker();
            worker.RunWorkerCompleted += delegate
            {
                pictureBoxUpdate.Visible = false;

                var installLocation = PlaybackChanger_Installer.RegHelper.GetRegInstallPath();
                if (!Directory.Exists(installLocation))
                    return;
                string updater = Path.Combine(installLocation, "PlaybackChanger_Installer.exe");
                if (!File.Exists(updater))
                    return;

                System.Diagnostics.Process.Start(updater);
                MayClose = true;
                this.Close();
            };
            try
            {
                _context.UpdateController.InstallUpdate(tag, worker);
            }
            finally
            {
                worker.Dispose();
            }
        }

        #endregion Events
    }
}