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
    public class DAL_Hang : DBConnect
    {
        //xem danh sách  hàng
        public DataTable danhSachHang()
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DanhSachHang";
                DataTable data = new DataTable();
                data.Load(cmd.ExecuteReader());
                return data;
            }
            finally
            {
                _conn.Close();
            }
        }

        //thêm  hàng
        public bool insertHang(DTO_Hang hang)
        {

            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "InsertDataHang";
                cmd.Parameters.AddWithValue("TenHang", hang.tenHang);
                cmd.Parameters.AddWithValue("Soluong", hang.soLuong);
                cmd.Parameters.AddWithValue("DonGiaBan", hang.donGiaBan);
                cmd.Parameters.AddWithValue("DonGiaNhap", hang.donGiaNhap);
                cmd.Parameters.AddWithValue("Email", hang.email);
                cmd.Parameters.AddWithValue("HinhAnh", hang.hinhAnh);
                cmd.Parameters.AddWithValue("GhiChu", hang.ghiChu);
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
        // cập nhật  hàng
        public bool updateHang(DTO_Hang Hang)
        {
            try
            {

                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "UpdateHang";
                cmd.Parameters.AddWithValue("maHang", Hang.maHang);
                cmd.Parameters.AddWithValue("TenHang", Hang.tenHang);
                cmd.Parameters.AddWithValue("Soluong", Hang.soLuong);
                cmd.Parameters.AddWithValue("DonGiaBan", Hang.donGiaBan);
                cmd.Parameters.AddWithValue("DonGiaNhap", Hang.donGiaNhap);
                cmd.Parameters.AddWithValue("hinhAnh", Hang.hinhAnh);
                cmd.Parameters.AddWithValue("ghiChu", Hang.ghiChu);

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

        // xóa  hàng
        public bool deleteHang(string maHang)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DeleteDataFromHang";
                cmd.Parameters.AddWithValue("mahang", maHang);

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


        // tìm  hàng
        public DataTable searchHang(string tenhang)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SearchHang";
                cmd.Parameters.AddWithValue("tenHang", tenhang);
                DataTable data = new DataTable();
                data.Load(cmd.ExecuteReader());
                return data;

            }

            finally
            {
                _conn.Close();
            }
        }




        // thông kê
        public DataTable thongKeSP()
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "ThongKeSP";
                DataTable data = new DataTable();
                data.Load(cmd.ExecuteReader());
                return data;

            }

            finally
            {
                _conn.Close();
            }
        }


        // thông kê
        public DataTable thongKeTonKho()
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "ThongKeTonKho";
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
