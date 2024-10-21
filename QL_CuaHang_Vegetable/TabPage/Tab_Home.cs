using QL_CuaHang_Vegetable.Forms;
using System.Windows.Forms;

namespace QL_CuaHang_Vegetable.TabPage
{
    public partial class Tab_Home : UserControl
    {

        static Tab_Home _obj;
        public static Tab_Home Instance
        {
            get
            {
                if (_obj == null || _obj.IsDisposed)
                {
                    _obj = new Tab_Home();
                }
                return _obj;
            }
        }

        public Tab_Home()
        {
            InitializeComponent();
            _obj = this;
        }

        private void btn_Add_Employ_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button== MouseButtons.Left)
            {
                Add_Employee_Form add_Employee_Form = new Add_Employee_Form();
                add_Employee_Form.Show();
            }    
        }
    }
}
