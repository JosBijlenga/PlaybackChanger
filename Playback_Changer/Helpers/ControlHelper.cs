using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playback_Changer.Helpers
{
    class ControlHelper
    {
        public static void SetToggleSwitchWithoutAnimation(bmControlLibrary.bmToggleSwitch toggleSwitch, bool value)
        {
            toggleSwitch.UseAnimation = false;
            toggleSwitch.Checked = value;
            toggleSwitch.UseAnimation = true;
        }
    }
}
