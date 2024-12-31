using Microsoft.Reporting.WinForms;
using QuanLyDuAn.Dao;
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
    public partial class BaoCaoChiTietVatTu : Form
    {
        SqlConnection conn = Dao.DAO.GetConnection();
        public BaoCaoChiTietVatTu()
        {
            InitializeComponent();
            DataTable dt = new DataTable();

            SqlDataAdapter dap = new SqlDataAdapter("SELECT MaDuAn FROM tbl_duan", conn);

            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }

                dap.Fill(dt);

                cbxMaDuAn.DataSource = dt;
                cbxMaDuAn.DisplayMember = "MaDuAn"; // Chỉ định trường hiển thị
                cbxMaDuAn.ValueMember = "MaDuAn"; // Chỉ định giá trị của ComboBox
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        private void BaoCaoChiTietVatTu_Load(object sender, EventArgs e)
        {
            if (cbxMaDuAn.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn dự án.");
                return;
            }
            // Cast SelectedItem thành DataRowView
            DataRowView selectedRow = (DataRowView)cbxMaDuAn.SelectedItem;

            using (SqlConnection conn = DAO.GetConnection())
            {
                string maDuAn = selectedRow["MaDuAn"].ToString();
                conn.Open();
                SqlCommand cmd = new SqlCommand("pd_chiphivattu_duan", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                // Truyền tham số vào stored procedure
                cmd.Parameters.AddWithValue("@MaDuAn", maDuAn);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                // Tạo BindingSource từ DataTable
                this.chiPhiVatTuBindingSource.DataSource = dataTable;

                //ReportParameter[] parameters = new ReportParameter[2];
                //parameters[0] = new ReportParameter("NguoiBaoCao", NguoiDung.NguoiDungInstant.TenNguoiDung);
                //parameters[0] = new ReportParameter("NguoiBaoCao", "Đỗ Phúc Lâm");
                //parameters[1] = new ReportParameter("Ngay", DateTime.Now.ToString("dd/MM/yyyy"));
                //this.reportViewer1.LocalReport.SetParameters(parameters);
                this.reportViewer1.RefreshReport();

            }
        }
    }
}
