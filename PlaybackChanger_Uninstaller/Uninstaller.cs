using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlaybackChanger_Installer;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace PlaybackChanger_Uninstaller
{
    public class Uninstaller
    {
        private InstallConfig _config;

        public Uninstaller(InstallConfig config)
        {
            _config = config;
        }

        public void Start(BackgroundWorker worker)
        {
            worker.WorkerReportsProgress = true;
            worker.DoWork += delegate (object sender, DoWorkEventArgs e)
            {
                // remove all files from install dir.
                //_config.InstallLocation = "::::"; // testing
                if (!Directory.Exists(_config.InstallLocation))
                {
                    worker.ReportProgress(5, "Uninstall directory doesn't exist");
                    e.Result = "Uninstall directory doesn't exist";
                    return;
                }

                try
                {
                    int progress = 0;
                    var uninstallerFile = Application.ExecutablePath;
                    var files = Directory.GetFiles(_config.InstallLocation);
                    for (int i = 0; i < files.Length; i++)
                    {
                        if (!files[i].Equals(uninstallerFile))
                        {
                            if (File.Exists(files[i]))
                            {
                                File.Delete(files[i]);
                                progress = ((int)((i * 100) / (files.Length - 1)));
                                worker.ReportProgress(progress, "Removing: " + files[i]);
                            }
                        }
                    }

                    // remove possible shortcut and startmenu shortcut
                    string startMenuPath = Environment.GetFolderPath(Environment.SpecialFolder.StartMenu);
                    string appStartMenuPath = Path.Combine(startMenuPath, "Programs", AppInfo.Name);
                    if (Directory.Exists(appStartMenuPath))
                        Directory.Delete(appStartMenuPath, true);

                    string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                    string shortcutLocation = Path.Combine(desktopPath, string.Format("{0}" + ".lnk", AppInfo.Name));
                    if (File.Exists(shortcutLocation))
                        File.Delete(shortcutLocation);

                    worker.ReportProgress(progress, string.Format("Removing {0} registry entries", AppInfo.Name));

                    // remove registry entries
                    RegHelper.RemoveRegRun();
                    RegHelper.RemoveRegUninstall();

                    worker.ReportProgress(100, "Done");
                    e.Result = null;
                }
                catch
                {
                    e.Result = "Something went wrong";
                    worker.ReportProgress(100, "Something went wrong");
                    return;
                }
            };

            worker.RunWorkerAsync();
        }
    }
}
