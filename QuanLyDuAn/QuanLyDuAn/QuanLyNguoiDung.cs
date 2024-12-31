using QuanLyDuAn.Dao;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyDuAn
{
    public partial class NguoiDungForm : UserControl
    {
        SqlConnection conn = DAO.GetConnection();
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataSet ds = null;

        public NguoiDungForm()
        {
            InitializeComponent();
            AddDefaultQuyenToCombobox();
            HienThiDSNguoiDung();
            quanLyNut(true, false, false);
        }
        private void AddDefaultQuyenToCombobox()
        {
            cbxMaQuyen.Items.Add("ADMIN");
            cbxMaQuyen.Items.Add("USER");
        }

        public void HienThiDSNguoiDung()
        {
            string sql = "select * from tbl_nguoidung";
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            try
            {
                conn.Open();
                adapter = new SqlDataAdapter(sql, conn);
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                ds = new DataSet();
                dgvDanhSachNguoiDung.AutoGenerateColumns = false;
                adapter.Fill(ds, "tbl_nguoidung");
                dgvDanhSachNguoiDung.DataSource = ds.Tables["tbl_nguoidung"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtTaiKhoan.Text = string.Empty;
            txtMatKhau.Text = string.Empty;
            txtTenNguoiDung.Text = string.Empty;
            cbxMaQuyen.SelectedIndex = -1;
            cbxMaQuyen.Refresh();
            quanLyNut(true, false, false);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (vt == -1) return;
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            try
            {
                conn.Open();
                DataRow row = ds.Tables["tbl_nguoidung"].Rows[vt];
                row.BeginEdit();
                row["TaiKhoan"] = txtTaiKhoan.Text;
                row["MatKhau"] = txtMatKhau.Text;
                row["TenNguoiDung"] = txtTenNguoiDung.Text;
                row["MaQuyen"] = cbxMaQuyen.SelectedItem?.ToString() ?? string.Empty;
                row.EndEdit();

                int success = adapter.Update(ds.Tables["tbl_nguoidung"]);
                if (success > 0)
                {
                    MessageBox.Show("Sửa thành công");
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                conn.Close();
                quanLyNut(false, true, true);
                vt = -1;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (vt == -1) return;

            try
            {
                conn.Open();
                DataRow row = ds.Tables["tbl_nguoidung"].Rows[vt];
                row.Delete();
                int success = adapter.Update(ds.Tables["tbl_nguoidung"]);
                if (success > 0)
                {
                    MessageBox.Show("Xoá Thành Công");
                }
                else
                {
                    MessageBox.Show("Xoá Thất bại");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có Lỗi Xảy ra: " + ex.Message);
            }
            finally
            {
                conn.Close();
                vt = -1;
                quanLyNut(true, false, false);
            }
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTaiKhoan.Text == string.Empty || txtMatKhau.Text == string.Empty ||
                    txtTenNguoiDung.Text == string.Empty || cbxMaQuyen.SelectedIndex == -1)
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                    return;
                }

                conn.Open();
                DataRow row = ds.Tables["tbl_nguoidung"].NewRow();
                row["TaiKhoan"] = txtTaiKhoan.Text;
                row["MatKhau"] = txtMatKhau.Text;
                row["TenNguoiDung"] = txtTenNguoiDung.Text;
                row["MaQuyen"] = cbxMaQuyen.SelectedItem?.ToString() ?? string.Empty;

                ds.Tables["tbl_nguoidung"].Rows.Add(row);
                int kq = adapter.Update(ds.Tables["tbl_nguoidung"]);
                if (kq > 0)
                {
                    MessageBox.Show("Thêm thành công người dùng");
                    HienThiDSNguoiDung();
                }
                else
                {
                    MessageBox.Show("Thất bại thêm!");
                }

                quanLyNut(true, false, false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        int vt = -1;
        private void dgvDanhSachNguoiDung_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            quanLyNut(false, true, true);

            vt = e.RowIndex;
            if (vt == -1) return;
            DataRow row = ds.Tables["tbl_nguoidung"].Rows[vt];
            txtTaiKhoan.Text = row["TaiKhoan"].ToString();
            txtMatKhau.Text = row["MatKhau"].ToString();
            txtTenNguoiDung.Text = row["TenNguoiDung"].ToString();
            cbxMaQuyen.Text = row["MaQuyen"].ToString();
            cbxMaQuyen.Refresh();
        }

        private void quanLyNut(bool a, bool b, bool c)
        {
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text;

            if (string.IsNullOrEmpty(keyword))
            {
                MessageBox.Show("Nhập từ khóa tìm kiếm trước khi ấn!");
                HienThiDSNguoiDung();
                return;
            }

            string filter = $"TaiKhoan LIKE '%{keyword}%' OR TenNguoiDung LIKE '%{keyword}%' OR MaQuyen LIKE '%{keyword}%'";
            DataRow[] rows = ds.Tables["tbl_nguoidung"].Select(filter);

            if (rows.Length > 0)
            {
                DataTable resultTable = ds.Tables["tbl_nguoidung"].Clone();
                foreach (DataRow row in rows)
                {
                    resultTable.ImportRow(row);
                }
                dgvDanhSachNguoiDung.DataSource = resultTable;
            }
            else
            {
                MessageBox.Show("Không tìm thấy kết quả!");
            }
        }

        private void dgvDanhSachNguoiDung_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra chỉ số hàng được chọn
            vt = e.RowIndex;
            if (vt < 0 || vt >= ds.Tables["tbl_nguoidung"].Rows.Count) return;

            try
            {
                DataRow row = ds.Tables["tbl_nguoidung"].Rows[vt];
                txtTaiKhoan.Text = row["TaiKhoan"]?.ToString();
                txtMatKhau.Text = row["MatKhau"]?.ToString();
                txtTenNguoiDung.Text = row["TenNguoiDung"]?.ToString();
                cbxMaQuyen.Text = row["MaQuyen"]?.ToString();
                cbxMaQuyen.Refresh();
                quanLyNut(false, true, true);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi khi hiển thị thông tin người dùng: {ex.Message}");
            }
        }

    }
}
