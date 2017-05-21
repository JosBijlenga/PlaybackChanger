using System;
using IWshRuntimeLibrary;
using System.IO;

namespace PlaybackChanger_Installer
{
    public static class CreateShortcutHelper
    {
        /// <summary>
        /// Add a shortcut to the startmenu.
        /// </summary>
        /// <param name="pathToExe">The absolute path to the executable.</param>
        /// <param name="pathToIco">The absolute path to the icon.</param>
        /// <param name="appName">The name of the application.</param>
        /// <param name="description">The description of the application. Defaults to appName.</param>
        public static void AddShortcutToStartmenu(string pathToExe, string pathToIco)
        {
            string startMenuPath = Environment.GetFolderPath(Environment.SpecialFolder.StartMenu);
            string appStartMenuPath = Path.Combine(startMenuPath, "Programs", AppInfo.Name);

            if (!Directory.Exists(appStartMenuPath))
                Directory.CreateDirectory(appStartMenuPath);

            string shortcutLocation = Path.Combine(appStartMenuPath, string.Format("{0}" + ".lnk", AppInfo.Name));
            WshShell shell = new WshShell();
            IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(shortcutLocation);

            shortcut.Description = AppInfo.Name;
            shortcut.IconLocation = @pathToIco;
            shortcut.TargetPath = @pathToExe;
            shortcut.Save();
        }

        /// <summary>
        /// Add a shortcut to the desktop.
        /// </summary>
        /// <param name="pathToExe">The absolute path to the executable.</param>
        /// <param name="pathToIco">The absolute path to the icon.</param>
        /// <param name="appName">The name of the application.</param>
        /// <param name="description">The description of the application. Defaults to appName.</param>
        public static void AddShortcutToDesktop(string pathToExe, string pathToIco)
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            if (!Directory.Exists(desktopPath))
                return; // We don't create desktop

            string shortcutLocation = Path.Combine(desktopPath, string.Format("{0}" + ".lnk", AppInfo.Name));
            WshShell shell = new WshShell();
            IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(shortcutLocation);

            shortcut.Description = AppInfo.Name;
            shortcut.IconLocation = @pathToIco;
            shortcut.TargetPath = @pathToExe;
            shortcut.Save();
        }
    }
}
