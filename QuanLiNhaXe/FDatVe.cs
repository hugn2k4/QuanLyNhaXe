using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLiNhaXe
{
    public partial class FDatVe : Form
    {
        private DBConnection dbConnection = new DBConnection();

        public FDatVe()
        {
            InitializeComponent();
        }

        private void FDatVe_Load(object sender, EventArgs e)
        {
            HienThiThongTinDatVe();
            LoadDataComboBoxes();
        }
        private void LoadDataComboBoxes()
        {
            LoadDataToComboBox("SELECT MaKhachHang FROM KhachHang", cbkhachhang);
            LoadDataToComboBox("SELECT MaChuyenDi FROM ChuyenDi", cbchuyendi);
        }

        private void LoadDataToComboBox(string query, ComboBox comboBox)
        {
            try
            {
                dbConnection.MoKetNoi();

                SqlDataAdapter adapter = new SqlDataAdapter(query, dbConnection.getConnection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                comboBox.DataSource = dataTable;
                comboBox.DisplayMember = dataTable.Columns[0].ColumnName;
                comboBox.ValueMember = dataTable.Columns[0].ColumnName;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể tải dữ liệu. Lỗi: " + ex.Message);
            }
            finally
            {
                dbConnection.DongKetNoi();
            }
        }

        private void HienThiThongTinDatVe()
        {
            try
            {
                dbConnection.MoKetNoi();

                string query = "SELECT * FROM view_XemKhach";

                SqlDataAdapter adapter = new SqlDataAdapter(query, dbConnection.getConnection);

                DataTable dataTable = new DataTable();

                adapter.Fill(dataTable);

                dgDatVe.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể hiển thị thông tin đặt vé. Lỗi: " + ex.Message);
            }
            finally
            {
                dbConnection.DongKetNoi();
            }
        }

        private void DatVe1(int maChuyenDi, int maKhachHang, int soGheMua, string tenHangHoa, string loaiHang, float kichThuoc, float khoiLuong)
        {
            using (SqlCommand command = new SqlCommand("TinhTongChiPhiCoHang", dbConnection.getConnection))
            {
                command.CommandType = CommandType.StoredProcedure;

                // Thêm các tham số vào stored procedure
                command.Parameters.AddWithValue("@MaChuyenDi", maChuyenDi);
                command.Parameters.AddWithValue("@MaKhachHang", maKhachHang);
                command.Parameters.AddWithValue("@SoGheMua", soGheMua);
                command.Parameters.AddWithValue("@LoaiHang", loaiHang);
                command.Parameters.AddWithValue("@KichThuoc", kichThuoc);
                command.Parameters.AddWithValue("@KhoiLuong", khoiLuong);
                command.Parameters.AddWithValue("@TenHangHoa", tenHangHoa);

                command.ExecuteNonQuery(); // Thực thi stored procedure
            }
        }

        private void DatVe2(int maChuyenDi, int maKhachHang, int soGheMua)
        {
            using (SqlCommand command = new SqlCommand("TinhTongChiPhiKhongHang", dbConnection.getConnection))
            {
                command.CommandType = CommandType.StoredProcedure;

                // Thêm các tham số vào stored procedure
                command.Parameters.AddWithValue("@MaChuyenDi", maChuyenDi);
                command.Parameters.AddWithValue("@MaKhachHang", maKhachHang);
                command.Parameters.AddWithValue("@SoGheMua", soGheMua);

                command.ExecuteNonQuery(); // Thực thi stored procedure
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Thực hiện đặt vé
            try
            {
                dbConnection.MoKetNoi(); // Mở kết nối đến cơ sở dữ liệu

                int maChuyenDi = Convert.ToInt32(cbchuyendi.Text);
                int maKhachHang = Convert.ToInt32(cbkhachhang.Text);
                int soGheMua = Convert.ToInt32(txtsoluongve.Text);

                // Kiểm tra nếu số ghế mua <= 0

                if (cbGuiHang.Checked == true)
                {
                    string tenHangHoa = txtTenHangHoa.Text;
                    string loaiHang = cbbLoaiHang.SelectedItem.ToString();
                    float kichThuoc = float.Parse(txtKichThuoc.Text);
                    float khoiLuong = float.Parse(txtKhoiLuong.Text);

                    DatVe1(maChuyenDi, maKhachHang, soGheMua, tenHangHoa, loaiHang, kichThuoc, khoiLuong);
                    MessageBox.Show("Đặt vé thành công!");
                }
                else
                {
                    if (soGheMua <= 0)
                    {
                        MessageBox.Show("Vui lòng chọn số vé mua");
                        return; // Thoát khỏi phương thức
                    }
                    DatVe2(maChuyenDi, maKhachHang, soGheMua); // Gọi stored procedure chỉ tính toán chi phí vé
                    MessageBox.Show("Đặt vé thành công!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đặt vé không thành công. Lỗi: " + ex.ToString());
            }
            finally
            {
                dbConnection.DongKetNoi(); // Đóng kết nối sau khi hoàn thành
                HienThiThongTinDatVe();
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                dbConnection.MoKetNoi(); // Mở kết nối đến cơ sở dữ liệu

                using (SqlCommand command = new SqlCommand("SuaThongTinDatVe", dbConnection.getConnection))
                {
                    command.CommandType = CommandType.StoredProcedure; // Loại command là stored procedure

                    // Thêm các tham số vào stored procedure
                    command.Parameters.AddWithValue("@MaChuyenDi", cbchuyendi.Text);
                    command.Parameters.AddWithValue("@MaKhachHang", cbkhachhang.Text);
                    command.Parameters.AddWithValue("@SoGheMua", txtsoluongve.Text);

                    command.ExecuteNonQuery(); // Thực thi stored procedure
                }

                MessageBox.Show("Sửa thông tin đặt vé thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sửa thông tin đặt vé không thành công. Lỗi: " + ex.Message);
            }
            finally
            {
                dbConnection.DongKetNoi(); // Đóng kết nối sau khi hoàn thành
                HienThiThongTinDatVe(); // Cập nhật lại hiển thị sau khi sửa
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                dbConnection.MoKetNoi(); // Mở kết nối đến cơ sở dữ liệu

                using (SqlCommand command = new SqlCommand("XoaThongTinDatVe", dbConnection.getConnection))
                {
                    command.CommandType = CommandType.StoredProcedure; // Loại command là stored procedure

                    // Thêm các tham số vào stored procedure
                    command.Parameters.AddWithValue("@MaChuyenDi", cbchuyendi.Text);
                    command.Parameters.AddWithValue("@MaKhachHang", cbkhachhang.Text);

                    command.ExecuteNonQuery(); // Thực thi stored procedure
                }

                MessageBox.Show("Xóa thông tin đặt vé thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa thông tin đặt vé không thành công. Lỗi: " + ex.Message);
            }
            finally
            {
                dbConnection.DongKetNoi(); // Đóng kết nối sau khi hoàn thành
                HienThiThongTinDatVe(); // Cập nhật lại hiển thị sau khi xóa
            }
        }

        private void cbGuiHang_CheckedChanged(object sender, EventArgs e)
        {
            if (cbGuiHang.Checked)
            {
                txtKhoiLuong.Enabled = true;
                txtKichThuoc.Enabled = true;
                cbbLoaiHang.Enabled = true;
                txtTenHangHoa.Enabled = true;
            }
            else 
            {
                txtKhoiLuong.Enabled = false;
                txtKichThuoc.Enabled = false;
                cbbLoaiHang.Enabled = false;
                txtTenHangHoa.Enabled= false;
                txtKhoiLuong.BackColor = Color.Transparent;
                txtKichThuoc.BackColor = Color.Transparent;
                cbbLoaiHang.BackColor = Color.Transparent;
                txtTenHangHoa.BackColor = Color.Transparent;
            }

        }
    }
}
