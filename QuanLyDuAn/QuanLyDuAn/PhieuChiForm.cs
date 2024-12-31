using QuanLyDuAn.Dao;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyDuAn
{
    public partial class PhieuChiForm : UserControl
    {
        SqlConnection conn = DAO.GetConnection();
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataSet ds = null;
        int vt = -1;

        public PhieuChiForm()
        {
            InitializeComponent();
            HienThiDSPhieuChi();
            quanLyNut(true, false, false);
        }

        public void HienThiDSPhieuChi()
        {
            string sql = "SELECT * FROM tbl_phieuchi";
            try
            {
                conn.Open();
                adapter = new SqlDataAdapter(sql, conn);
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                ds = new DataSet();
                dgvDanhSachPhieuChi.AutoGenerateColumns = false;
                adapter.Fill(ds, "tbl_phieuchi");
                dgvDanhSachPhieuChi.DataSource = ds.Tables["tbl_phieuchi"];
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
            txtSoPhieuChi.Text = string.Empty;
            txtLyDo.Text = string.Empty;
            txtSoTien.Text = string.Empty;
            txtMaQuy.Text = string.Empty;
            txtGiamDocDuyet.Text = string.Empty;
            quanLyNut(true, false, false);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (vt == -1) return;

            try
            {
                conn.Open();
                DataRow row = ds.Tables["tbl_phieuchi"].Rows[vt];
                row.BeginEdit();
                row["SoPhieuChi"] = txtSoPhieuChi.Text;
                row["LyDo"] = txtLyDo.Text;
                row["SoTien"] = decimal.TryParse(txtSoTien.Text, out var soTien) ? soTien : 0;
                row["MaQuy"] = txtMaQuy.Text;
                row["GiamDocDuyet"] = int.TryParse(txtGiamDocDuyet.Text, out var giamDocDuyet) ? giamDocDuyet : 0;
                row.EndEdit();

                int success = adapter.Update(ds.Tables["tbl_phieuchi"]);
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

            try
            {
                conn.Open();
                DataRow row = ds.Tables["tbl_phieuchi"].Rows[vt];
                row.Delete();
                int success = adapter.Update(ds.Tables["tbl_phieuchi"]);
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
                if (string.IsNullOrEmpty(txtSoPhieuChi.Text) || string.IsNullOrEmpty(txtLyDo.Text) ||
                    string.IsNullOrEmpty(txtSoTien.Text) || string.IsNullOrEmpty(txtMaQuy.Text) ||
                    string.IsNullOrEmpty(txtGiamDocDuyet.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                    return;
                }

                conn.Open();
                DataRow row = ds.Tables["tbl_phieuchi"].NewRow();
                row["SoPhieuChi"] = txtSoPhieuChi.Text;
                row["LyDo"] = txtLyDo.Text;
                row["SoTien"] = decimal.TryParse(txtSoTien.Text, out var soTien) ? soTien : 0;
                row["MaQuy"] = txtMaQuy.Text;
                row["GiamDocDuyet"] = int.TryParse(txtGiamDocDuyet.Text, out var giamDocDuyet) ? giamDocDuyet : 0;
                ds.Tables["tbl_phieuchi"].Rows.Add(row);

                int success = adapter.Update(ds.Tables["tbl_phieuchi"]);
                if (success > 0)
                {
                    MessageBox.Show("Thêm thành công phiếu chi");
                    HienThiDSPhieuChi();
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

        private void dgvDanhSachPhieuChi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            vt = e.RowIndex;
            if (vt < 0 || vt >= ds.Tables["tbl_phieuchi"].Rows.Count) return;

            DataRow row = ds.Tables["tbl_phieuchi"].Rows[vt];
            txtSoPhieuChi.Text = row["SoPhieuChi"].ToString();
            txtLyDo.Text = row["LyDo"].ToString();
            txtSoTien.Text = row["SoTien"].ToString();
            txtMaQuy.Text = row["MaQuy"].ToString();
            txtGiamDocDuyet.Text = row["GiamDocDuyet"].ToString();

            quanLyNut(false, true, true);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text;

            if (string.IsNullOrEmpty(keyword))
            {
                MessageBox.Show("Nhập từ khóa tìm kiếm trước khi ấn!");
                HienThiDSPhieuChi();
                return;
            }

            string filter = string.Format("SoPhieuChi LIKE '%{0}%' OR LyDo LIKE '%{0}%' OR MaQuy LIKE '%{0}%'", keyword);
            DataRow[] rows = ds.Tables["tbl_phieuchi"].Select(filter);

            if (rows.Length > 0)
            {
                DataTable resultTable = ds.Tables["tbl_phieuchi"].Clone();
                foreach (DataRow row in rows)
                {
                    resultTable.ImportRow(row);
                }
                dgvDanhSachPhieuChi.DataSource = resultTable;
            }
        }

        private void quanLyNut(bool themMoi, bool luu, bool xoa)
        {
            btnThemMoi.Enabled = themMoi;
            btnLuu.Enabled = luu;
            btnXoa.Enabled = xoa;
        }
    }
}
