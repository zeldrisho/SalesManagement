using System;
using DTO_QLBanHang;
using System.Data.SqlClient;
using System.Data;

namespace DAL_QLBanHang
{
   public class DAL_NhanVien : DBConnect
    {
        public bool DangNhap(string email , string password)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "DangNhap";
                cmd.Parameters.AddWithValue("email", email);
                cmd.Parameters.AddWithValue("matkhau", password);
                if (Convert.ToInt16(cmd.ExecuteScalar()) == 1)
                    return true;
                else
                    return false;
            }
            catch (Exception )
            {
              
            }
            finally
            {
                _conn.Close();
            }
            return false;
        }

        public bool QuenMatKhau(string email)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "QuenMatKhau";
                cmd.Parameters.AddWithValue("email", email);
                if (Convert.ToInt16(cmd.ExecuteScalar()) == 1)
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

        public bool UpdateMatKhau(string email, string pass)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "UpdateMatKhau";
                cmd.Parameters.AddWithValue("email", email);
                cmd.Parameters.AddWithValue("pass", pass);

                if (cmd.ExecuteNonQuery() != 0)
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

        public bool LayVaiTroNV(string email)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "LayVaiTroNV";
                cmd.Parameters.AddWithValue("email", email);
                if (Convert.ToInt16(cmd.ExecuteScalar()) == 1)
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

        public bool QuenMatKhau(string email , string opassword , string npassword)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "ChangePwd";
                cmd.Parameters.AddWithValue("email", email);
                cmd.Parameters.AddWithValue("@oPwd", opassword);
                cmd.Parameters.AddWithValue("@nPwd", npassword);

                if (Convert.ToInt16(cmd.ExecuteScalar()) == 1)
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

        //xem danh sách nhân viên
        public DataTable danhSachNV()
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DanhSachNhanVien";
                DataTable data = new DataTable();
                data.Load(cmd.ExecuteReader());
                return data;
            }
            finally
            {
                _conn.Close();
            }
        }
        


        //thêm nhân viên
        public bool insertNhanVien(DTO_NhanVien nhanVien)
        {

            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "InsertDataNhanVien";
                cmd.Parameters.AddWithValue("email", nhanVien.EmailNV);
                cmd.Parameters.AddWithValue("tennv", nhanVien.TenNhanVien);
                cmd.Parameters.AddWithValue("diachi", nhanVien.DiaChi);
                cmd.Parameters.AddWithValue("vaitro", nhanVien.VaiTro);
                cmd.Parameters.AddWithValue("tinhtrang", nhanVien.TinhTrang);
                cmd.Parameters.AddWithValue("matkhau", nhanVien.MatKhau);
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


        // cập nhân nhân viên 
        public bool updateNhanVien (DTO_NhanVien nhanVien)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "UpdateNhanVien";
                cmd.Parameters.AddWithValue("email", nhanVien.EmailNV);
                cmd.Parameters.AddWithValue("tenNv", nhanVien.TenNhanVien);
                cmd.Parameters.AddWithValue("diaChi", nhanVien.DiaChi);
                cmd.Parameters.AddWithValue("vaitro", nhanVien.VaiTro);
                cmd.Parameters.AddWithValue("tinhtrang", nhanVien.TinhTrang);
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

        // xóa nhân viên
        public bool deleteNhanVien(string email)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DeleteDataFromNhanVien";
                cmd.Parameters.AddWithValue("Email", email);
                
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

        // tìm nhân viên
        public DataTable searchNhanVien(string tenNV)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SearchNhanVien";
                cmd.Parameters.AddWithValue("tenNV", tenNV);
                DataTable data = new DataTable();
                data.Load(cmd.ExecuteReader());
                return data;

            }
            
            finally
            {
                _conn.Close();
            }

        }

        //thong tin nhan vien 
        public DataTable thongTinNhanVien(string email)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "XemThongTinNV";
                cmd.Parameters.AddWithValue("email", email);
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
