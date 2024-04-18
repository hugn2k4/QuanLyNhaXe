using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLiNhaXe
{
    public partial class FHangHoa : Form
    {
        private DBConnection dbConnection = new DBConnection();

        public FHangHoa()
        {
            InitializeComponent();
        }
        private void HienThiThongTinHangHoa()
        {
            try
            {
                dbConnection.MoKetNoi();

                SqlCommand cmd = new SqlCommand("LayHangHoa", dbConnection.getConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dghanghoa.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể hiển thị thông tin hàng hóa. Lỗi: " + ex.Message);
            }
            finally
            {
                dbConnection.DongKetNoi();
            }
        }


        private void FHangHoa_Load(object sender, EventArgs e)
        {
            HienThiThongTinHangHoa();

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                dbConnection.MoKetNoi();

                int maHangHoa = Convert.ToInt32(txtMaHangHoa.Text);

                SqlCommand cmd = new SqlCommand("XoaHangHoa", dbConnection.getConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaHangHoa", maHangHoa);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Xóa hàng hóa thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa hàng hóa không thành công. Lỗi: " + ex.Message);
            }
            finally
            {
                dbConnection.DongKetNoi();
                HienThiThongTinHangHoa();
            }
        }


        private void dghanghoa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dghanghoa.Rows[e.RowIndex];

                // Lấy thông tin từ hàng được chọn
                string tenhanghoa = row.Cells["TenHangHoa"].Value.ToString();
                int maHangHoa = Convert.ToInt32(row.Cells["MaHangHoa"].Value);
                string loaiHang = row.Cells["LoaiHang"].Value.ToString();
                string trangthai = row.Cells["TrangThai"].Value.ToString();
                float kichThuoc = Convert.ToSingle(row.Cells["KichThuoc"].Value);
                float khoiLuong = Convert.ToSingle(row.Cells["KhoiLuong"].Value);

                // Hiển thị thông tin trong các control
                cbbTrangThai.Text = trangthai;
                cbloaihang.Text = loaiHang;
                txtKichThuoc.Text = kichThuoc.ToString();
                txtKhoiLuong.Text = khoiLuong.ToString();
                txtTenHangHoa.Text = tenhanghoa.ToString();
                txtMaHangHoa.Text= maHangHoa.ToString();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                dbConnection.MoKetNoi();
                string tenMatHang = txtTenHangHoa.Text;
                string loaiHang = cbloaihang.Text;
                string trangThai = cbbTrangThai.Text;
                float kichThuoc = float.Parse(txtKichThuoc.Text);
                float khoiLuong = float.Parse(txtKhoiLuong.Text);
                int maHangHoa = Convert.ToInt32(txtMaHangHoa.Text);

                SqlCommand cmd = new SqlCommand("SuaHangHoa", dbConnection.getConnection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@MaHangHoa", maHangHoa);
                cmd.Parameters.AddWithValue("@LoaiHang", loaiHang);
                cmd.Parameters.AddWithValue("@KichThuoc", kichThuoc);
                cmd.Parameters.AddWithValue("@KhoiLuong", khoiLuong);
                cmd.Parameters.AddWithValue("@TenMatHang", tenMatHang);
                cmd.Parameters.AddWithValue("@TrangThai", trangThai);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Sửa thông tin hàng hóa thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sửa thông tin hàng hóa không thành công. Lỗi: " + ex.Message);
            }
            finally
            {
                dbConnection.DongKetNoi();
                HienThiThongTinHangHoa();
            }
        }
    }
}
