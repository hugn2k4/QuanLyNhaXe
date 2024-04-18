namespace QuanLiNhaXe
{
    partial class FHangHoa
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
            this.dghanghoa = new System.Windows.Forms.DataGridView();
            this.lblBiensoXe = new System.Windows.Forms.Label();
            this.lblMaHangHoa = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKhoiLuong = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTenHangHoa = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtKichThuoc = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMaHangHoa = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.btnXoa = new Guna.UI2.WinForms.Guna2Button();
            this.cbloaihang = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbbTrangThai = new Guna.UI2.WinForms.Guna2ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dghanghoa)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTrangthaixe
            // 
            this.lblTrangthaixe.AutoSize = true;
            this.lblTrangthaixe.Location = new System.Drawing.Point(377, 82);
            this.lblTrangthaixe.Name = "lblTrangthaixe";
            this.lblTrangthaixe.Size = new System.Drawing.Size(80, 19);
            this.lblTrangthaixe.TabIndex = 64;
            this.lblTrangthaixe.Text = "Kích thước:";
            // 
            // lblLoaixe
            // 
            this.lblLoaixe.AutoSize = true;
            this.lblLoaixe.Location = new System.Drawing.Point(377, 7);
            this.lblLoaixe.Name = "lblLoaixe";
            this.lblLoaixe.Size = new System.Drawing.Size(71, 19);
            this.lblLoaixe.TabIndex = 60;
            this.lblLoaixe.Text = "Loại hàng:";
            // 
            // lblDotai
            // 
            this.lblDotai.AutoSize = true;
            this.lblDotai.Location = new System.Drawing.Point(69, 82);
            this.lblDotai.Name = "lblDotai";
            this.lblDotai.Size = new System.Drawing.Size(80, 19);
            this.lblDotai.TabIndex = 57;
            this.lblDotai.Text = "Khối lượng:";
            // 
            // dghanghoa
            // 
            this.dghanghoa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dghanghoa.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(254)))), ((int)(((byte)(247)))));
            this.dghanghoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dghanghoa.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(93)))), ((int)(((byte)(102)))));
            this.dghanghoa.Location = new System.Drawing.Point(4, 205);
            this.dghanghoa.Name = "dghanghoa";
            this.dghanghoa.RowHeadersWidth = 51;
            this.dghanghoa.RowTemplate.Height = 24;
            this.dghanghoa.Size = new System.Drawing.Size(1079, 496);
            this.dghanghoa.TabIndex = 55;
            this.dghanghoa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dghanghoa_CellContentClick);
            this.dghanghoa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dghanghoa_CellContentClick);
            // 
            // lblBiensoXe
            // 
            this.lblBiensoXe.AutoSize = true;
            this.lblBiensoXe.Location = new System.Drawing.Point(69, 7);
            this.lblBiensoXe.Name = "lblBiensoXe";
            this.lblBiensoXe.Size = new System.Drawing.Size(93, 19);
            this.lblBiensoXe.TabIndex = 54;
            this.lblBiensoXe.Text = "Tên mặt hàng:";
            // 
            // lblMaHangHoa
            // 
            this.lblMaHangHoa.AutoSize = true;
            this.lblMaHangHoa.Location = new System.Drawing.Point(701, 7);
            this.lblMaHangHoa.Name = "lblMaHangHoa";
            this.lblMaHangHoa.Size = new System.Drawing.Size(71, 19);
            this.lblMaHangHoa.TabIndex = 71;
            this.lblMaHangHoa.Text = "Trạng thái:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(701, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 19);
            this.label1.TabIndex = 73;
            this.label1.Text = "Mã Hàng Hóa:";
            // 
            // txtKhoiLuong
            // 
            this.txtKhoiLuong.BorderRadius = 10;
            this.txtKhoiLuong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtKhoiLuong.DefaultText = "";
            this.txtKhoiLuong.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtKhoiLuong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtKhoiLuong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtKhoiLuong.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtKhoiLuong.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtKhoiLuong.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKhoiLuong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.txtKhoiLuong.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtKhoiLuong.Location = new System.Drawing.Point(73, 107);
            this.txtKhoiLuong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtKhoiLuong.Name = "txtKhoiLuong";
            this.txtKhoiLuong.PasswordChar = '\0';
            this.txtKhoiLuong.PlaceholderText = "";
            this.txtKhoiLuong.SelectedText = "";
            this.txtKhoiLuong.Size = new System.Drawing.Size(244, 37);
            this.txtKhoiLuong.TabIndex = 155;
            // 
            // txtTenHangHoa
            // 
            this.txtTenHangHoa.BorderRadius = 10;
            this.txtTenHangHoa.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenHangHoa.DefaultText = "";
            this.txtTenHangHoa.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenHangHoa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenHangHoa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenHangHoa.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenHangHoa.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenHangHoa.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenHangHoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.txtTenHangHoa.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenHangHoa.Location = new System.Drawing.Point(73, 32);
            this.txtTenHangHoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenHangHoa.Name = "txtTenHangHoa";
            this.txtTenHangHoa.PasswordChar = '\0';
            this.txtTenHangHoa.PlaceholderText = "";
            this.txtTenHangHoa.SelectedText = "";
            this.txtTenHangHoa.Size = new System.Drawing.Size(244, 37);
            this.txtTenHangHoa.TabIndex = 156;
            // 
            // txtKichThuoc
            // 
            this.txtKichThuoc.BorderRadius = 10;
            this.txtKichThuoc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtKichThuoc.DefaultText = "";
            this.txtKichThuoc.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtKichThuoc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtKichThuoc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtKichThuoc.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtKichThuoc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtKichThuoc.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKichThuoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.txtKichThuoc.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtKichThuoc.Location = new System.Drawing.Point(381, 107);
            this.txtKichThuoc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtKichThuoc.Name = "txtKichThuoc";
            this.txtKichThuoc.PasswordChar = '\0';
            this.txtKichThuoc.PlaceholderText = "";
            this.txtKichThuoc.SelectedText = "";
            this.txtKichThuoc.Size = new System.Drawing.Size(244, 37);
            this.txtKichThuoc.TabIndex = 157;
            // 
            // txtMaHangHoa
            // 
            this.txtMaHangHoa.BorderRadius = 10;
            this.txtMaHangHoa.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaHangHoa.DefaultText = "";
            this.txtMaHangHoa.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaHangHoa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaHangHoa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaHangHoa.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaHangHoa.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaHangHoa.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHangHoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.txtMaHangHoa.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaHangHoa.Location = new System.Drawing.Point(705, 108);
            this.txtMaHangHoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaHangHoa.Name = "txtMaHangHoa";
            this.txtMaHangHoa.PasswordChar = '\0';
            this.txtMaHangHoa.PlaceholderText = "";
            this.txtMaHangHoa.SelectedText = "";
            this.txtMaHangHoa.Size = new System.Drawing.Size(244, 37);
            this.txtMaHangHoa.TabIndex = 159;
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
            this.guna2Button1.Location = new System.Drawing.Point(917, 167);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(93, 32);
            this.guna2Button1.TabIndex = 163;
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
            this.btnXoa.Location = new System.Drawing.Point(796, 167);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(93, 32);
            this.btnXoa.TabIndex = 162;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // cbloaihang
            // 
            this.cbloaihang.BackColor = System.Drawing.Color.Transparent;
            this.cbloaihang.BorderRadius = 10;
            this.cbloaihang.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbloaihang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbloaihang.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbloaihang.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbloaihang.Font = new System.Drawing.Font("Tahoma", 12F);
            this.cbloaihang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.cbloaihang.ItemHeight = 30;
            this.cbloaihang.Items.AddRange(new object[] {
            "Khô",
            "Dung dịch",
            "Dễ vỡ",
            "Cồng kềnh",
            "Trái cây",
            "Mĩ phẩm",
            "Dụng cụ đồ gia dụng",
            "Hàng sắt thép, inox",
            "Đông lạnh"});
            this.cbloaihang.Location = new System.Drawing.Point(381, 33);
            this.cbloaihang.Name = "cbloaihang";
            this.cbloaihang.Size = new System.Drawing.Size(244, 36);
            this.cbloaihang.TabIndex = 166;
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
            "Chưa gửi",
            "Đã gửi",
            "Đang gửi"});
            this.cbbTrangThai.Location = new System.Drawing.Point(705, 33);
            this.cbbTrangThai.Name = "cbbTrangThai";
            this.cbbTrangThai.Size = new System.Drawing.Size(244, 36);
            this.cbbTrangThai.TabIndex = 167;
            // 
            // FHangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1083, 704);
            this.Controls.Add(this.cbbTrangThai);
            this.Controls.Add(this.cbloaihang);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.txtMaHangHoa);
            this.Controls.Add(this.txtKichThuoc);
            this.Controls.Add(this.txtTenHangHoa);
            this.Controls.Add(this.txtKhoiLuong);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMaHangHoa);
            this.Controls.Add(this.lblTrangthaixe);
            this.Controls.Add(this.lblLoaixe);
            this.Controls.Add(this.lblDotai);
            this.Controls.Add(this.dghanghoa);
            this.Controls.Add(this.lblBiensoXe);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FHangHoa";
            this.Text = "FHangHoa";
            this.Load += new System.EventHandler(this.FHangHoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dghanghoa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTrangthaixe;
        private System.Windows.Forms.Label lblLoaixe;
        private System.Windows.Forms.Label lblDotai;
        private System.Windows.Forms.DataGridView dghanghoa;
        private System.Windows.Forms.Label lblBiensoXe;
        private System.Windows.Forms.Label lblMaHangHoa;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtKhoiLuong;
        private Guna.UI2.WinForms.Guna2TextBox txtTenHangHoa;
        private Guna.UI2.WinForms.Guna2TextBox txtKichThuoc;
        private Guna.UI2.WinForms.Guna2TextBox txtMaHangHoa;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button btnXoa;
        private Guna.UI2.WinForms.Guna2ComboBox cbloaihang;
        private Guna.UI2.WinForms.Guna2ComboBox cbbTrangThai;
    }
}