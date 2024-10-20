using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_CuaHang_Vegetable.TabPage
{
    public partial class Tab_Food : UserControl
    {
        static Tab_Food _obj;
        public static Tab_Food Instance
        {
            get
            {
                if (_obj == null || _obj.IsDisposed)
                {
                    _obj = new Tab_Food();
                }
                return _obj;
            }
        }

        public Tab_Food()
        {
            InitializeComponent();
            _obj = this;

            FLP_Products.Paint += FLP_Products_Paint;
        }

        private void FLP_Products_Paint(object sender, PaintEventArgs e)
        {
            // Vẽ khung xám
            ControlPaint.DrawBorder(e.Graphics, FLP_Products.ClientRectangle, Color.Silver, ButtonBorderStyle.Solid);
        }
    }
}
