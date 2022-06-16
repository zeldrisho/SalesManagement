using System;
using System.Security.Cryptography;
using System.Text;
using DAL_QLBanHang;
using System.Data;
using DTO_QLBanHang;
namespace BUS_QLBanHang
{
   public class BUS_NhanVien
    {
        DAL_NhanVien dalNhanVien = new DAL_NhanVien();
        private string encrytion(string password)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] encrypt;
            UTF8Encoding encode = new UTF8Encoding();
            encrypt = md5.ComputeHash(encode.GetBytes(password));
            StringBuilder builder = new StringBuilder();
            foreach (var item in encrypt)
            {
                builder.Append(item.ToString());
            }
            return builder.ToString();
        }

        public bool DangNhap(string email, string password)
        {
            password = encrytion(password);
           return dalNhanVien.DangNhap(email, password);
        }
        public bool checkEmail (string email)
        {
            return dalNhanVien.QuenMatKhau(email);
        }
        public bool updateMatKhau(string email , string password)
        {
            password = encrytion(password);
            return dalNhanVien.UpdateMatKhau(email, password);
        }
        public bool LayVaiTro(string email)
        {
            return dalNhanVien.LayVaiTroNV(email);
        }

        public bool QuenMatKhau(string email ,string opassword , string npassword)
        {
            opassword = encrytion(opassword);
            npassword = encrytion(npassword);
            return dalNhanVien.QuenMatKhau(email, opassword, npassword);
        }

        public DataTable danhSachNV()
        {
            return dalNhanVien.danhSachNV();
        }
        public bool insertNhanVien(DTO_NhanVien nhanVien)
        {
            nhanVien.MatKhau = encrytion(nhanVien.MatKhau);
            return dalNhanVien.insertNhanVien(nhanVien);
        }
        public bool updateNhanVien(DTO_NhanVien nhanVien)
        {
            return dalNhanVien.updateNhanVien(nhanVien);
        }
        public bool deleteNhanVien(string email)
        {
            return dalNhanVien.deleteNhanVien(email);
        }
        public DataTable searchNhanVien(string tenNV)
        {
            return dalNhanVien.searchNhanVien(tenNV);
        }
        public DataTable thongTinNV(string email)
        {
            return dalNhanVien.thongTinNhanVien(email);
        }


        // tạo mật khẩu random 
        public string getPassword()
        {
            Random r = new Random();
            StringBuilder builder = new StringBuilder();
            builder.Append(randomString(4, true));
            builder.Append(r.Next(1000, 9999));
            builder.Append(randomString(2, false));
            return builder.ToString();

        }
        private string randomString(int size, bool lowerCase)
        {
            StringBuilder builder = new StringBuilder();
            Random r = new Random();
            char ch;
            for (int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * r.NextDouble() + 65)));
                builder.Append(ch);
            }
            if (lowerCase)
            {
                return builder.ToString().ToUpper();

            }
            else return builder.ToString().ToLower();
        }
    }
}
