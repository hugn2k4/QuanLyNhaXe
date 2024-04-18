using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanLiNhaXe
{
    public partial class FChuyenDi : Form
    {
        public FChuyenDi()
        {
            InitializeComponent();
        }
        DBConnection dbC = new DBConnection();
      
        private void FChuyenDi_Load(object sender, EventArgs e)
        {
            LoadChuyenDi();
        }
        private void LoadChuyenDi()
        {
            LoadXe();
            LoadTaiXe();
            LoadLoTrinh();
            LoadDtgv();
        }
        private void LoadDtgv()
        {
            try
            {
                dbC.MoKetNoi();
                string SQL = string.Format("SELECT *FROM View_ChuyenDi");

                SqlDataAdapter adapter = new SqlDataAdapter(SQL, dbC.getConnection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dtgvChuyenDi.DataSource = dataTable;
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
        private void LoadXe()
        {
            try
            {
                dbC.MoKetNoi();
                string SQL = "SELECT MaXe FROM Xe";
                SqlCommand cmd = new SqlCommand(SQL, dbC.getConnection);
                SqlDataReader reader = cmd.ExecuteReader();
                cbbChonXe.Items.Clear();
                while (reader.Read())
                {
                    int maXe = reader.GetInt32(0);
                    cbbChonXe.Items.Add(maXe);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi lấy mã xe: " + ex.Message);
            }
            finally
            {
                dbC.DongKetNoi();
            }
        }
        private void LoadTaiXe()
        {
            try
            {
                dbC.MoKetNoi();
                string SQL = "SELECT MaTaiXe FROM TaiXe";
                SqlCommand cmd = new SqlCommand(SQL, dbC.getConnection);
                SqlDataReader reader = cmd.ExecuteReader();
                cbbChonTaiXe.Items.Clear();
                while (reader.Read())
                {
                    int maTaiXe = reader.GetInt32(0);
                    cbbChonTaiXe.Items.Add(maTaiXe);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi lấy mã tài xế: " + ex.Message);
            }
            finally
            {
                dbC.DongKetNoi();
            }
        }
        private void LoadLoTrinh()
        {
            try
            {
                dbC.MoKetNoi();
                string SQL = "SELECT MaLoTrinh FROM LoTrinh WHERE TrangThai = N'Đã kiểm duyệt'";
                SqlCommand cmd = new SqlCommand(SQL, dbC.getConnection);
                SqlDataReader reader = cmd.ExecuteReader();
                cbbLoTrinh.Items.Clear();
                while (reader.Read())
                {
                    int maLoTrinh = reader.GetInt32(0);
                    cbbLoTrinh.Items.Add(maLoTrinh);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi lấy mã lộ trình: " + ex.Message);
            }
            finally
            {
                dbC.DongKetNoi();
            }
        }
        private bool KiemTraNull()
        {
            if (cbbChonTaiXe.SelectedItem == null || cbbChonXe.SelectedItem == null || cbbLoTrinh.SelectedItem == null || cbbTrangThai.SelectedItem == null)
            {
                return true; // Có ít nhất một ComboBox không được chọn
            }
            else
            {
                return false; // Tất cả các ComboBox đều có giá trị được chọn
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                dbC.MoKetNoi();
                SqlCommand cmd = new SqlCommand("ThemChuyenDi", dbC.getConnection);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaChuyenDi", SqlDbType.Int).Value = int.Parse(txtMaChuyenDi.Text);
                 cmd.Parameters.Add("@MaLoTrinh", SqlDbType.Int).Value = int.Parse(cbbLoTrinh.SelectedItem.ToString());
                cmd.Parameters.Add("@ThoiDiemXuatPhat", SqlDbType.DateTime).Value = dtXuatPhat.Value;
                cmd.Parameters.Add("@ThoiDiemKetThuc", SqlDbType.DateTime).Value = dtKetThuc.Value;
                cmd.Parameters.Add("@SoGheTrong", SqlDbType.Int).Value = int.Parse(txtSoGheTrong.Text);
                cmd.Parameters.Add("@TrangThai", SqlDbType.NVarChar).Value = cbbTrangThai.SelectedItem.ToString();
                cmd.Parameters.Add("@MaXe", SqlDbType.Int).Value = int.Parse(cbbChonXe.SelectedItem.ToString());
                cmd.Parameters.Add("@MaTaiXe", SqlDbType.Int).Value = int.Parse(cbbChonTaiXe.SelectedItem.ToString());

                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Thêm thành công!", "Thêm chuyến đi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadChuyenDi();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại", "Thêm chuyến đi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi thêm chuyến đi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                SqlCommand cmd = new SqlCommand("XoaChuyenDi", dbC.getConnection);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaChuyenDi", SqlDbType.Int).Value = int.Parse(txtMaChuyenDi.Text);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Xoá thành công!", "Xoá chuyến đi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadChuyenDi();
                }
                else
                {
                    MessageBox.Show("Xoá thất bại", "Xoá chuyến đi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi xoá chuyến đi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (KiemTraNull())
            {
                MessageBox.Show("Nhập đầy đủ thông tin!");
            }
            try
            {
                dbC.MoKetNoi();
                SqlCommand cmd = new SqlCommand("SuaChuyenDi", dbC.getConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaChuyenDi", SqlDbType.Int).Value = int.Parse(txtMaChuyenDi.Text);
                cmd.Parameters.Add("@MaLoTrinh", SqlDbType.Int).Value = int.Parse(cbbLoTrinh.SelectedItem.ToString());
                cmd.Parameters.Add("@ThoiDiemXuatPhat", SqlDbType.DateTime).Value = dtXuatPhat.Value;
                cmd.Parameters.Add("@ThoiDiemKetThuc", SqlDbType.DateTime).Value = dtKetThuc.Value;
                cmd.Parameters.Add("@SoGheTrong", SqlDbType.Int).Value = int.Parse(txtSoGheTrong.Text);
                cmd.Parameters.Add("@TrangThai", SqlDbType.NVarChar).Value = cbbTrangThai.SelectedItem.ToString();
                cmd.Parameters.Add("@MaXe", SqlDbType.Int).Value = int.Parse(cbbChonXe.SelectedItem.ToString());
                cmd.Parameters.Add("@MaTaiXe", SqlDbType.Int).Value = int.Parse(cbbChonTaiXe.SelectedItem.ToString());
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cập nhật thành công!", "Sửa chuyến đi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadChuyenDi();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi sửa chuyến đi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        

        private void dglotrinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.RowIndex == dtgvChuyenDi.RowCount - 1) return;

            DataGridViewRow row = dtgvChuyenDi.Rows[e.RowIndex];
            txtMaChuyenDi.Text = Convert.ToString(row.Cells["MaChuyenDi"].Value);
            dtXuatPhat.Value = Convert.ToDateTime(row.Cells["ThoiDiemXuatPhat"].Value);
            dtKetThuc.Value = Convert.ToDateTime(row.Cells["ThoiDiemKetThuc"].Value);
            txtSoGheTrong.Text = Convert.ToString(row.Cells["SoGheTrong"].Value);
            cbbChonTaiXe.SelectedItem = Convert.ToInt32(row.Cells["MaTaiXe"].Value);
            cbbChonXe.SelectedItem = Convert.ToInt32(row.Cells["MaXe"].Value);
            cbbLoTrinh.SelectedItem = Convert.ToInt32(row.Cells["MaLoTrinh"].Value);
            cbbTrangThai.SelectedItem = Convert.ToString(row.Cells["TrangThai"].Value);

        }

        private void cbbChonXe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbChonXe.SelectedItem != null)
            {
                string maXe = cbbChonXe.SelectedItem.ToString();
                try
                {
                    dbC.MoKetNoi();
                    string SQL = $"SELECT BienSoXe FROM Xe WHERE MaXe = {maXe}";
                    SqlCommand cmd = new SqlCommand(SQL, dbC.getConnection);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                        txtBienSoXe.Text = reader.GetString(0);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi lấy biển số xe: " + ex.Message);
                }
                finally
                {
                    dbC.DongKetNoi();
                }
            }
        }

        private void cbbChonTaiXe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbChonTaiXe.SelectedItem != null)
            {
                string maTaiXe = cbbChonTaiXe.SelectedItem.ToString();
                try
                {
                    dbC.MoKetNoi();
                    string SQL = $"SELECT HoTen FROM TaiXe WHERE MaTaiXe = {maTaiXe}";
                    SqlCommand cmd = new SqlCommand(SQL, dbC.getConnection);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                        txtTenTaiXe.Text = reader.GetString(0);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi lấy tên tài xế: " + ex.Message);
                }
                finally
                {
                    dbC.DongKetNoi();
                }
            }
        }

        private void cbbLoTrinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbLoTrinh.SelectedItem != null)
            {
                string loTrinh = cbbLoTrinh.SelectedItem.ToString();
                try
                {
                    dbC.MoKetNoi();
                    string SQL = $"SELECT TenLoTrinh FROM LoTrinh WHERE MaLoTrinh = {loTrinh}";
                    SqlCommand cmd = new SqlCommand(SQL, dbC.getConnection);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                        txtTenLoTrinh.Text = reader.GetString(0);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi lấy lộ trình: " + ex.Message);
                }
                finally
                {
                    dbC.DongKetNoi();
                }
            }
        }

        private void cbbTrangThai_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
