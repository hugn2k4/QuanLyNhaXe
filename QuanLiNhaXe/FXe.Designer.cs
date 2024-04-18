namespace QuanLiNhaXe
{
    partial class FXe
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblBiensoXe = new System.Windows.Forms.Label();
            this.dtgvXe = new System.Windows.Forms.DataGridView();
            this.lblDotai = new System.Windows.Forms.Label();
            this.lblKhonggian = new System.Windows.Forms.Label();
            this.lblLoaixe = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTrangthaixe = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaXe = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtBienSoXe = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtLoaiXe = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtSoGhe = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtDoTai = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtKGHC = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbbTrangThaiXe = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.btnXoa = new Guna.UI2.WinForms.Guna2Button();
            this.btnThem = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvXe)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBiensoXe
            // 
            this.lblBiensoXe.AutoSize = true;
            this.lblBiensoXe.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBiensoXe.Location = new System.Drawing.Point(365, 23);
            this.lblBiensoXe.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBiensoXe.Name = "lblBiensoXe";
            this.lblBiensoXe.Size = new System.Drawing.Size(94, 21);
            this.lblBiensoXe.TabIndex = 1;
            this.lblBiensoXe.Text = "Biển số Xe:";
            // 
            // dtgvXe
            // 
            this.dtgvXe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvXe.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(254)))), ((int)(((byte)(247)))));
            this.dtgvXe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvXe.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(93)))), ((int)(((byte)(102)))));
            this.dtgvXe.Location = new System.Drawing.Point(5, 288);
            this.dtgvXe.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dtgvXe.Name = "dtgvXe";
            this.dtgvXe.RowHeadersWidth = 51;
            this.dtgvXe.RowTemplate.Height = 24;
            this.dtgvXe.Size = new System.Drawing.Size(1076, 335);
            this.dtgvXe.TabIndex = 3;
            this.dtgvXe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgXe_CellClick);
            // 
            // lblDotai
            // 
            this.lblDotai.AutoSize = true;
            this.lblDotai.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDotai.Location = new System.Drawing.Point(57, 105);
            this.lblDotai.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDotai.Name = "lblDotai";
            this.lblDotai.Size = new System.Drawing.Size(61, 21);
            this.lblDotai.TabIndex = 18;
            this.lblDotai.Text = "Độ tải:";
            // 
            // lblKhonggian
            // 
            this.lblKhonggian.AutoSize = true;
            this.lblKhonggian.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKhonggian.Location = new System.Drawing.Point(365, 105);
            this.lblKhonggian.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKhonggian.Name = "lblKhonggian";
            this.lblKhonggian.Size = new System.Drawing.Size(170, 21);
            this.lblKhonggian.TabIndex = 28;
            this.lblKhonggian.Text = "Không gian hầm chứa";
            // 
            // lblLoaixe
            // 
            this.lblLoaixe.AutoSize = true;
            this.lblLoaixe.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoaixe.Location = new System.Drawing.Point(673, 23);
            this.lblLoaixe.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLoaixe.Name = "lblLoaixe";
            this.lblLoaixe.Size = new System.Drawing.Size(70, 21);
            this.lblLoaixe.TabIndex = 26;
            this.lblLoaixe.Text = "Loại Xe:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(667, 105);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 21);
            this.label3.TabIndex = 32;
            this.label3.Text = "Số ghế";
            // 
            // lblTrangthaixe
            // 
            this.lblTrangthaixe.AutoSize = true;
            this.lblTrangthaixe.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrangthaixe.Location = new System.Drawing.Point(57, 170);
            this.lblTrangthaixe.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTrangthaixe.Name = "lblTrangthaixe";
            this.lblTrangthaixe.Size = new System.Drawing.Size(114, 21);
            this.lblTrangthaixe.TabIndex = 30;
            this.lblTrangthaixe.Text = "Trạng thái xe:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 21);
            this.label1.TabIndex = 57;
            this.label1.Text = "Mã xe:";
            // 
            // txtMaXe
            // 
            this.txtMaXe.BorderRadius = 10;
            this.txtMaXe.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaXe.DefaultText = "";
            this.txtMaXe.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaXe.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaXe.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaXe.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaXe.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaXe.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaXe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.txtMaXe.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaXe.Location = new System.Drawing.Point(62, 48);
            this.txtMaXe.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtMaXe.Name = "txtMaXe";
            this.txtMaXe.PasswordChar = '\0';
            this.txtMaXe.PlaceholderText = "";
            this.txtMaXe.SelectedText = "";
            this.txtMaXe.Size = new System.Drawing.Size(244, 37);
            this.txtMaXe.TabIndex = 165;
            // 
            // txtBienSoXe
            // 
            this.txtBienSoXe.BorderRadius = 10;
            this.txtBienSoXe.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBienSoXe.DefaultText = "";
            this.txtBienSoXe.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBienSoXe.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBienSoXe.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBienSoXe.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBienSoXe.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBienSoXe.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBienSoXe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.txtBienSoXe.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBienSoXe.Location = new System.Drawing.Point(369, 48);
            this.txtBienSoXe.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtBienSoXe.Name = "txtBienSoXe";
            this.txtBienSoXe.PasswordChar = '\0';
            this.txtBienSoXe.PlaceholderText = "";
            this.txtBienSoXe.SelectedText = "";
            this.txtBienSoXe.Size = new System.Drawing.Size(244, 37);
            this.txtBienSoXe.TabIndex = 166;
            // 
            // txtLoaiXe
            // 
            this.txtLoaiXe.BorderRadius = 10;
            this.txtLoaiXe.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLoaiXe.DefaultText = "";
            this.txtLoaiXe.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtLoaiXe.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtLoaiXe.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLoaiXe.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLoaiXe.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLoaiXe.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoaiXe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.txtLoaiXe.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLoaiXe.Location = new System.Drawing.Point(671, 48);
            this.txtLoaiXe.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtLoaiXe.Name = "txtLoaiXe";
            this.txtLoaiXe.PasswordChar = '\0';
            this.txtLoaiXe.PlaceholderText = "";
            this.txtLoaiXe.SelectedText = "";
            this.txtLoaiXe.Size = new System.Drawing.Size(244, 37);
            this.txtLoaiXe.TabIndex = 167;
            // 
            // txtSoGhe
            // 
            this.txtSoGhe.BorderRadius = 10;
            this.txtSoGhe.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSoGhe.DefaultText = "";
            this.txtSoGhe.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSoGhe.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSoGhe.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoGhe.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoGhe.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoGhe.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoGhe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.txtSoGhe.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoGhe.Location = new System.Drawing.Point(671, 130);
            this.txtSoGhe.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtSoGhe.Name = "txtSoGhe";
            this.txtSoGhe.PasswordChar = '\0';
            this.txtSoGhe.PlaceholderText = "";
            this.txtSoGhe.SelectedText = "";
            this.txtSoGhe.Size = new System.Drawing.Size(244, 37);
            this.txtSoGhe.TabIndex = 168;
            // 
            // txtDoTai
            // 
            this.txtDoTai.BorderRadius = 10;
            this.txtDoTai.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDoTai.DefaultText = "";
            this.txtDoTai.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDoTai.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDoTai.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDoTai.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDoTai.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDoTai.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDoTai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.txtDoTai.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDoTai.Location = new System.Drawing.Point(62, 129);
            this.txtDoTai.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtDoTai.Name = "txtDoTai";
            this.txtDoTai.PasswordChar = '\0';
            this.txtDoTai.PlaceholderText = "";
            this.txtDoTai.SelectedText = "";
            this.txtDoTai.Size = new System.Drawing.Size(244, 37);
            this.txtDoTai.TabIndex = 169;
            // 
            // txtKGHC
            // 
            this.txtKGHC.BorderRadius = 10;
            this.txtKGHC.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtKGHC.DefaultText = "";
            this.txtKGHC.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtKGHC.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtKGHC.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtKGHC.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtKGHC.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtKGHC.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKGHC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.txtKGHC.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtKGHC.Location = new System.Drawing.Point(369, 130);
            this.txtKGHC.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtKGHC.Name = "txtKGHC";
            this.txtKGHC.PasswordChar = '\0';
            this.txtKGHC.PlaceholderText = "";
            this.txtKGHC.SelectedText = "";
            this.txtKGHC.Size = new System.Drawing.Size(244, 37);
            this.txtKGHC.TabIndex = 170;
            // 
            // cbbTrangThaiXe
            // 
            this.cbbTrangThaiXe.BackColor = System.Drawing.Color.Transparent;
            this.cbbTrangThaiXe.BorderRadius = 10;
            this.cbbTrangThaiXe.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbTrangThaiXe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTrangThaiXe.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbTrangThaiXe.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbTrangThaiXe.Font = new System.Drawing.Font("Tahoma", 12F);
            this.cbbTrangThaiXe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.cbbTrangThaiXe.ItemHeight = 30;
            this.cbbTrangThaiXe.Items.AddRange(new object[] {
            "Đang chạy",
            "Đang bảo dưỡng",
            "Đã tham gia",
            "Chưa tham gia"});
            this.cbbTrangThaiXe.Location = new System.Drawing.Point(62, 194);
            this.cbbTrangThaiXe.Name = "cbbTrangThaiXe";
            this.cbbTrangThaiXe.Size = new System.Drawing.Size(244, 36);
            this.cbbTrangThaiXe.TabIndex = 171;
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 5;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(226)))), ((int)(((byte)(225)))));
            this.guna2Button1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(886, 250);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(93, 32);
            this.guna2Button1.TabIndex = 174;
            this.guna2Button1.Text = "Sửa";
            this.guna2Button1.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BorderRadius = 5;
            this.btnXoa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXoa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXoa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXoa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXoa.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.btnXoa.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(765, 250);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(93, 32);
            this.btnXoa.TabIndex = 173;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.BorderRadius = 5;
            this.btnThem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(138)))), ((int)(((byte)(112)))));
            this.btnThem.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(644, 250);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(93, 32);
            this.btnThem.TabIndex = 172;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // FXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1083, 626);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.cbbTrangThaiXe);
            this.Controls.Add(this.txtKGHC);
            this.Controls.Add(this.txtDoTai);
            this.Controls.Add(this.txtSoGhe);
            this.Controls.Add(this.txtLoaiXe);
            this.Controls.Add(this.txtBienSoXe);
            this.Controls.Add(this.txtMaXe);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTrangthaixe);
            this.Controls.Add(this.lblKhonggian);
            this.Controls.Add(this.lblLoaixe);
            this.Controls.Add(this.lblDotai);
            this.Controls.Add(this.dtgvXe);
            this.Controls.Add(this.lblBiensoXe);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FXe";
            this.Text = "FXe";
            this.Load += new System.EventHandler(this.FXe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvXe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblBiensoXe;
        private System.Windows.Forms.DataGridView dtgvXe;
        private System.Windows.Forms.Label lblDotai;
        private System.Windows.Forms.Label lblKhonggian;
        private System.Windows.Forms.Label lblLoaixe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTrangthaixe;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtMaXe;
        private Guna.UI2.WinForms.Guna2TextBox txtBienSoXe;
        private Guna.UI2.WinForms.Guna2TextBox txtLoaiXe;
        private Guna.UI2.WinForms.Guna2TextBox txtSoGhe;
        private Guna.UI2.WinForms.Guna2TextBox txtDoTai;
        private Guna.UI2.WinForms.Guna2TextBox txtKGHC;
        private Guna.UI2.WinForms.Guna2ComboBox cbbTrangThaiXe;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button btnXoa;
        private Guna.UI2.WinForms.Guna2Button btnThem;
    }
}