using System.Linq;

namespace Playback_Changer.Eo
{
    public class Settings
    {
        private bool _startOnSystemStart = false;
        public bool StartOnSystemStart
        {
            get
            {
                bool regValue = PlaybackChanger_Installer.RegHelper.GetRegRun();
                if (_startOnSystemStart != regValue)
                    _startOnSystemStart = regValue;
                return _startOnSystemStart;
            }
            set
            {
                bool changed = (_startOnSystemStart != value);
                _startOnSystemStart = value;

                if (changed)
                {
                    OnRaiseSettingChanged(new SettingChangedEventArgs(
                        Enums.Settings.StartOnSystemStart,
                        value
                    ));
                }
            }
        }

        private System.Collections.Generic.List<HotkeySetting> _hotkeys = null;
        public System.Collections.Generic.List<HotkeySetting> Hotkeys
        {
            get
            {
                if (_hotkeys == null)
                    Hotkeys = new System.Collections.Generic.List<HotkeySetting>();
                return _hotkeys;
            }
            set
            {
                bool changed = false;
                if (value != null)
                {
                    if (_hotkeys != null)
                        changed = (!_hotkeys.SequenceEqual(value, new HotkeySettingComparer()));
                    else
                        changed = true;
                }
                _hotkeys = value;

                if (changed)
                {
                    OnRaiseSettingChanged(new SettingChangedEventArgs(
                        Enums.Settings.Hotkeys,
                        value
                    ));
                }
            }
        }

        private System.Collections.Generic.List<string> _ignoredDevices = null;
        public System.Collections.Generic.List<string> IgnoredDevices
        {
            get
            {
                if (_ignoredDevices == null)
                    IgnoredDevices = new System.Collections.Generic.List<string>();
                return _ignoredDevices;
            }
            set
            {
                bool changed = false;
                if (value != null)
                {
                    if (_ignoredDevices != null)
                        changed = (!_ignoredDevices.SequenceEqual(value));
                    else
                        changed = true;
                }
                _ignoredDevices = value;

                if (changed)
                {
                    OnRaiseSettingChanged(new SettingChangedEventArgs(
                        Enums.Settings.IgnoredDevices,
                        value
                    ));
                }
            }
        }

        private System.Windows.Forms.Keys _activateKey = System.Windows.Forms.Keys.Q;
        public System.Windows.Forms.Keys ActivateKey
        {
            get
            {
                return _activateKey;
            }
            set
            {
                bool changed = (_activateKey != value);
                _activateKey = value;

                if (changed)
                {
                    OnRaiseSettingChanged(new SettingChangedEventArgs(
                        Enums.Settings.ActivateKey,
                        value
                    ));
                }
            }
        }

        private bool _firstLaunch = true;
        public bool FirstLaunch
        {
            get
            {
                return _firstLaunch;
            }
            set
            {
                bool changed = (_firstLaunch != value);
                _firstLaunch = value;

                if (changed)
                {
                    OnRaiseSettingChanged(new SettingChangedEventArgs(
                        Enums.Settings.FirstLaunch,
                        value
                    ));
                }
            }
        }

        private bool _checkUpdate = true;
        public bool CheckUpdate
        {
            get
            {
                return _checkUpdate;
            }
            set
            {
                bool changed = (_checkUpdate != value);
                _checkUpdate = value;

                if (changed)
                {
                    OnRaiseSettingChanged(new SettingChangedEventArgs(
                        Enums.Settings.CheckUpdate,
                        value
                    ));
                }
            }
        }
        

        public delegate void SettingChangedEventHandler(object sender, SettingChangedEventArgs e);
        public event SettingChangedEventHandler SettingChanged;
        protected virtual void OnRaiseSettingChanged(SettingChangedEventArgs e)
        {
            if (!_suspended)
                SettingChanged?.Invoke(this, e);
        }

        private bool _suspended = false;
        public void Suspend()
        {
            _suspended = true;
        }
        public void Resume()
        {
            _suspended = false;
        }

        public class SettingChangedEventArgs : System.EventArgs
        {
            private Enums.Settings _settings;
            public Enums.Settings Settings { get { return _settings; } }

            private object _value;
            public object Value { get { return _value; } }

            public SettingChangedEventArgs(Enums.Settings settings, object value)
            {
                _settings = settings;
                _value = value;
            }
        }
    }
}
