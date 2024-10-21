using System;
using System.Windows.Forms;

namespace QL_CuaHang_Vegetable
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(DangNhap_Form.Instance);
            //Application.Run(new MauThietKe_KoSua());
        }
    }
}
