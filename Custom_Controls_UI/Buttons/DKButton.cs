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
                Invalidate();
            }
        }

        AnimationManager animationManager;

        public DKButton()
        {
            SetStyle(ControlStyles.SupportsTransparentBackColor | ControlStyles.OptimizedDoubleBuffer, true);
            animationManager = new AnimationManager (false)
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
            Invalidate();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            _isHovering = false;
            Invalidate();
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            _isPressed = true;
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


        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
            e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;

            using (Bitmap bmp = new Bitmap(Width, Height))
            {
                bmp.MakeTransparent();

                using (Graphics g = Graphics.FromImage(bmp))
                {
                    g.SmoothingMode = SmoothingMode.AntiAlias;
                    g.PixelOffsetMode = PixelOffsetMode.HighQuality;
                    g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                    g.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;

                    Color color1, color2;
                    if (_isPressed)
                    {
                        color1 = _pressColor1;
                        color2 = _pressColor2;
                    }
                    else if (_isHovering)
                    {
                        color1 = _hoverColor1;
                        color2 = _hoverColor2;
                    }
                    else
                    {
                        color1 = _normalColor1;
                        color2 = _normalColor2;
                    }

                    StringFormat sf = new StringFormat();
                    TextHelper.SetStringAlign(sf, contentAlignment);

                    Rectangle textBound = new Rectangle(BorderThickness + textPadding.Left, BorderThickness + textPadding.Top,
                        Width - BorderThickness * 2 - textPadding.Left - textPadding.Right, Height - textPadding.Top - textPadding.Bottom - BorderThickness * 2);

                    using (var pen = new Pen(_borderColor, _borderThickness))
                    using (var textBru = new SolidBrush(_isPressed ? _textPressColor : _isHovering ? _textHoverColor : _textNormalColor))
                    using (LinearGradientBrush brush = new LinearGradientBrush(ClientRectangle, color1, color2, 90F))
                    {
                        switch (shapeType)
                        {
                            case ShapeType.RoundedRectangle:
                                using (GraphicsPath path = GraphicsHelper.GetRoundPath(ClientRectangle, Radius))
                                using (GraphicsPath borpath = GraphicsHelper.GetRoundPath(ClientRectangle, Radius, _borderThickness))
                                {
                                    g.FillPath(brush, path);
                                    g.DrawString(Text, Font, textBru, textBound, sf);
                                    if (BorderThickness != 0) g.DrawPath(pen, borpath);
                                }

                                break;
                            case ShapeType.Ellipse:
                                RectangleF rect = new RectangleF(0.5f, 0.5f, Width - 1, Height - 1);
                                g.FillEllipse(brush, rect);
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
                            Rectangle rippleRect = new Rectangle(source.X - rippleSize / 2, source.Y - rippleSize / 2, rippleSize, rippleSize);
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
    }
}
