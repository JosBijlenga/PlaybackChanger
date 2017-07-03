using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using Playback_Changer.Eo;
using System.Net;
using System.IO;
using SharpCompress.Archives;
using SharpCompress.Readers;
using System.ComponentModel;

namespace Playback_Changer.Controllers
{
    public class UpdateController
    {
        private Timer _updateCheckTimer = null;
        private const string LATEST_VERSION_URL = @"https://github.com/JosBijlenga/PlaybackChanger/tree/feature/Updater/Versions/Latest-version.txt";
        private bool _checkingUpdate = false;
        private bool _downloadingUpdate = false;

        public UpdateController()
        {
            // Check for updates every 3 hours
            _updateCheckTimer = new Timer()
            {
                Interval = 1000 * 60 * 60 * 3
            };
            _updateCheckTimer.Tick += UpdateCheckTimer_Tick;

            // Only check for updates 30 seconds after creation,
            // then start the with 3 hourly check.
            Timer delayTimer = new Timer()
            {
                Interval = 1000 * 30
            };
            delayTimer.Tick += delegate (object sender, EventArgs e)
            {
                delayTimer.Stop();
                delayTimer.Dispose();
                if (SettingsManager.Settings.CheckUpdate)
                    CheckForUpdate();
                _updateCheckTimer.Start();
            };
            delayTimer.Start();
        }

        private void UpdateCheckTimer_Tick(object sender, EventArgs e)
        {
            if (SettingsManager.Settings.CheckUpdate)
                CheckForUpdate();
        }

        public void InstallUpdate(VersionTag tag, BackgroundWorker worker)
        {
            var installLocation = PlaybackChanger_Installer.RegHelper.GetRegInstallPath();

            // Does the update dir still exist?
            string updateDir = Path.Combine(installLocation, "Update");
            if (!Directory.Exists(updateDir))
                return;

            var files = Directory.GetFiles(updateDir, $"{tag.Version.ToString()}.7z");
            // Someone must have deleted the file. Not gonna build build something to prevent sabotaging.
            if (files.Length <= 0)
                return;

            var options = new ExtractionOptions()
            {
                ExtractFullPath = true,
                Overwrite = true
            };
            var archive = ArchiveFactory.Open(files[0]);

            worker.DoWork += delegate (object sender, DoWorkEventArgs e)
            {
                try
                {
                    foreach (var entry in archive.Entries)
                        entry.WriteToDirectory(installLocation, options);
                }
                catch (Exception)
                {
                    OnRaiseUpdateFailure(new UpdateFailureEventArgs());
                }
            };
            worker.RunWorkerAsync();
        }

        public void DownloadUpdate(VersionTag tag)
        {
            // Already downloading?
            if (_downloadingUpdate)
                return;
            DownloadUpdateAsync(tag);
        }

        public void CheckForUpdate(bool fromUi = false)
        {
            // Already checking?
            if (_checkingUpdate)
                return;

            var installVersion = HasLocalUpdate();
            if (installVersion != null)
            {
                var currentVersion = GetCurrentVersion();
                // version in update folder higher than current version?
                if (installVersion.CompareTo(currentVersion) > 0)
                {
                    // Fire sync event Download
                    OnRaiseInstallAvailable(new InstallAvailableEventArgs(installVersion));
                }
            }
            else
            {
                // Fires async event UpdateAvailable
                CheckLatestVersionAsync(fromUi);
            }
        }

        private Version HasLocalUpdate()
        {
            string updateDir = Path.Combine(PlaybackChanger_Installer.RegHelper.GetRegInstallPath(), "Update");
            if (!Directory.Exists(updateDir))
                return null;

            var files = Directory.GetFiles(updateDir, "*.7z");
            if (files.Length > 0)
                return GetLatestVersionFromVersionFiles(files);

            return null;
        }

        private Version GetLatestVersionFromVersionFiles(string[] versions)
        {
            if (versions.Length <= 0)
                return new Version(); // returns (0.0.undefined(-1).undefined(-1))

            var latestVersion = new Version();
            // Get the latest update from the installed ones.
            foreach (var versionStr in versions)
            {
                try
                {
                    var version = new Version(Path.GetFileNameWithoutExtension(versionStr));
                    if (latestVersion.CompareTo(version) < 0)
                        latestVersion = version;
                }
                catch (Exception)
                {
                    // Invalid version, ignore
                }
            }

            return latestVersion;
        }

        private Version GetCurrentVersion()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(assembly.Location);
            return new Version(fvi.FileVersion);
        }

        private HttpWebRequest updateRequest;
        private void CheckLatestVersionAsync(bool fromUi = false)
        {
            _checkingUpdate = true;
            try
            {
                updateRequest = (HttpWebRequest)WebRequest.Create(LATEST_VERSION_URL);
                updateRequest.BeginGetResponse(new AsyncCallback(FinishUpdateRequest), fromUi);
            }
            catch (Exception)
            {
                // Exception won't occur after user interaction, yet, so no need to warn.
            }
        }

        private void FinishUpdateRequest(IAsyncResult result)
        {
            bool fromUi = false;
            try
            {
                string data = string.Empty;
                fromUi = (bool)result.AsyncState;

                using (HttpWebResponse response = (HttpWebResponse)updateRequest.EndGetResponse(result))
                using (Stream stream = response.GetResponseStream())
                using (StreamReader reader = new StreamReader(stream))
                {

                    data = reader.ReadToEnd();
                }

                if (string.IsNullOrWhiteSpace(data))
                    return;

                // data should be in format [version] [urlToNewVersion];
                string[] items = data.Split(' ');
                if (items.Length != 2)
                    return;

                var currentVersion = GetCurrentVersion();
                try
                {
                    var retrievedVersion = new Version(items[0]);
                    // retrievedVersion higher than currentVersion? Raise event.
                    if (retrievedVersion.CompareTo(currentVersion) > 0)
                    {
                        OnRaiseUpdateAvailable(new UpdateAvailableEventArgs(new VersionInfo(retrievedVersion, items[1])));
                    }
                    else
                    {
                        OnRaiseNoUpdateAvailable(new NoUpdateAvailableEventArgs());
                    }
                }
                catch (Exception e)
                {
                    if (fromUi)
                    {
                        OnRaiseNoUpdateAvailable(new NoUpdateAvailableEventArgs());
                    }
                    Console.WriteLine(e);
                    // invalid version, ignore.
                }

            }
            catch (Exception)
            {
                if (fromUi)
                {
                    OnRaiseNoUpdateAvailable(new NoUpdateAvailableEventArgs());
                }
                //Console.WriteLine(xe);
                // Exception won't occur after user interaction, yet, so no need to warn.
            }
            finally
            {
                _checkingUpdate = false;
            }
        }

        private HttpWebRequest downloadRequest;
        private void DownloadUpdateAsync(VersionTag tag)
        {
            _downloadingUpdate = true;
            try
            {
                downloadRequest = (HttpWebRequest)WebRequest.Create(tag.Url);
                downloadRequest.BeginGetResponse(new AsyncCallback(FinishDownloadUpdateRequest), null);
            }
            catch (Exception)
            {
                OnRaiseUpdateFailure(new UpdateFailureEventArgs());
            }
        }

        private string CreateUpdateDirectory()
        {
            string updateDir = Path.Combine(PlaybackChanger_Installer.RegHelper.GetRegInstallPath(), "Update");
            if (!Directory.Exists(updateDir))
                Directory.CreateDirectory(updateDir);
            return updateDir;
        }

        private void FinishDownloadUpdateRequest(IAsyncResult result)
        {
            try
            {
                string filename = string.Empty;
                using (HttpWebResponse response = (HttpWebResponse)downloadRequest.EndGetResponse(result))
                {
                    filename = Path.GetFileNameWithoutExtension(response.ResponseUri.AbsolutePath);
                    string fullFilename = Path.GetFileName(response.ResponseUri.AbsolutePath);
                    string absolutePath = Path.Combine(CreateUpdateDirectory(), fullFilename);
                    Console.WriteLine("Downloading update to path: " + absolutePath);

                    using (Stream stream = response.GetResponseStream())
                    using (FileStream fs = new FileStream(absolutePath, FileMode.Create))
                    {
                        var buffer = new byte[4096];
                        int bytesRead;

                        while ((bytesRead = stream.Read(buffer, 0, buffer.Length)) > 0)
                        {
                            fs.Write(buffer, 0, bytesRead);
                        }
                    }
                }

                try
                {
                    OnRaiseInstallAvailable(new InstallAvailableEventArgs(new Version(filename)));
                }
                catch (Exception)
                {
                    // Parsing of version went wrong.
                    OnRaiseUpdateFailure(new UpdateFailureEventArgs());
                }
            }
            catch (Exception)
            {
                OnRaiseUpdateFailure(new UpdateFailureEventArgs());
            }
            finally
            {
                _downloadingUpdate = false;
            }
        }


        public delegate void UpdateAvailableEventHandler(object sender, UpdateAvailableEventArgs e);
        public event UpdateAvailableEventHandler UpdateAvailable;
        protected virtual void OnRaiseUpdateAvailable(UpdateAvailableEventArgs e)
        {
            UpdateAvailable?.Invoke(this, e);
        }

        public class UpdateAvailableEventArgs : EventArgs
        {
            private VersionInfo _versionInfo;
            public VersionInfo VersionInfo { get { return _versionInfo; } }

            public UpdateAvailableEventArgs(VersionInfo versionInfo)
            {
                _versionInfo = versionInfo;
            }

            public override string ToString()
            {
                return _versionInfo.ToString();
            }
        }

        public delegate void NoUpdateAvailableEventHandler(object sender, NoUpdateAvailableEventArgs e);
        public event NoUpdateAvailableEventHandler NoUpdateAvailable;
        protected virtual void OnRaiseNoUpdateAvailable(NoUpdateAvailableEventArgs e)
        {
            NoUpdateAvailable?.Invoke(this, e);
        }

        public class NoUpdateAvailableEventArgs : EventArgs
        {
            public NoUpdateAvailableEventArgs()
            { }
        }


        public delegate void InstallAvailableEventHandler(object sender, InstallAvailableEventArgs e);
        public event InstallAvailableEventHandler InstallAvailable;
        protected virtual void OnRaiseInstallAvailable(InstallAvailableEventArgs e)
        {
            InstallAvailable?.Invoke(this, e);
        }

        public class InstallAvailableEventArgs : EventArgs
        {
            private Version _version;
            public Version Version { get { return _version; } }

            public InstallAvailableEventArgs(Version version)
            {
                _version = version;
            }

            public override string ToString()
            {
                return _version.ToString();
            }
        }

        public delegate void UpdateFailureEventHandler(object sender, UpdateFailureEventArgs e);
        public event UpdateFailureEventHandler UpdateFailure;
        protected virtual void OnRaiseUpdateFailure(UpdateFailureEventArgs e)
        {
            UpdateFailure?.Invoke(this, e);
        }

        public class UpdateFailureEventArgs : EventArgs
        {
            public UpdateFailureEventArgs()
            { }
        }
    }
}
