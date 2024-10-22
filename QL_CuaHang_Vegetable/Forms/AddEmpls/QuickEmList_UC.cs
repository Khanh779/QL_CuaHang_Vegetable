using QL_CuaHang_Vegetable.PhanXuLy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_CuaHang_Vegetable.Forms.AddEmpls
{
    public partial class QuickEmList_UC : UserControl
    {
        public QuickEmList_UC()
        {
            InitializeComponent();
        }

        public QuickEmList_UC(List<ThongTinUser> danhSachNhanVien) : this()
        {
            foreach (var item in danhSachNhanVien)
            {
                var a = TrungTamXuLy.NutBamMau_SangGradient_Title();
                a.Size = new System.Drawing.Size(239, 170);
                a.Text = item.TenUser + $"\n({item.MaUser})";

                FLP_Products.Controls.Add(a);
            }
        }
    }
}
