using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_CuaHang_Vegetable.PhanXuLy
{
    [Serializable]
    public class ThongTinNhaCungCap
    {
        public string MaNCC { get; set; }
        public string TenNCC { get; set; }
        public string DiaChi { get; set; }
        public string SoDienThoai { get; set; }
        public string Email { get; set; }
        public ThongTinNhaCungCap()
        {
            MaNCC = "";
            TenNCC = "";
            DiaChi = "";
            SoDienThoai = "";
            Email = "";
        }
    }
}
