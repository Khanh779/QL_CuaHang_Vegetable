using DinhKhanh_Controls_UI.Helper;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
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
            var gp = GraphicsHelper.GetRoundPath(ClientRectangle, bordert + radius, bordert);
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
