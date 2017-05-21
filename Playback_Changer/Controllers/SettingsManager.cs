using System;
using Newtonsoft.Json;
using System.IO;
using PlaybackChanger_Installer;

namespace Playback_Changer.Controllers
{
    public class SettingsManager
    {
        private static Eo.Settings _settings;
        public static Eo.Settings Settings
        {
            get
            {
                if (_settings == null)
                {
                    var settingsFile = GetSettingsPath();
                    if (!File.Exists(settingsFile))
                    {
                        _settings = WriteDefaultSettings(settingsFile);
                    }
                    else
                    {
                        _settings = ReadSettings(settingsFile);
                    }

                    BindSettingChangedEvent(_settings);
                }

                return _settings;
            }
        }

        private static string GetSettingsPath()
        {
            string settingsPath = RegHelper.GetRegInstallPath() ?? Environment.CurrentDirectory ?? null;
            if (string.IsNullOrWhiteSpace(settingsPath))
            {
                throw new DirectoryNotFoundException("Can't find settings directory");
            }

            return Path.Combine(settingsPath, "Settings.json");
        }

        private static void BindSettingChangedEvent(Eo.Settings settings)
        {
            settings.SettingChanged += Settings_SettingChanged;
        }
        private static void Settings_SettingChanged(object sender, EventArgs e)
        {
            if (sender is Eo.Settings settings)
                _settings = WriteSettings(GetSettingsPath(), settings);
        }


        private static Eo.Settings WriteDefaultSettings(string path)
        {
            var settings = new Eo.Settings();
            return WriteSettings(path, settings);
        }

        private static Eo.Settings WriteSettings(string path, Eo.Settings settings)
        {
            var json = JsonConvert.SerializeObject(settings);
            File.WriteAllText(path, json);
            return settings;
        }

        private static Eo.Settings ReadSettings(string path)
        {
            using (StreamReader r = new StreamReader(path))
            {
                string json = r.ReadToEnd();
                return JsonConvert.DeserializeObject<Eo.Settings>(json);
            }
        }

    }
}
