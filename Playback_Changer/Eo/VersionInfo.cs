using System;

namespace Playback_Changer.Eo
{
    public class VersionInfo
    {
        private Version _version;
        public Version Version
        {
            get { return _version; }
            protected set
            {
                _version = value;
            }
        }

        private string _url;
        public string Url
        {
            get { return _url; }
            protected set
            {
                _url = value;
            }
        }

        public VersionInfo() : this(new Version(), string.Empty)
        { }

        public VersionInfo(Version version) : this(version, string.Empty)
        { }

        public VersionInfo(Version version, string url)
        {
            _version = version;
            _url = url;
        }

        public override string ToString()
        {
            return string.Format("Version: {0}; Url: {1}", _version, _url);
        }
    }
}
