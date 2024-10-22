using DinhKhanh_Controls_UI.Forms;
using QL_CuaHang_Vegetable.Forms.AddEmpls;
using QL_CuaHang_Vegetable.PhanXuLy;
using System;
using System.Windows.Forms;

namespace QL_CuaHang_Vegetable.Forms
{
    public partial class Employee_Manager_Form : TemplateForm
    {

        public Employee_Manager_Form()
        {
            InitializeComponent();

        }

        QuickEmList_UC a;
        DetailsEmList_UC b;

        bool detailsView = false;

        private void Add_Employee_Form_Load(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            var a = new QuickEmList_UC(XuLyThongTin.DanhSachNguoiDung);
            panel1.Controls.Add(a);
            a.Dock = DockStyle.Fill;
        }

        private void LB_ViewAdvan_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void LB_ViewAdvan_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (detailsView == false)
                {
                    panel1.Controls.Clear();
                    b?.Dispose();
                    b = new DetailsEmList_UC(XuLyThongTin.DanhSachNguoiDung);
                    panel1.Controls.Add(b);
                    b.Dock = DockStyle.Fill;
                    detailsView = true;
                    LB_ViewAdvan.Text = "Xem nhanh thông tin";
                }
                else
                {
                    panel1.Controls.Clear();
                    a?.Dispose();
                    a = new QuickEmList_UC(XuLyThongTin.DanhSachNguoiDung);
                    panel1.Controls.Add(a);
                    a.Dock = DockStyle.Fill;
                    detailsView = false;
                    LB_ViewAdvan.Text = "Xem chi tiết thông tin";
                }
            }
        }
    }
}
