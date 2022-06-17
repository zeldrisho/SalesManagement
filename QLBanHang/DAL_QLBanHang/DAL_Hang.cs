using System;
using System.Data;
using System.Data.SqlClient;
using DTO_QLBanHang;

namespace DAL_QLBanHang
{
    public class DAL_Hang : DBConnect
    {
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

        public bool insertHang(DTO_Hang hang)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "InsertDataHang";
                cmd.Parameters.AddWithValue("TenHang", hang.TenHang);
                cmd.Parameters.AddWithValue("Soluong", hang.SoLuong);
                cmd.Parameters.AddWithValue("DonGiaBan", hang.DonGiaBan);
                cmd.Parameters.AddWithValue("DonGiaNhap", hang.DonGiaNhap);
                cmd.Parameters.AddWithValue("Email", hang.Email);
                cmd.Parameters.AddWithValue("HinhAnh", hang.HinhAnh);
                cmd.Parameters.AddWithValue("GhiChu", hang.GhiChu);
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

        public bool updateHang(DTO_Hang Hang)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "UpdateHang";
                cmd.Parameters.AddWithValue("MaHang", Hang.MaHang);
                cmd.Parameters.AddWithValue("TenHang", Hang.TenHang);
                cmd.Parameters.AddWithValue("Soluong", Hang.SoLuong);
                cmd.Parameters.AddWithValue("DonGiaBan", Hang.DonGiaBan);
                cmd.Parameters.AddWithValue("DonGiaNhap", Hang.DonGiaNhap);
                cmd.Parameters.AddWithValue("HinhAnh", Hang.HinhAnh);
                cmd.Parameters.AddWithValue("GhiChu", Hang.GhiChu);

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
