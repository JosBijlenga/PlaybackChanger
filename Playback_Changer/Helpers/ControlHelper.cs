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
