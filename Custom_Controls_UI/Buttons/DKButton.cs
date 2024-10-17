using Custom_Controls_UI.Animation;
using Custom_Controls_UI.Enums;
using Custom_Controls_UI.Helper;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;

namespace Custom_Controls_UI.Buttons
{
    public class DKButton : Control
    {
        // Các thuộc tính màu sắc
        private Color _normalColor1 = ColorHelper.NormalColor;
        private Color _normalColor2 = ColorHelper.NormalColor;
        private Color _hoverColor1 = ColorHelper.HoverColor;
        private Color _hoverColor2 = ColorHelper.HoverColor;
        private Color _pressColor1 = ColorHelper.PressedColor;
        private Color _pressColor2 = ColorHelper.PressedColor;

        private Color _textNormalColor = ColorHelper.TextNormalColor;
        private Color _textHoverColor = ColorHelper.TextHoverColor;
        private Color _textPressColor = ColorHelper.TextPressedColor;

        private Color _borderColor = Color.FromArgb(34, 139, 34);



        private int _borderThickness = 1;

        // Biến trạng thái
        private bool _isHovering = false;
        private bool _isPressed = false;

        ShapeType shapeType = ShapeType.RoundedRectangle;
        public ShapeType ShapeType
        {
            get => shapeType;
            set
            {
                shapeType = value;
                Invalidate();
            }
        }

        int radius = 3;
        public int Radius
        {
            get => radius;
            set
            {
                radius = value;
                Invalidate();
            }
        }

        ContentAlignment contentAlignment = ContentAlignment.MiddleCenter;
        public ContentAlignment ContentAlignment
        {
            get => contentAlignment;
            set
            {
                contentAlignment = value;
                Invalidate();
            }
        }

        StringTrimming stringTrimming = StringTrimming.EllipsisCharacter;
        public StringTrimming StringTrimming
        {
            get => stringTrimming;
            set
            {
                stringTrimming = value;
                Invalidate();
            }
        }

        TextRenderingHint textRenderingHint = TextRenderingHint.AntiAliasGridFit;
        public TextRenderingHint TextRenderingHint
        {
            get => textRenderingHint;
            set
            {
                textRenderingHint = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Get or set the text color
        /// </summary>
        [Description("Get or set the text color")]
        public new Color ForeColor
        {
            get => base.ForeColor;
            set
            {
                base.ForeColor = value;
                Invalidate();
            }
        }

        public Color TextNormalColor
        {
            get => _textNormalColor;
            set { _textNormalColor = value; Invalidate(); }
        }

        public Color TextHoverColor
        {
            get => _textHoverColor;
            set { _textHoverColor = value; Invalidate(); }
        }

        public Color TextPressColor
        {
            get => _textPressColor;
            set { _textPressColor = value; Invalidate(); }
        }

        AnimationMode animationMode = AnimationMode.None;
        public AnimationMode AnimationMode
        {
            get => animationMode;
            set
            {
                animationMode = value;
                if (animationMode == AnimationMode.ColorTransition)
                {
                    animationManager.Singular = true;
                }
                if (animationMode == AnimationMode.Ripple)
                {
                    animationManager.Singular = false;
                }
                Invalidate();
            }
        }

        AnimationManager animationManager;

        public DKButton()
        {
            SetStyle(ControlStyles.SupportsTransparentBackColor | ControlStyles.OptimizedDoubleBuffer, true);
            animationManager = new AnimationManager(false)
            {
                Increment = 0.07
            };

            animationManager.AnimationProgress += AnimationManager_AnimationProgress;

        }

        private void AnimationManager_AnimationProgress(object obj)
        {
            Invalidate();
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            _isHovering = true;
            if (animationMode == AnimationMode.ColorTransition)
            {
                animationManager.StartNewAnimation(AnimationType.In);
            }
            Invalidate();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            _isHovering = false;
            if (animationMode == AnimationMode.ColorTransition)
            {
                animationManager.StartNewAnimation(AnimationType.Out);
            }
            Invalidate();
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            _isPressed = true;
            if (animationMode == AnimationMode.ColorTransition)
            {
                animationManager.StartNewAnimation(AnimationType.In);
            }
            Invalidate();
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            _isPressed = false;
            Invalidate();
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);
            if (animationMode == AnimationMode.Ripple)
            {
                animationManager.StartNewAnimation(AnimationType.In, e.Location);
            }
        }

        LinearGradientMode gradientMode = LinearGradientMode.BackwardDiagonal;
        public LinearGradientMode GradientMode
        {
            get => gradientMode;
            set
            {
                gradientMode = value;
                Invalidate();
            }
        }

        TextImageRelation imageRelation = TextImageRelation.ImageBeforeText;
        public TextImageRelation ImageRelation
        {
            get => imageRelation;
            set
            {
                imageRelation = value;
                Invalidate();
            }
        }

        Image image;
        public Image Image
        {
            get => image;
            set
            {
                image = value;
                Invalidate();
            }
        }

        Size _imageSize = new Size(20, 20);
        public Size ImageSize
        {
            get => _imageSize;
            set
            {
                _imageSize = value;
                Invalidate();
            }
        }

        int imageOffsetX = 0;
        public int ImageOffsetX
        {
            get => imageOffsetX;
            set
            {
                imageOffsetX = value;
                Invalidate();
            }
        }

        int imageOffsetY = 0;
        public int ImageOffsetY
        {
            get => imageOffsetY;
            set
            {
                imageOffsetY = value;
                Invalidate();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
            e.Graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
            e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
            e.Graphics.TextRenderingHint = TextRenderingHint;
            e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;

            using (Bitmap bmp = new Bitmap(Width, Height))
            {
                bmp.MakeTransparent();

                using (Graphics g = Graphics.FromImage(bmp))
                {
                    g.SmoothingMode = SmoothingMode.HighQuality;
                    g.PixelOffsetMode = PixelOffsetMode.HighQuality;
                    g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                    g.TextRenderingHint = TextRenderingHint;
                    g.InterpolationMode = InterpolationMode.HighQualityBicubic;

                    Color color1 =
        animationMode == AnimationMode.ColorTransition
            ? (_isPressed ? ColorHelper.BlendColor(_pressColor2, _pressColor1, animationManager.GetProgress() * 255)
                : _isHovering ? ColorHelper.BlendColor(_hoverColor2, _hoverColor1, animationManager.GetProgress() * 255)
                    : ColorHelper.BlendColor(_normalColor2, _normalColor1, animationManager.GetProgress() * 255))
            : animationMode == AnimationMode.Ripple ? (_isHovering ? _hoverColor1 : _normalColor1)
                : (_isPressed ? _pressColor1 : _isHovering ? _hoverColor1 : _normalColor1);

                    Color color2 = animationMode == AnimationMode.ColorTransition
                            ? (_isPressed ? ColorHelper.BlendColor(_pressColor1, _pressColor2, animationManager.GetProgress() * 255) :
                             _isHovering ? ColorHelper.BlendColor(_hoverColor1, _hoverColor2, animationManager.GetProgress() * 255)
                                    : ColorHelper.BlendColor(_normalColor1, _normalColor2, animationManager.GetProgress() * 255))
                            : animationMode == AnimationMode.Ripple ? (_isHovering
                                    ? _hoverColor2 : _normalColor2) : (_isPressed ? _pressColor2 : _isHovering ? _hoverColor2 : _normalColor2);



                    StringFormat sf = new StringFormat();
                    TextHelper.SetStringAlign(sf, contentAlignment);

                    // Kích thước và vị trí của văn bản
                    RectangleF textBound = new RectangleF(BorderThickness + textPadding.Left,
                        BorderThickness + textPadding.Top,
                        Width - BorderThickness * 2 - textPadding.Left - textPadding.Right,
                        Height - textPadding.Top - textPadding.Bottom - BorderThickness * 2);

                    // Kích thước và vị trí của hình ảnh
                    RectangleF imageBound = new RectangleF(BorderThickness + textPadding.Left,
                        BorderThickness + textPadding.Top, _imageSize.Width, _imageSize.Height);

                    if (Image != null)
                    {
                        switch (ImageRelation)
                        {
                            case TextImageRelation.TextBeforeImage:
                                // Văn bản ở trước hình ảnh
                                textBound = new RectangleF(BorderThickness + textPadding.Left, BorderThickness + textPadding.Top,
                                    Width - BorderThickness * 2 - textPadding.Left - textPadding.Right - _imageSize.Width - imageOffsetX,
                                    Height - textPadding.Top - textPadding.Bottom - BorderThickness * 2);
                                imageBound = new RectangleF(textBound.Right + imageOffsetX, Height / 2 - _imageSize.Height / 2, _imageSize.Width, _imageSize.Height);
                                break;

                            case TextImageRelation.ImageBeforeText:
                                // Hình ảnh ở trước văn bản
                                textBound = new RectangleF(BorderThickness + textPadding.Left + _imageSize.Width + imageOffsetX, BorderThickness + textPadding.Top,
                                    Width - BorderThickness * 2 - textPadding.Left - textPadding.Right - _imageSize.Width - imageOffsetX,
                                    Height - textPadding.Top - textPadding.Bottom - BorderThickness * 2);
                                imageBound = new RectangleF(BorderThickness + imageOffsetX, Height / 2 - _imageSize.Height / 2, _imageSize.Width, _imageSize.Height);
                                break;

                            case TextImageRelation.ImageAboveText:
                                // Hình ảnh ở trên văn bản
                                textBound = new RectangleF(BorderThickness + textPadding.Left, BorderThickness + textPadding.Top + _imageSize.Height + imageOffsetY,
                                    Width - BorderThickness * 2 - textPadding.Left - textPadding.Right,
                                    Height - textPadding.Top - textPadding.Bottom - BorderThickness * 2 - _imageSize.Height - imageOffsetY);
                                imageBound = new RectangleF(Width / 2 - _imageSize.Width / 2, BorderThickness + imageOffsetY, _imageSize.Width, _imageSize.Height);
                                break;

                            case TextImageRelation.TextAboveImage:
                                // Văn bản ở trên hình ảnh
                                textBound = new Rectangle(BorderThickness + textPadding.Left, BorderThickness + textPadding.Top,
                                    Width - BorderThickness * 2 - textPadding.Left - textPadding.Right,
                                    Height - textPadding.Top - textPadding.Bottom - BorderThickness * 2 - _imageSize.Height - imageOffsetY);
                                imageBound = new RectangleF(Width / 2 - _imageSize.Width / 2, textBound.Bottom + imageOffsetY, _imageSize.Width, _imageSize.Height);
                                break;
                        }
                    }


                    using (var pen = new Pen(_borderColor, _borderThickness))
                    using (var textBru = new SolidBrush(_isPressed ? _textPressColor : _isHovering ? _textHoverColor : _textNormalColor))
                    using (LinearGradientBrush brush = new LinearGradientBrush(ClientRectangle, color1, color2, gradientMode))
                    {
                        switch (shapeType)
                        {
                            case ShapeType.RoundedRectangle:
                                using (GraphicsPath path = GraphicsHelper.GetRoundPath(ClientRectangle, Radius))
                                using (GraphicsPath borpath = GraphicsHelper.GetRoundPath(ClientRectangle, Radius, _borderThickness))
                                {
                                    g.FillPath(brush, path);

                                    if (Image != null)
                                    {
                                        g.DrawImage(Image, imageBound);
                                    }

                                    g.DrawString(Text, Font, textBru, textBound, sf);
                                    if (BorderThickness != 0) g.DrawPath(pen, borpath);
                                }

                                break;
                            case ShapeType.Ellipse:
                                RectangleF rect = new RectangleF(0.5f, 0.5f, Width - 1, Height - 1);
                                g.FillEllipse(brush, rect);
                                if (Image != null)
                                {
                                    g.DrawImage(Image, imageBound);
                                }
                                g.DrawString(Text, Font, textBru, textBound, sf);
                                if (BorderThickness != 0) g.DrawEllipse(pen, rect);
                                break;
                        }
                    }

                    if (animationMode == AnimationMode.Ripple)
                    {
                        for (int i = 0; i < animationManager.GetAnimationCount(); i++)
                        {
                            double progress = animationManager.GetProgress(i);
                            Point source = animationManager.GetSource(i);
                            int rippleSize = (int)(progress * Width * 2);
                            RectangleF rippleRect = new RectangleF(source.X - rippleSize / 2, source.Y - rippleSize / 2, rippleSize, rippleSize);
                            using (Brush rippleBrush = new SolidBrush(Color.FromArgb((int)(51 - progress * 50), ForeColor)))
                            {
                                g.FillEllipse(rippleBrush, rippleRect);
                            }
                        }
                    }

                    using (TextureBrush tb = new TextureBrush(bmp))
                    {
                        e.Graphics.FillRectangle(tb, ClientRectangle);
                    }


                }

            }
        }


        [Editor(typeof(ColorEditor), typeof(UITypeEditor))]
        public Color NormalColor1
        {
            get => _normalColor1;
            set { _normalColor1 = value; Invalidate(); }
        }

        [Editor(typeof(ColorEditor), typeof(UITypeEditor))]
        public Color NormalColor2
        {
            get => _normalColor2;
            set { _normalColor2 = value; Invalidate(); }
        }

        [Editor(typeof(ColorEditor), typeof(UITypeEditor))]
        public Color HoverColor1
        {
            get => _hoverColor1;
            set { _hoverColor1 = value; Invalidate(); }
        }

        [Editor(typeof(ColorEditor), typeof(UITypeEditor))]
        public Color HoverColor2
        {
            get => _hoverColor2;
            set { _hoverColor2 = value; Invalidate(); }
        }

        [Editor(typeof(ColorEditor), typeof(UITypeEditor))]
        public Color PressColor1
        {
            get => _pressColor1;
            set { _pressColor1 = value; Invalidate(); }
        }

        [Editor(typeof(ColorEditor), typeof(UITypeEditor))]
        public Color PressColor2
        {
            get => _pressColor2;
            set { _pressColor2 = value; Invalidate(); }
        }

        [Editor(typeof(ColorEditor), typeof(UITypeEditor))]
        public Color BorderColor
        {
            get => _borderColor;
            set { _borderColor = value; Invalidate(); }
        }

        public int BorderThickness
        {
            get => _borderThickness;
            set { _borderThickness = value; Invalidate(); }
        }

        Padding textPadding = new Padding(0);
        public Padding TextPadding
        {
            get => textPadding;
            set
            {
                textPadding = value;
                Invalidate();
            }
        }

        [Editor("System.ComponentModel.Design.MultilineStringEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        [SettingsBindable(true)]
        [Category("Misc")]
        public override string Text
        {
            get => base.Text;
            set
            {
                base.Text = value;
                Invalidate();
            }
        }
        [Category("Misc")]
        public override Font Font
        {
            get => base.Font;
            set
            {
                base.Font = value;
                Invalidate();
            }
        }


    }
}
