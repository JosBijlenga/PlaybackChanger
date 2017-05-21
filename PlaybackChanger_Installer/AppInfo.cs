using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaybackChanger_Installer
{
    public static class AppInfo
    {
        /// <summary>
        /// Static constructor to initialize members.
        /// </summary>
        static AppInfo()
        {
            _name = "Playback Changer";
            _regName = "PlaybackChanger";
            _publisher = "Jos Bijlenga";
            _version = new Version(1, 0, 0, 2); // Major, Minor, Build, Revision
            _uid = "{TYORHV-5Q4HZ0-CYW6EJ-6XHL3I-IDT7C5}";
        }

        /// <summary>
        /// The name of the application to be installed.
        /// </summary>
        private static string _name;
        public static string Name
        {
            get { return _name; }
        }

        /// <summary>
        /// The registry name of the application to be installed.
        /// </summary>
        private static string _regName;
        public static string RegName
        {
            get { return _regName; }
        }

        /// <summary>
        /// The publisher of the application to be installed.
        /// </summary>
        private static string _publisher;
        public static string Publisher
        {
            get { return _publisher; }
        }

        /// <summary>
        /// The version of the application to be installed.
        /// </summary>
        private static Version _version;
        public static Version Version
        {
            get { return _version; }
        }

        /// <summary>
        /// The UID of the application to be installed.
        /// </summary>
        private static string _uid;
        public static string UID
        {
            get { return _uid; }
        }
    }
}
