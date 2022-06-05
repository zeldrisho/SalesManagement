using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLBanHang
{
    public class DTO_KhachHang
    {

        private string DienThoai;
        private string TenKhach;
        private string DiaChi;
        private string Phai;
        private string email;
        public string soDienThoai
        {
            get
            {
                return DienThoai;
            }
            set
            {
                DienThoai = value;
            }
        }
        public string tenKhach
        {
            get
            {
                return TenKhach;
            }
            set
            {
                TenKhach = value;
            }
        }

        public string diaChi
        {
            get
            {
                return DiaChi;
            }
            set
            {
                DiaChi = value;
            }
        }
        public string phai
        {
            get
            {
                return Phai;
            }
            set
            {
                Phai = value;
            }
        }
        public string emailNV
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }
        public DTO_KhachHang(string _dienthoai, string _tenKhach, string _diaChi, string _phai, string _email)
        {
            this.soDienThoai = _dienthoai;
            this.tenKhach = _tenKhach;
            this.diaChi = _diaChi;
            this.phai = _phai;
            this.emailNV = _email;
        }
        public DTO_KhachHang(string _dienthoai, string _tenKhach, string _diaChi, string _phai)
        {
            this.soDienThoai = _dienthoai;
            this.tenKhach = _tenKhach;
            this.diaChi = _diaChi;
            this.phai = _phai;
        }
        public DTO_KhachHang() { }
    }
}
