using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaybackChanger_Uninstaller
{
    public class Navigator
    {
        private FormMain _container;

        public Navigator(System.Windows.Forms.Form container)
        {
            _container = container as FormMain;
        }

        public void CancelInstall()
        {
            _container.CancelApplication();
        }
    }
}
