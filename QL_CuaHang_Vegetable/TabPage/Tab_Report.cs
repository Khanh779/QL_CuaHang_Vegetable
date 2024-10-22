using DinhKhanh_Controls_UI.Charts;
using System.Drawing;
using System.Windows.Forms;

namespace QL_CuaHang_Vegetable.TabPage
{
    public partial class Tab_Report : UserControl
    {

        static Tab_Report _instance;
        public static Tab_Report Instance
        {
            get
            {
                if (_instance == null || _instance.IsDisposed)
                    _instance = new Tab_Report();
                return _instance;
            }
        }

        public Tab_Report()
        {
            InitializeComponent();
            _instance = this;
        }

        private void Tab_Report_Load(object sender, System.EventArgs e)
        {
            ChartItem item0 = new ChartItem { Name = "dKDonutChartItem0", Value = 25, Color = Color.FromArgb(86, 169, 128), Index = 0 };
            ChartItem item1 = new ChartItem { Name = "dKDonutChartItem1", Value = 25, Color = Color.DodgerBlue, Index = 1 };
            ChartItem item2 = new ChartItem { Name = "dKDonutChartItem2", Value = 25, Color = Color.Gold, Index = 2 };
            ChartItem item3 = new ChartItem { Name = "dKDonutChartItem2", Value = 25, Color = Color.FromArgb(253, 1, 73), Index = 3 };

            dkDonutChart1.Items.Add(item0);
            dkDonutChart1.Items.Add(item1);
            dkDonutChart1.Items.Add(item2);
            dkDonutChart1.Items.Add(item3);

        }

        private void PN_Report_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, PN_Report.ClientRectangle, Color.Gainsboro, ButtonBorderStyle.Solid);
        }

        public void ReloadData()
        {
            dkDonutChart1.ReloadData();
        }
    }
}
