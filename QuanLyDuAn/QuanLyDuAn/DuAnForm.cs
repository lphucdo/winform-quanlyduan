using QuanLyDuAn.Dao;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyDuAn
{
    public partial class DuAnForm : UserControl
    {
        SqlConnection conn = DAO.GetConnection();
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataSet ds = null;
        int vt = -1;

        public DuAnForm()
        {
            InitializeComponent();
            HienThiDSDuAn();
            AddItemsIntoComboBox();
            quanLyNut(true, false, false);
        }

        private void AddItemsIntoComboBox()
        {
            cbxTrangThai.Items.Add("Chưa bắt đầu");
            cbxTrangThai.Items.Add("Đang thực hiện");
            cbxTrangThai.Items.Add("Hoàn thành");
        }

        public void HienThiDSDuAn()
        {
            string sql = "SELECT * FROM tbl_duan";
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
                dgvDanhSachDuAn.AutoGenerateColumns = false;
                adapter.Fill(ds, "tbl_duan");
                dgvDanhSachDuAn.DataSource = ds.Tables["tbl_duan"];
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
            txtMaDuAn.Text = string.Empty;
            txtTenDuAn.Text = string.Empty;
            txtSoHopDong.Text = string.Empty;
            dtpNgayHopDong.Value = DateTime.Now;
            txtGiaTriHopDong.Text = string.Empty;
            txtGiaTriQuyetToan.Text = string.Empty;
            cbxTrangThai.SelectedIndex = -1;
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
                DataRow row = ds.Tables["tbl_duan"].Rows[vt];
                row.BeginEdit();
                row["MaDuAn"] = txtMaDuAn.Text;
                row["TenDuAn"] = txtTenDuAn.Text;
                row["SoHopDong"] = txtSoHopDong.Text;
                row["NgayHopDong"] = dtpNgayHopDong.Value;
                row["GiaTriHopDong"] = decimal.TryParse(txtGiaTriHopDong.Text, out var giaTriHD) ? giaTriHD : 0;
                row["GiaTriQuyetToan"] = decimal.TryParse(txtGiaTriQuyetToan.Text, out var giaTriQT) ? giaTriQT : 0;
                row["TrangThai"] = cbxTrangThai.SelectedItem?.ToString() ?? "";
                row.EndEdit();

                int success = adapter.Update(ds.Tables["tbl_duan"]);
                if (success > 0)
                {
                    MessageBox.Show("Cập nhật thành công");
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
                quanLyNut(true, false, false);
                vt = -1;
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
                conn.Open();
                DataRow row = ds.Tables["tbl_duan"].Rows[vt];
                row.Delete();
                int success = adapter.Update(ds.Tables["tbl_duan"]);
                if (success > 0)
                {
                    MessageBox.Show("Xóa thành công");
                }
                else
                {
                    MessageBox.Show("Xóa thất bại");
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

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtMaDuAn.Text) || string.IsNullOrEmpty(txtTenDuAn.Text) ||
                    string.IsNullOrEmpty(txtSoHopDong.Text) || string.IsNullOrEmpty(txtGiaTriHopDong.Text) ||
                    string.IsNullOrEmpty(txtGiaTriQuyetToan.Text) || cbxTrangThai.SelectedIndex == -1)
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                    return;
                }

                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                conn.Open();
                DataRow row = ds.Tables["tbl_duan"].NewRow();
                row["MaDuAn"] = txtMaDuAn.Text;
                row["TenDuAn"] = txtTenDuAn.Text;
                row["SoHopDong"] = txtSoHopDong.Text;
                row["NgayHopDong"] = dtpNgayHopDong.Value;
                row["GiaTriHopDong"] = decimal.TryParse(txtGiaTriHopDong.Text, out var giaTriHD) ? giaTriHD : 0;
                row["GiaTriQuyetToan"] = decimal.TryParse(txtGiaTriQuyetToan.Text, out var giaTriQT) ? giaTriQT : 0;
                row["TrangThai"] = cbxTrangThai.SelectedItem?.ToString() ?? "";
                ds.Tables["tbl_duan"].Rows.Add(row);

                int success = adapter.Update(ds.Tables["tbl_duan"]);
                if (success > 0)
                {
                    MessageBox.Show("Thêm mới thành công");
                    HienThiDSDuAn();
                }
                else
                {
                    MessageBox.Show("Thất bại thêm mới");
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

        private void dgvDanhSachDuAn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            vt = e.RowIndex;
            if (vt < 0 || vt >= ds.Tables["tbl_duan"].Rows.Count)
            {
                MessageBox.Show("Dòng không hợp lệ!");
                return;
            }

            DataRow row = ds.Tables["tbl_duan"].Rows[vt];
            txtMaDuAn.Text = row["MaDuAn"].ToString();
            txtTenDuAn.Text = row["TenDuAn"].ToString();
            txtSoHopDong.Text = row["SoHopDong"].ToString();
            dtpNgayHopDong.Value = DateTime.TryParse(row["NgayHopDong"].ToString(), out var ngayHD) ? ngayHD : DateTime.Now;
            txtGiaTriHopDong.Text = row["GiaTriHopDong"].ToString();
            txtGiaTriQuyetToan.Text = row["GiaTriQuyetToan"].ToString();
            cbxTrangThai.Text = row["TrangThai"].ToString();cbxTrangThai.Refresh();

            quanLyNut(false, true, true);
        }

        private void quanLyNut(bool a, bool b, bool c)
        {
            btnThemMoi.Enabled = a;
            btnLuu.Enabled = b;
            btnXoa.Enabled = c;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text;

            if (string.IsNullOrEmpty(keyword))
            {
                MessageBox.Show("Nhập từ khóa tìm kiếm trước khi ấn!");
                HienThiDSDuAn();
                return;
            }

            string filter = string.Format("MaDuAn LIKE '%{0}%' OR TenDuAn LIKE '%{0}%' OR SoHopDong LIKE '%{0}%'", keyword);
            DataRow[] rows = ds.Tables["tbl_duan"].Select(filter);

            if (rows.Length > 0)
            {
                DataTable resultTable = ds.Tables["tbl_duan"].Clone();
                foreach (DataRow row in rows)
                {
                    resultTable.ImportRow(row);
                }
                dgvDanhSachDuAn.DataSource = resultTable;
            }

        }
    }
}


