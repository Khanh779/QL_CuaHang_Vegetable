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
        public new Color BackColor { get; set; }

        [Browsable(false)]
        public new Color ForeColor { get; set; }


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
                using (var shadowBitmap = GraphicsHelper.DrawBitmapShadow(ClientRectangle, Color.FromArgb(ShadowAlpha, shadowColor), Rad))
                using (var shadowBrush = new TextureBrush(shadowBitmap))
                {
                    e.Graphics.FillPath(shadowBrush, sgp);
                }
            }

            Bitmap bitmap = new Bitmap(Width - shadowPadding.Horizontal, Height - shadowPadding.Vertical);
            bitmap.MakeTransparent();

            var contentRectangle = new RectangleF(shadowPadding.Left, shadowPadding.Top, Width - shadowPadding.Horizontal, Height - shadowPadding.Vertical);
            using (GraphicsPath contentPath = GraphicsHelper.GetRoundPath(contentRectangle, Rad))
            using (GraphicsPath borderPath = GraphicsHelper.GetRoundPath(contentRectangle, Rad, borderThickness))
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.PixelOffsetMode = PixelOffsetMode.HighQuality;

                // Fill card background with gradient
                using (var backgroundBrush = new LinearGradientBrush(contentRectangle, cardColor1, cardColor2, angle))
                {
                    g.FillPath(backgroundBrush, contentPath);
                }

                // Fill the bar depending on the alignment
                using (var barBrush = new LinearGradientBrush(ClientRectangle, BarColor1, BarColor2, angle))
                {
                    int x = shadowPadding.Left;
                    int y = borderThickness + shadowPadding.Top;
                    int width = Width - shadowPadding.Horizontal;
                    int height = barThickness;

                    switch (contentAlignment)
                    {
                        case ContentLayoutAlign.Left:
                            x = borderThickness + shadowPadding.Left;
                            y = 0;
                            width = barThickness;
                            height = Height;
                            break;
                        case ContentLayoutAlign.Right:
                            x = bitmap.Width - borderThickness - barThickness;
                            y = 0;
                            width = barThickness;
                            height = Height;
                            break;
                        case ContentLayoutAlign.Bottom:
                            y = bitmap.Height - borderThickness - barThickness;
                            x = 0;
                            width = bitmap.Width;
                            height = barThickness;
                            break;
                    }

                    g.FillRectangle(barBrush, x, y, width, height);
                }

                // Draw border if borderThickness > 0
                if (borderThickness > 0)
                {
                    using (var borderPen = new Pen(borderColor, borderThickness))
                    {
                        g.DrawPath(borderPen, borderPath);
                    }
                }
                // Draw the main content using texture brush
                using (var textureBrush = new TextureBrush(bitmap))
                {
                    e.Graphics.FillPath(textureBrush, contentPath);
                }
            }

            bitmap.Dispose();
        }

    }
}
