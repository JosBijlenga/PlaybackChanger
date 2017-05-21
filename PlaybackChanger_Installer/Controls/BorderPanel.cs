using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing;

namespace PlaybackChanger_Installer.Controls
{
    public class BorderPanel : Panel
    {
        #region Properties

        private Color _borderColor = Color.Black;
        [Description("The color of the border"), Category("Border")]
        public Color BorderColor
        {
            get { return _borderColor; }
            set
            {
                _borderColor = value;
                Redraw();
            }
        }

        private bool _topBorder = false;
        [Description("Indicates whether a border should be drawn on the top of the panel"), Category("Border")]
        public bool TopBorder
        {
            get { return _topBorder; }
            set
            {
                _topBorder = value;
                Redraw();
            }
        }

        private int _topBorderWidth = 1;
        [Description("The width of the topborder"), Category("Border")]
        public int TopBorderWidth
        {
            get { return _topBorderWidth; }
            set
            {
                if (value > 0)
                    _topBorderWidth = value;
                else
                    _topBorderWidth = 0;
                Redraw();
            }
        }

        private bool _rightBorder = false;
        [Description("Indicates whether a border should be drawn on the right side of the panel"), Category("Border")]
        public bool RightBorder
        {
            get { return _rightBorder; }
            set
            {
                _rightBorder = value;
                Redraw();
            }
        }

        private int _rightBorderWidth = 1;
        [Description("The width of the topborder"), Category("Border")]
        public int RightBorderWidth
        {
            get { return _rightBorderWidth; }
            set
            {
                if (value > 0)
                    _rightBorderWidth = value;
                else
                    _rightBorderWidth = 0;
                Redraw();
            }
        }

        private bool _bottomBorder = false;
        [Description("Indicates whether a border should be drawn on the bottom of the panel"), Category("Border")]
        public bool BottomBorder
        {
            get { return _bottomBorder; }
            set
            {
                _bottomBorder = value;
                Redraw();
            }
        }

        private int _bottomBorderWidth = 1;
        [Description("The width of the topborder"), Category("Border")]
        public int BottomBorderWidth
        {
            get { return _bottomBorderWidth; }
            set
            {
                if (value > 0)
                    _bottomBorderWidth = value;
                else
                    _bottomBorderWidth = 0;
                Redraw();

            }
        }

        private bool _leftBorder = false;
        [Description("Indicates whether a border should be drawn on the left side of the panel"), Category("Border")]
        public bool LeftBorder
        {
            get { return _leftBorder; }
            set
            {
                _leftBorder = value;
                Redraw();
            }
        }

        private int _leftBorderWidth = 1;
        [Description("The width of the topborder"), Category("Border")]
        public int LeftBorderWidth
        {
            get { return _leftBorderWidth; }
            set
            {
                if (value > 0)

                    _leftBorderWidth = value;
                else
                    _leftBorderWidth = 0;
                Redraw();

            }
        }

        #endregion Properties

        private void Redraw()
        {
            this.Invalidate();
        }

        public BorderPanel()
        {
            SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.DoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);
            Redraw();
        }

        /// <summary>
        /// Draw the borders
        /// </summary>
        /// <param name="e">Paintarguments</param>
        protected override void OnPaint(PaintEventArgs e)
        {
            // Draw the background
            using (var backBrush = new SolidBrush(BackColor))
            using (var borderBrush = new SolidBrush(BorderColor))
            {
                e.Graphics.FillRectangle(backBrush, ClientRectangle);

                if (TopBorder)
                    e.Graphics.FillRectangle(borderBrush, 0, 0, ClientSize.Width, TopBorderWidth);
                if (RightBorder)
                    e.Graphics.FillRectangle(borderBrush, ClientSize.Width - RightBorderWidth, 0, RightBorderWidth, ClientSize.Height);
                if (BottomBorder)
                    e.Graphics.FillRectangle(borderBrush, 0, ClientSize.Height - BottomBorderWidth, ClientSize.Width, BottomBorderWidth);
                if (LeftBorder)
                    e.Graphics.FillRectangle(borderBrush, 0, 0, LeftBorderWidth, ClientSize.Height);

            }
        }

    }
}
