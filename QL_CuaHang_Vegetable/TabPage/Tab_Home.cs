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
                Add_Employee_Form add_Employee_Form = new Add_Employee_Form();
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
            ChartItem item1 = new ChartItem { Name = "dKDonutChartItem1", Value = 25, Color = System.Drawing.Color.DodgerBlue, Index = 1 };
            ChartItem item2 = new ChartItem { Name = "dKDonutChartItem2", Value = 25, Color = System.Drawing.Color.Gold, Index = 2 };

            dkStackBarChart1.Items.Add(item0);
            dkStackBarChart1.Items.Add(item1);
            dkStackBarChart1.Items.Add(item2);

        }
    }
}
