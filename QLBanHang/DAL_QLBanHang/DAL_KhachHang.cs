using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_QLBanHang;
namespace DAL_QLBanHang
{
   public class DAL_KhachHang : DBConnect
    {
        //xem danh sách khách hàng
        public DataTable danhSachKH()
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DanhSachKhach";
                DataTable data = new DataTable();
                data.Load(cmd.ExecuteReader());
                return data;
            }
            finally
            {
                _conn.Close();
            }
        }


        //thêm khách hàng
        public bool insertKH(DTO_KhachHang khachHang)
        {

            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "InsertDataKhach";
                cmd.Parameters.AddWithValue("DienThoai", khachHang.soDienThoai);
                cmd.Parameters.AddWithValue("TenKhach", khachHang.tenKhach);
                cmd.Parameters.AddWithValue("DiaChi", khachHang.diaChi);
                cmd.Parameters.AddWithValue("Phai", khachHang.phai);
                cmd.Parameters.AddWithValue("Email", khachHang.emailNV);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception)
            {

            }
            finally
            {
                _conn.Close();
            }
            return false;
        }


        // cập nhật khách hàng
        public bool updateKH(DTO_KhachHang khachHang)
        {
            try
            {
                
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "UpdateKhach";
                cmd.Parameters.AddWithValue("dienThoai", khachHang.soDienThoai);
                cmd.Parameters.AddWithValue("tenKhach", khachHang.tenKhach);
                cmd.Parameters.AddWithValue("diaChi", khachHang.diaChi);
                cmd.Parameters.AddWithValue("phai", khachHang.phai);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
                else
                    return false;

            }
            catch (Exception)
            {

            }
            finally
            {
                _conn.Close();
            }

            return false;
        }


        // xóa khách hàng
        public bool deleteKH(string dienthoai)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DeleteDataFromKhach";
                cmd.Parameters.AddWithValue("DienThoai", dienthoai);

                if (cmd.ExecuteNonQuery() >0)
                    return true;
                else
                    return false;

            }
            catch (Exception)
            {

            }
            finally
            {
                _conn.Close();
            }

            return false;
        }

        // tìm khách hàng
        public DataTable searchKH(string tenKhach)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SearchKhach";
                cmd.Parameters.AddWithValue("tenKhach", tenKhach);
                DataTable data = new DataTable();
                data.Load(cmd.ExecuteReader());
                return data;

            }

            finally
            {
                _conn.Close();
            }

        }

    }
}
