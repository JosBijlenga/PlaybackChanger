using System;
using System.Windows.Forms;

namespace Playback_Changer.Helpers
{
    public static class ExceptionHelper
    {
        public static void TerminateWithMessage(string message)
        {
            MessageBox.Show(
                "An error occured: " + Environment.NewLine + message + 
                Environment.NewLine + "Application will terminate now.",
                "Playback Changer error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
    }
}
