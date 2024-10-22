using DinhKhanh_Controls_UI.Charts;
using QL_CuaHang_Vegetable.Forms;
using System;
using System.Windows.Forms;

namespace QL_CuaHang_Vegetable.TabPage
{
    public partial class Tab_Home : UserControl
    {

        static Tab_Home _obj;
        public static Tab_Home Instance
        {
            get
            {
                if (_obj == null || _obj.IsDisposed)
                {
                    _obj = new Tab_Home();
                }
                return _obj;
            }
        }

        public Tab_Home()
        {
            InitializeComponent();
            _obj = this;
        }

        private void btn_Add_Employ_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Employee_Manager_Form add_Employee_Form = new Employee_Manager_Form();
                add_Employee_Form.Show();
            }
        }

        public string LayBuoi()
        {
            DateTime now = DateTime.Now;
            if (now.Hour >= 0 && now.Hour < 12)
            {
                return "Chào buổi sáng";
            }
            else if (now.Hour >= 12 && now.Hour < 18)
            {
                return "Chào buổi chiều";
            }
            else
            {
                return "Chào buổi tối";
            }
        }

        private void Tab_Home_Load(object sender, EventArgs e)
        {
            label1.Text = "Trang chủ - " + LayBuoi() + ", Admin!";


            ChartItem item0 = new ChartItem { Name = "dKDonutChartItem0", Value = 25, Color = System.Drawing.Color.FromArgb(86, 169, 128), Index = 0 };
            ChartItem item1 = new ChartItem { Name = "dKDonutChartItem1", Value = 25, Color = System.Drawing.Color.DeepSkyBlue, Index = 1 };
            ChartItem item2 = new ChartItem { Name = "dKDonutChartItem2", Value = 25, Color = System.Drawing.Color.Gold, Index = 2 };
            ChartItem item3 = new ChartItem { Name = "dKDonutChartItem2", Value = 25, Color = System.Drawing.Color.FromArgb(253, 1, 73), Index = 3 };

            dkStackBarChart1.Items.Add(item0);
            dkStackBarChart1.Items.Add(item1);
            dkStackBarChart1.Items.Add(item2);
            dkStackBarChart1.Items.Add(item3);

            LoadData_Foood();
        }

        // Hàm làm mới lại dữ liệu về thực phẩm
        void LoadData_Foood()
        {
            dkStackBarChart1.ReloadData();

            // Random số lượng thực phẩm
            Random rd = new Random();

            dkStackBarChart1.Items[0].Value = rd.Next(1, 100);
            dkStackBarChart1.Items[1].Value = rd.Next(1, 100);
            dkStackBarChart1.Items[2].Value = rd.Next(1, 100);
            dkStackBarChart1.Items[3].Value = rd.Next(1, 100);

            // dklabel từ 2 đến 5 là trạng thái chú thích của biểu đồ thanh ngăn xếp stack
            dkLabel2.Text = "Còn tồn: " + dkStackBarChart1.Items[0].Value.ToString();
            dkLabel3.Text = "Đã bán: " + dkStackBarChart1.Items[1].Value.ToString();
            dkLabel4.Text = "Sắp hết hạn: " + dkStackBarChart1.Items[2].Value.ToString();
            dkLabel5.Text = "Đã hết hạn: " + dkStackBarChart1.Items[3].Value.ToString();


            lbl_RefreshDataStatus.Text = "Dữ liệu được cập nhật vào lúc: " + DateTime.Now; // Thời gian cập nhật dữ liệu
        }

        private void btn_ReloadData_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                LoadData_Foood();
            }
        }

        private void PN_StackChartLegend_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;

            e.Graphics.DrawRectangle(new System.Drawing.Pen(System.Drawing.Color.Silver, 1) { Alignment = System.Drawing.Drawing2D.PenAlignment.Inset, DashStyle = System.Drawing.Drawing2D.DashStyle.Dot }, PN_StackChartLegend.ClientRectangle);
        }

        private void llbl_DenTP_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                QuanTri_Main.Instance.PN_Tabs.Controls.Clear();
                QuanTri_Main.Instance.PN_Tabs.Controls.Add(Tab_Food.Instance);
            }
        }
    }
}
