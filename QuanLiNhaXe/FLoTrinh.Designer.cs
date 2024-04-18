namespace QuanLiNhaXe
{
    partial class FLoTrinh
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
            this.lblTrangthaixe = new System.Windows.Forms.Label();
            this.lblLoaixe = new System.Windows.Forms.Label();
            this.lblDotai = new System.Windows.Forms.Label();
            this.dtgvLoTrinh = new System.Windows.Forms.DataGridView();
            this.lblBiensoXe = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaLoTrinh = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtDiemXuatPhat = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTenLoTrinh = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtDiemKetThuc = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMoTa = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbbTrangThai = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.btnXoa = new Guna.UI2.WinForms.Guna2Button();
            this.btnThem = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvLoTrinh)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTrangthaixe
            // 
            this.lblTrangthaixe.AutoSize = true;
            this.lblTrangthaixe.Location = new System.Drawing.Point(385, 80);
            this.lblTrangthaixe.Name = "lblTrangthaixe";
            this.lblTrangthaixe.Size = new System.Drawing.Size(119, 22);
            this.lblTrangthaixe.TabIndex = 90;
            this.lblTrangthaixe.Text = "Điểm kết thúc";
            // 
            // lblLoaixe
            // 
            this.lblLoaixe.AutoSize = true;
            this.lblLoaixe.Location = new System.Drawing.Point(693, 5);
            this.lblLoaixe.Name = "lblLoaixe";
            this.lblLoaixe.Size = new System.Drawing.Size(62, 22);
            this.lblLoaixe.TabIndex = 88;
            this.lblLoaixe.Text = "Mô tả:";
            // 
            // lblDotai
            // 
            this.lblDotai.AutoSize = true;
            this.lblDotai.Location = new System.Drawing.Point(77, 80);
            this.lblDotai.Name = "lblDotai";
            this.lblDotai.Size = new System.Drawing.Size(134, 22);
            this.lblDotai.TabIndex = 86;
            this.lblDotai.Text = "Điểm xuất phát:";
            // 
            // dtgvLoTrinh
            // 
            this.dtgvLoTrinh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvLoTrinh.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(254)))), ((int)(((byte)(247)))));
            this.dtgvLoTrinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvLoTrinh.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(93)))), ((int)(((byte)(102)))));
            this.dtgvLoTrinh.Location = new System.Drawing.Point(1, 203);
            this.dtgvLoTrinh.Name = "dtgvLoTrinh";
            this.dtgvLoTrinh.RowHeadersWidth = 51;
            this.dtgvLoTrinh.RowTemplate.Height = 24;
            this.dtgvLoTrinh.Size = new System.Drawing.Size(1082, 496);
            this.dtgvLoTrinh.TabIndex = 84;
            this.dtgvLoTrinh.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvLoTrinh_CellContentClick);
            // 
            // lblBiensoXe
            // 
            this.lblBiensoXe.AutoSize = true;
            this.lblBiensoXe.Location = new System.Drawing.Point(385, 5);
            this.lblBiensoXe.Name = "lblBiensoXe";
            this.lblBiensoXe.Size = new System.Drawing.Size(108, 22);
            this.lblBiensoXe.TabIndex = 83;
            this.lblBiensoXe.Text = "Tên lộ trình:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 22);
            this.label1.TabIndex = 95;
            this.label1.Text = "Mã lộ trình:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(693, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 22);
            this.label2.TabIndex = 96;
            this.label2.Text = "Trạng thái:";
            // 
            // txtMaLoTrinh
            // 
            this.txtMaLoTrinh.BorderRadius = 10;
            this.txtMaLoTrinh.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaLoTrinh.DefaultText = "";
            this.txtMaLoTrinh.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaLoTrinh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaLoTrinh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaLoTrinh.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaLoTrinh.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaLoTrinh.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaLoTrinh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.txtMaLoTrinh.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaLoTrinh.Location = new System.Drawing.Point(81, 31);
            this.txtMaLoTrinh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaLoTrinh.Name = "txtMaLoTrinh";
            this.txtMaLoTrinh.PasswordChar = '\0';
            this.txtMaLoTrinh.PlaceholderText = "";
            this.txtMaLoTrinh.SelectedText = "";
            this.txtMaLoTrinh.Size = new System.Drawing.Size(244, 37);
            this.txtMaLoTrinh.TabIndex = 160;
            // 
            // txtDiemXuatPhat
            // 
            this.txtDiemXuatPhat.BorderRadius = 10;
            this.txtDiemXuatPhat.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDiemXuatPhat.DefaultText = "";
            this.txtDiemXuatPhat.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDiemXuatPhat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDiemXuatPhat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiemXuatPhat.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiemXuatPhat.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDiemXuatPhat.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiemXuatPhat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.txtDiemXuatPhat.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDiemXuatPhat.Location = new System.Drawing.Point(81, 110);
            this.txtDiemXuatPhat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDiemXuatPhat.Name = "txtDiemXuatPhat";
            this.txtDiemXuatPhat.PasswordChar = '\0';
            this.txtDiemXuatPhat.PlaceholderText = "";
            this.txtDiemXuatPhat.SelectedText = "";
            this.txtDiemXuatPhat.Size = new System.Drawing.Size(244, 37);
            this.txtDiemXuatPhat.TabIndex = 161;
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
            this.txtTenLoTrinh.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenLoTrinh.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenLoTrinh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.txtTenLoTrinh.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenLoTrinh.Location = new System.Drawing.Point(389, 31);
            this.txtTenLoTrinh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenLoTrinh.Name = "txtTenLoTrinh";
            this.txtTenLoTrinh.PasswordChar = '\0';
            this.txtTenLoTrinh.PlaceholderText = "";
            this.txtTenLoTrinh.SelectedText = "";
            this.txtTenLoTrinh.Size = new System.Drawing.Size(244, 37);
            this.txtTenLoTrinh.TabIndex = 162;
            // 
            // txtDiemKetThuc
            // 
            this.txtDiemKetThuc.BorderRadius = 10;
            this.txtDiemKetThuc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDiemKetThuc.DefaultText = "";
            this.txtDiemKetThuc.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDiemKetThuc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDiemKetThuc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiemKetThuc.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiemKetThuc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDiemKetThuc.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiemKetThuc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.txtDiemKetThuc.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDiemKetThuc.Location = new System.Drawing.Point(389, 110);
            this.txtDiemKetThuc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDiemKetThuc.Name = "txtDiemKetThuc";
            this.txtDiemKetThuc.PasswordChar = '\0';
            this.txtDiemKetThuc.PlaceholderText = "";
            this.txtDiemKetThuc.SelectedText = "";
            this.txtDiemKetThuc.Size = new System.Drawing.Size(244, 37);
            this.txtDiemKetThuc.TabIndex = 163;
            // 
            // txtMoTa
            // 
            this.txtMoTa.BorderRadius = 10;
            this.txtMoTa.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMoTa.DefaultText = "";
            this.txtMoTa.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMoTa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMoTa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMoTa.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMoTa.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMoTa.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMoTa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.txtMoTa.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMoTa.Location = new System.Drawing.Point(697, 31);
            this.txtMoTa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.PasswordChar = '\0';
            this.txtMoTa.PlaceholderText = "";
            this.txtMoTa.SelectedText = "";
            this.txtMoTa.Size = new System.Drawing.Size(244, 37);
            this.txtMoTa.TabIndex = 164;
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
            "Chưa kiểm duyệt",
            "Đã kiểm duyệt"});
            this.cbbTrangThai.Location = new System.Drawing.Point(697, 111);
            this.cbbTrangThai.Name = "cbbTrangThai";
            this.cbbTrangThai.Size = new System.Drawing.Size(244, 36);
            this.cbbTrangThai.TabIndex = 165;
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
            this.guna2Button1.Location = new System.Drawing.Point(942, 165);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(93, 32);
            this.guna2Button1.TabIndex = 168;
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
            this.btnXoa.Location = new System.Drawing.Point(821, 165);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(93, 32);
            this.btnXoa.TabIndex = 167;
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
            this.btnThem.Location = new System.Drawing.Point(700, 165);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(93, 32);
            this.btnThem.TabIndex = 166;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // FLoTrinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1083, 704);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.cbbTrangThai);
            this.Controls.Add(this.txtMoTa);
            this.Controls.Add(this.txtDiemKetThuc);
            this.Controls.Add(this.txtTenLoTrinh);
            this.Controls.Add(this.txtDiemXuatPhat);
            this.Controls.Add(this.txtMaLoTrinh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTrangthaixe);
            this.Controls.Add(this.lblLoaixe);
            this.Controls.Add(this.lblDotai);
            this.Controls.Add(this.dtgvLoTrinh);
            this.Controls.Add(this.lblBiensoXe);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FLoTrinh";
            this.Text = "FLoTrinh";
            this.Load += new System.EventHandler(this.FLoTrinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvLoTrinh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTrangthaixe;
        private System.Windows.Forms.Label lblLoaixe;
        private System.Windows.Forms.Label lblDotai;
        private System.Windows.Forms.DataGridView dtgvLoTrinh;
        private System.Windows.Forms.Label lblBiensoXe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtMaLoTrinh;
        private Guna.UI2.WinForms.Guna2TextBox txtDiemXuatPhat;
        private Guna.UI2.WinForms.Guna2TextBox txtTenLoTrinh;
        private Guna.UI2.WinForms.Guna2TextBox txtDiemKetThuc;
        private Guna.UI2.WinForms.Guna2TextBox txtMoTa;
        private Guna.UI2.WinForms.Guna2ComboBox cbbTrangThai;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button btnXoa;
        private Guna.UI2.WinForms.Guna2Button btnThem;
    }
}