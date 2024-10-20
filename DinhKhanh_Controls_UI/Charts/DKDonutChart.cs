using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace DinhKhanh_Controls_UI.Charts
{
    public class DKDonutChart : Control
    {
        public DKDonutChart()
        {
            this.SetStyle(ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.SupportsTransparentBackColor, true);
        }

        protected override void OnCreateControl()
        {
            base.OnCreateControl();

            // Ví dụ các item
            DKDonutChartItem item0 = new DKDonutChartItem();
            item0.Name = "dKDonutChartItem0";
            item0.Value = 100;
            item0.Color = Color.Red;
            item0.Index = 0;

            DKDonutChartItem item1 = new DKDonutChartItem();
            item1.Name = "dKDonutChartItem1";
            item1.Value = 200;
            item1.Color = Color.Blue;
            item1.Index = 1;

            DKDonutChartItem item2 = new DKDonutChartItem();
            item2.Name = "dKDonutChartItem2";
            item2.Value = 300;
            item2.Color = Color.Green;
            item2.Index = 2;

            items.Add(item0);
            items.Add(item1);
            items.Add(item2);


        }

        List<DKDonutChartItem> items { get; set; } = new List<DKDonutChartItem>();
        public List<DKDonutChartItem> Items
        {
            get { return items; }
            set
            {
                items = value;
                Invalidate();
            }
        }

        int arcWidth = 50;
        public int ArcWidth
        {
            get { return arcWidth; }
            set
            {
                arcWidth = value;
                Invalidate();
            }
        }

        int chartSize = 100;
        public int ChartSize
        {
            get { return chartSize; }
            set
            {
                chartSize = value;
                Invalidate();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            e.Graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            e.Graphics.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;

            if (Items == null || Items.Count == 0)
                return;

            var a = TaoBieuDo_BangBitmap();
            e.Graphics.DrawImage(a, 0, 0);

            a?.Dispose();

        }

        public Bitmap TaoBieuDo_BangBitmap()
        {
            // Create a bitmap with control size
            Bitmap bmp = new Bitmap(chartSize, this.chartSize);
            bmp.MakeTransparent();
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;

                if (Items == null || Items.Count == 0)
                    return bmp;

                float total = Items.Sum(x => (float)x.Value);
                float startAngle = 0;
                float sweepAngle = 0;

                Rectangle rect = new Rectangle(0, 0, chartSize - 1, chartSize - 1);
                for (int i = 0; i < Items.Count; i++)
                {
                    sweepAngle = (float)(Items[i].Value / total) * 360;
                    using (SolidBrush brush = new SolidBrush(Items[i].Color))
                    using (var pen = new Pen(Items[i].Color, ArcWidth))
                    {
                        g.DrawArc(pen, rect, startAngle, sweepAngle);
                    }
                    startAngle += sweepAngle;
                }
            }

            return bmp;
        }


    }

    [Serializable]
    public class DKDonutChartItem
    {
        public string Text { get; set; }
        public int Index { get; set; }
        public string Name { get; set; }
        public double Value { get; set; }
        public Color Color { get; set; }
    }
}
