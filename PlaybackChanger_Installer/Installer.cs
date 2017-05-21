using SharpCompress.Archives;
using SharpCompress.Readers;
using System.IO;
using System;
using System.ComponentModel;

namespace PlaybackChanger_Installer
{
    public class Installer
    {
        private InstallConfig _config;

        public Installer(InstallConfig config)
        {
            _config = config;
        }

        private long _totalSize = 0;
        private long _sizeProgress = 0;
        public void Start(BackgroundWorker worker)
        {
            var options = new ExtractionOptions()
            {
                ExtractFullPath = true,
                Overwrite = true
            };

            var archive = ArchiveFactory.Open(_config.InstallPackage);
            archive.FilePartExtractionBegin += delegate (object sender, SharpCompress.Common.FilePartExtractionBeginEventArgs e)
            {
                _sizeProgress += e.Size;
                worker.ReportProgress(((int)((_sizeProgress * 95) / _totalSize)), "Extracting: " + e.Name);
            };

            foreach (var entry in archive.Entries)
                _totalSize += entry.Size;

            worker.WorkerReportsProgress = true;
            worker.DoWork += delegate (object sender, DoWorkEventArgs e)
            {
                var backgroundWorker = sender as BackgroundWorker;
                foreach (var entry in archive.Entries)
                    entry.WriteToDirectory(_config.InstallLocation, options);
                worker.ReportProgress(98, "Adding registry entries: ");
                var exePath = Path.Combine(_config.InstallLocation, string.Format("{0}.exe", AppInfo.Name));
                var icoPath = Path.Combine(_config.InstallLocation, "icon.ico");
                if (_config.DesktopShortcut)
                    CreateShortcutHelper.AddShortcutToDesktop(exePath, icoPath);
                if (_config.StartmenuShortcut)
                    CreateShortcutHelper.AddShortcutToStartmenu(exePath, icoPath);
                if (_config.StartOnSystemStart)
                    RegHelper.SetRegRun(exePath);
                RegHelper.SetRegUninstall(_config.InstallLocation, icoPath);
                worker.ReportProgress(100, "Done");
            };
            worker.RunWorkerAsync();
        }
    }
}
