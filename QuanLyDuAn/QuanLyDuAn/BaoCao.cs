using Microsoft.Reporting.WinForms;
using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;
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
    public partial class BaoCao : UserControl
    {
        SqlConnection conn = Dao.DAO.GetConnection();
        public BaoCao()
        {
            InitializeComponent();

        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {

        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            BaoCaoChiTietDuAn baoCaoChiTietDuAn = new BaoCaoChiTietDuAn();
            baoCaoChiTietDuAn.Show();
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            BaoCaoChiTietVatTu baoCaoChiTietVatTu = new BaoCaoChiTietVatTu();
            baoCaoChiTietVatTu.Show();
        }

        private void btnCPMay_Click(object sender, EventArgs e)
        {
            BaoCaoChiTietMay baoCaoChiTietMay = new BaoCaoChiTietMay();
            baoCaoChiTietMay.Show();
        }
    }
}
