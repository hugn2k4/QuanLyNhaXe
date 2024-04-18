using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiNhaXe
{
    public partial class FKhachHang : Form
    {
        int maKhachHang = 0;
        public FKhachHang()
        {
            InitializeComponent();
        }
        DBConnection dbC = new DBConnection();
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                dbC.MoKetNoi();
                SqlCommand cmd = new SqlCommand("ThemKhachHang", dbC.getConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaKhachHang", SqlDbType.NChar).Value = txtMaKhachHang.Text;
                cmd.Parameters.Add("@HoTen", SqlDbType.NChar).Value = txtHoTen.Text;
                cmd.Parameters.Add("@SoDienThoai", SqlDbType.NVarChar).Value = txtSoDienThoai.Text;
                cmd.Parameters.Add("@DiaChi", SqlDbType.NChar).Value = txtDiaChi.Text;

                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Thêm thành công!", "Thêm khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadKhachHang();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại", "Thêm khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi thêm khách hàng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi không mong muốn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbC.DongKetNoi();
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                dbC.MoKetNoi();
                SqlCommand cmd = new SqlCommand("XoaKhachHang", dbC.getConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaKhachHang", SqlDbType.Int).Value = int.Parse(txtMaKhachHang.Text);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Xoá thành công!", "Xoá khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadKhachHang();
                }
                else
                {
                    MessageBox.Show("Xoá thất bại", "Xoá khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi xoá khách hàng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi không mong muốn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbC.DongKetNoi();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                dbC.MoKetNoi();
                SqlCommand cmd = new SqlCommand("SuaKhachHang", dbC.getConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaKhachHang", SqlDbType.Int).Value = maKhachHang;
                cmd.Parameters.Add("@MaKhachHangMoi", SqlDbType.Int).Value = int.Parse(txtMaKhachHang.Text);
                cmd.Parameters.Add("@HoTen", SqlDbType.NChar).Value = txtHoTen.Text;
                cmd.Parameters.Add("@SoDienThoai", SqlDbType.NVarChar).Value = txtSoDienThoai.Text;
                cmd.Parameters.Add("@DiaChi", SqlDbType.NChar).Value = txtDiaChi.Text;

                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Sửa thành công!", "Sửa khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadKhachHang();
                }
                else
                {
                    MessageBox.Show("Sửa thất bại", "Sửa khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi sửa khách hàng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi không mong muốn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbC.DongKetNoi();
            }
        }

        private void FKhachHang_Load(object sender, EventArgs e)
        {
            LoadKhachHang();
        }
        public void LoadKhachHang()
        {
            try
            {
                dbC.MoKetNoi();
                string SQL = string.Format("SELECT *FROM KhachHang");

                SqlDataAdapter adapter = new SqlDataAdapter(SQL, dbC.getConnection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dtgvXe.DataSource = dataTable;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {
                dbC.DongKetNoi();
            }
        }

        private void dtgvXe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.RowIndex == dtgvXe.RowCount - 1) return;
            DataGridViewRow row = dtgvXe.Rows[e.RowIndex];
            maKhachHang = Convert.ToInt32(row.Cells["MaKhachHang"].Value);
            txtMaKhachHang.Text = Convert.ToString(row.Cells["MaKhachHang"].Value);
            txtHoTen.Text = Convert.ToString(row.Cells["HoTen"].Value);
            txtSoDienThoai.Text = Convert.ToString(row.Cells["SoDienThoai"].Value);
            txtDiaChi.Text = Convert.ToString(row.Cells["DiaChi"].Value);
        }
    }
}
