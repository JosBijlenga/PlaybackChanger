using System;
using Microsoft.Win32;

namespace PlaybackChanger_Installer
{
    public static class RegHelper
    {
        public static string GetRegInstallPath()
        {
            return Registry.GetValue(string.Format(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Uninstall\{0}", AppInfo.RegName), "InstallLocation", null) as string;
        }

        public static void SetRegRun(string applicationExePath)
        {
            var rkApp = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true);
            rkApp.SetValue(AppInfo.RegName, string.Format("{0} 0", applicationExePath), RegistryValueKind.String);
        }

        public static void RemoveRegRun()
        {
            var keyName = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Run";
            using (var key = Registry.CurrentUser.OpenSubKey(keyName, true))
            {
                if (key != null)
                    key.DeleteValue(AppInfo.RegName, false);
            }
        }

        public static bool GetRegRun()
        {
            var rkApp = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", false);
            return rkApp.GetValue(AppInfo.RegName) != null;
        }

        public static void SetRegUninstall(string installLocation, string applicationIco)
        {
            var regRoot = string.Format(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Uninstall\{0}", AppInfo.RegName);
            Registry.SetValue(regRoot, "DisplayName", AppInfo.Name, RegistryValueKind.String);
            Registry.SetValue(regRoot, "DisplayVersion", AppInfo.Version.ToString(), RegistryValueKind.String);
            Registry.SetValue(regRoot, "InstallDate", DateTime.Now, RegistryValueKind.String);
            Registry.SetValue(regRoot, "InstallLocation", installLocation, RegistryValueKind.String);
            Registry.SetValue(regRoot, "NoModify", 1, RegistryValueKind.DWord);
            Registry.SetValue(regRoot, "NoRepair", 1, RegistryValueKind.DWord);
            Registry.SetValue(regRoot, "Publisher", AppInfo.Publisher, RegistryValueKind.String);
            Registry.SetValue(regRoot, "UninstallString", string.Format(@"{0}\{1}", installLocation, "PlaybackChanger_Uninstaller.exe"), RegistryValueKind.String);
            Registry.SetValue(regRoot, "QuietUninstallString", string.Format(@"{0}\{1}", installLocation, "PlaybackChanger_Uninstaller.exe"), RegistryValueKind.String);
            Registry.SetValue(regRoot, "DisplayIcon", applicationIco, RegistryValueKind.String);
        }


        public static void RemoveRegUninstall()
        {
            var keyName = @"Software\Microsoft\Windows\CurrentVersion\Uninstall";
            using (var key = Registry.CurrentUser.OpenSubKey(keyName, true))
            {
                if (key != null)
                    key.DeleteSubKey(AppInfo.RegName, false);
            }
        }
    }
}
