using QuanLyDuAn.Dao;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyDuAn
{
    public partial class NhanVienForm : UserControl
    {
        SqlConnection conn = DAO.GetConnection();
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataSet ds = null;
        int vt = -1;

        public NhanVienForm()
        {
            InitializeComponent();
            HienThiDSNhanVien();
            AddItemsIntoComboBox();
            quanLyNut(true, false, false);
        }

        private void AddItemsIntoComboBox()
        {
            cbxChucVu.Items.Add("Giám đốc");
            cbxChucVu.Items.Add("Trưởng phòng");
            cbxChucVu.Items.Add("Nhân viên");
        }

        public void HienThiDSNhanVien()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            string sql = "SELECT * FROM tbl_nhanvien";
            try
            {
                conn.Open();
                adapter = new SqlDataAdapter(sql, conn);
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                ds = new DataSet();
                dgvDanhSachNhanVien.AutoGenerateColumns = false;
                adapter.Fill(ds, "tbl_nhanvien");
                dgvDanhSachNhanVien.DataSource = ds.Tables["tbl_nhanvien"];
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

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                if (txtMaNhanVien.Text == string.Empty || txtTenNhanVien.Text == string.Empty ||
                    txtSoDienThoai.Text == string.Empty || txtDiaChi.Text == string.Empty ||
                    txtLuong.Text == string.Empty || cbxChucVu.SelectedIndex == -1)
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                    return;
                }

                DataRow row = ds.Tables["tbl_nhanvien"].NewRow();
                row["MaNhanVien"] = txtMaNhanVien.Text;
                row["TenNhanVien"] = txtTenNhanVien.Text;
                row["NgaySinh"] = dtpNgaySinh.Value;
                row["SoDienThoai"] = txtSoDienThoai.Text;
                row["DiaChi"] = txtDiaChi.Text;
                row["Luong"] = decimal.TryParse(txtLuong.Text, out var luong) ? luong : 0;
                row["ChucVu"] = cbxChucVu.SelectedItem.ToString();
                ds.Tables["tbl_nhanvien"].Rows.Add(row);

                conn.Open();
                int kq = adapter.Update(ds.Tables["tbl_nhanvien"]);
                if (kq > 0)
                {
                    MessageBox.Show("Thêm thành công nhân viên!");
                    HienThiDSNhanVien();
                }
                else
                {
                    MessageBox.Show("Thất bại thêm nhân viên!");
                }
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

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (vt == -1) return;
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            try
            {
                DataRow row = ds.Tables["tbl_nhanvien"].Rows[vt];
                row.BeginEdit();
                row["MaNhanVien"] = txtMaNhanVien.Text;
                row["TenNhanVien"] = txtTenNhanVien.Text;
                row["NgaySinh"] = dtpNgaySinh.Value;
                row["SoDienThoai"] = txtSoDienThoai.Text;
                row["DiaChi"] = txtDiaChi.Text;
                row["Luong"] = decimal.TryParse(txtLuong.Text, out var luong) ? luong : 0;
                row["ChucVu"] = cbxChucVu.SelectedItem.ToString();
                row.EndEdit();

                conn.Open();
                int kq = adapter.Update(ds.Tables["tbl_nhanvien"]);
                if (kq > 0)
                {
                    MessageBox.Show("Cập nhật thành công!");
                    HienThiDSNhanVien();
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                conn.Close();
                vt = -1;
                quanLyNut(true, false, false);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (vt == -1) return;
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            try
            {
                DataRow row = ds.Tables["tbl_nhanvien"].Rows[vt];
                row.Delete();

                conn.Open();
                int kq = adapter.Update(ds.Tables["tbl_nhanvien"]);
                if (kq > 0)
                {
                    MessageBox.Show("Xoá thành công!");
                    HienThiDSNhanVien();
                }
                else
                {
                    MessageBox.Show("Xoá thất bại!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                conn.Close();
                vt = -1;
                quanLyNut(true, false, false);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtMaNhanVien.Text = string.Empty;
            txtTenNhanVien.Text = string.Empty;
            txtSoDienThoai.Text = string.Empty;
            txtDiaChi.Text = string.Empty;
            txtLuong.Text = string.Empty;
            cbxChucVu.SelectedIndex = -1;
            dtpNgaySinh.Value = DateTime.Now;
            quanLyNut(true, false, false);
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.RowIndex >= ds.Tables["tbl_nhanvien"].Rows.Count) return;

            vt = e.RowIndex;
            DataRow row = ds.Tables["tbl_nhanvien"].Rows[vt];
            txtMaNhanVien.Text = row["MaNhanVien"].ToString();
            txtTenNhanVien.Text = row["TenNhanVien"].ToString();
            txtSoDienThoai.Text = row["SoDienThoai"].ToString();
            txtDiaChi.Text = row["DiaChi"].ToString();
            txtLuong.Text = row["Luong"].ToString();
            cbxChucVu.Text = row["ChucVu"].ToString();cbxChucVu.Refresh();
            dtpNgaySinh.Value = DateTime.TryParse(row["NgaySinh"].ToString(), out var date) ? date : DateTime.Now;

            quanLyNut(false, true, true);
        }

        private void quanLyNut(bool themMoi, bool sua, bool xoa)
        {
            btnThemMoi.Enabled = themMoi;
            btnLuu.Enabled = sua;
            btnXoa.Enabled = xoa;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text.Trim();

            if (string.IsNullOrEmpty(keyword))
            {
                MessageBox.Show("Vui lòng nhập từ khóa để tìm kiếm!");
                HienThiDSNhanVien();
                return;
            }

            try
            {
                string filter = $"MaNhanVien LIKE '%{keyword}%' OR TenNhanVien LIKE '%{keyword}%' OR SoDienThoai LIKE '%{keyword}%'";
                DataRow[] rows = ds.Tables["tbl_nhanvien"].Select(filter);

                if (rows.Length > 0)
                {
                    DataTable resultTable = ds.Tables["tbl_nhanvien"].Clone();
                    foreach (DataRow row in rows)
                    {
                        resultTable.ImportRow(row);
                    }

                    dgvDanhSachNhanVien.DataSource = resultTable;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy nhân viên nào phù hợp!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

    }
}
