using System;
using System.Collections.Generic;

namespace QL_CuaHang_Vegetable.PhanXuLy
{
    [Serializable]
    public class ThongTinDonHang
    {
        public string MaDonHang { get; set; }
        public string TenKhachHang { get; set; }
        public string DiaChi { get; set; }
        public string SoDienThoai { get; set; }
        public string Email { get; set; }
        public DateTime NgayDatHang { get; set; }
        public double TongTien { get; set; }
        public TrangThai_DonHang TrangThai { get; set; }
        public LoaiDonHang LoaiDonHang { get; set; }
        public List<ThongTinSanPham> DanhSach_SanPham { get; set; } // Danh sách sản phẩm trong đơn hàng

        public ThongTinUser NguoiTao { get; set; } // Người tạo đơn hàng

        public ThongTinDonHang()
        {
            DanhSach_SanPham = new List<ThongTinSanPham>(); // Khởi tạo danh sách
        }
    }

    public enum LoaiDonHang
    {
        Nhap,
        Xuat
    }

    public enum TrangThai_DonHang
    {
        DangChoXuLy,
        DangGiaoHang,
        DaGiaoHang,
        DaHuy
    }
}
