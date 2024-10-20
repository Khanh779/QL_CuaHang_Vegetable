namespace QL_CuaHang_Vegetable.TabPage
{
    partial class Tab_Order
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.listViewOrders = new System.Windows.Forms.ListView();
            this.CH_CodeOrder = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CH_ProductName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CH_Number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CH_Coin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CH_Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CH_Status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LB_ItemCount = new System.Windows.Forms.Label();
            this.btn_Add_Order = new DinhKhanh_Controls_UI.Buttons.DKButton();
            this.btn_Edit_Order = new DinhKhanh_Controls_UI.Buttons.DKButton();
            this.btn_Del_Order = new DinhKhanh_Controls_UI.Buttons.DKButton();
            this.dkTextBox1 = new DinhKhanh_Controls_UI.TextControls.DKTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lý đơn hàng";
            // 
            // listViewOrders
            // 
            this.listViewOrders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewOrders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.listViewOrders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CH_CodeOrder,
            this.CH_ProductName,
            this.CH_Number,
            this.CH_Coin,
            this.CH_Date,
            this.CH_Status});
            this.listViewOrders.FullRowSelect = true;
            this.listViewOrders.HideSelection = false;
            this.listViewOrders.Location = new System.Drawing.Point(22, 80);
            this.listViewOrders.Name = "listViewOrders";
            this.listViewOrders.Size = new System.Drawing.Size(740, 369);
            this.listViewOrders.TabIndex = 1;
            this.listViewOrders.UseCompatibleStateImageBehavior = false;
            this.listViewOrders.View = System.Windows.Forms.View.Details;
            // 
            // CH_CodeOrder
            // 
            this.CH_CodeOrder.Text = "Mã đơn hàng";
            this.CH_CodeOrder.Width = 127;
            // 
            // CH_ProductName
            // 
            this.CH_ProductName.Text = "Tên sản phẩm";
            this.CH_ProductName.Width = 140;
            // 
            // CH_Number
            // 
            this.CH_Number.Text = "Số lượng";
            this.CH_Number.Width = 83;
            // 
            // CH_Coin
            // 
            this.CH_Coin.Text = "Giá";
            this.CH_Coin.Width = 110;
            // 
            // CH_Date
            // 
            this.CH_Date.Text = "Ngày đặt";
            this.CH_Date.Width = 113;
            // 
            // CH_Status
            // 
            this.CH_Status.Text = "Trạng thái";
            this.CH_Status.Width = 105;
            // 
            // LB_ItemCount
            // 
            this.LB_ItemCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LB_ItemCount.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.LB_ItemCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(169)))), ((int)(((byte)(128)))));
            this.LB_ItemCount.Location = new System.Drawing.Point(18, 469);
            this.LB_ItemCount.Name = "LB_ItemCount";
            this.LB_ItemCount.Size = new System.Drawing.Size(218, 36);
            this.LB_ItemCount.TabIndex = 47;
            this.LB_ItemCount.Text = "Số đơn: 12 đơn";
            // 
            // btn_Add_Order
            // 
            this.btn_Add_Order.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Add_Order.AnimationMode = DinhKhanh_Controls_UI.Enums.AnimationMode.Ripple;
            this.btn_Add_Order.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(139)))), ((int)(((byte)(34)))));
            this.btn_Add_Order.BorderThickness = 0;
            this.btn_Add_Order.ContentAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Add_Order.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Add_Order.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btn_Add_Order.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.btn_Add_Order.HoverColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(169)))), ((int)(((byte)(128)))));
            this.btn_Add_Order.HoverColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(149)))), ((int)(((byte)(108)))));
            this.btn_Add_Order.Image = null;
            this.btn_Add_Order.ImageOffsetX = 0;
            this.btn_Add_Order.ImageOffsetY = 0;
            this.btn_Add_Order.ImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Add_Order.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_Add_Order.Location = new System.Drawing.Point(450, 469);
            this.btn_Add_Order.Name = "btn_Add_Order";
            this.btn_Add_Order.NormalColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(149)))), ((int)(((byte)(108)))));
            this.btn_Add_Order.NormalColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(169)))), ((int)(((byte)(128)))));
            this.btn_Add_Order.PressColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(139)))), ((int)(((byte)(98)))));
            this.btn_Add_Order.PressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(139)))), ((int)(((byte)(98)))));
            this.btn_Add_Order.Radius = 5;
            this.btn_Add_Order.ShadowAlpha = 120;
            this.btn_Add_Order.ShadowColor = System.Drawing.Color.Black;
            this.btn_Add_Order.ShadowPadding = new System.Windows.Forms.Padding(0);
            this.btn_Add_Order.ShapeType = DinhKhanh_Controls_UI.Enums.ShapeType.RoundedRectangle;
            this.btn_Add_Order.Size = new System.Drawing.Size(100, 35);
            this.btn_Add_Order.StringTrimming = System.Drawing.StringTrimming.EllipsisCharacter;
            this.btn_Add_Order.TabIndex = 44;
            this.btn_Add_Order.Text = "Thêm";
            this.btn_Add_Order.TextHoverColor = System.Drawing.Color.White;
            this.btn_Add_Order.TextNormalColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Add_Order.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn_Add_Order.TextPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btn_Add_Order.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // btn_Edit_Order
            // 
            this.btn_Edit_Order.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Edit_Order.AnimationMode = DinhKhanh_Controls_UI.Enums.AnimationMode.Ripple;
            this.btn_Edit_Order.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(139)))), ((int)(((byte)(34)))));
            this.btn_Edit_Order.BorderThickness = 0;
            this.btn_Edit_Order.ContentAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Edit_Order.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Edit_Order.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btn_Edit_Order.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.btn_Edit_Order.HoverColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(120)))), ((int)(((byte)(1)))));
            this.btn_Edit_Order.HoverColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(101)))), ((int)(((byte)(36)))));
            this.btn_Edit_Order.Image = null;
            this.btn_Edit_Order.ImageOffsetX = 0;
            this.btn_Edit_Order.ImageOffsetY = 0;
            this.btn_Edit_Order.ImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Edit_Order.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_Edit_Order.Location = new System.Drawing.Point(556, 469);
            this.btn_Edit_Order.Name = "btn_Edit_Order";
            this.btn_Edit_Order.NormalColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(101)))), ((int)(((byte)(36)))));
            this.btn_Edit_Order.NormalColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(120)))), ((int)(((byte)(1)))));
            this.btn_Edit_Order.PressColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(91)))), ((int)(((byte)(26)))));
            this.btn_Edit_Order.PressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(110)))), ((int)(((byte)(0)))));
            this.btn_Edit_Order.Radius = 5;
            this.btn_Edit_Order.ShadowAlpha = 120;
            this.btn_Edit_Order.ShadowColor = System.Drawing.Color.Black;
            this.btn_Edit_Order.ShadowPadding = new System.Windows.Forms.Padding(0);
            this.btn_Edit_Order.ShapeType = DinhKhanh_Controls_UI.Enums.ShapeType.RoundedRectangle;
            this.btn_Edit_Order.Size = new System.Drawing.Size(100, 35);
            this.btn_Edit_Order.StringTrimming = System.Drawing.StringTrimming.EllipsisCharacter;
            this.btn_Edit_Order.TabIndex = 46;
            this.btn_Edit_Order.Text = "Chỉnh sửa";
            this.btn_Edit_Order.TextHoverColor = System.Drawing.Color.White;
            this.btn_Edit_Order.TextNormalColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Edit_Order.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn_Edit_Order.TextPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btn_Edit_Order.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // btn_Del_Order
            // 
            this.btn_Del_Order.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Del_Order.AnimationMode = DinhKhanh_Controls_UI.Enums.AnimationMode.Ripple;
            this.btn_Del_Order.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(139)))), ((int)(((byte)(34)))));
            this.btn_Del_Order.BorderThickness = 0;
            this.btn_Del_Order.ContentAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Del_Order.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Del_Order.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btn_Del_Order.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.btn_Del_Order.HoverColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(86)))), ((int)(((byte)(72)))));
            this.btn_Del_Order.HoverColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btn_Del_Order.Image = null;
            this.btn_Del_Order.ImageOffsetX = 0;
            this.btn_Del_Order.ImageOffsetY = 0;
            this.btn_Del_Order.ImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Del_Order.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_Del_Order.Location = new System.Drawing.Point(662, 469);
            this.btn_Del_Order.Name = "btn_Del_Order";
            this.btn_Del_Order.NormalColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btn_Del_Order.NormalColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(86)))), ((int)(((byte)(72)))));
            this.btn_Del_Order.PressColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btn_Del_Order.PressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(76)))), ((int)(((byte)(62)))));
            this.btn_Del_Order.Radius = 5;
            this.btn_Del_Order.ShadowAlpha = 120;
            this.btn_Del_Order.ShadowColor = System.Drawing.Color.Black;
            this.btn_Del_Order.ShadowPadding = new System.Windows.Forms.Padding(0);
            this.btn_Del_Order.ShapeType = DinhKhanh_Controls_UI.Enums.ShapeType.RoundedRectangle;
            this.btn_Del_Order.Size = new System.Drawing.Size(100, 35);
            this.btn_Del_Order.StringTrimming = System.Drawing.StringTrimming.EllipsisCharacter;
            this.btn_Del_Order.TabIndex = 45;
            this.btn_Del_Order.Text = "Xoá";
            this.btn_Del_Order.TextHoverColor = System.Drawing.Color.White;
            this.btn_Del_Order.TextNormalColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Del_Order.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn_Del_Order.TextPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btn_Del_Order.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // dkTextBox1
            // 
            this.dkTextBox1.AcceptReturn = false;
            this.dkTextBox1.AcceptTab = false;
            this.dkTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(252)))), ((int)(((byte)(250)))));
            this.dkTextBox1.BorderColor = System.Drawing.Color.Gray;
            this.dkTextBox1.BorderWidth = 1;
            this.dkTextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.dkTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.dkTextBox1.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(169)))), ((int)(((byte)(128)))));
            this.dkTextBox1.ForeColor = System.Drawing.Color.DimGray;
            this.dkTextBox1.HideSelection = true;
            this.dkTextBox1.Image = null;
            this.dkTextBox1.ImageAlignRight = false;
            this.dkTextBox1.ImageSize = new System.Drawing.Size(20, 20);
            this.dkTextBox1.ImageVisible = false;
            this.dkTextBox1.Lines = new string[0];
            this.dkTextBox1.Location = new System.Drawing.Point(545, 30);
            this.dkTextBox1.MaxLength = 32767;
            this.dkTextBox1.Name = "dkTextBox1";
            this.dkTextBox1.PasswordChar = '\0';
            this.dkTextBox1.ReadOnly = false;
            this.dkTextBox1.ShortCutKeysEnabled = true;
            this.dkTextBox1.Size = new System.Drawing.Size(217, 36);
            this.dkTextBox1.TabIndex = 48;
            this.dkTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.dkTextBox1.TextRenderHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.dkTextBox1.UnderlineStyle = true;
            this.dkTextBox1.UseAnimation = true;
            this.dkTextBox1.WartermarkFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dkTextBox1.Watermark = "Nhập mã hoặc tên đơn hàng";
            this.dkTextBox1.WatermarkForeColor = System.Drawing.Color.Gray;
            this.dkTextBox1.WordWrap = true;
            // 
            // Tab_Order
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.dkTextBox1);
            this.Controls.Add(this.LB_ItemCount);
            this.Controls.Add(this.btn_Add_Order);
            this.Controls.Add(this.btn_Edit_Order);
            this.Controls.Add(this.btn_Del_Order);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listViewOrders);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Tab_Order";
            this.Size = new System.Drawing.Size(775, 550);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listViewOrders;
        private System.Windows.Forms.ColumnHeader CH_CodeOrder;
        private System.Windows.Forms.ColumnHeader CH_ProductName;
        private System.Windows.Forms.ColumnHeader CH_Number;
        private System.Windows.Forms.ColumnHeader CH_Coin;
        private System.Windows.Forms.ColumnHeader CH_Date;
        private DinhKhanh_Controls_UI.Buttons.DKButton btn_Add_Order;
        private DinhKhanh_Controls_UI.Buttons.DKButton btn_Edit_Order;
        private DinhKhanh_Controls_UI.Buttons.DKButton btn_Del_Order;
        private System.Windows.Forms.ColumnHeader CH_Status;
        private System.Windows.Forms.Label LB_ItemCount;
        private DinhKhanh_Controls_UI.TextControls.DKTextBox dkTextBox1;
    }
}
