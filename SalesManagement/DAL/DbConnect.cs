using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DbConnect
    {
        static string connstr = ConfigurationManager.ConnectionStrings["SalesManagement"].ToString();
        protected SqlConnection _conn = new SqlConnection(connstr);
    }
}
