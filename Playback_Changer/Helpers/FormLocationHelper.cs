using System.Drawing;
using System.Windows.Forms;

namespace Playback_Changer.Helpers
{
    public class FormLocationHelper
    {
        public static Point GetLocation(Size size)
        {
            const int OFFSET = 12;

            int x, y;

            switch (TaskbarHelper.Taskbar.Position)
            {
                case TaskbarPosition.Left:
                    x = Screen.PrimaryScreen.WorkingArea.Left + OFFSET;
                    y = Screen.PrimaryScreen.WorkingArea.Bottom - size.Height;
                    break;
                case TaskbarPosition.Right:
                    x = Screen.PrimaryScreen.WorkingArea.Right - size.Width - OFFSET;
                    y = Screen.PrimaryScreen.WorkingArea.Bottom - size.Height;
                    break;
                case TaskbarPosition.Top:
                    x = Screen.PrimaryScreen.WorkingArea.Right - size.Width;
                    y = Screen.PrimaryScreen.WorkingArea.Top + OFFSET;
                    break;
                default:
                    x = Screen.PrimaryScreen.WorkingArea.Right - size.Width;
                    y = Screen.PrimaryScreen.WorkingArea.Bottom - size.Height - OFFSET;
                    break;
            }
            return new Point(x, y);
        }
    }
}