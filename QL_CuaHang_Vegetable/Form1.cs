using Custom_Controls_UI.Buttons;
using Custom_Controls_UI.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_CuaHang_Vegetable
{
    public partial class Form1 : TemplateForm
    {
        public Form1()
        {
            InitializeComponent();

            int x = btn_Nav0.Location.X;
            // Đặt vị trí các nút điều khiển btn_Nav<number> sát nhau (toạ độ Y) bằng cách btn_Nav1.Location = new Point(..., btn_Nav0.Y + btn_Nav0.Height);
            btn_Nav1.Location = new Point(x, btn_Nav0.Location.Y + btn_Nav0.Height + 1);
            btn_Nav2.Location = new Point(x, btn_Nav1.Location.Y + btn_Nav1.Height + 1);
            btn_Nav3.Location = new Point(x, btn_Nav2.Location.Y + btn_Nav2.Height + 1);
            btn_Nav4.Location = new Point(x, btn_Nav3.Location.Y + btn_Nav3.Height + 1);


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            if (Created)
            {
                // Luôn Canh các nút điều khiển btn_Nav<number> sát nhau (toạ độ Y) ở giữa Navigation Panel
                int x = btn_Nav0.Location.X;
                btn_Nav0.Location = new Point(x, (navigationPanel.Height - (btn_Nav0.Height + btn_Nav1.Height + btn_Nav2.Height + btn_Nav3.Height + btn_Nav4.Height + 4)) / 2);
                btn_Nav1.Location = new Point(x, btn_Nav0.Location.Y + btn_Nav0.Height + 1);
                btn_Nav2.Location = new Point(x, btn_Nav1.Location.Y + btn_Nav1.Height + 1);
                btn_Nav3.Location = new Point(x, btn_Nav2.Location.Y + btn_Nav2.Height + 1);
                btn_Nav4.Location = new Point(x, btn_Nav3.Location.Y + btn_Nav3.Height + 1);
            }

        }
    }
}
