using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaybackChanger_Installer
{
    public class InstallConfig
    {
        public string InstallLocation { get; set; }
        public bool DesktopShortcut { get; set; }
        public bool StartmenuShortcut { get; set; }
        public bool StartOnSystemStart { get; set; }
        public string InstallPackage { get; set; }
    }
}
