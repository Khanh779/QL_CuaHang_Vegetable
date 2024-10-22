namespace QL_CuaHang_Vegetable.Forms.AddEmpls
{
    partial class DetailsEmList_UC
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listView1 = new System.Windows.Forms.ListView();
            this.CH_MaNV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CH_TenNV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CH_Email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CH_Sdt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CH_Pass = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CH_DiaChi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CH_LoaiUser = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CH_MaNV,
            this.CH_TenNV,
            this.CH_Email,
            this.CH_Sdt,
            this.CH_Pass,
            this.CH_DiaChi,
            this.CH_LoaiUser});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(762, 376);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // CH_MaNV
            // 
            this.CH_MaNV.Text = "Mã nhân viên";
            this.CH_MaNV.Width = 98;
            // 
            // CH_TenNV
            // 
            this.CH_TenNV.Text = "Tên nhân viên";
            this.CH_TenNV.Width = 137;
            // 
            // CH_Email
            // 
            this.CH_Email.Text = "Email";
            this.CH_Email.Width = 105;
            // 
            // CH_Sdt
            // 
            this.CH_Sdt.Text = "Số điện thoại";
            this.CH_Sdt.Width = 128;
            // 
            // CH_Pass
            // 
            this.CH_Pass.Text = "Mật khẩu";
            this.CH_Pass.Width = 88;
            // 
            // CH_DiaChi
            // 
            this.CH_DiaChi.Text = "Địa chỉ";
            this.CH_DiaChi.Width = 118;
            // 
            // CH_LoaiUser
            // 
            this.CH_LoaiUser.Text = "Loại User";
            this.CH_LoaiUser.Width = 91;
            // 
            // DetailsEmList_UC
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.listView1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Name = "DetailsEmList_UC";
            this.Size = new System.Drawing.Size(762, 376);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader CH_MaNV;
        private System.Windows.Forms.ColumnHeader CH_TenNV;
        private System.Windows.Forms.ColumnHeader CH_Email;
        private System.Windows.Forms.ColumnHeader CH_Sdt;
        private System.Windows.Forms.ColumnHeader CH_DiaChi;
        private System.Windows.Forms.ColumnHeader CH_LoaiUser;
        private System.Windows.Forms.ColumnHeader CH_Pass;
    }
}
