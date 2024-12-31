using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDuAn.Response
{
    public class ChiTietDuAn
    {
        public string MaVatTu { get; set; }
        public string TenVatTu { get; set; }
        public string DonViTinh { get; set; }
        public string MaHangMucVatTu { get; set; }
        public string MaHangMuc { get; set; }
        public string NoiDung { get; set; }
        public int SoLuong { get; set; }
        public decimal DonGia { get; set; }
        public decimal ThanhTien { get; set; }
        public string MaNCC { get; set; }
        public string SoPhieuChi { get; set; }


        public ChiTietDuAn(string maVatTu, string tenVatTu, string donViTinh, string maHangMucVatTu, string maHangMuc, string noiDung, int soLuong, decimal donGia, decimal thanhTien, string maNCC, string soPhieuChi)
        {
            MaVatTu = maVatTu;
            TenVatTu = tenVatTu;
            DonViTinh = donViTinh;
            MaHangMucVatTu = maHangMucVatTu;
            MaHangMuc = maHangMuc;
            NoiDung = noiDung;
            SoLuong = soLuong;
            DonGia = donGia;
            ThanhTien = thanhTien;
            MaNCC = maNCC;
            SoPhieuChi = soPhieuChi;
        }

        public ChiTietDuAn()
        {
        }
    }
}
