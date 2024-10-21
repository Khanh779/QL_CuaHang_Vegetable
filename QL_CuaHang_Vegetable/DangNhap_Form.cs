using DinhKhanh_Controls_UI.Forms;
using QL_CuaHang_Vegetable.PhanXuLy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_CuaHang_Vegetable
{
    public partial class DangNhap_Form : TemplateForm
    {

        static DangNhap_Form dangNhap_Form;
        public static DangNhap_Form Instance
        {
            get
            {
                if (dangNhap_Form == null || dangNhap_Form.IsDisposed)
                {
                    dangNhap_Form = new DangNhap_Form();
                }
                dangNhap_Form.BringToFront();
                return dangNhap_Form;
            }
        }

        public DangNhap_Form()
        {
            InitializeComponent();
            dangNhap_Form = this;
        }

        private void dkCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            txt_Pass.UseSystemPasswordChar = !dkCheckBox1.Checked;
        }

        private void btn_Close_MouseClick(object sender, MouseEventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn đóng ko?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question)== DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btn_Login_MouseClick(object sender, MouseEventArgs e)
        {
            if(txt_UserName.Text == "" || txt_Pass.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                if(txt_UserName.Text =="admin" && txt_Pass.Text=="admin")
                {
                    MessageBox.Show("Đăng nhập thành công", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();

                    QuanTri_Main.Instance.Show();

                  
                }    
            }
        }
    }
}
