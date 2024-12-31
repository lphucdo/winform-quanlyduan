using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDuAn.Entity
{
    public class Quy
    {
        public string MaQuy { get; set; }
        public string TenQuy { get; set; }
        public decimal SoTien { get; set; }
        public string NganHang { get; set; }
        public string SoTaiKhoan { get; set; }

        public Quy()
        {
        }

        public Quy(string MaQuy, string TenQuy, decimal SoTien, string NganHang, string SoTaiKhoan)
        {
            this.MaQuy = MaQuy;
            this.TenQuy = TenQuy;
            this.SoTien = SoTien;
            this.NganHang = NganHang;
            this.SoTaiKhoan = SoTaiKhoan;
        }
    }
}
