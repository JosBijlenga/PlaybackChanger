using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing;

namespace PlaybackChanger_Installer.Controls
{
    public class FlatButton : Button
    {
        public FlatButton()
        {
            this.BackColor = Color.FromArgb(236, 236, 240);
            this.ForeColor = Color.FromArgb(80, 80, 80);

            this.UseVisualStyleBackColor = false;
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.FlatAppearance.BorderColor = Color.FromArgb(215, 215, 215);
            this.FlatAppearance.MouseDownBackColor = Color.FromArgb(51, 153, 255);
            this.FlatAppearance.MouseOverBackColor = Color.FromArgb(201, 222, 245);

            this.MouseDown += FlatButton_MouseDown;
            this.MouseEnter += FlatButton_MouseEnter;
            this.MouseLeave += FlatButton_MouseLeave;

            SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.DoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);
            Redraw();
        }

        private void FlatButton_MouseDown(object sender, MouseEventArgs e)
        {
            this.BackColor = Color.FromArgb(51, 153, 255);
            this.FlatAppearance.BorderColor = Color.FromArgb(51, 153, 255);
            this.ForeColor = Color.White;
        }
        private void FlatButton_MouseEnter(object sender, EventArgs e)
        {
            //var button = sender as Button;
            this.BackColor = Color.FromArgb(201, 222, 245);
            this.ForeColor = Color.FromArgb(80, 80, 80);
            this.FlatAppearance.BorderColor = Color.FromArgb(51, 153, 255);
        }
        private void FlatButton_MouseLeave(object sender, EventArgs e)
        {
            //var button = sender as Button;
            this.BackColor = Color.FromArgb(236, 236, 240);
            this.ForeColor = Color.FromArgb(80, 80, 80);
            this.FlatAppearance.BorderColor = Color.FromArgb(204, 206, 219);
        }

        private void Redraw()
        {
            this.Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if (base.Enabled)
            {
                using (var pen = new Pen(base.FlatAppearance.BorderColor))
                    e.Graphics.DrawRectangle(pen, 0, 0, ClientSize.Width - 1, ClientSize.Height - 1);
            }
            else
            {
                using (var pen = new Pen(base.FlatAppearance.BorderColor))
                using (var brushBack = new SolidBrush(Color.FromArgb(245, 245, 245)))
                using (var brushFore = new SolidBrush(Color.FromArgb(180, 180, 180)))
                {
                    e.Graphics.FillRectangle(brushBack, e.ClipRectangle); // background
                    e.Graphics.DrawRectangle(pen, 0, 0, ClientSize.Width - 1, ClientSize.Height - 1); // border
                    e.Graphics.DrawString(base.Text, base.Font, // text
                        brushFore, (base.Width - e.Graphics.MeasureString(base.Text, base.Font).Width) / 2, (base.Height / 2) -
                        (e.Graphics.MeasureString(base.Text, base.Font).Height / 2));
                }
            }

        }
    }
}
