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
    public partial class FTaiXe : Form
    {
        DBConnection dbC = new DBConnection();

        public FTaiXe()
        {
            InitializeComponent();
        }

        private void FTaiXe_Load(object sender, EventArgs e)
        {
            LoadTaiXe();
        }
        private void LoadTaiXe()
        {
            try
            {
                dbC.MoKetNoi();
                string sql = string.Format("SELECT * FROM TaiXe");

                SqlDataAdapter adapter = new SqlDataAdapter(sql, dbC.getConnection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dtgvTaiXe.DataSource = dataTable;
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
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                dbC.MoKetNoi();
                SqlCommand cmd = new SqlCommand("ThemTaiXe", dbC.getConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("MaTaiXe", SqlDbType.NChar).Value = txtMaTaiXe.Text;
                cmd.Parameters.Add("HoTen", SqlDbType.NChar).Value = txtHoTen.Text;
                cmd.Parameters.Add("NgaySinh", SqlDbType.NChar).Value = dtNgaySinh.Value;
                cmd.Parameters.Add("GioiTinh", SqlDbType.NChar).Value = cbbGioiTinh.Text;
                cmd.Parameters.Add("DiaChi", SqlDbType.NChar).Value = txtDiaChi.Text;
                cmd.Parameters.Add("SoDienThoai", SqlDbType.NChar).Value = txtSDT.Text;
                cmd.Parameters.Add("TrangThai", SqlDbType.NChar).Value = cbbTinhTrang.Text;

                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Thêm thành công!", "Thêm Tài Xế", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadTaiXe();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại", "Thêm Tài Xế", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi thêm tài xế: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                SqlCommand cmd = new SqlCommand("XoaTaiXe", dbC.getConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaTaiXe", SqlDbType.Int).Value = int.Parse(txtMaTaiXe.Text);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Xoá thành công!", "Xoá tài xế", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadTaiXe();
                }
                else
                {
                    MessageBox.Show("Xoá thất bại", "Xoá tài xế", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi xoá tài xế: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                SqlCommand cmd = new SqlCommand("SuaTaiXe", dbC.getConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("MaTaiXe", SqlDbType.NChar).Value = txtMaTaiXe.Text;
                cmd.Parameters.Add("HoTen", SqlDbType.NChar).Value = txtHoTen.Text;
                cmd.Parameters.Add("NgaySinh", SqlDbType.NChar).Value = dtNgaySinh.Value;
                cmd.Parameters.Add("GioiTinh", SqlDbType.NChar).Value = cbbGioiTinh.Text;
                cmd.Parameters.Add("DiaChi", SqlDbType.NChar).Value = txtDiaChi.Text;
                cmd.Parameters.Add("SoDienThoai", SqlDbType.NChar).Value = txtSDT.Text;
                cmd.Parameters.Add("TrangThai", SqlDbType.NChar).Value = cbbTinhTrang.Text;

                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Thêm thành công!", "Thêm Tài Xế", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadTaiXe();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại", "Thêm Tài Xế", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi thêm tài xế: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void dgXe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.RowIndex == dtgvTaiXe.RowCount - 1) return;
            DataGridViewRow row = dtgvTaiXe.Rows[e.RowIndex];
            txtMaTaiXe.Text = Convert.ToString(row.Cells["MaTaiXe"].Value);
            txtHoTen.Text = Convert.ToString(row.Cells["HoTen"].Value);
            dtNgaySinh.Value = Convert.ToDateTime(row.Cells["NgaySinh"].Value);
            cbbGioiTinh.Text = Convert.ToString(row.Cells["GioiTinh"].Value);
            txtDiaChi.Text = Convert.ToString(row.Cells["DiaChi"].Value);
            txtSDT.Text = Convert.ToString(row.Cells["SoDienThoai"].Value);
            cbbTinhTrang.Text = Convert.ToString(row.Cells["TrangThai"].Value);

        }
    }
}
