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
    public partial class DetailsEmList_UC : UserControl
    {
        public DetailsEmList_UC()
        {
            InitializeComponent();
        }

        public DetailsEmList_UC(List<ThongTinUser> danhSachNhanVien) : this()
        {
            foreach (var item in danhSachNhanVien)
            {
                ListViewItem listViewItem = new ListViewItem(item.MaUser);
                listViewItem.SubItems.Add(item.TenUser);
                listViewItem.SubItems.Add(item.Email);
                listViewItem.SubItems.Add(item.SoDienThoai);
                listViewItem.SubItems.Add(item.MatKhau);
                listViewItem.SubItems.Add(item.DiaChi);
                listViewItem.SubItems.Add(item.LoaiUser.ToString());
                listView1.Items.Add(listViewItem);
            }
        }
    }
}
