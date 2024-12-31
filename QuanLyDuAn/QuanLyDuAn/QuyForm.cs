using QuanLyDuAn.Dao;
using QuanLyDuAn.Entity;
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

namespace QuanLyDuAn
{
    public partial class QuyForm : UserControl
    {
        SqlConnection conn = DAO.GetConnection();
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataSet ds = null;

        public QuyForm()
        {
            InitializeComponent();
            HienThiDSQuy();
            AddItemsIntoCombobox();
            quanLyNut(true, false, false);
        }

        private void AddItemsIntoCombobox()
        {
            cbxNganHang.Items.Add("VIETTINBANK");
            cbxNganHang.Items.Add("MBBANK");
            cbxNganHang.Items.Add("VIETCOMBANK");
        }

        public void HienThiDSQuy()
        {
            string sql = "select * from tbl_quy";
            try
            {
                conn.Open();
                adapter = new SqlDataAdapter(sql, conn);
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                ds = new DataSet();
                dgvDanhSachQuy.AutoGenerateColumns = false;
                adapter.Fill(ds, "tbl_quy");
                dgvDanhSachQuy.DataSource = ds.Tables["tbl_quy"];
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
            txtMaQuy.Text = string.Empty;
            txtTenQuy.Text = string.Empty;
            txtSoTien.Text = string.Empty;
            txtSoTK.Text = string.Empty;
            cbxNganHang.SelectedIndex = -1;
            cbxNganHang.Refresh();
            quanLyNut(true, false, false);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (vt == -1) return;

            try
            {
                Quy quy = new Quy()
                {
                    MaQuy = txtMaQuy.Text,
                    TenQuy = txtTenQuy.Text,
                    NganHang = cbxNganHang.SelectedItem.ToString() ?? string.Empty,
                    SoTien = decimal.TryParse(txtSoTien.Text, out var soTien) ? soTien : 0,
                    SoTaiKhoan = txtSoTK.Text
                };

                conn.Open();
                DataRow row = ds.Tables["tbl_quy"].Rows[vt];
                row.BeginEdit();
                row["MaQuy"] = quy.MaQuy;
                row["TenQuy"] = quy.TenQuy;
                row["NganHang"] = quy.NganHang;
                row["SoTien"] = quy.SoTien;
                row["SoTaiKhoan"] = quy.SoTaiKhoan;
                row.EndEdit();

                int success = adapter.Update(ds.Tables["tbl_quy"]);
                if (success > 0)
                {
                    MessageBox.Show("Sửa thành công");
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra");
                }
            }
            catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
            finally { 
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
                DataRow row = ds.Tables["tbl_quy"].Rows[vt];
                row.Delete();
                int success = adapter.Update(ds.Tables["tbl_quy"]);
                if (success > 0)
                {
                    MessageBox.Show("Xoá Thành Công");
                }
                else
                {
                    MessageBox.Show("Xoá Thất bại");
                }
            }
            catch(Exception ex) {
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
                if(txtMaQuy.Text == string.Empty || txtTenQuy.Text == string.Empty || 
                    txtSoTien.Text == string.Empty || txtSoTK.Text == string.Empty)
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                    return;
                }
                Quy quy = new Quy()
                {
                    MaQuy = txtMaQuy.Text,
                    TenQuy = txtTenQuy.Text,
                    NganHang = cbxNganHang.SelectedItem.ToString() ?? string.Empty,
                    SoTien = decimal.TryParse(txtSoTien.Text, out var soTien) ? soTien : 0,
                    SoTaiKhoan = txtSoTK.Text
                };



                if (quy != null) {
                    conn.Open();
                    DataRow row = ds.Tables["tbl_quy"].NewRow();
                    row["MaQuy"] = quy.MaQuy;
                    row["TenQuy"] = quy.TenQuy;
                    row["NganHang"] = quy.NganHang;
                    row["SoTien"] = quy.SoTien;
                    row["SoTaiKhoan"] = quy.SoTaiKhoan;

                    ds.Tables["tbl_quy"].Rows.Add(row);
                    int kq = adapter.Update(ds.Tables["tbl_quy"]);
                    if(kq > 0)
                    {
                        MessageBox.Show("Thêm thành công quỹ");
                        HienThiDSQuy();
                    }
                    else
                    {
                        MessageBox.Show("Thất bại thêm!");
                    }
                }

                quanLyNut(true, false, false);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi: "+ ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        int vt = -1;
        private void dgvDanhSachQuy_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            quanLyNut(false, true, true);

            vt = e.RowIndex;
            if (vt == -1) return;
            DataRow row = ds.Tables["tbl_quy"].Rows[vt];
            txtMaQuy.Text = row["MaQuy"].ToString();
            txtTenQuy.Text = row["TenQuy"].ToString();
            txtSoTien.Text = row["SoTien"].ToString();
            cbxNganHang.Text = row["NganHang"].ToString(); cbxNganHang.Refresh();
            txtSoTK.Text = row["SoTaiKhoan"].ToString();
        }

        private void quanLyNut(bool a, bool b, bool c)
        {
            btnThemMoi.Enabled = a;
            btnLuu.Enabled = b;
            btnXoa .Enabled = c;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string text = txtTimKiem.Text;

            if (string.IsNullOrEmpty(text)) {
                MessageBox.Show("Nhập từ khoá tìm kiếm trước khi ấn?");
                HienThiDSQuy();
                return;
            };

            string filter = string.Format("MaQuy LIKE '%{0}%' OR TenQuy LIKE '%{0}%' OR NganHang LIKE '%{0}%'", text);
            DataRow[] rows = ds.Tables["tbl_quy"].Select(filter);

            if (rows.Length > 0) 
            {
                DataTable resultTable = ds.Tables["tbl_quy"].Clone();
                foreach (DataRow row in rows) 
                {
                    resultTable.ImportRow(row);
                }

                dgvDanhSachQuy.DataSource = resultTable;
            }
        }
    }
}
