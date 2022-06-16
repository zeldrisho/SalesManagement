namespace DTO_QLBanHang
{
   public class DTO_NhanVien
    {

        private string tenNhanVien;
        private string diaChi;
        private int vaiTro;    // true = 1 , flase = 0 ;
        private string emailNV;
        private string matKhau;
        private int tinhTrang;


        public string TenNhanVien
        {
            get
            {
                return tenNhanVien;
            }
            set
            {
                tenNhanVien = value;
            }
        }

        public string DiaChi
        {
            get
            {
                return diaChi;
            }
            set
            {
                diaChi = value;
            }
        }


        public int VaiTro
        {
            get
            {
                return vaiTro;
            }
            set
            {
                vaiTro = value;
            }
        }


        public string EmailNV
        {
            get
            {
                return emailNV;
            }
            set
            {
                emailNV = value;
            }
        }


        public string MatKhau
        {
            get
            {
                return matKhau;
            }
            set
            {
                matKhau = value;
            }
        }


        public int TinhTrang
        {
            get
            {
                return tinhTrang;
            }
            set
            {
                tinhTrang = value;
            }
        }

        public DTO_NhanVien(string _email , string _tenNV, string _diaChi , int _vaiTro , int _tinhTrang , string _matKhau)
        {
            this.emailNV = _email;
            this.tenNhanVien = _tenNV;
            this.diaChi = _diaChi;
            this.vaiTro = _vaiTro;
            this.tinhTrang = _tinhTrang;
            this.matKhau = _matKhau;
        }
        public DTO_NhanVien(string _email, string _tenNV, string _diaChi, int _vaiTro, int _tinhTrang)
        {
            this.emailNV = _email;
            this.tenNhanVien = _tenNV;
            this.diaChi = _diaChi;
            this.vaiTro = _vaiTro;
            this.tinhTrang = _tinhTrang;
        }
        public DTO_NhanVien() { }
    }
}
