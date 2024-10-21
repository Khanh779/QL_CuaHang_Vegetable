using System;
using System.Drawing;

namespace QL_CuaHang_Vegetable.PhanXuLy
{
    [Serializable]
    public class ThongTinSanPham
    {
        public string MaSanPham { get; set; }
        public string TenSanPham { get; set; }
        public string LoaiSanPham { get; set; }
        public int SoLuong { get; set; }
        public double GiaBan { get; set; }
        public double GiaNhap { get; set; }
        public Bitmap HinhAnh { get; set; }
        public string MoTa { get; set; }
        public DateTime NgayHetHan { get; set; }
        public DateTime NgaySanXuat { get; set; }
        public string NhaCungCap { get; set; }
        public DateTime NgayTao { get; set; }

        public ThongTinSanPham() { }
    }
}
