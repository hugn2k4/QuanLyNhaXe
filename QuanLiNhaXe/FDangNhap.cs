using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLiNhaXe
{
    public partial class FDangNhap : Form
    {
        // tạo 2 biến cục bộ
        string strCon = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=QuanLyNhaXe;Integrated Security=True";        // đối tượng kết nối
        SqlConnection sqlCon = null;
        public FDangNhap()
        {
            InitializeComponent();
        }

        private void btnKetNoi_Click(object sender, EventArgs e)
        {
            try
            {
                if (sqlCon == null)
                { 
                    sqlCon = new SqlConnection(strCon);
                }
                // mở kết nối
                if(sqlCon.State == ConnectionState.Closed)
                {
                    sqlCon.Open();
                    MessageBox.Show("Kết nối thành công");
                }
                else if(sqlCon.State == ConnectionState.Open)
                {
                    MessageBox.Show("Đã kết nối");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnNgatKetNoi_Click(object sender, EventArgs e)
        {
            try
            {
                if (sqlCon == null)
                {
                    sqlCon = new SqlConnection(strCon);
                }
                // mở kết nối
                if (sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                    MessageBox.Show("Ngắt kết nối thành công");
                }
                else if(sqlCon.State == ConnectionState.Closed)
                {
                    MessageBox.Show("Chưa tạo kết nối");
                }    
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            FTrangChu form = new FTrangChu();
            this.Hide();
            form.ShowDialog();  
        }
    }
}
