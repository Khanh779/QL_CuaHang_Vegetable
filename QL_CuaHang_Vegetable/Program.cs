﻿using System;
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
            Application.Run(Form1.Instance);
            //Application.Run(new MauThietKe_KoSua());
        }
    }
}
