using DinhKhanh_Controls_UI.Forms;

namespace QL_CuaHang_Vegetable.Forms
{
    public class Add_Manufacturer_Form : TemplateForm
    {
        private DinhKhanh_Controls_UI.Buttons.DKButton btn_Del_Product;
        private System.Windows.Forms.GroupBox groupBox1;
        private DinhKhanh_Controls_UI.TextControls.DKTextBox dkTextBox1;
        private System.Windows.Forms.Label label5;
        private DinhKhanh_Controls_UI.TextControls.DKTextBox dkTextBox2;
        private System.Windows.Forms.Label label6;
        private DinhKhanh_Controls_UI.TextControls.DKTextBox txt_Loai;
        private System.Windows.Forms.Label label4;
        private DinhKhanh_Controls_UI.TextControls.DKTextBox txt_SoLuong;
        private System.Windows.Forms.Label label3;
        private DinhKhanh_Controls_UI.TextControls.DKTextBox txt_TenSP;
        private System.Windows.Forms.Label label1;
        private DinhKhanh_Controls_UI.TextControls.DKTextBox txt_MaNCC;
        private System.Windows.Forms.Label label2;
        private DinhKhanh_Controls_UI.Buttons.DKButton dkButton1;

        private void InitializeComponent()
        {
            this.btn_Del_Product = new DinhKhanh_Controls_UI.Buttons.DKButton();
            this.dkButton1 = new DinhKhanh_Controls_UI.Buttons.DKButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dkTextBox1 = new DinhKhanh_Controls_UI.TextControls.DKTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dkTextBox2 = new DinhKhanh_Controls_UI.TextControls.DKTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Loai = new DinhKhanh_Controls_UI.TextControls.DKTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_SoLuong = new DinhKhanh_Controls_UI.TextControls.DKTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_TenSP = new DinhKhanh_Controls_UI.TextControls.DKTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_MaNCC = new DinhKhanh_Controls_UI.TextControls.DKTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Del_Product
            // 
            this.btn_Del_Product.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Del_Product.AnimationMode = DinhKhanh_Controls_UI.Enums.AnimationMode.Ripple;
            this.btn_Del_Product.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(139)))), ((int)(((byte)(34)))));
            this.btn_Del_Product.BorderThickness = 0;
            this.btn_Del_Product.ContentAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Del_Product.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Del_Product.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btn_Del_Product.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.btn_Del_Product.HoverColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(86)))), ((int)(((byte)(72)))));
            this.btn_Del_Product.HoverColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btn_Del_Product.Image = null;
            this.btn_Del_Product.ImageOffsetX = 0;
            this.btn_Del_Product.ImageOffsetY = 0;
            this.btn_Del_Product.ImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Del_Product.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_Del_Product.Location = new System.Drawing.Point(592, 235);
            this.btn_Del_Product.Name = "btn_Del_Product";
            this.btn_Del_Product.NormalColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btn_Del_Product.NormalColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(86)))), ((int)(((byte)(72)))));
            this.btn_Del_Product.PressColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btn_Del_Product.PressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(76)))), ((int)(((byte)(62)))));
            this.btn_Del_Product.Radius = 5;
            this.btn_Del_Product.ShadowAlpha = 120;
            this.btn_Del_Product.ShadowColor = System.Drawing.Color.Black;
            this.btn_Del_Product.ShadowPadding = new System.Windows.Forms.Padding(0);
            this.btn_Del_Product.ShapeType = DinhKhanh_Controls_UI.Enums.ShapeType.RoundedRectangle;
            this.btn_Del_Product.Size = new System.Drawing.Size(77, 30);
            this.btn_Del_Product.StringTrimming = System.Drawing.StringTrimming.EllipsisCharacter;
            this.btn_Del_Product.TabIndex = 71;
            this.btn_Del_Product.Text = "Huỷ";
            this.btn_Del_Product.TextHoverColor = System.Drawing.Color.White;
            this.btn_Del_Product.TextNormalColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Del_Product.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn_Del_Product.TextPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btn_Del_Product.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // dkButton1
            // 
            this.dkButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dkButton1.AnimationMode = DinhKhanh_Controls_UI.Enums.AnimationMode.Ripple;
            this.dkButton1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(139)))), ((int)(((byte)(34)))));
            this.dkButton1.BorderThickness = 0;
            this.dkButton1.ContentAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.dkButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dkButton1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.dkButton1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.dkButton1.HoverColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(169)))), ((int)(((byte)(128)))));
            this.dkButton1.HoverColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(149)))), ((int)(((byte)(108)))));
            this.dkButton1.Image = null;
            this.dkButton1.ImageOffsetX = 0;
            this.dkButton1.ImageOffsetY = 0;
            this.dkButton1.ImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.dkButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.dkButton1.Location = new System.Drawing.Point(508, 235);
            this.dkButton1.Name = "dkButton1";
            this.dkButton1.NormalColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(149)))), ((int)(((byte)(108)))));
            this.dkButton1.NormalColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(169)))), ((int)(((byte)(128)))));
            this.dkButton1.PressColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(139)))), ((int)(((byte)(98)))));
            this.dkButton1.PressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(139)))), ((int)(((byte)(98)))));
            this.dkButton1.Radius = 5;
            this.dkButton1.ShadowAlpha = 120;
            this.dkButton1.ShadowColor = System.Drawing.Color.Black;
            this.dkButton1.ShadowPadding = new System.Windows.Forms.Padding(0);
            this.dkButton1.ShapeType = DinhKhanh_Controls_UI.Enums.ShapeType.RoundedRectangle;
            this.dkButton1.Size = new System.Drawing.Size(77, 30);
            this.dkButton1.StringTrimming = System.Drawing.StringTrimming.EllipsisCharacter;
            this.dkButton1.TabIndex = 70;
            this.dkButton1.Text = "Lưu";
            this.dkButton1.TextHoverColor = System.Drawing.Color.White;
            this.dkButton1.TextNormalColor = System.Drawing.Color.WhiteSmoke;
            this.dkButton1.TextPadding = new System.Windows.Forms.Padding(0);
            this.dkButton1.TextPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dkButton1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dkTextBox1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dkTextBox2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_Loai);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_SoLuong);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_TenSP);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_MaNCC);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.groupBox1.Location = new System.Drawing.Point(20, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(652, 172);
            this.groupBox1.TabIndex = 69;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhà cung cấp";
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
            this.dkTextBox1.Location = new System.Drawing.Point(458, 117);
            this.dkTextBox1.MaxLength = 32767;
            this.dkTextBox1.Name = "dkTextBox1";
            this.dkTextBox1.PasswordChar = '\0';
            this.dkTextBox1.ReadOnly = false;
            this.dkTextBox1.ShortCutKeysEnabled = true;
            this.dkTextBox1.Size = new System.Drawing.Size(179, 25);
            this.dkTextBox1.TabIndex = 75;
            this.dkTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.dkTextBox1.TextRenderHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.dkTextBox1.UnderlineStyle = true;
            this.dkTextBox1.UseAnimation = true;
            this.dkTextBox1.WartermarkFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dkTextBox1.Watermark = "Nhập ghi chú ...";
            this.dkTextBox1.WatermarkForeColor = System.Drawing.Color.Gray;
            this.dkTextBox1.WordWrap = true;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(335, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 25);
            this.label5.TabIndex = 74;
            this.label5.Text = "Nhập ghi chú:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dkTextBox2
            // 
            this.dkTextBox2.AcceptReturn = false;
            this.dkTextBox2.AcceptTab = false;
            this.dkTextBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(252)))), ((int)(((byte)(250)))));
            this.dkTextBox2.BorderColor = System.Drawing.Color.Gray;
            this.dkTextBox2.BorderWidth = 1;
            this.dkTextBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.dkTextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.dkTextBox2.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(169)))), ((int)(((byte)(128)))));
            this.dkTextBox2.ForeColor = System.Drawing.Color.DimGray;
            this.dkTextBox2.HideSelection = true;
            this.dkTextBox2.Image = null;
            this.dkTextBox2.ImageAlignRight = false;
            this.dkTextBox2.ImageSize = new System.Drawing.Size(20, 20);
            this.dkTextBox2.ImageVisible = false;
            this.dkTextBox2.Lines = new string[0];
            this.dkTextBox2.Location = new System.Drawing.Point(134, 117);
            this.dkTextBox2.MaxLength = 32767;
            this.dkTextBox2.Name = "dkTextBox2";
            this.dkTextBox2.PasswordChar = '\0';
            this.dkTextBox2.ReadOnly = false;
            this.dkTextBox2.ShortCutKeysEnabled = true;
            this.dkTextBox2.Size = new System.Drawing.Size(179, 25);
            this.dkTextBox2.TabIndex = 73;
            this.dkTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.dkTextBox2.TextRenderHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.dkTextBox2.UnderlineStyle = true;
            this.dkTextBox2.UseAnimation = true;
            this.dkTextBox2.WartermarkFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dkTextBox2.Watermark = "Nhập địa chỉ";
            this.dkTextBox2.WatermarkForeColor = System.Drawing.Color.Gray;
            this.dkTextBox2.WordWrap = true;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(10, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 25);
            this.label6.TabIndex = 72;
            this.label6.Text = "Địa chỉ:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_Loai
            // 
            this.txt_Loai.AcceptReturn = false;
            this.txt_Loai.AcceptTab = false;
            this.txt_Loai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(252)))), ((int)(((byte)(250)))));
            this.txt_Loai.BorderColor = System.Drawing.Color.Gray;
            this.txt_Loai.BorderWidth = 1;
            this.txt_Loai.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_Loai.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Loai.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(169)))), ((int)(((byte)(128)))));
            this.txt_Loai.ForeColor = System.Drawing.Color.DimGray;
            this.txt_Loai.HideSelection = true;
            this.txt_Loai.Image = null;
            this.txt_Loai.ImageAlignRight = false;
            this.txt_Loai.ImageSize = new System.Drawing.Size(20, 20);
            this.txt_Loai.ImageVisible = false;
            this.txt_Loai.Lines = new string[0];
            this.txt_Loai.Location = new System.Drawing.Point(458, 79);
            this.txt_Loai.MaxLength = 32767;
            this.txt_Loai.Name = "txt_Loai";
            this.txt_Loai.PasswordChar = '\0';
            this.txt_Loai.ReadOnly = false;
            this.txt_Loai.ShortCutKeysEnabled = true;
            this.txt_Loai.Size = new System.Drawing.Size(179, 25);
            this.txt_Loai.TabIndex = 71;
            this.txt_Loai.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_Loai.TextRenderHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.txt_Loai.UnderlineStyle = true;
            this.txt_Loai.UseAnimation = true;
            this.txt_Loai.WartermarkFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Loai.Watermark = "Nhập số điện thoại";
            this.txt_Loai.WatermarkForeColor = System.Drawing.Color.Gray;
            this.txt_Loai.WordWrap = true;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(333, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 25);
            this.label4.TabIndex = 70;
            this.label4.Text = "Số điện thoại:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_SoLuong
            // 
            this.txt_SoLuong.AcceptReturn = false;
            this.txt_SoLuong.AcceptTab = false;
            this.txt_SoLuong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(252)))), ((int)(((byte)(250)))));
            this.txt_SoLuong.BorderColor = System.Drawing.Color.Gray;
            this.txt_SoLuong.BorderWidth = 1;
            this.txt_SoLuong.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_SoLuong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_SoLuong.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(169)))), ((int)(((byte)(128)))));
            this.txt_SoLuong.ForeColor = System.Drawing.Color.DimGray;
            this.txt_SoLuong.HideSelection = true;
            this.txt_SoLuong.Image = null;
            this.txt_SoLuong.ImageAlignRight = false;
            this.txt_SoLuong.ImageSize = new System.Drawing.Size(20, 20);
            this.txt_SoLuong.ImageVisible = false;
            this.txt_SoLuong.Lines = new string[0];
            this.txt_SoLuong.Location = new System.Drawing.Point(134, 79);
            this.txt_SoLuong.MaxLength = 32767;
            this.txt_SoLuong.Name = "txt_SoLuong";
            this.txt_SoLuong.PasswordChar = '\0';
            this.txt_SoLuong.ReadOnly = false;
            this.txt_SoLuong.ShortCutKeysEnabled = true;
            this.txt_SoLuong.Size = new System.Drawing.Size(179, 25);
            this.txt_SoLuong.TabIndex = 69;
            this.txt_SoLuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_SoLuong.TextRenderHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.txt_SoLuong.UnderlineStyle = true;
            this.txt_SoLuong.UseAnimation = true;
            this.txt_SoLuong.WartermarkFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SoLuong.Watermark = "Nhập email";
            this.txt_SoLuong.WatermarkForeColor = System.Drawing.Color.Gray;
            this.txt_SoLuong.WordWrap = true;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(10, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 25);
            this.label3.TabIndex = 68;
            this.label3.Text = "Email:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_TenSP
            // 
            this.txt_TenSP.AcceptReturn = false;
            this.txt_TenSP.AcceptTab = false;
            this.txt_TenSP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(252)))), ((int)(((byte)(250)))));
            this.txt_TenSP.BorderColor = System.Drawing.Color.Gray;
            this.txt_TenSP.BorderWidth = 1;
            this.txt_TenSP.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_TenSP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_TenSP.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(169)))), ((int)(((byte)(128)))));
            this.txt_TenSP.ForeColor = System.Drawing.Color.DimGray;
            this.txt_TenSP.HideSelection = true;
            this.txt_TenSP.Image = null;
            this.txt_TenSP.ImageAlignRight = false;
            this.txt_TenSP.ImageSize = new System.Drawing.Size(20, 20);
            this.txt_TenSP.ImageVisible = false;
            this.txt_TenSP.Lines = new string[0];
            this.txt_TenSP.Location = new System.Drawing.Point(458, 42);
            this.txt_TenSP.MaxLength = 32767;
            this.txt_TenSP.Name = "txt_TenSP";
            this.txt_TenSP.PasswordChar = '\0';
            this.txt_TenSP.ReadOnly = false;
            this.txt_TenSP.ShortCutKeysEnabled = true;
            this.txt_TenSP.Size = new System.Drawing.Size(179, 25);
            this.txt_TenSP.TabIndex = 67;
            this.txt_TenSP.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_TenSP.TextRenderHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.txt_TenSP.UnderlineStyle = true;
            this.txt_TenSP.UseAnimation = true;
            this.txt_TenSP.WartermarkFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenSP.Watermark = "Nhập tên NCC";
            this.txt_TenSP.WatermarkForeColor = System.Drawing.Color.Gray;
            this.txt_TenSP.WordWrap = true;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(333, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 25);
            this.label1.TabIndex = 66;
            this.label1.Text = "Tên nhà cung cấp:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_MaNCC
            // 
            this.txt_MaNCC.AcceptReturn = false;
            this.txt_MaNCC.AcceptTab = false;
            this.txt_MaNCC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(252)))), ((int)(((byte)(250)))));
            this.txt_MaNCC.BorderColor = System.Drawing.Color.Gray;
            this.txt_MaNCC.BorderWidth = 1;
            this.txt_MaNCC.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_MaNCC.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_MaNCC.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(169)))), ((int)(((byte)(128)))));
            this.txt_MaNCC.ForeColor = System.Drawing.Color.DimGray;
            this.txt_MaNCC.HideSelection = true;
            this.txt_MaNCC.Image = null;
            this.txt_MaNCC.ImageAlignRight = false;
            this.txt_MaNCC.ImageSize = new System.Drawing.Size(20, 20);
            this.txt_MaNCC.ImageVisible = false;
            this.txt_MaNCC.Lines = new string[0];
            this.txt_MaNCC.Location = new System.Drawing.Point(134, 42);
            this.txt_MaNCC.MaxLength = 32767;
            this.txt_MaNCC.Name = "txt_MaNCC";
            this.txt_MaNCC.PasswordChar = '\0';
            this.txt_MaNCC.ReadOnly = false;
            this.txt_MaNCC.ShortCutKeysEnabled = true;
            this.txt_MaNCC.Size = new System.Drawing.Size(179, 25);
            this.txt_MaNCC.TabIndex = 65;
            this.txt_MaNCC.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_MaNCC.TextRenderHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.txt_MaNCC.UnderlineStyle = true;
            this.txt_MaNCC.UseAnimation = true;
            this.txt_MaNCC.WartermarkFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaNCC.Watermark = "Nhập mã NCC";
            this.txt_MaNCC.WatermarkForeColor = System.Drawing.Color.Gray;
            this.txt_MaNCC.WordWrap = true;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(10, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 25);
            this.label2.TabIndex = 64;
            this.label2.Text = "Mã nhà cung cấp:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Add_Manufacturer_Form
            // 
            this.AllowResize = false;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(690, 280);
            this.Controls.Add(this.btn_Del_Product);
            this.Controls.Add(this.dkButton1);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Add_Manufacturer_Form";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thêm nhà cung cấp";
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.dkButton1, 0);
            this.Controls.SetChildIndex(this.btn_Del_Product, 0);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        public Add_Manufacturer_Form()
        {
            InitializeComponent();
        }


    }
}
