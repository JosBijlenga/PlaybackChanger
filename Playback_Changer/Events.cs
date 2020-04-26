using System;
using System.Windows.Forms;

namespace Playback_Changer
{
    public static class Events
    {
        public delegate void ActivatedEventHandler(object sender, DeviceEventArgs e);

        public class DeviceEventArgs : EventArgs
        {
            public Eo.IDevice Device { get; }

            public bool Active { get; }

            public DeviceEventArgs(Eo.IDevice device, bool active)
            {
                Device = device;
                Active = active;
            }
        }

        public delegate void HotkeyChangedEventHandler(object sender, HotkeyChangedEventArgs e);

        public class HotkeyChangedEventArgs : EventArgs
        {
            private Eo.IDevice _device;
            public Eo.IDevice Device { get { return _device; } }

            private Keys _key;
            public Keys Key { get { return _key; } }

            public HotkeyChangedEventArgs(Eo.IDevice device, Keys key)
            {
                _device = device;
                _key = key;
            }
        }

        public delegate void IgnoredDeviceRemovedEventHandler(object sender, EventArgs e);
    }
}