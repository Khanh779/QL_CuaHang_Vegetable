using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_CuaHang_Vegetable.PhanXuLy
{
    [Serializable]
    public class ThongTinDonHang
    {
        public int MaDonHang { get; set; }
        public string TenKhachHang { get; set; }
        public string DiaChi { get; set; }
        public string SoDienThoai { get; set; }
        public string Email { get; set; }
        public DateTime NgayDatHang { get; set; }
        public double TongTien { get; set; }
        public TrangThai_DonHang TrangThai { get; set; }


        public ThongTinDonHang()
        {
        }   
    }

    public enum TrangThai_DonHang
    {
        DangChoXuLy,
        DangGiaoHang,
        DaGiaoHang,
        DaHuy
    }
}
