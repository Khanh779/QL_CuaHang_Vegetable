using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DinhKhanh_Controls_UI.Helper
{
    public class GraphicsHelper
    {

        public static void SetHightGraphics(Graphics g)
        {
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            g.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;

        }

        public static void MakeTransparent(Control control, Graphics g)
        {
            Control parent = control.Parent;
            if (parent != null)
            {
                Rectangle rectangle = control.Bounds;
                Control.ControlCollection controls = parent.Controls;
                int index = controls.IndexOf(control);
                Bitmap bitmap = null;
                for (int i = controls.Count - 1; i > index; i--)
                {
                    Control control3 = controls[i];
                    if (control3.Bounds.IntersectsWith(rectangle))
                    {
                        if (bitmap == null)
                        {
                            bitmap = new Bitmap(control.Parent.ClientSize.Width, control.Parent.ClientSize.Height);
                            bitmap.MakeTransparent();
                        }
                        control3.DrawToBitmap(bitmap, control3.Bounds);
                    }
                }
                if (bitmap != null)
                {
                    g.DrawImage((Image)bitmap, control.ClientRectangle, rectangle, (GraphicsUnit)GraphicsUnit.Pixel);
                    bitmap.Dispose();
                }
            }
        }

        public static GraphicsPath GetRoundPath(RectangleF Rect, float radius, float width = 0)
        {
            //Fix radius to rect size
            radius = (int)Math.Max((Math.Min(radius, Math.Min(Rect.Width, Rect.Height)) - width), 1) * 2;
            //radius *= 2;
            var r2 = (radius / 2f); var w2 = (width / 2f);
            GraphicsPath GraphPath = new GraphicsPath();
            if (radius != 0)
            {
                //Top-Left Arc
                GraphPath.AddArc(Rect.X + w2, Rect.Y + w2, radius, radius, 180, 90);
                //Top-Right Arc
                GraphPath.AddArc(Rect.X + Rect.Width - radius - w2, Rect.Y + w2, radius, radius, 270, 90);
                //Bottom-Right Arc
                GraphPath.AddArc(Rect.X + Rect.Width - w2 - radius, Rect.Y + Rect.Height - w2 - radius, radius, radius, 0, 90);
                //Bottom-Left Arc
                GraphPath.AddArc(Rect.X + w2, Rect.Y - w2 + Rect.Height - radius, radius, radius, 90, 90);
                //Close line ( Left)           
                GraphPath.AddLine(Rect.X + w2, Rect.Y + Rect.Height - r2 - w2, Rect.X + w2, Rect.Y + r2 + w2);
            }
            if (radius == 0) GraphPath.AddRectangle(new RectangleF(Rect.X + w2, Rect.Y + w2, Rect.Width - w2, Rect.Height - w2));
            return GraphPath;
        }






    }
}
