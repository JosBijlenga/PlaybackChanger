using System.Drawing;
using System.Windows.Forms;
using Playback_Changer.Enums;
using Playback_Changer.Eo;
using Playback_Changer.Helpers;

namespace Playback_Changer.Forms
{
    public partial class PlaybackChangedForm : Form
    {
        private Color _backColor;
        private Color _foreColor;

        private readonly Size mySize = new Size(360, 100);

        public PlaybackChangedForm(IDevice device)
        {
            InitializeComponent();

            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.DoubleBuffer, true);

            this.Location = FormLocationHelper.GetLocation(mySize);
            SetColors();
            this.labelDevice.Text = device.DeviceName;
        }

        public static void ShowForDevice(VisualDevice device)
        {
            var timer = new Timer
            {
                Interval = 3 * 1000
            };
            var form = new PlaybackChangedForm(device);

            timer.Tick += (sender, args) =>
            {
                form.Close();
                timer.Stop();
                timer.Dispose();
            };

            form.Show();
            timer.Start();
        }

        private void SetColors()
        {
            _backColor = ImmersiveColorHelper.GetColor(ImmersiveColors.ImmersiveStartBackground);
            _foreColor = ImmersiveColorHelper.GetColor(ImmersiveColors.ImmersiveStartPrimaryText);

            this.BackColor = _backColor;
            this.ForeColor = _foreColor;
        }
    }
}