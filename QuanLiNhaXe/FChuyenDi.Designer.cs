namespace QuanLiNhaXe
{
    partial class FChuyenDi
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
            this.dtgvChuyenDi = new System.Windows.Forms.DataGridView();
            this.lblLoaixe = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblBiensoXe = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtXuatPhat = new System.Windows.Forms.DateTimePicker();
            this.dtKetThuc = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaChuyenDi = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtBienSoXe = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbbChonXe = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbbChonTaiXe = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtTenTaiXe = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbbLoTrinh = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtTenLoTrinh = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbbTrangThai = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtSoGheTrong = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.btnXoa = new Guna.UI2.WinForms.Guna2Button();
            this.btnThem = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChuyenDi)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvChuyenDi
            // 
            this.dtgvChuyenDi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvChuyenDi.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(254)))), ((int)(((byte)(247)))));
            this.dtgvChuyenDi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvChuyenDi.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(93)))), ((int)(((byte)(102)))));
            this.dtgvChuyenDi.Location = new System.Drawing.Point(2, 318);
            this.dtgvChuyenDi.Name = "dtgvChuyenDi";
            this.dtgvChuyenDi.RowHeadersWidth = 51;
            this.dtgvChuyenDi.RowTemplate.Height = 24;
            this.dtgvChuyenDi.Size = new System.Drawing.Size(1078, 381);
            this.dtgvChuyenDi.TabIndex = 98;
            this.dtgvChuyenDi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dglotrinh_CellClick);
            // 
            // lblLoaixe
            // 
            this.lblLoaixe.AutoSize = true;
            this.lblLoaixe.Location = new System.Drawing.Point(25, 151);
            this.lblLoaixe.Name = "lblLoaixe";
            this.lblLoaixe.Size = new System.Drawing.Size(173, 22);
            this.lblLoaixe.TabIndex = 100;
            this.lblLoaixe.Text = "Thời điểm xuất phát:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 22);
            this.label1.TabIndex = 105;
            this.label1.Text = "Thời điểm kết thúc:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(372, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 22);
            this.label2.TabIndex = 110;
            this.label2.Text = "Số ghế trống:";
            // 
            // lblBiensoXe
            // 
            this.lblBiensoXe.AutoSize = true;
            this.lblBiensoXe.Location = new System.Drawing.Point(16, 12);
            this.lblBiensoXe.Name = "lblBiensoXe";
            this.lblBiensoXe.Size = new System.Drawing.Size(116, 22);
            this.lblBiensoXe.TabIndex = 97;
            this.lblBiensoXe.Text = "Mã chuyến đi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(733, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 22);
            this.label4.TabIndex = 114;
            this.label4.Text = "Lộ trình:";
            // 
            // dtXuatPhat
            // 
            this.dtXuatPhat.Location = new System.Drawing.Point(29, 176);
            this.dtXuatPhat.Name = "dtXuatPhat";
            this.dtXuatPhat.Size = new System.Drawing.Size(291, 30);
            this.dtXuatPhat.TabIndex = 117;
            // 
            // dtKetThuc
            // 
            this.dtKetThuc.Location = new System.Drawing.Point(29, 245);
            this.dtKetThuc.Name = "dtKetThuc";
            this.dtKetThuc.Size = new System.Drawing.Size(291, 30);
            this.dtKetThuc.TabIndex = 118;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 22);
            this.label5.TabIndex = 119;
            this.label5.Text = "Chọn xe:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(373, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 22);
            this.label6.TabIndex = 121;
            this.label6.Text = "Chọn tài xế:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(372, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 22);
            this.label3.TabIndex = 138;
            this.label3.Text = "Trạng thái:";
            // 
            // txtMaChuyenDi
            // 
            this.txtMaChuyenDi.BorderRadius = 10;
            this.txtMaChuyenDi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaChuyenDi.DefaultText = "";
            this.txtMaChuyenDi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaChuyenDi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaChuyenDi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaChuyenDi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaChuyenDi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaChuyenDi.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaChuyenDi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.txtMaChuyenDi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaChuyenDi.Location = new System.Drawing.Point(21, 38);
            this.txtMaChuyenDi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaChuyenDi.Name = "txtMaChuyenDi";
            this.txtMaChuyenDi.PasswordChar = '\0';
            this.txtMaChuyenDi.PlaceholderText = "";
            this.txtMaChuyenDi.SelectedText = "";
            this.txtMaChuyenDi.Size = new System.Drawing.Size(133, 37);
            this.txtMaChuyenDi.TabIndex = 142;
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
            this.txtBienSoXe.Enabled = false;
            this.txtBienSoXe.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBienSoXe.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBienSoXe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.txtBienSoXe.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBienSoXe.Location = new System.Drawing.Point(137, 99);
            this.txtBienSoXe.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBienSoXe.Name = "txtBienSoXe";
            this.txtBienSoXe.PasswordChar = '\0';
            this.txtBienSoXe.PlaceholderText = "";
            this.txtBienSoXe.SelectedText = "";
            this.txtBienSoXe.Size = new System.Drawing.Size(213, 37);
            this.txtBienSoXe.TabIndex = 143;
            // 
            // cbbChonXe
            // 
            this.cbbChonXe.BackColor = System.Drawing.Color.Transparent;
            this.cbbChonXe.BorderRadius = 10;
            this.cbbChonXe.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbChonXe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbChonXe.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbChonXe.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbChonXe.Font = new System.Drawing.Font("Tahoma", 12F);
            this.cbbChonXe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.cbbChonXe.ItemHeight = 30;
            this.cbbChonXe.Location = new System.Drawing.Point(20, 99);
            this.cbbChonXe.Name = "cbbChonXe";
            this.cbbChonXe.Size = new System.Drawing.Size(111, 36);
            this.cbbChonXe.TabIndex = 144;
            // 
            // cbbChonTaiXe
            // 
            this.cbbChonTaiXe.BackColor = System.Drawing.Color.Transparent;
            this.cbbChonTaiXe.BorderRadius = 10;
            this.cbbChonTaiXe.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbChonTaiXe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbChonTaiXe.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbChonTaiXe.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbChonTaiXe.Font = new System.Drawing.Font("Tahoma", 12F);
            this.cbbChonTaiXe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.cbbChonTaiXe.ItemHeight = 30;
            this.cbbChonTaiXe.Location = new System.Drawing.Point(367, 99);
            this.cbbChonTaiXe.Name = "cbbChonTaiXe";
            this.cbbChonTaiXe.Size = new System.Drawing.Size(111, 36);
            this.cbbChonTaiXe.TabIndex = 145;
            // 
            // txtTenTaiXe
            // 
            this.txtTenTaiXe.BorderRadius = 10;
            this.txtTenTaiXe.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenTaiXe.DefaultText = "";
            this.txtTenTaiXe.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenTaiXe.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenTaiXe.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenTaiXe.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenTaiXe.Enabled = false;
            this.txtTenTaiXe.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenTaiXe.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenTaiXe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.txtTenTaiXe.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenTaiXe.Location = new System.Drawing.Point(484, 99);
            this.txtTenTaiXe.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenTaiXe.Name = "txtTenTaiXe";
            this.txtTenTaiXe.PasswordChar = '\0';
            this.txtTenTaiXe.PlaceholderText = "";
            this.txtTenTaiXe.SelectedText = "";
            this.txtTenTaiXe.Size = new System.Drawing.Size(213, 37);
            this.txtTenTaiXe.TabIndex = 146;
            // 
            // cbbLoTrinh
            // 
            this.cbbLoTrinh.BackColor = System.Drawing.Color.Transparent;
            this.cbbLoTrinh.BorderRadius = 10;
            this.cbbLoTrinh.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbLoTrinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLoTrinh.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbLoTrinh.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbLoTrinh.Font = new System.Drawing.Font("Tahoma", 12F);
            this.cbbLoTrinh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.cbbLoTrinh.ItemHeight = 30;
            this.cbbLoTrinh.Location = new System.Drawing.Point(719, 100);
            this.cbbLoTrinh.Name = "cbbLoTrinh";
            this.cbbLoTrinh.Size = new System.Drawing.Size(111, 36);
            this.cbbLoTrinh.TabIndex = 147;
            // 
            // txtTenLoTrinh
            // 
            this.txtTenLoTrinh.BorderRadius = 10;
            this.txtTenLoTrinh.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenLoTrinh.DefaultText = "";
            this.txtTenLoTrinh.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenLoTrinh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenLoTrinh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenLoTrinh.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenLoTrinh.Enabled = false;
            this.txtTenLoTrinh.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenLoTrinh.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenLoTrinh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.txtTenLoTrinh.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenLoTrinh.Location = new System.Drawing.Point(836, 99);
            this.txtTenLoTrinh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenLoTrinh.Name = "txtTenLoTrinh";
            this.txtTenLoTrinh.PasswordChar = '\0';
            this.txtTenLoTrinh.PlaceholderText = "";
            this.txtTenLoTrinh.SelectedText = "";
            this.txtTenLoTrinh.Size = new System.Drawing.Size(213, 37);
            this.txtTenLoTrinh.TabIndex = 148;
            // 
            // cbbTrangThai
            // 
            this.cbbTrangThai.BackColor = System.Drawing.Color.Transparent;
            this.cbbTrangThai.BorderRadius = 10;
            this.cbbTrangThai.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTrangThai.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbTrangThai.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbTrangThai.Font = new System.Drawing.Font("Tahoma", 12F);
            this.cbbTrangThai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.cbbTrangThai.ItemHeight = 30;
            this.cbbTrangThai.Items.AddRange(new object[] {
            "Chưa thực hiện",
            "Đã thực hiện",
            "Đang thực hiện"});
            this.cbbTrangThai.Location = new System.Drawing.Point(377, 176);
            this.cbbTrangThai.Name = "cbbTrangThai";
            this.cbbTrangThai.Size = new System.Drawing.Size(243, 36);
            this.cbbTrangThai.TabIndex = 149;
            // 
            // txtSoGheTrong
            // 
            this.txtSoGheTrong.BorderRadius = 10;
            this.txtSoGheTrong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSoGheTrong.DefaultText = "";
            this.txtSoGheTrong.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSoGheTrong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSoGheTrong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoGheTrong.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoGheTrong.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoGheTrong.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoGheTrong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.txtSoGheTrong.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoGheTrong.Location = new System.Drawing.Point(376, 243);
            this.txtSoGheTrong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSoGheTrong.Name = "txtSoGheTrong";
            this.txtSoGheTrong.PasswordChar = '\0';
            this.txtSoGheTrong.PlaceholderText = "";
            this.txtSoGheTrong.SelectedText = "";
            this.txtSoGheTrong.Size = new System.Drawing.Size(150, 37);
            this.txtSoGheTrong.TabIndex = 150;
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
            this.guna2Button1.Location = new System.Drawing.Point(957, 243);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(93, 32);
            this.guna2Button1.TabIndex = 153;
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
            this.btnXoa.Location = new System.Drawing.Point(836, 243);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(93, 32);
            this.btnXoa.TabIndex = 152;
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
            this.btnThem.Location = new System.Drawing.Point(715, 243);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(93, 32);
            this.btnThem.TabIndex = 151;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // FChuyenDi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1083, 704);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtSoGheTrong);
            this.Controls.Add(this.cbbTrangThai);
            this.Controls.Add(this.txtTenLoTrinh);
            this.Controls.Add(this.cbbLoTrinh);
            this.Controls.Add(this.txtTenTaiXe);
            this.Controls.Add(this.cbbChonTaiXe);
            this.Controls.Add(this.cbbChonXe);
            this.Controls.Add(this.txtBienSoXe);
            this.Controls.Add(this.txtMaChuyenDi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtKetThuc);
            this.Controls.Add(this.dtXuatPhat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblLoaixe);
            this.Controls.Add(this.dtgvChuyenDi);
            this.Controls.Add(this.lblBiensoXe);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FChuyenDi";
            this.Text = "FChuyenDi";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChuyenDi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvChuyenDi;
        private System.Windows.Forms.Label lblLoaixe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblBiensoXe;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtXuatPhat;
        private System.Windows.Forms.DateTimePicker dtKetThuc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtMaChuyenDi;
        private Guna.UI2.WinForms.Guna2TextBox txtBienSoXe;
        private Guna.UI2.WinForms.Guna2ComboBox cbbChonXe;
        private Guna.UI2.WinForms.Guna2ComboBox cbbChonTaiXe;
        private Guna.UI2.WinForms.Guna2TextBox txtTenTaiXe;
        private Guna.UI2.WinForms.Guna2ComboBox cbbLoTrinh;
        private Guna.UI2.WinForms.Guna2TextBox txtTenLoTrinh;
        private Guna.UI2.WinForms.Guna2ComboBox cbbTrangThai;
        private Guna.UI2.WinForms.Guna2TextBox txtSoGheTrong;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button btnXoa;
        private Guna.UI2.WinForms.Guna2Button btnThem;
    }
}