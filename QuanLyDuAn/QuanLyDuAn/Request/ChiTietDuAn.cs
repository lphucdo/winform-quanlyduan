using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDuAn.Request
{
    public class ChiTietDuAn
    {
        public string MaVatTu {  get; set; }
        public string TenVatTu { get; set; }

        public string DonViTinh { get; set; }
        public string NoiDung { get; set; }

        public int SoLuong { get; set; }    
        public string DonGia { get; set; }
        public string ThanhTien {  get; set; }
        public string MaNCC { get; set; }   
        public string SoPhieuChi {  get; set; }
    }
}
