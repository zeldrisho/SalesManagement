using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess
{
    public class LoginDao : ILoginDao
    {
        public int Login(string userId, string passwordEncrypted)
        {
            object returnValue;

            //Lấy chuỗi kết nối
            var connString = ConfigurationManager.ConnectionStrings["QLBH"].ConnectionString;

            //Tạo connection đến cơ sở dữ liệu
            using (var conn = new SqlConnection(connString))
            {
                //Mở connection
                conn.Open();

                //Tạo command
                using (var cmd = conn.CreateCommand())
                {
                    //Gán nội dung câu lệnh select
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "DangNhap";

                    //Xóa các parameters
                    cmd.Parameters.Clear();

                    //Thêm các parameters cần thiết cho Stored Procedure
                    cmd.Parameters.AddWithValue("email", userId);
                    cmd.Parameters.AddWithValue("matkhau", passwordEncrypted);

                    //Thực thi câu lệnh select
                    returnValue = cmd.ExecuteScalar();
                }
            }

            return (int)returnValue;
        }
    }
}