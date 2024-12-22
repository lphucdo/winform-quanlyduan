using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDuAn.Entity
{
    public class NguoiDung
    {
        public static NguoiDung NguoiDungInstant { get; set; }

        public NguoiDung()
        {
        }

        public NguoiDung(string taiKhoan, string tenNguoiDung, string matKhau, string quyen)
        {
            TaiKhoan = taiKhoan;
            TenNguoiDung = tenNguoiDung;
            MatKhau = matKhau;
            Quyen = quyen;
        }

        public string TaiKhoan {  get; set; }
        public string TenNguoiDung {  get; set; }
        public string MatKhau { get; set; }
        public string Quyen {  get; set; }



    }
}
