using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_CuaHang_Vegetable.PhanXuLy
{
    [Serializable]
    public class XuLyThongTin
    {

        public static HashSet<ThongTinSanPham> DanhSachSanPham { get; set; }
        public static HashSet<ThongTinDonHang> DanhSachDonHang { get; set; }

        public XuLyThongTin()
        {
            DanhSachSanPham = new HashSet<ThongTinSanPham>();

            DanhSachDonHang = new HashSet<ThongTinDonHang>();

        }
    }
}
