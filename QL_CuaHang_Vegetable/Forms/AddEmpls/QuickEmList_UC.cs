using QL_CuaHang_Vegetable.PhanXuLy;
using System.Collections.Generic;
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
            //FLP_Products.Controls.Clear();


            foreach (var item in danhSachNhanVien)
            {
                var a = TrungTamXuLy.NutBamMau_SangGradient_Title();
                a.Size = new System.Drawing.Size(239, 170);
                a.Text = item.TenUser + $"\n({item.MaUser})";
                a.MouseClick += (sender, e) =>
                {
                    if (e.Button == MouseButtons.Left)
                    {
                        MessageBox.Show("Bạn đang chọn user: " + item.TenUser + "\nCó mã: " + item.MaUser);
                        ThongTinUser = item;
                    }
                };

                FLP_Products.Controls.Add(a);
            }
        }

        public ThongTinUser ThongTinUser { get; set; }


    }
}
