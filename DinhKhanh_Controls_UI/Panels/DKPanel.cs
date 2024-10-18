using DinhKhanh_Controls_UI.Helper;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DinhKhanh_Controls_UI.Panels
{
    public partial class DKPanel : Panel
    {

        int borderSize = 0;
        Color _panelColor1 = Color.White;
        Color _panelColor2 = Color.White;

        Color _borderColor = Color.Black;

        public Color PanelColor1
        {
            get { return _panelColor1; }
            set { _panelColor1 = value; Invalidate(); }
        }
        public Color PanelColor2
        {
            get { return _panelColor2; }
            set { _panelColor2 = value; Invalidate(); }
        }
        public Color BorderColor
        {
            get { return _borderColor; }
            set { _borderColor = value; Invalidate(); }
        }

        public int BorderThickness
        {
            get { return borderSize; }
            set { borderSize = value; Invalidate(); }
        }

        int rad = 0;
        public int Radius
        {
            get { return rad; }
            set { rad = value; Invalidate(); }
        }

        LinearGradientMode _gradientMode = LinearGradientMode.Vertical;
        public LinearGradientMode LinearGradientMode
        {
            get { return _gradientMode; }
            set { _gradientMode = value; Invalidate(); }
        }


        public DKPanel()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.UserPaint, true);

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
            e.Graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
            e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;


            using (GraphicsPath gp = GraphicsHelper.GetRoundPath(ClientRectangle, rad))
            {
                using (LinearGradientBrush brush = new LinearGradientBrush(ClientRectangle, PanelColor1, PanelColor2, _gradientMode))
                {
                    e.Graphics.FillPath(brush, gp);
                }
                if (borderSize > 0)
                    using (Pen pen = new Pen(BorderColor, BorderThickness))
                    {
                        e.Graphics.DrawPath(pen, gp);
                    }
            }
        }


    }
}
