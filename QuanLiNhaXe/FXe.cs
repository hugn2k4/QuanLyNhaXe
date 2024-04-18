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
    public partial class FXe : Form
    {
        DBConnection dbC = new DBConnection();

        public FXe()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                dbC.MoKetNoi();
                SqlCommand cmd = new SqlCommand("ThemXe", dbC.getConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("MaXe", SqlDbType.NChar).Value = txtMaXe.Text;
                cmd.Parameters.Add("BienSoXe", SqlDbType.NChar).Value = txtBienSoXe.Text;
                cmd.Parameters.Add("LoaiXe", SqlDbType.NChar).Value = txtLoaiXe.Text;
                cmd.Parameters.Add("TrangThai", SqlDbType.NChar).Value = cbbTrangThaiXe.Text;
                cmd.Parameters.Add("DoTai", SqlDbType.NChar).Value = txtDoTai.Text;
                cmd.Parameters.Add("KhongGianHamChua", SqlDbType.NChar).Value = txtKGHC.Text;
                cmd.Parameters.Add("SoGhe", SqlDbType.NChar).Value = txtSoGhe.Text;

                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Thêm thành công!", "Thêm Xe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadXe();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại", "Thêm Xe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi thêm xe: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                SqlCommand cmd = new SqlCommand("XoaXe", dbC.getConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaXe", SqlDbType.Int).Value = int.Parse(txtMaXe.Text);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Xoá thành công!", "Xoá xe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadXe();
                }
                else
                {
                    MessageBox.Show("Xoá thất bại", "Xoá xe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi xoá xe: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                SqlCommand cmd = new SqlCommand("SuaXe", dbC.getConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("MaXe", SqlDbType.NChar).Value = txtMaXe.Text;
                cmd.Parameters.Add("BienSoXe", SqlDbType.NChar).Value = txtBienSoXe.Text;
                cmd.Parameters.Add("LoaiXe", SqlDbType.NChar).Value = txtLoaiXe.Text;
                cmd.Parameters.Add("TrangThai", SqlDbType.NChar).Value = cbbTrangThaiXe.Text;
                cmd.Parameters.Add("DoTai", SqlDbType.NChar).Value = txtDoTai.Text;
                cmd.Parameters.Add("KhongGianHamChua", SqlDbType.NChar).Value = txtKGHC.Text;
                cmd.Parameters.Add("SoGhe", SqlDbType.NChar).Value = txtSoGhe.Text;

                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Thêm thành công!", "Thêm Xe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadXe();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại", "Thêm Xe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi thêm xe: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (e.RowIndex == -1 || e.RowIndex == dtgvXe.RowCount - 1) return;
            DataGridViewRow row = dtgvXe.Rows[e.RowIndex];
            txtMaXe.Text = Convert.ToString(row.Cells["MaXe"].Value);
            txtBienSoXe.Text = Convert.ToString(row.Cells["BienSoXe"].Value);
            txtLoaiXe.Text = Convert.ToString(row.Cells["LoaiXe"].Value);
            txtDoTai.Text = Convert.ToString(row.Cells["DoTai"].Value);
            cbbTrangThaiXe.Text = Convert.ToString(row.Cells["TrangThai"].Value);
            txtKGHC.Text = Convert.ToString(row.Cells["KhongGianHamChua"].Value);
            txtSoGhe.Text = Convert.ToString(row.Cells["SoGhe"].Value);
        }   
        

        private void FXe_Load(object sender, EventArgs e)
        {
            LoadXe();
        }

        private void LoadXe()
        {
            try
            {
                dbC.MoKetNoi();
                string sql = string.Format("SELECT * FROM Xe");

                SqlDataAdapter adapter = new SqlDataAdapter(sql, dbC.getConnection);
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
    }
}
