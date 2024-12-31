using QuanLyDuAn.Dao;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyDuAn
{
    public partial class NhaCungCapForm : UserControl
    {
        SqlConnection conn = DAO.GetConnection();
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataSet ds = null;
        int vt = -1;

        public NhaCungCapForm()
        {
            InitializeComponent();
            HienThiDSNhaCungCap();
            quanLyNut(true, false, false);
        }

        public void HienThiDSNhaCungCap()
        {
            string sql = "select * from tbl_nhacungcap";
            if (conn.State == ConnectionState.Open) conn.Close();
            try
            {
                conn.Open();
                adapter = new SqlDataAdapter(sql, conn);
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                ds = new DataSet();
                dgvDanhSachNhaCungCap.AutoGenerateColumns = false;
                adapter.Fill(ds, "tbl_nhacungcap");
                dgvDanhSachNhaCungCap.DataSource = ds.Tables["tbl_nhacungcap"];
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
            txtMaNCC.Text = string.Empty;
            txtTenNCC.Text = string.Empty;
            txtSoDienThoai.Text = string.Empty;
            quanLyNut(true, false, false);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (vt == -1) return;
            if (conn.State == ConnectionState.Open) conn.Close();
            try
            {
                conn.Open();
                DataRow row = ds.Tables["tbl_nhacungcap"].Rows[vt];
                row.BeginEdit();
                row["MaNCC"] = txtMaNCC.Text;
                row["TenNCC"] = txtTenNCC.Text;
                row["SoDienThoai"] = txtSoDienThoai.Text;
                row.EndEdit();

                int success = adapter.Update(ds.Tables["tbl_nhacungcap"]);
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
            if (conn.State == ConnectionState.Open) conn.Close();
            try
            {
                conn.Open();
                DataRow row = ds.Tables["tbl_nhacungcap"].Rows[vt];
                row.Delete();
                int success = adapter.Update(ds.Tables["tbl_nhacungcap"]);
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
                if (string.IsNullOrEmpty(txtMaNCC.Text) || string.IsNullOrEmpty(txtTenNCC.Text) || string.IsNullOrEmpty(txtSoDienThoai.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                    return;
                }
                if (conn.State == ConnectionState.Open) conn.Close();
                conn.Open();
                DataRow row = ds.Tables["tbl_nhacungcap"].NewRow();
                row["MaNCC"] = txtMaNCC.Text;
                row["TenNCC"] = txtTenNCC.Text;
                row["SoDienThoai"] = txtSoDienThoai.Text;
                ds.Tables["tbl_nhacungcap"].Rows.Add(row);

                int success = adapter.Update(ds.Tables["tbl_nhacungcap"]);
                if (success > 0)
                {
                    MessageBox.Show("Thêm thành công");
                    HienThiDSNhaCungCap();
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

        private void dgvDanhSachNCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            vt = e.RowIndex;
            if (vt < 0 || vt >= ds.Tables["tbl_nhacungcap"].Rows.Count) return;

            DataRow row = ds.Tables["tbl_nhacungcap"].Rows[vt];
            txtMaNCC.Text = row["MaNCC"].ToString();
            txtTenNCC.Text = row["TenNCC"].ToString();
            txtSoDienThoai.Text = row["SoDienThoai"].ToString();

            quanLyNut(false, true, true);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text;

            if (string.IsNullOrEmpty(keyword))
            {
                MessageBox.Show("Nhập từ khóa tìm kiếm trước khi ấn!");
                HienThiDSNhaCungCap();
                return;
            }

            string filter = string.Format("MaNCC LIKE '%{0}%' OR TenNCC LIKE '%{0}%' OR SoDienThoai LIKE '%{0}%'", keyword);
            DataRow[] rows = ds.Tables["tbl_nhacungcap"].Select(filter);

            if (rows.Length > 0)
            {
                DataTable resultTable = ds.Tables["tbl_nhacungcap"].Clone();
                foreach (DataRow row in rows)
                {
                    resultTable.ImportRow(row);
                }
                dgvDanhSachNhaCungCap.DataSource = resultTable;
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
