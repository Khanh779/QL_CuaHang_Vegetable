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
    public partial class Tab_Order : UserControl
    {
        static Tab_Order _obj;
        public static Tab_Order Instance
        {
            get
            {
                if (_obj == null || _obj.IsDisposed)
                {
                    _obj = new Tab_Order();
                }
                return _obj;
            }
        }
        public Tab_Order()
        {
            InitializeComponent();
            _obj = this;
        }
    }
}
