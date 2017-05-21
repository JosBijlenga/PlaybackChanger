using System;
using System.Windows.Forms;
using Playback_Changer.Helpers;
using System.Collections.Generic;
using static Playback_Changer.Eo.VisualDevice;

namespace Playback_Changer.Controllers
{
    public class DeviceController
    {

        #region Properties

        private SoundDeviceHelper _deviceHelper;
        private SoundDeviceHelper DeviceHelper
        {
            get
            {
                if (_deviceHelper == null)
                    _deviceHelper = new SoundDeviceHelper();
                return _deviceHelper;
            }
        }

        private Eo.VisualDevice[] _devices;
        public Eo.VisualDevice[] Devices
        {
            get
            {
                if (_devices == null)
                    UpdateDevices();
                return _devices;
            }
        }

        #endregion Properties

        #region Publics

        public void ActivateDeviceByHotkey(Keys key)
        {
            foreach (var device in Devices)
                if (device.Hotkey == key && !device.Default)
                    if (DeviceHelper.DefaultDeviceByIndex(device.Index))
                        device.Default = true;
        }

        public void RefreshDevices()
        {
            UpdateDevices();
        }

        #endregion Publics

        #region Privates

        private void UpdateDevices()
        {
            _devices = DeviceHelper.GetDevices();
            ApplyIgnoredDevices(_devices);
            ApplyHotkeys(_devices);
            Array.Sort(_devices);
            BindListeners(_devices);
        }

        private void ApplyIgnoredDevices(Eo.VisualDevice[] devices)
        {
            foreach (var device in devices)
                device.Ignored = SettingsManager.Settings.IgnoredDevices.Contains(device.Id);
        }

        private void ApplyHotkeys(Eo.VisualDevice[] devices)
        {
            foreach (var device in devices)
            {
                foreach (var setting in SettingsManager.Settings.Hotkeys)
                {
                    if (device.Id == setting.Id)
                    {
                        device.Hotkey = setting.Hotkey;
                        break;
                    }
                }
            }
        }

        private void BindListeners(Eo.VisualDevice[] devices)
        {
            foreach (var device in devices)
            {
                device.DefaultChanged += Device_DefaultChanged;
                device.IgnoredChanged += Device_IgnoredChanged;
                device.HotkeyChanged += Device_HotkeyChanged;
            }
        }

        private List<Eo.HotkeySetting> GetUpdatedHotkeys(Eo.VisualDevice[] devices)
        {
            var rtn = new List<Eo.HotkeySetting>();
            foreach (var device in devices)
                if (device.Hotkey != Keys.None)
                    rtn.Add(new Eo.HotkeySetting() { Id = device.Id, Hotkey = device.Hotkey });
            return rtn;
        }

        private List<string> GetUpdatedIgnoredDevices(Eo.VisualDevice[] devices)
        {
            var rtn = new List<string>();
            foreach (var device in devices)
                if (device.Ignored)
                    rtn.Add(device.Id);
            return rtn;
        }

        #endregion Privates

        #region EventListeners

        private void Device_DefaultChanged(object sender, DefaultChangedEventArgs e)
        {
            if (!e.Default)
                return;

            var device = sender as Eo.VisualDevice;
            if (device == null)
                return;

            DeviceHelper.DefaultDeviceByIndex(device.Index);
            foreach (var dev in _devices)
                if (dev != device)
                    dev.UndefaultDevice();
        }

        private void Device_IgnoredChanged(object sender, EventArgs e)
        {
            var device = sender as Eo.VisualDevice;
            if (device == null)
                return;

            SettingsManager.Settings.IgnoredDevices = GetUpdatedIgnoredDevices(_devices);
        }

        private void Device_HotkeyChanged(object sender, HotkeyChangedEventArgs e)
        {
            var device = sender as Eo.VisualDevice;
            if (device == null)
                return;

            foreach (var dev in _devices)
                if (dev.Hotkey == e.Hotkey && dev != device)
                    dev.NoneHotkey();

            SettingsManager.Settings.Hotkeys = GetUpdatedHotkeys(_devices);
        }

        #endregion EventListeners

    }
}
