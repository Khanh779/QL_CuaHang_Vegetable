namespace QL_CuaHang_Vegetable.TabPage
{
    partial class Tab_Home
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
            this.label1 = new System.Windows.Forms.Label();
            this.dkCard1 = new DinhKhanh_Controls_UI.Other.DKCard();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Trang chủ";
            // 
            // dkCard1
            // 
            this.dkCard1.BarAlignment = DinhKhanh_Controls_UI.Enums.ContentLayoutAlign.Top;
            this.dkCard1.BarColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(149)))), ((int)(((byte)(108)))));
            this.dkCard1.BarColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(149)))), ((int)(((byte)(108)))));
            this.dkCard1.BarThickness = 2;
            this.dkCard1.BorderColor = System.Drawing.Color.Silver;
            this.dkCard1.BorderThickness = 1;
            this.dkCard1.BrushAngle = 100;
            this.dkCard1.CardColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.dkCard1.CardColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.dkCard1.Location = new System.Drawing.Point(39, 118);
            this.dkCard1.Name = "dkCard1";
            this.dkCard1.Radius = 5;
            this.dkCard1.ShadowAlpha = 120;
            this.dkCard1.ShadowColor = System.Drawing.Color.Black;
            this.dkCard1.ShadowPadding = new System.Windows.Forms.Padding(1, 1, 1, 3);
            this.dkCard1.Size = new System.Drawing.Size(140, 148);
            this.dkCard1.TabIndex = 17;
            // 
            // Tab_Home
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.dkCard1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Tab_Home";
            this.Size = new System.Drawing.Size(775, 532);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public DinhKhanh_Controls_UI.Other.DKCard dkCard1;
    }
}
