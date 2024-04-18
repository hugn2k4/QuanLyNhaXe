using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace QuanLiNhaXe
{
    public partial class FTrangChu : Form
    {
        public FTrangChu()
        {
            InitializeComponent();
        }
        
        private void btnKhachhang_Click(object sender, EventArgs e)
        {
            FKhachHang form = new FKhachHang();
            pnlTrangChu.Controls.Clear();
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            pnlTrangChu.Controls.Add(form);
            form.Show();
            form.BringToFront();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnChuyenDi_Click(object sender, EventArgs e)
        {
            FChuyenDi form = new FChuyenDi();
            pnlTrangChu.Controls.Clear();
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            pnlTrangChu.Controls.Add(form);
            form.Show();
            form.BringToFront();
        }
        private void btnLoTrinh_Click(object sender, EventArgs e)
        {
           FLoTrinh form = new FLoTrinh();
            pnlTrangChu.Controls.Clear();
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            pnlTrangChu.Controls.Add(form);
            form.Show();
            form.BringToFront();
        }

        private void btnDatVe_Click(object sender, EventArgs e)
        {
            FDatVe form = new FDatVe();
            pnlTrangChu.Controls.Clear();
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            pnlTrangChu.Controls.Add(form);
            form.Show();
            form.BringToFront();
        }

        private void btnHanghoa_Click(object sender, EventArgs e)
        {
            FHangHoa form = new FHangHoa();
            pnlTrangChu.Controls.Clear();
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            pnlTrangChu.Controls.Add(form);
            form.Show();
            form.BringToFront();
        }

        private void btnXe_Click(object sender, EventArgs e)
        {
            FXe form = new FXe();
            pnlTrangChu.Controls.Clear();
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            pnlTrangChu.Controls.Add(form);
            form.Show();
            form.BringToFront();
        }

        private void btnTaiXe_Click(object sender, EventArgs e)
        {
            FTaiXe form = new FTaiXe();
            pnlTrangChu.Controls.Clear();
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            pnlTrangChu.Controls.Add(form);
            form.Show();
            form.BringToFront();
        }
    }
}
