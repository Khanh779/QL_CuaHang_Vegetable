using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Windows.Forms.Design;
using System.Runtime.InteropServices;

namespace DinhKhanh_Controls_UI.Containers
{
    [ComVisible(true)]
    [ClassInterface(ClassInterfaceType.AutoDispatch)]
    [Designer(typeof(DKCollapsiblePanelDesigner))]
    public class DKCollapsiblePanel : Control
    {
        public event EventHandler CollapsedChanged;

        private readonly DKPanelControl contentPanel; // Panel chứa nội dung

        public DKCollapsiblePanel()
        {
            SetStyle(ControlStyles.SupportsTransparentBackColor | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.ContainerControl, true);
            this.DoubleBuffered = true;
            this.Padding = new Padding(10);
            this.Click += DKCollapsiblePanel_Click; // Đăng ký sự kiện click

            // Tạo panel cho nội dung
            contentPanel = new DKPanelControl
            {
                Padding = new Padding(10),
                Dock = DockStyle.Fill,
                BackColor = Color.White // Màu nền của phần nội dung
            };

            Controls.Add(contentPanel); // Thêm panel nội dung vào điều khiển
        }

        private int titleHeight = 30;
        [Category("Appearance")]
        [Description("Height of the title bar.")]
        public int TitleHeight
        {
            get { return titleHeight; }
            set
            {
                if (value >= 0)
                {
                    titleHeight = value;
                    Invalidate();
                }
            }
        }

        Padding containerPadding
            = new Padding(10);
        [Category("Appearance")]
        [Description("Padding of the container.")]
        public Padding ContainerPadding
        {
            get { return containerPadding; }
            set
            {
                containerPadding = value;
                Invalidate();
            }
        }


        private bool isCollapsed = false;
        [Category("Appearance")]
        [Description("Indicates whether the panel is collapsed.")]
        public bool IsCollapsed
        {
            get { return isCollapsed; }
            set
            {
                if (isCollapsed != value)
                {
                    isCollapsed = value;
                    CollapsedChanged?.Invoke(this, EventArgs.Empty);
                    Invalidate();
                    // Điều chỉnh kích thước của control
                    if (isCollapsed)
                    {
                        Height = TitleHeight; // Đặt chiều cao cố định
                    }
                    else
                    {
                        Height = TitleHeight + contentPanel.Height; // Chiều cao tự do, có thể thay đổi theo nội dung
                    }
                }
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.Clear(Parent.BackColor);

            // Vẽ bóng
            using (var shadowBrush = new SolidBrush(Color.FromArgb(100, 0, 0, 0)))
            {
                e.Graphics.FillRectangle(shadowBrush, new Rectangle(5, 5, Width, Height));
            }

            // Vẽ border
            e.Graphics.DrawRectangle(Pens.Gray, 0, 0, Width - 1, Height - 1);

            // Vẽ tiêu đề
            using (var titleBrush = new SolidBrush(Color.LightGray))
            {
                e.Graphics.FillRectangle(titleBrush, new Rectangle(0, 0, Width, TitleHeight));
            }

            // Vẽ mũi tên
            DrawArrow(e.Graphics);
        }

        private void DrawArrow(Graphics g)
        {
            Point[] arrowPoints = isCollapsed
                ? new Point[] { new Point(Width / 2, TitleHeight - 10), new Point(Width / 2 - 5, TitleHeight - 5), new Point(Width / 2 + 5, TitleHeight - 5) }
                : new Point[] { new Point(Width / 2, TitleHeight + 10), new Point(Width / 2 - 5, TitleHeight + 15), new Point(Width / 2 + 5, TitleHeight + 15) };

            g.FillPolygon(Brushes.Black, arrowPoints);
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            // Cập nhật chiều cao cho panel nội dung khi kích thước thay đổi
            contentPanel.Height = IsCollapsed ? 0 : Height - TitleHeight;
        }

        private void DKCollapsiblePanel_Click(object sender, EventArgs e)
        {
            IsCollapsed = !IsCollapsed; // Chuyển đổi trạng thái khi click
        }

        // Phương thức để thêm điều khiển vào contentPanel
        public void AddControl(Control control)
        {
            if (control != null)
            {
                contentPanel.Controls.Add(control);
            }
        }
    }

    [ComVisible(true)]
    [ClassInterface(ClassInterfaceType.AutoDispatch)]
    [Designer(typeof(ScrollableControlDesigner))]
    internal class DKPanelControl : Panel
    {
        public DKPanelControl()
        {
            SetStyle(ControlStyles.SupportsTransparentBackColor | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw, true);
            this.DoubleBuffered = true;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.DrawRectangle(Pens.Gray, 0, 0, Width - 1, Height - 1);
        }
    }

    public class DKCollapsiblePanelDesigner : ParentControlDesigner
    {
        // Thiết lập các thuộc tính thiết kế
        public override void Initialize(IComponent component)
        {
            base.Initialize(component);

            // Thêm hỗ trợ cho các thuộc tính thiết kế
            // Ví dụ, có thể thêm thuộc tính cho chiều cao tiêu đề
            var panel = (DKCollapsiblePanel)component;

            // Cung cấp thông tin cho Designer
            if (panel != null)
            {
                // Thiết lập thuộc tính hiển thị trong Designer
                TypeDescriptor.AddAttributes(panel, new DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Visible));
            }
        }

      
    }

}
