using DinhKhanh_Controls_UI.Buttons;
using System;
using System.IO;

namespace QL_CuaHang_Vegetable.PhanXuLy
{
    public class TrungTamXuLy
    {


        public static XuLyThongTin xuLyThongTin { get; set; }

        // Đặt đường dẫn mặt định cho file lưu trữ
        public static string duongDanTepTinLuuTru = "Luu_Tru_ThongTin.dk";

        public static void SaveFile()
        {
            try
            {
                // Lưu file nhị phân
                using (FileStream fs = new FileStream(duongDanTepTinLuuTru, FileMode.Create))
                {
                    System.Runtime.Serialization.Formatters.Binary.BinaryFormatter bf = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                    bf.Serialize(fs, xuLyThongTin);
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi lưu file: " + ex.Message);
            }
        }

        public static void ReadFile()
        {
            try
            {
                // Đọc file nhị phân
                using (FileStream fs = new FileStream(duongDanTepTinLuuTru, FileMode.Open))
                {
                    System.Runtime.Serialization.Formatters.Binary.BinaryFormatter bf = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                    xuLyThongTin = (XuLyThongTin)bf.Deserialize(fs);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi đọc file: " + ex.Message);
            }
        }


        public static DKButton NutBamMau_SangGradient_Title()
        {
            DKButton btn = new DKButton();
            btn.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            btn.BorderColor = System.Drawing.Color.FromArgb(255, 255, 255);

            btn.ShadowAlpha = 255;

            btn.NormalColor1 = System.Drawing.Color.FromArgb(234, 245, 245);
            btn.NormalColor2 = System.Drawing.Color.FromArgb(250, 250, 250);

            btn.PressColor1 = System.Drawing.Color.FromArgb(224, 235, 235);
            btn.PressColor2 = System.Drawing.Color.FromArgb(240, 240, 240);

            btn.HoverColor1 = System.Drawing.Color.FromArgb(250, 250, 250);
            btn.HoverColor2 = System.Drawing.Color.FromArgb(234, 245, 245);

            btn.ImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btn.ImageOffsetY = 8;
            btn.ImageSize = new System.Drawing.Size(50, 50);
            btn.Radius = 5;
            btn.ShadowPadding = new System.Windows.Forms.Padding(5);
            btn.TextPadding = new System.Windows.Forms.Padding(0, 5, 0, 0);

            btn.TextNormalColor = System.Drawing.Color.FromArgb(64, 64, 64);
            btn.TextPressColor = System.Drawing.Color.FromArgb(54, 54, 54);
            btn.TextHoverColor = System.Drawing.Color.FromArgb(74, 74, 74);


            return btn;
        }

    }
}
