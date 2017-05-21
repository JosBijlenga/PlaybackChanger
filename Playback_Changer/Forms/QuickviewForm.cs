using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Playback_Changer.Controllers;
using Playback_Changer.Enums;
using Playback_Changer.Helpers;

namespace Playback_Changer.Forms
{
    public partial class QuickviewForm : Form
    {
        private Color _backColor;
        private Color _borderColor;
        private Color _foreColor;

        private Color _deviceControlBackColor;
        private Color _deviceControlHoverColor;

        private const int Offset = 12;

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
                    x = taskbar.Bounds.X + taskbar.Bounds.Width + Offset;
                    y = taskbar.Bounds.Height - (this.Size.Height);
                    break;
                case TaskbarPosition.Right:
                    x = taskbar.Bounds.X - this.Size.Width - Offset;
                    y = taskbar.Bounds.Height - (this.Size.Height);
                    break;
                case TaskbarPosition.Top:
                    x = taskbar.Bounds.Width - (this.Size.Width);
                    y = taskbar.Bounds.Height + Offset;
                    break;
                case TaskbarPosition.Bottom:
                default:
                    x = taskbar.Bounds.Width - (this.Size.Width);
                    y = taskbar.Bounds.Y - (this.Size.Height + Offset);
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

        #region Events

        /// <summary>
        /// The window was activated/gained focus.
        /// Update the colors for they could have changed, repopulated accordingly.
        /// </summary>
        private void View_Activated(object sender, EventArgs e)
        {
            _context.DeviceController.RefreshDevices();
            this.Activate(); // Makes sure deactivated will always be triggered
            this.Location = SetQuickviewLocation();
            SetColors();
            PopulateDevices(_context.DeviceController.Devices);
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

        #endregion Events
    }
}