using Microsoft.VisualStudio.TestTools.UnitTesting;
using DTO_QLBanHang;
namespace DAL_QLBanHang.Tests
{
    [TestClass()]
    public class DAL_NhanVienTests
    {
        [TestMethod()]
        public void DangNhapTest001()
        {
            //login thiếu trường email
            DAL_NhanVien login = new DAL_NhanVien();
            bool result = login.DangNhap("", "matkhau");
            Assert.IsFalse(result);
        }
        [TestMethod()]
        public void DangNhapTest002()
        {
            //login thiếu trường password
            DAL_NhanVien login = new DAL_NhanVien();
            bool result = login.DangNhap("abc", "");
            Assert.IsFalse(result);
        }
        [TestMethod()]
        public void DangNhapTest003()
        {
            //login thiếu trường password và email
            DAL_NhanVien login = new DAL_NhanVien();
            bool result = login.DangNhap("", "");
            Assert.IsFalse(result);
        }
        [TestMethod()]
        public void DangNhapTest004()
        {
            //login thành công
            DAL_NhanVien login = new DAL_NhanVien();
            bool result = login.DangNhap("akhucute5@gmail.com", "263617819617711222721081031195915165129188");
            Assert.IsTrue(result);
        }




        // thêm nhân viên 
        [TestMethod()]
        public void ThemNVTest001()
        {
            // thêm nhân viên thiếu email
            DAL_NhanVien add = new DAL_NhanVien();
            DTO_NhanVien nv = new DTO_NhanVien()
            {
                TenNhanVien = "Thanh",
                DiaChi = "HCM",
                VaiTro = 1,
                TinhTrang = 1,
                MatKhau = "33333"

            };
            bool result = add.insertNhanVien(nv);
            Assert.IsFalse(result);
        }
        [TestMethod()]
        public void ThemNVTest002()
        {
            // thêm nhân viên thiếu tên
            DAL_NhanVien add = new DAL_NhanVien();
            DTO_NhanVien nv = new DTO_NhanVien()
            {
                EmailNV = "a@a.a",
                DiaChi = "HCM",
                VaiTro = 1,
                TinhTrang = 1,
                MatKhau = "33333"

            };
            bool result = add.insertNhanVien(nv);
            Assert.IsFalse(result);
        }
        [TestMethod()]
        public void ThemNVTest003()
        {
            // thêm nhân viên thiếu đại chỉ
            DAL_NhanVien add = new DAL_NhanVien();
            DTO_NhanVien nv = new DTO_NhanVien()
            {
                EmailNV = "a@a.a",
                TenNhanVien = "Nguyễn Thành",
                VaiTro = 1,
                TinhTrang = 1,
                MatKhau = "33333"

            };
            bool result = add.insertNhanVien(nv);
            Assert.IsFalse(result);
        }
   
        [TestMethod()]
        public void ThemNVTest004()
        {
            // thêm nhân viên thiếu tinh trạng
            DAL_NhanVien add = new DAL_NhanVien();
            DTO_NhanVien nv = new DTO_NhanVien()
            {
                EmailNV = "akhucute@gmail.com",
                TenNhanVien = "Nguyễn Thành",
                DiaChi = "HCM",
                VaiTro = 1,
                TinhTrang = 1,
                MatKhau = "matkhaune"
            };
            bool result = add.insertNhanVien(nv);
            Assert.IsTrue(result);
        }
    }
}