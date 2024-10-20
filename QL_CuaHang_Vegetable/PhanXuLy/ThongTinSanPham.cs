using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_CuaHang_Vegetable.PhanXuLy
{
    [Serializable]
    public class ThongTinSanPham
    {
        public int MaSanPham { get; set; }
        public string TenSanPham { get; set; }
        public string LoaiSanPham { get; set; }
        public string DonViTinh { get; set; }
        public int SoLuong { get; set; }
        public double GiaBan { get; set; }
        public double GiaNhap { get; set; }
        public Image HinhAnh { get; set; }
        public string MoTa { get; set; }

        public DateTime NgayHetHan { get; set; }

        public DateTime NgaySanXuat { get; set; }

        public string NhaCungCap { get; set; }
        public ThongTinSanPham()
        {
        }

    }
}
