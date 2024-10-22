using System;
using System.Collections;
using System.Collections.Generic;

namespace QL_CuaHang_Vegetable.PhanXuLy
{
    [Serializable]
    public class XuLyThongTin
    {

         public static Dictionary<string, ThongTinUser> LocNguoiDung = new Dictionary<string, ThongTinUser>();
        public static List<ThongTinUser> DanhSachNguoiDung = new List<ThongTinUser>();

        public XuLyThongTin()
        {
          

        }
    }
}
