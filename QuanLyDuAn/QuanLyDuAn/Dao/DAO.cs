using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Configuration;
using System.Data.SqlClient;

namespace QuanLyDuAn.Dao
{
    public class DAO
    {
        static string connstr = ConfigurationManager.ConnectionStrings["connstr"].ConnectionString;
        public static SqlConnection GetConnection()
        {
            SqlConnection conn = new SqlConnection(connstr);
            return conn;
        }
    }
}
