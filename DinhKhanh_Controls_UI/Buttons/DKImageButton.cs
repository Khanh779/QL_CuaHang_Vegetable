using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DinhKhanh_Controls_UI.Buttons
{
    public class DKImageButton : Control
    {
        public DKImageButton()
        {
            SetStyle(ControlStyles.SupportsTransparentBackColor | ControlStyles.OptimizedDoubleBuffer, true);

        }

        Size _imageNormalSize = new Size(16, 16);
        public Size ImageNormalSize
        {
            get { return _imageNormalSize; }
            set { _imageNormalSize = value; Invalidate(); }
        }

        Size _imageHoverSize = new Size(16, 16);
        public Size ImageHoverSize
        {
            get { return _imageHoverSize; }
            set { _imageHoverSize = value; Invalidate(); }
        }

        Image _image = null;
        public Image ImageButton
        {
            get { return _image; }
            set { _image = value; Invalidate(); }
        }

        bool _isMouseOver = false;



        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            e.Graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            e.Graphics.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;  

            // Vẽ hình ảnh dựa trên trạng thái nút
            if (ImageButton != null)
            {
                if (_isMouseOver)
                {
                    e.Graphics.DrawImage(ImageButton, Width / 2 - ImageHoverSize.Width / 2, Height / 2 - ImageHoverSize.Height / 2, ImageHoverSize.Width, ImageHoverSize.Height);
                }
                else
                {
                    e.Graphics.DrawImage(ImageButton, Width / 2 - ImageNormalSize.Width / 2, Height / 2 - ImageNormalSize.Height / 2, ImageNormalSize.Width, ImageNormalSize.Height);
                }
            }
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            _isMouseOver = true;
            Invalidate();

        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            _isMouseOver = false;
            Invalidate();
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            _isMouseOver = false;
            Invalidate();
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            _isMouseOver = true;
            Invalidate();
        }
    }
}
