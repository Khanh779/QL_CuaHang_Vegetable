using DinhKhanh_Controls_UI.Animation;
using DinhKhanh_Controls_UI.Enums;
using DinhKhanh_Controls_UI.Forms;
using QL_CuaHang_Vegetable.TabPage;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace QL_CuaHang_Vegetable
{
    public partial class QuanTri_Main : TemplateForm
    {

        static QuanTri_Main _obj;
        public static QuanTri_Main Instance
        {
            get
            {
                if (_obj == null || _obj.IsDisposed)
                {
                    _obj = new QuanTri_Main();
                }
                return _obj;
            }
        }

        public QuanTri_Main()
        {
            InitializeComponent();
            _obj = this;

            int x = btn_Nav0.Location.X;
            // Đặt vị trí các nút điều khiển btn_Nav<number> sát nhau (toạ độ Y) bằng cách btn_Nav1.Location = new Point(..., btn_Nav0.Y + btn_Nav0.Height);
            btn_Nav1.Location = new Point(x, btn_Nav0.Location.Y + btn_Nav0.Height + 1);
            btn_Nav2.Location = new Point(x, btn_Nav1.Location.Y + btn_Nav1.Height + 1);
            btn_Nav3.Location = new Point(x, btn_Nav2.Location.Y + btn_Nav2.Height + 1);
            btn_Nav4.Location = new Point(x, btn_Nav3.Location.Y + btn_Nav3.Height + 1);


            Tab_Home.Instance.TabIndex = 0;
            Tab_Food.Instance.TabIndex = 1;
            Tab_Order.Instance.TabIndex = 2;
            Tab_Report.Instance.TabIndex = 3;
            Tab_Settings.Instance.TabIndex = 4;

            SelectedTab = Tab_Home.Instance;
            PN_Tabs.Controls.Add(Tab_Home.Instance);
        }

        private void Form1_Load(object sender, EventArgs e)
        {



        }

     
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            //if (Created)
            //{
            //    // Luôn Canh các nút điều khiển btn_Nav<number> sát nhau (toạ độ Y) ở giữa Navigation Panel
            //    int x = btn_Nav0.Location.X;
            //    btn_Nav0.Location = new Point(x, (navigationPanel.Height - (btn_Nav0.Height + btn_Nav1.Height + btn_Nav2.Height + btn_Nav3.Height + btn_Nav4.Height + 4)) / 2);
            //    btn_Nav1.Location = new Point(x, btn_Nav0.Location.Y + btn_Nav0.Height + 1);
            //    btn_Nav2.Location = new Point(x, btn_Nav1.Location.Y + btn_Nav1.Height + 1);
            //    btn_Nav3.Location = new Point(x, btn_Nav2.Location.Y + btn_Nav2.Height + 1);
            //    btn_Nav4.Location = new Point(x, btn_Nav3.Location.Y + btn_Nav3.Height + 1);
            //}

        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            DangNhap_Form.Instance.Show();
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            if (Created)
            {
                if (WindowState == FormWindowState.Maximized)
                {
                    PN_Nav.Width = 220;
                }
                else
                {
                    PN_Nav.Width = 169;
                }
            }
        }

        private void btn_Nav0_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                SwitchTab(QL_CuaHang_Vegetable.TabPage.Tab_Home.Instance);
            }
        }

        private void btn_Nav1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                SwitchTab(QL_CuaHang_Vegetable.TabPage.Tab_Food.Instance);
            }
        }

        private void btn_Nav2_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                SwitchTab(QL_CuaHang_Vegetable.TabPage.Tab_Order.Instance);
            }
        }

        private void btn_Nav3_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                SwitchTab(QL_CuaHang_Vegetable.TabPage.Tab_Report.Instance);
                QL_CuaHang_Vegetable.TabPage.Tab_Report.Instance.ReloadData();
            }
        }

        private void btn_Nav4_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                SwitchTab(QL_CuaHang_Vegetable.TabPage.Tab_Settings.Instance);
            }
        }

        Control SelectedTab;

        private void SwitchTab(Control newControl)
        {
            if (!PN_Tabs.Controls.Contains(newControl))
            {
                // Lấy control hiện tại
                Control currentControl = SelectedTab;

                PN_Tabs.Controls.Clear();
                PN_Tabs.Controls.Add(newControl);
                newControl.Dock = DockStyle.Fill;

                //AntiFlicker(newControl);

                //Nếu có control hiện tại, thực hiện hoạt ảnh trượt
                
                //if (currentControl != null)
                //{
                //    DoSlideAnimate(currentControl, newControl, currentControl.TabIndex < newControl.TabIndex ? false : true);
                //}

                // Cập nhật control đã chọn
                SelectedTab = newControl;
            }
        }

        // T tính làm hiệu ứng hoạt hình, mà... nó chạy đc ấy, mà phải đợi 0,5 ~ 1 giây mới hoàn thành xong hiệu ứng nên t bỏ

        #region Vùng hiệu ứng push

        public void AntiFlicker(Control control)
        {
            control.GetType().GetProperty("DoubleBuffered",
                System.Reflection.BindingFlags.Instance |
                System.Reflection.BindingFlags.NonPublic)
                .SetValue(control, true, null);
        }

        private void DoSlideAnimate(Control control1, Control control2, bool moveBack)
        {

            // Tạo graphics và bitmap cho hoạt ảnh
            AntiFlicker(control1);
            AntiFlicker(control2);
            var _slideGraphics = Graphics.FromHwnd(control2.Handle);
            var _slideBitmap = new Bitmap(control1.Width, control1.Height + control2.Height);
            _slideBitmap.MakeTransparent();

            // Vẽ các control vào bitmap dựa trên hướng
            if (moveBack)
            {
                control2.DrawToBitmap(_slideBitmap, new Rectangle(0, 0, control2.Width, control2.Height));
                control1.DrawToBitmap(_slideBitmap, new Rectangle(control2.Width, 0, control1.Width, control1.Height));
            }
            else
            {
                control1.DrawToBitmap(_slideBitmap, new Rectangle(0, 0, control1.Width, control1.Height));
                control2.DrawToBitmap(_slideBitmap, new Rectangle(control1.Width, 0, control2.Width, control2.Height));
            }

            foreach (Control c in control2.Controls)
            {
                c.Hide();
            }

            AnimationManager _slideAnimator = new AnimationManager(); // Tạo một AnimationManager mới
            _slideAnimator.Increment = 0.1; // Đặt tốc độ hoạt ảnh

            // Cập nhật hàm vẽ khi hoạt ảnh diễn ra
            _slideAnimator.AnimationProgress += (alpha) =>
            {

                // Vẽ bitmap với độ alpha cho hiệu ứng mờ
                if (_slideGraphics != null && _slideBitmap != null)
                    _slideGraphics.DrawImage(_slideBitmap, new PointF(0, control2.Height - (float)_slideAnimator.GetProgress() * control2.Height));
                control2.Invalidate();

            };

            // Hàm hoàn thành sau khi hoạt ảnh kết thúc
            _slideAnimator.Complete += () =>
            {
                SelectedTab = control2; // Cập nhật tab đã chọn
                foreach (Control c in control2.Controls)
                {
                    c.Show(); // Hiện lại các control trong control2
                }
                control2.Invalidate();

                _slideGraphics.Dispose();
                _slideGraphics = null;

                _slideBitmap.Dispose();
                _slideBitmap = null;
            };


            if (moveBack)
                _slideAnimator.StartNewAnimation(AnimationType.In);
            else
                _slideAnimator.StartNewAnimation(AnimationType.Out);

        }

        #endregion Vùng hiệu ứng push

    }
}
