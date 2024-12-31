using QuanLyDuAn.Dao;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyDuAn
{
    public partial class HangMucForm : UserControl
    {
        SqlConnection conn = DAO.GetConnection();
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataSet ds = null;
        DataSet ds2 = null;
        DataSet dsMain = null;
        int vt = -1;

        public HangMucForm()
        {
            InitializeComponent();
            HienThiDSHangMuc();
            HienThiDSHangMucMay();
            mainHienThiDSHangMucDuAn();
        }

        // Hiển thị danh sách hàng mục vật tư
        public void HienThiDSHangMuc()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }

            string sql = "SELECT * FROM tbl_hangmuc_vattu";
            try
            {
                conn.Open();
                adapter = new SqlDataAdapter(sql, conn);
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                ds2 = new DataSet();
                dgvHangMucVatTu.AutoGenerateColumns = false;
                adapter.Fill(ds2, "tbl_hangmuc_vattu");
                dgvHangMucVatTu.DataSource = ds2.Tables["tbl_hangmuc_vattu"];
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

        //

        // Thêm hàng mục vật tư mới
        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                if (txtMaHangMucMain.Text == string.Empty || txtNoiDung.Text == string.Empty ||
                    txtSoLuong.Text == string.Empty || txtDonGia.Text == string.Empty ||
                    txtThanhTien.Text == string.Empty || txtMaNCC.Text == string.Empty ||
                    txtMaVatTu.Text == string.Empty || txtSoPhieuChi.Text == string.Empty)
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                    return;
                }

                DataRow row = ds2.Tables["tbl_hangmuc_vattu"].NewRow();
                row["MaHangMuc"] = txtMaHangMucMain.Text;
                row["NoiDung"] = txtNoiDung.Text;
                row["SoLuong"] = int.TryParse(txtSoLuong.Text, out var soLuong) ? soLuong : 0;
                row["DonGia"] = decimal.TryParse(txtDonGia.Text, out var donGia) ? donGia : 0;
                row["ThanhTien"] = decimal.TryParse(txtThanhTien.Text, out var thanhTien) ? thanhTien : 0;
                row["MaNCC"] = txtMaNCC.Text;
                row["MaVatTu"] = txtMaVatTu.Text;
                row["SoPhieuChi"] = txtSoPhieuChi.Text;
                ds2.Tables["tbl_hangmuc_vattu"].Rows.Add(row);

                conn.Open();
                int kq = adapter.Update(ds2.Tables["tbl_hangmuc_vattu"]);
                if (kq > 0)
                {
                    MessageBox.Show("Thêm thành công!");
                    HienThiDSHangMuc();
                }
                else
                {
                    MessageBox.Show("Thất bại khi thêm!");
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

        // Sửa hàng mục vật tư
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (vt == -1) return;
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }

            try
            {
                DataRow row = ds2.Tables["tbl_hangmuc_vattu"].Rows[vt];
                row.BeginEdit();
                row["MaHangMuc"] = txtMaHangMucMain.Text;
                row["NoiDung"] = txtNoiDung.Text;
                row["SoLuong"] = int.TryParse(txtSoLuong.Text, out var soLuong) ? soLuong : 0;
                row["DonGia"] = decimal.TryParse(txtDonGia.Text, out var donGia) ? donGia : 0;
                row["ThanhTien"] = decimal.TryParse(txtThanhTien.Text, out var thanhTien) ? thanhTien : 0;
                row["MaNCC"] = txtMaNCC.Text;
                row["MaVatTu"] = txtMaVatTu.Text;
                row["SoPhieuChi"] = txtSoPhieuChi.Text;
                row.EndEdit();

                conn.Open();
                int kq = adapter.Update(ds2.Tables["tbl_hangmuc_vattu"]);
                if (kq > 0)
                {
                    MessageBox.Show("Cập nhật thành công!");
                    HienThiDSHangMuc();
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
            }
        }

        // Xóa hàng mục vật tư
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (vt == -1) return;
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }

            try
            {
                DataRow row = ds2.Tables["tbl_hangmuc_vattu"].Rows[vt];
                row.Delete();

                conn.Open();
                int kq = adapter.Update(ds2.Tables["tbl_hangmuc_vattu"]);
                if (kq > 0)
                {
                    MessageBox.Show("Xóa thành công!");
                    HienThiDSHangMuc();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại!");
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
            }
        }

        // Hủy bỏ
        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtMaHangMucMain.Text = string.Empty;
            txtNoiDung.Text = string.Empty;
            txtSoLuong.Text = string.Empty;
            txtDonGia.Text = string.Empty;
            txtThanhTien.Text = string.Empty;
            txtMaNCC.Text = string.Empty;
            txtMaVatTu.Text = string.Empty;
            txtSoPhieuChi.Text = string.Empty;
        }

        // Lựa chọn hàng mục khi click vào bảng
        private void dgvHangMuc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.RowIndex >= ds2.Tables["tbl_hangmuc_vattu"].Rows.Count) return;

            vt = e.RowIndex;
            DataRow row = ds2.Tables["tbl_hangmuc_vattu"].Rows[vt];
            txtNoiDung.Text = row["NoiDung"].ToString();
            txtSoLuong.Text = row["SoLuong"].ToString();
            txtDonGia.Text = row["DonGia"].ToString();
            txtThanhTien.Text = row["ThanhTien"].ToString();
            txtMaNCC.Text = row["MaNCC"].ToString();
            txtMaVatTu.Text = row["MaVatTu"].ToString();
            txtSoPhieuChi.Text = row["SoPhieuChi"].ToString();
        }

        //Hạng mục máy
        // Hiển thị danh sách hạng mục máy
        public void HienThiDSHangMucMay()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }

            string sql = "SELECT * FROM tbl_hangmuc_may";
            try
            {
                conn.Open();
                adapter = new SqlDataAdapter(sql, conn);
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                ds = new DataSet();
                dgvHangMucMay.AutoGenerateColumns = false;
                adapter.Fill(ds, "tbl_hangmuc_may");
                dgvHangMucMay.DataSource = ds.Tables["tbl_hangmuc_may"];
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

        private void btnThemMoiHMM_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                if (txtSoLuongHMM.Text == string.Empty || txtDonGiaHMM.Text == string.Empty ||
                    txtThanhTienHMM.Text == string.Empty || txtMaNCCHMM.Text == string.Empty ||
                    txtMaMayHMM.Text == string.Empty || txtSoPhieuChiHMM.Text == string.Empty)
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                    return;
                }

                DataRow row = ds.Tables["tbl_hangmuc_may"].NewRow();
                row["SoLuong"] = int.TryParse(txtSoLuongHMM.Text, out var soLuong) ? soLuong : 0;
                row["DonGia"] = decimal.TryParse(txtDonGiaHMM.Text, out var donGia) ? donGia : 0;
                row["ThanhTien"] = decimal.TryParse(txtThanhTienHMM.Text, out var thanhTien) ? thanhTien : 0;
                row["MaNCC"] = txtMaNCCHMM.Text;
                row["MaMay"] = txtMaMayHMM.Text;
                row["SoPhieuChi"] = txtSoPhieuChiHMM.Text;
                ds.Tables["tbl_hangmuc_may"].Rows.Add(row);

                conn.Open();
                int kq = adapter.Update(ds.Tables["tbl_hangmuc_may"]);
                if (kq > 0)
                {
                    MessageBox.Show("Thêm thành công!");
                    HienThiDSHangMucMay();
                }
                else
                {
                    MessageBox.Show("Thất bại khi thêm!");
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

        private void btnSuaHMM_Click(object sender, EventArgs e)
        {
            if (vt == -1) return;
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }

            try
            {
                DataRow row = ds.Tables["tbl_hangmuc_may"].Rows[vt];
                row.BeginEdit();
                row["SoLuong"] = int.TryParse(txtSoLuongHMM.Text, out var soLuong) ? soLuong : 0;
                row["DonGia"] = decimal.TryParse(txtDonGiaHMM.Text, out var donGia) ? donGia : 0;
                row["ThanhTien"] = decimal.TryParse(txtThanhTienHMM.Text, out var thanhTien) ? thanhTien : 0;
                row["MaNCC"] = txtMaNCCHMM.Text;
                row["MaMay"] = txtMaMayHMM.Text;
                row["SoPhieuChi"] = txtSoPhieuChiHMM.Text;
                row.EndEdit();

                conn.Open();
                int kq = adapter.Update(ds.Tables["tbl_hangmuc_may"]);
                if (kq > 0)
                {
                    MessageBox.Show("Cập nhật thành công!");
                    HienThiDSHangMucMay();
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
            }
        }

        private void btnXoaHMM_Click(object sender, EventArgs e)
        {
            if (vt == -1) return;
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }

            try
            {
                DataRow row = ds.Tables["tbl_hangmuc_may"].Rows[vt];
                row.Delete();

                conn.Open();
                int kq = adapter.Update(ds.Tables["tbl_hangmuc_may"]);
                if (kq > 0)
                {
                    MessageBox.Show("Xóa thành công!");
                    HienThiDSHangMucMay();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại!");
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
            }
        }

        private void btnHuyHMM_Click(object sender, EventArgs e)
        {
            txtNoiDungHMM.Text = string.Empty;
            txtSoLuongHMM.Text = string.Empty;
            txtDonGiaHMM.Text = string.Empty;
            txtThanhTienHMM.Text = string.Empty;
            txtMaNCCHMM.Text = string.Empty;
            txtMaVatTu.Text = string.Empty;
            txtSoPhieuChiHMM.Text = string.Empty;
        }

        private void dgvHangMucMay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.RowIndex >= ds.Tables["tbl_hangmuc_may"].Rows.Count) return;

            vt = e.RowIndex;
            DataRow row = ds.Tables["tbl_hangmuc_may"].Rows[vt];
            txtNoiDungHMM.Text = row["NoiDung"].ToString();
            txtSoLuongHMM.Text = row["SoLuong"].ToString();
            txtDonGiaHMM.Text = row["DonGia"].ToString();
            txtThanhTienHMM.Text = row["ThanhTien"].ToString();
            txtMaNCCHMM.Text = row["MaNCC"].ToString();
            txtMaMayHMM.Text = row["MaMay"].ToString();
            txtSoPhieuChiHMM.Text = row["SoPhieuChi"].ToString();
        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {

        }

        public void mainHienThiDSHangMucDuAn()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }

            string sql = "SELECT * FROM tbl_hangmuc";
            try
            {
                conn.Open();
                adapter = new SqlDataAdapter(sql, conn);
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                dsMain = new DataSet();
                dgvHangMuc.AutoGenerateColumns = false;
                adapter.Fill(dsMain, "tbl_hangmuc");
                dgvHangMuc.DataSource = dsMain.Tables["tbl_hangmuc"];
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

        // Thêm hạng mục
        private void mainBtnThemMoiHangMuc_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                if (txtMaHangMucMain.Text == string.Empty || txtTenHangMuc.Text == string.Empty || txtMaDuAn.Text == string.Empty)
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                    return;
                }

                DataRow row = dsMain.Tables["tbl_hangmuc"].NewRow();
                row["MaHangMuc"] = txtMaHangMucMain.Text;
                row["TenHangMuc"] = txtTenHangMuc.Text;
                row["MaDuAn"] = txtMaDuAn.Text;
                dsMain.Tables["tbl_hangmuc"].Rows.Add(row);

                conn.Open();
                int kq = adapter.Update(dsMain.Tables["tbl_hangmuc"]);
                if (kq > 0)
                {
                    MessageBox.Show("Thêm thành công!");
                    mainHienThiDSHangMucDuAn();
                }
                else
                {
                    MessageBox.Show("Thất bại khi thêm!");
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

        // Sửa hạng mục
        private void mainBtnSuaHangMuc_Click(object sender, EventArgs e)
        {
            if (vt == -1) return;
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }

            try
            {
                DataRow row = dsMain.Tables["tbl_hangmuc"].Rows[vt];
                row.BeginEdit();
                row["MaHangMuc"] = txtMaHangMucMain.Text;
                row["TenHangMuc"] = txtTenHangMuc.Text;
                row["MaDuAn"] = txtMaDuAn.Text;
                row.EndEdit();

                conn.Open();
                int kq = adapter.Update(dsMain.Tables["tbl_hangmuc"]);
                if (kq > 0)
                {
                    MessageBox.Show("Cập nhật thành công!");
                    mainHienThiDSHangMucDuAn();
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
            }
        }

        // Xóa hạng mục
        private void mainBtnXoaHangMuc_Click(object sender, EventArgs e)
        {
            if (vt == -1) return;
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }

            try
            {
                DataRow row = dsMain.Tables["tbl_hangmuc"].Rows[vt];
                row.Delete();

                conn.Open();
                int kq = adapter.Update(dsMain.Tables["tbl_hangmuc"]);
                if (kq > 0)
                {
                    MessageBox.Show("Xóa thành công!");
                    mainHienThiDSHangMucDuAn();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại!");
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
            }
        }

        // Lựa chọn hạng mục khi click vào bảng
        private void dgvHangMucDuAn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.RowIndex >= dsMain.Tables["tbl_hangmuc"].Rows.Count) return;

            vt = e.RowIndex;
            DataRow row = dsMain.Tables["tbl_hangmuc"].Rows[vt];
            txtMaHangMucMain.Text = row["MaHangMuc"].ToString();
            txtTenHangMuc.Text = row["TenHangMuc"].ToString();
            txtMaDuAn.Text = row["MaDuAn"].ToString();
        }

    }
}
