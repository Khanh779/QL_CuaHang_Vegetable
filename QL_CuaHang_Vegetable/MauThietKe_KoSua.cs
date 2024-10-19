using DinhKhanh_Controls_UI.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Media;
using System.Windows.Media.Media3D;
using Color = System.Drawing.Color;
using Pen = System.Drawing.Pen;

namespace QL_CuaHang_Vegetable
{
    public partial class MauThietKe_KoSua : Form
    {
        public MauThietKe_KoSua()
        {
            InitializeComponent();
            SetStyle(ControlStyles.ResizeRedraw, true);

        }

        private void MauThietKe_KoSua_Load(object sender, EventArgs e)
        {

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            int bordert = 12;
            int radius = 25;

            Color color = Color.Black;
            var gp = GraphicsHelper.GetRoundPath(ClientRectangle, bordert+ radius, bordert);
            using (PathGradientBrush pathGradientBrush = new PathGradientBrush(gp))
            using (Graphics g = e.Graphics)
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;
                ColorBlend colorBlend = new ColorBlend();
                colorBlend.Colors = new Color[] { Color.Transparent, color };
                colorBlend.Positions = new float[] { 0, 1 };
                pathGradientBrush.InterpolationColors = colorBlend;

                //pathGradientBrush.CenterColor = color; // Màu nằm ở trung tâm
                //pathGradientBrush.SurroundColors = new Color[] { Color.Transparent }; // Màu nằm ở ngoài

                using (var pen = new Pen(pathGradientBrush, bordert))
                {
                    g.DrawPath(pen, gp);
                }
            }
        }
    }
}
