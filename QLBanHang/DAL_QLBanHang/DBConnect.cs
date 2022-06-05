using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
