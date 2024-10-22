using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_CuaHang_Vegetable.PhanXuLy
{
    [Serializable]
    public class ThongTinUser
    {
        public string MaUser { get; set; }
        public string TenUser { get; set; }
        public string Email { get; set; }
        public string MatKhau { get; set; }
        public string SoDienThoai { get; set; }

        public string DiaChi { get; set; }

        public LoaiUser LoaiUser { get; set; }

        public HashSet<ThongTinDonHang> DanhSachDonHang { get; set; }

        public ThongTinUser()
        {
        }
    }

    public enum LoaiUser
    {
       QuanTri,
        NhanVien
    }
}
