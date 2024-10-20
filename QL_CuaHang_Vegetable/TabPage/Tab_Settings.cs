using System.Windows.Forms;

namespace QL_CuaHang_Vegetable.TabPage
{
    public partial class Tab_Settings : UserControl
    {
        static Tab_Settings _obj;
        public static Tab_Settings Instance
        {
            get
            {
                if (_obj == null || _obj.IsDisposed)
                {
                    _obj = new Tab_Settings();
                }
                return _obj;
            }
        }
        public Tab_Settings()
        {
            InitializeComponent();
            _obj = this;
        }
    }
}
