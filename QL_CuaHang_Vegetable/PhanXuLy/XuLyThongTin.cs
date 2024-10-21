using System;
using System.Collections;
using System.Collections.Generic;

namespace QL_CuaHang_Vegetable.PhanXuLy
{
    [Serializable]
    public class XuLyThongTin
    {

        Dictionary<string, ThongTinUser> DanhSachNguoiDung { get; set; }

        public XuLyThongTin()
        {
            DanhSachNguoiDung = new Dictionary<string, ThongTinUser>();

        }
    }
}
