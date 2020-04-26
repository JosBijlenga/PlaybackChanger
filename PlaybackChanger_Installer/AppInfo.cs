using System;

namespace PlaybackChanger_Installer
{
    public static class AppInfo
    {
        /// <summary>
        /// Static constructor to initialize members.
        /// </summary>
        static AppInfo()
        {
            Name = "Playback Changer";
            RegName = "PlaybackChanger";
            Publisher = "Jos Bijlenga";
            Version = new Version(1, 1, 0, 0); // Major, Minor, Build, Revision
            UID = "{TYORHV-5Q4HZ0-CYW6EJ-6XHL3I-IDT7C5}";
        }

        /// <summary>
        /// The name of the application to be installed.
        /// </summary>
        public static string Name { get; }

        /// <summary>
        /// The registry name of the application to be installed.
        /// </summary>
        public static string RegName { get; }

        /// <summary>
        /// The publisher of the application to be installed.
        /// </summary>
        public static string Publisher { get; }

        /// <summary>
        /// The version of the application to be installed.
        /// </summary>
        public static Version Version { get; }

        /// <summary>
        /// The UID of the application to be installed.
        /// </summary>
        public static string UID { get; }
    }
}