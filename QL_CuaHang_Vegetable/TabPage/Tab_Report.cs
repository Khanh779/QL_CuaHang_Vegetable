﻿using System.Windows.Forms;

namespace QL_CuaHang_Vegetable.TabPage
{
    public partial class Tab_Report : UserControl
    {

        static Tab_Report _instance;
        public static Tab_Report Instance
        {
            get
            {
                if (_instance == null || _instance.IsDisposed)
                    _instance = new Tab_Report();
                return _instance;
            }
        }

        public Tab_Report()
        {
            InitializeComponent();
            _instance = this;
        }
    }
}
