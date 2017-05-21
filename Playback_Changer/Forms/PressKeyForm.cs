using System.Windows.Forms;
using Playback_Changer.Helpers;
using System.Drawing;

namespace Playback_Changer.Forms
{
    public partial class PressKeyForm : Form
    {
        public Keys PressedKey { get; set; }

        public PressKeyForm(Form parent)
        {
            InitializeComponent();

            // Appearance
            this.Opacity = 0.95;
            int x = parent.Left + (parent.Width - this.Right + this.Left) / 2;
            int y = parent.Top + (parent.Height - this.Bottom + this.Top) / 2;
            this.Location = new Point(x, y);

            // Init
            PressedKey = Keys.None;
        }

        private bool SetKey(Keys key)
        {
            PressedKey = key;
            this.DialogResult = DialogResult.OK;
            return true;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (KeyHelper.IsValidKey(keyData))
                return SetKey(keyData);
            else if (keyData == Keys.Escape)
                this.DialogResult = DialogResult.Cancel;

            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
