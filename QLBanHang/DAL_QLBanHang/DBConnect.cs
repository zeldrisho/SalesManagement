using System.Data.SqlClient;
using System.Configuration;

namespace DAL_QLBanHang
{
    public class DBConnect
    {
        static string connstr = ConfigurationManager.ConnectionStrings["QLBH"].ToString();
        protected SqlConnection _conn = new SqlConnection(connstr);
    }
}
