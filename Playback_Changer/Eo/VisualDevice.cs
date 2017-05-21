using System;
using System.Drawing;
using System.Windows.Forms;

namespace Playback_Changer.Eo
{
    public partial class VisualDevice : UserControl, IDevice
    {
        #region Properties

        private int _index;
        public int Index
        {
            get => _index;
            set => _index = value;
        }

        private string _deviceName;
        public string DeviceName
        {
            get => _deviceName;
            set => _deviceName = value;
        }

        private DeviceState _state;
        public DeviceState State
        {
            get => _state;
            set
            {
                _state = value;
                UpdateSortOrder();
            }
        }

        private bool _default;
        public bool Default
        {
            get => _default;
            set
            {
                _default = value;
                bmToggleSwitchDefault.Checked = value;
                UpdateSortOrder();
                UpdateTogleSwitchEnabled();
                UpdateDeviceStateColor();
                RaiseDefaultChanged(new DefaultChangedEventArgs(value));
            }
        }

        private string _description;
        public string Description
        {
            get => _description;
            set => _description = value;
        }

        private string _interfaceName;
        public string InterfaceName
        {
            get => _interfaceName;
            set => _interfaceName = value;
        }

        private string _id;
        public string Id
        {
            get => _id;
            set => _id = value;
        }

        private Keys _hotkey;
        public Keys Hotkey
        {
            get => _hotkey;
            set
            {
                _hotkey = value;
                labelHotkey.Text = (Hotkey == Keys.None) ? string.Empty : Hotkey.ToString();
                RaiseHotkeyChanged(new HotkeyChangedEventArgs(value));
            }
        }

        private bool _ignored;
        public bool Ignored
        {
            get => _ignored;
            set
            {
                _ignored = value;
                UpdateSortOrder();
                UpdateTogleSwitchEnabled();
                UpdateDeviceStateColor();
                RaiseIgnoredChanged(new IgnoredChangedEventArgs(value));
            }
        }

        private int _sortOrder;
        public int SortOrder
        {
            get => _sortOrder;
            set => _sortOrder = value;
        }

        #endregion Properties

        #region Constructor

        public VisualDevice(int index, string name, DeviceState state, int isDefault, string description, string interfaceName, string id)
        {
            InitializeComponent();

            // Initializing fields
            _index = index;
            _deviceName = name;
            _state = state;
            _default = (isDefault == 1);
            _description = description;
            _interfaceName = interfaceName;
            _id = id;
            _hotkey = Keys.None;
            _sortOrder = GetSortOrder(); // Make sure this one is set last

            // Initializing visuals
            borderPanelMain.SuspendLayout();
            Helpers.ControlHelper.SetToggleSwitchWithoutAnimation(bmToggleSwitchDefault, Default);
            bmToggleSwitchDefault.Enabled = ToggleSwitchEnabled();
            labelDeviceName.MaximumSize = new Size(210, 40);
            labelDeviceName.Text = DeviceName;
            buttonPopover.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            borderPanelMain.ResumeLayout(true);
        }

        #endregion Constructor

        private void UpdateTogleSwitchEnabled()
        {
            bmToggleSwitchDefault.Enabled = ToggleSwitchEnabled();
        }
        private bool ToggleSwitchEnabled()
        {
            return !Default && !Ignored && State == DeviceState.Active;
        }

        private void UpdateSortOrder()
        {
            SortOrder = GetSortOrder();
        }
        private int GetSortOrder()
        {
            if (Default)
                return 0;

            if (Ignored)
                return 2;

            switch (State)
            {
                case DeviceState.Active: return 1;
                case DeviceState.Disabled: return 3;
                case DeviceState.Unplugged: return 4;
                case DeviceState.NotPresent: return 5;
                default: return 6;
            }
        }

        private void UpdateDeviceStateColor()
        {
            borderPanelMain.BorderColor = GetDeviceStateColor();
        }
        private Color GetDeviceStateColor()
        {
            if (Default)
                return Helpers.Constants.DefaultColor;

            if (Ignored)
                return Helpers.Constants.IgnoredColor;

            switch (State)
            {
                case DeviceState.Active:
                    return Helpers.Constants.ActiveColor;
                case DeviceState.Disabled:
                    return Helpers.Constants.DisabledColor;
                case DeviceState.NotPresent:
                    return Helpers.Constants.NotPresentColor;
                case DeviceState.Unplugged:
                    return Helpers.Constants.UnpluggedColor;
                default:
                    return Color.Black;
            }
        }

        public void AddToControl(Control parent, VisualDeviceStyling style)
        {
            borderPanelMain.SuspendLayout();
            try
            {
                borderPanelMain.BorderColor = GetDeviceStateColor();
                labelHotkey.Text = (Hotkey == Keys.None) ? string.Empty : Hotkey.ToString();

                this.BackColor = style.BackColor;
                this.ForeColor = style.ForeColor;
                labelDeviceName.ForeColor = style.ForeColor;
                labelHotkey.ForeColor = style.ForeColor;
                if (style.ShowPopover)
                {
                    buttonPopover.Visible = true;
                    buttonPopover.BackgroundImage = Properties.Resources.popover;
                }
                else
                {
                    buttonPopover.Visible = false;
                    labelDeviceName.MaximumSize = new Size(245, 40);
                }
                borderPanelMain.LeftBorder = style.ShowBorder;

                this.Parent = parent;
                parent.Controls.Add(this);
                this.Dock = DockStyle.Top;
            }
            finally
            {
                borderPanelMain.ResumeLayout(true);
            }
        }

        public override string ToString()
        {
            return DeviceName;
        }

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;
            if (obj is IDevice device)
                return this.SortOrder.CompareTo(device.SortOrder);
            else
                return 1;
        }

        public void UndefaultDevice()
        {
            _default = false;
            bmToggleSwitchDefault.Checked = false;
        }
        public void NoneHotkey()
        {
            _hotkey = Keys.None;
            labelHotkey.Text = (Hotkey == Keys.None) ? string.Empty : Hotkey.ToString();
        }

        private void UpdateContextMenuStripValues()
        {
            if (!Ignored)
            {
                f1ToolStripMenuItem.Checked = (Hotkey == Keys.F1);
                f2ToolStripMenuItem.Checked = (Hotkey == Keys.F2);
                f3ToolStripMenuItem.Checked = (Hotkey == Keys.F3);
                noneToolStripMenuItem.Checked = (Hotkey == Keys.None);
            }
            hotkeyToolStripMenuItem.Enabled = !Ignored;
            ignoredToolStripMenuItem.Checked = Ignored;
        }


        private void BmToggleSwitchDefault_CheckedChanged(object sender, EventArgs e)
        {
            Default = bmToggleSwitchDefault.Checked;
        }

        private void ButtonPopover_MouseDown(object sender, MouseEventArgs e)
        {
            UpdateContextMenuStripValues();
            contextMenuStripDevice.Show(Cursor.Position);
        }
        private void F1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hotkey = Keys.F1;
        }
        private void F2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hotkey = Keys.F2;
        }
        private void F3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hotkey = Keys.F3;
        }
        private void NoneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hotkey = Keys.None;
        }
        private void IgnoredToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ignored = !Ignored;
            borderPanelMain.BorderColor = GetDeviceStateColor();
        }

        #region Events

        public delegate void DefaultChangedEventHandler(object sender, DefaultChangedEventArgs e);
        public event DefaultChangedEventHandler DefaultChanged;
        protected virtual void RaiseDefaultChanged(DefaultChangedEventArgs e)
        {
            DefaultChanged?.Invoke(this, e);
        }

        public delegate void IgnoredChangedEventHandler(object sender, IgnoredChangedEventArgs e);
        public event IgnoredChangedEventHandler IgnoredChanged;
        protected virtual void RaiseIgnoredChanged(IgnoredChangedEventArgs e)
        {
            IgnoredChanged?.Invoke(this, e);
        }

        public delegate void HotkeyChangedEventHandler(object sender, HotkeyChangedEventArgs e);
        public event HotkeyChangedEventHandler HotkeyChanged;
        protected virtual void RaiseHotkeyChanged(HotkeyChangedEventArgs e)
        {
            HotkeyChanged?.Invoke(this, e);
        }

        #endregion Events


        #region EventArgs

        public class DefaultChangedEventArgs : EventArgs
        {
            private bool _default;
            public bool Default { get { return _default; } }

            public DefaultChangedEventArgs(bool isDefault)
            {
                _default = isDefault;
            }
        }

        public class IgnoredChangedEventArgs : EventArgs
        {
            private bool _ignored;
            public bool Ignored { get { return _ignored; } }

            public IgnoredChangedEventArgs(bool ignored)
            {
                _ignored = ignored;
            }
        }

        public class HotkeyChangedEventArgs : EventArgs
        {
            private Keys _hotkey;
            public Keys Hotkey { get { return _hotkey; } }

            public HotkeyChangedEventArgs(Keys hotkey)
            {
                _hotkey = hotkey;
            }
        }

        #endregion EventArgs
    }
}
