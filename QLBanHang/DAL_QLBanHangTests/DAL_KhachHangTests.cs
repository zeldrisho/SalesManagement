using Microsoft.VisualStudio.TestTools.UnitTesting;
using DAL_QLBanHang;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_QLBanHang;
namespace DAL_QLBanHang.Tests
{
    [TestClass()]
    public class DAL_KhachHangTests
    {
        [TestMethod()]
        public void insertKHTest001()
        {
            // login thiếu số điện thoại
            DAL_KhachHang add = new DAL_KhachHang();
            DTO_KhachHang khachHang = new DTO_KhachHang() 
            {
                phai = "Nam",

                tenKhach = "Nguyễn Thành",
                diaChi = "BRVT",
                emailNV = "akhucute5@gmail.com"
            };
            bool result = add.insertKH(khachHang);
            Assert.IsFalse(result);
        }
        [TestMethod()]

        public void insertKHTest002()
        {
            // login thiếu tên
            DAL_KhachHang add = new DAL_KhachHang();
            DTO_KhachHang khachHang = new DTO_KhachHang()
            {
                phai = "Nam",

                soDienThoai = "0123456789",
                diaChi = "BRVT",
                emailNV = "akhucute5@gmail.com"
            };
            bool result = add.insertKH(khachHang);
            Assert.IsFalse(result);

        }

        [TestMethod()]

        public void insertKHTest003()
        {
            // login thiếu địa chỉ
            DAL_KhachHang add = new DAL_KhachHang();
            DTO_KhachHang khachHang = new DTO_KhachHang()
            {
                phai = "Nam",
                soDienThoai = "0123456789",
                tenKhach = "Nguyễn Thành",
                emailNV = "akhucute5@gmail.com"
            };
            bool result = add.insertKH(khachHang);
            Assert.IsFalse(result);

        }
        [TestMethod()]

        public void insertKHTest004()
        {
            // login thiếu phái
            DAL_KhachHang add = new DAL_KhachHang();
            DTO_KhachHang khachHang = new DTO_KhachHang()
            {
                soDienThoai = "0123456789",
                tenKhach = "Nguyễn Thành",
                emailNV = "akhucute5@gmail.com",
                diaChi = "BRVT"
            };
            bool result = add.insertKH(khachHang);
            Assert.IsFalse(result);

        }
        [TestMethod()]

        public void insertKHTest005()
        {
            // login thành công
            DAL_KhachHang add = new DAL_KhachHang();
            DTO_KhachHang khachHang = new DTO_KhachHang()
            {
                soDienThoai = "0123456789",
                tenKhach = "Nguyễn Thành",
                diaChi = "BRVT",
                phai = "Nam",
                emailNV = "akhucute5@gmail.com"
            };
            bool result = add.insertKH(khachHang);
            Assert.IsTrue(result);

        }


    }
}