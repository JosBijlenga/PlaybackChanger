using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playback_Changer.Eo
{

    public class VersionTag : VersionInfo
    {
        private string _tag;
        public string Tag { get { return _tag; } }

        public VersionTag() : base()
        {
            _tag = string.Empty;
        }

        public VersionTag(Version version, string url, string tag) : base(version, url)
        {
            _tag = tag;
        }

        public override string ToString()
        {
            return $"{base.ToString()}; Tag: {_tag}";
        }
    }

}
