using QuanLyDuAn.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDuAn.Dao
{
    public class QuyDAO
    {
        static SqlConnection conn;
        static SqlCommand cmd;
        public static int addQuy(Quy quy) {
            string sql = @"INSERT INTO tbl_quy (MaQuy, TenQuy, SoTien, NganHang, SoTaiKhoan) 
                VALUES (@MaQuy, @TenQuy, @SoTien, @NganHang, @SoTaiKhoan)";
            
            conn.Open();
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@MaQuy", quy.MaQuy);
            cmd.Parameters.AddWithValue("@TenQuy", quy.TenQuy);
            cmd.Parameters.AddWithValue("@SoTien", quy.SoTien);
            cmd.Parameters.AddWithValue("@NganHang", quy.NganHang);
            cmd.Parameters.AddWithValue("@SoTaiKhoan", quy.SoTaiKhoan);

            //cmd.exec

            return 0;
        }
    }
}
