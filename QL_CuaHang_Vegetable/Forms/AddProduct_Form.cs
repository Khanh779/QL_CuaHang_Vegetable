using DinhKhanh_Controls_UI.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_CuaHang_Vegetable.Forms
{
    public partial class AddProduct_Form : TemplateForm
    {
        public AddProduct_Form()
        {
            InitializeComponent();

            PB_Product.Paint += PB_Product_Paint;
        }

        private void PB_Product_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.Silver, 1) { DashStyle= System.Drawing.Drawing2D.DashStyle.Dot}, 0, 0, PB_Product.Width - 1, PB_Product.Height - 1);
        }

        private void llb_Add_Provider_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button== MouseButtons.Left)
            {
                Add_Manufacturer_Form add_Manufacturer_Form = new Add_Manufacturer_Form();
                add_Manufacturer_Form.ShowDialog();
            }    
        }
    }
}
