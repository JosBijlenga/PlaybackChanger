using System;
using System.Windows.Forms;

namespace Playback_Changer
{
    public static class Events
    {
        public delegate void ActivatedEventHandler(object sender, DeviceEventArgs e);

        public class DeviceEventArgs : EventArgs
        {
            private Eo.IDevice _device;
            public Eo.IDevice Device { get { return _device; } }

            private bool _active;
            public bool Active { get { return _active; } }

            public DeviceEventArgs(Eo.IDevice device, bool active)
            {
                _device = device;
                _active = active;
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
