using DinhKhanh_Controls_UI.Enums;
using DinhKhanh_Controls_UI.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DinhKhanh_Controls_UI.Other
{
    public partial class DKCard : Control
    {

        [Browsable(false)]
        public Color BackColor { get; set; }

        [Browsable(false)]
        public Color ForeColor { get; set; }


        public DKCard()
        {
            SetStyle(ControlStyles.SupportsTransparentBackColor | ControlStyles.OptimizedDoubleBuffer, true);

        }

        Color barColor1 = ColorHelper.NormalColor;
        public Color BarColor1
        {
            get { return barColor1; }
            set
            {
                barColor1 = value;
                Invalidate();
            }
        }

        Color barColor2 = ColorHelper.HoverColor;
        public Color BarColor2
        {
            get { return barColor2; }
            set
            {
                barColor2 = value;
                Invalidate();
            }
        }

        int barThickness = 1;
        public int BarThickness
        {
            get { return barThickness; }
            set
            {
                barThickness = value; Invalidate();
            }
        }

        int Rad = 0;
        public int Radius
        {
            get { return Rad; }
            set
            {
                Rad = value; Invalidate();
            }
        }

        int borderThickness = 0;
        public int BorderThickness
        {
            get { return borderThickness; }
            set
            {
                borderThickness = value; Invalidate();
            }
        }

        ContentLayoutAlign contentAlignment = ContentLayoutAlign.Top;
        public ContentLayoutAlign BarAlignment
        {
            get { return contentAlignment; }
            set
            {
                contentAlignment = value; Invalidate();
            }
        }

        Color borderColor = Color.Gray;
        public Color BorderColor
        {
            get { return borderColor; }
            set
            {
                borderColor = value; Invalidate();
            }
        }

        int angle = 0;
        public int BrushAngle
        {
            get { return angle; }
            set
            {
                angle = value; Invalidate();
            }
        }


        Color cardColor1 = Color.WhiteSmoke;
        public Color CardColor1
        {
            get { return cardColor1; }
            set
            {
                cardColor1 = value; Invalidate();
            }
        }

        Color cardColor2 = Color.WhiteSmoke;
        public Color CardColor2
        {
            get { return cardColor2; }
            set
            {
                cardColor2 = value; Invalidate();
            }
        }

        Padding shadowPadding = new Padding(0);
        public Padding ShadowPadding
        {
            get { return shadowPadding; }
            set
            {
                shadowPadding = value; Invalidate();
            }
        }

        int alpha = 120;
        public int ShadowAlpha
        {
            get
            {
                return alpha;
            }
            set
            {
                alpha = value; Invalidate();
            }
        }

        Color shadowColor = Color.Black;
        public Color ShadowColor
        {
            get { return shadowColor; }
            set
            {
                shadowColor = value; Invalidate();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
            e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;

            using (GraphicsPath sgp = GraphicsHelper.GetRoundPath(ClientRectangle, Rad))
            {
                var vb = GraphicsHelper.DrawBitmapShadow(ClientRectangle, Color.FromArgb(ShadowAlpha, shadowColor), Rad, 10,false);
                using (var tbS = new TextureBrush(vb))
                {
                    e.Graphics.FillPath(tbS, sgp);
                }
                vb.Dispose();
            }

            Bitmap bitmap = new Bitmap(Width, Height);
            bitmap.MakeTransparent();


            using (GraphicsPath gp = GraphicsHelper.GetRoundPath(new RectangleF(shadowPadding.Left, shadowPadding.Top, Width - shadowPadding.Horizontal,
                Height - shadowPadding.Vertical), Rad))
            using (GraphicsPath bgp = GraphicsHelper.GetRoundPath(new RectangleF(shadowPadding.Left, shadowPadding.Top, Width - shadowPadding.Horizontal,
                Height - shadowPadding.Vertical), Rad, borderThickness))
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var b = new LinearGradientBrush(ClientRectangle, cardColor1, cardColor2, angle))
                {
                    g.FillPath(b, gp);
                }

                using (var b = new LinearGradientBrush(ClientRectangle, BarColor1, BarColor2, angle))
                {
                    int x = shadowPadding.Left;
                    int y = borderThickness + shadowPadding.Top;
                    int width = Width - shadowPadding.Horizontal;
                    int height = barThickness;

                    switch (contentAlignment)
                    {
                        case ContentLayoutAlign.Left:
                            x = borderThickness + shadowPadding.Left; y = 0; width = barThickness; height = Height;
                            break;
                        case ContentLayoutAlign.Right:
                            x = Width - borderThickness - shadowPadding.Right - barThickness; y = 0; width = barThickness; height = Height;

                            break;
                        case ContentLayoutAlign.Bottom:
                            y = Height - shadowPadding.Bottom - borderThickness - barThickness;
                            x = 0; width = Width; height = barThickness;
                            break;
                    }

                    g.FillRectangle(b, x, y, width, height);
                }

                if (borderThickness > 0)
                {

                    using (var pen = new Pen(new SolidBrush(borderColor)))
                        g.DrawPath(pen, bgp);
                }



                using (TextureBrush tb = new TextureBrush(bitmap))
                {
                    e.Graphics.FillPath(tb, gp);
                }
            }

            bitmap.Dispose();


        }

    }
}
