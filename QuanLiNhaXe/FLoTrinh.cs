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
    public partial class FLoTrinh : Form
    {
        DBConnection dbC = new DBConnection();
        public FLoTrinh()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                dbC.MoKetNoi();
                SqlCommand cmd = new SqlCommand("ThemLoTrinh", dbC.getConnection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@MaLoTrinh", SqlDbType.Int).Value = int.Parse(txtMaLoTrinh.Text);
                cmd.Parameters.Add("@TenLoTrinh", SqlDbType.NChar).Value = txtTenLoTrinh.Text;
                cmd.Parameters.Add("@DiemXuatPhat", SqlDbType.NChar).Value = txtDiemXuatPhat.Text;
                cmd.Parameters.Add("@DiemKetThuc", SqlDbType.NVarChar).Value = txtDiemKetThuc.Text;
                cmd.Parameters.Add("@MoTa", SqlDbType.NVarChar).Value = txtMoTa.Text;
                cmd.Parameters.Add("@TrangThai", SqlDbType.NVarChar).Value = cbbTrangThai.Text;

                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Thêm thành công!", "Thêm lộ trình", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadLoTrinh();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại", "Thêm lộ trình", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi thêm lộ trình: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                SqlCommand cmd = new SqlCommand("XoaLoTrinh", dbC.getConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaLoTrinh", SqlDbType.Int).Value = int.Parse(txtMaLoTrinh.Text);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Xoá thành công!", "Xoá lộ trình", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadLoTrinh();
                }
                else
                {
                    MessageBox.Show("Xoá thất bại", "Xoá lộ trình", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi xoá lộ trình: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                SqlCommand cmd = new SqlCommand("SuaLoTrinh", dbC.getConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaLoTrinh", SqlDbType.Int).Value = int.Parse(txtMaLoTrinh.Text);
                cmd.Parameters.Add("@TenLoTrinh", SqlDbType.NChar).Value = txtTenLoTrinh.Text;
                cmd.Parameters.Add("@DiemXuatPhat", SqlDbType.NChar).Value = txtDiemXuatPhat.Text;
                cmd.Parameters.Add("@DiemKetThuc", SqlDbType.NVarChar).Value = txtDiemKetThuc.Text;
                cmd.Parameters.Add("@MoTa", SqlDbType.NVarChar).Value = txtMoTa.Text;
                cmd.Parameters.Add("@TrangThai", SqlDbType.NVarChar).Value = cbbTrangThai.Text;

                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Sửa thành công!", "Sửa lộ trình", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadLoTrinh();
                }
                else
                {
                    MessageBox.Show("Sửa thất bại", "Sửa lộ trình", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi sửa lộ trình: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void FLoTrinh_Load(object sender, EventArgs e)
        {
            LoadLoTrinh();
        }
        public void LoadLoTrinh()
        {
            try
            {
                dbC.MoKetNoi();
                string SQL = string.Format("SELECT * FROM LoTrinh");

                SqlDataAdapter adapter = new SqlDataAdapter(SQL, dbC.getConnection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dtgvLoTrinh.DataSource = dataTable;
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

        private void dtgvLoTrinh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.RowIndex == dtgvLoTrinh.RowCount - 1) return;
            DataGridViewRow row = dtgvLoTrinh.Rows[e.RowIndex];
            txtMaLoTrinh.Text = Convert.ToString(row.Cells["MaLoTrinh"].Value);
            txtTenLoTrinh.Text = Convert.ToString(row.Cells["TenLoTrinh"].Value);
            txtDiemXuatPhat.Text = Convert.ToString(row.Cells["DiemXuatPhat"].Value);
            txtDiemKetThuc.Text = Convert.ToString(row.Cells["DiemKetThuc"].Value); 
            txtMoTa.Text = Convert.ToString(row.Cells["MoTa"].Value);
            cbbTrangThai.Text = Convert.ToString(row.Cells["TrangThai"].Value);
        }

       
    }
}
