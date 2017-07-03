using System.Drawing;

namespace Playback_Changer.Eo
{
    public class VisualDeviceStyling
    {
        public Color BackColor { get; set; }
        public Color ForeColor { get; set; }
        public bool ShowPopover { get; set; }
        public bool ShowBorder { get; set; }

        public static VisualDeviceStyling GetSettingStyling()
        {
            return new VisualDeviceStyling()
            {
                BackColor = Color.White,
                ForeColor = Color.FromArgb(80, 80, 80),
                ShowPopover = true,
                ShowBorder = true
            };
        }
    }

}
