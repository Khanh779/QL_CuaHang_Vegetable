namespace QL_CuaHang_Vegetable.ExContro
{
    partial class FoodCard
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dkCard1 = new DinhKhanh_Controls_UI.Other.DKCard();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(20, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(76, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(16, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 35);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sản phẩm";
            // 
            // dkCard1
            // 
            this.dkCard1.BarAlignment = DinhKhanh_Controls_UI.Enums.ContentLayoutAlign.Top;
            this.dkCard1.BarColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(149)))), ((int)(((byte)(108)))));
            this.dkCard1.BarColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(169)))), ((int)(((byte)(128)))));
            this.dkCard1.BarThickness = 2;
            this.dkCard1.BorderColor = System.Drawing.Color.Gainsboro;
            this.dkCard1.BorderThickness = 1;
            this.dkCard1.BrushAngle = 0;
            this.dkCard1.CardColor1 = System.Drawing.Color.White;
            this.dkCard1.CardColor2 = System.Drawing.Color.White;
            this.dkCard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dkCard1.Location = new System.Drawing.Point(3, 3);
            this.dkCard1.Name = "dkCard1";
            this.dkCard1.Radius = 5;
            this.dkCard1.ShadowAlpha = 255;
            this.dkCard1.ShadowColor = System.Drawing.Color.Black;
            this.dkCard1.ShadowPadding = new System.Windows.Forms.Padding(5);
            this.dkCard1.Size = new System.Drawing.Size(171, 184);
            this.dkCard1.TabIndex = 0;
            this.dkCard1.Text = "dkCard1";
            // 
            // FoodCard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dkCard1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FoodCard";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Size = new System.Drawing.Size(177, 190);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DinhKhanh_Controls_UI.Other.DKCard dkCard1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}
