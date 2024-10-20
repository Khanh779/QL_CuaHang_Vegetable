using System;
using System.Collections.Generic;

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
