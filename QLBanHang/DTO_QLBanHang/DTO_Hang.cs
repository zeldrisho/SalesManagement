namespace DTO_QLBanHang
{
    public class DTO_Hang
    {
        private int MaHang;
        private string TenHang;
        private int SoLuong;
        private float DonGiaNhap;
        private float DonGiaBan;
        private string HinhAnh;
        private string GhiChu;
        private string Email;

        public int maHang
        {
            get
            {
                return MaHang;
            }
            set
            {
                MaHang = value;
            }
        }
        public string tenHang
        {
            get
            {
                return TenHang;
            }
            set
            {
                TenHang = value;
            }
        }
        public int soLuong
        {
            get
            {
                return SoLuong;
            }
            set
            {
                SoLuong = value;
            }
        }
        public float donGiaNhap
        {
            get
            {
                return DonGiaNhap;
            }
            set
            {
                DonGiaNhap = value;
            }
        }
        public float donGiaBan
        {
            get
            {
                return DonGiaBan;
            }
            set
            {
                DonGiaBan = value;
            }
        }
        public string hinhAnh
        {
            get
            {
                return HinhAnh;
            }
            set
            {
                HinhAnh = value;
            }
        }
        public string ghiChu
        {
            get
            {
                return GhiChu;
            }
            set
            {
                GhiChu = value;
            }
        }
        public string email
        {
            get
            {
                return Email;
            }
            set
            {
                Email = value;
            }
        }

        public DTO_Hang(int _maHang,string _tenHang , int _soLuong , float _donGiaNhap , float _donGiaBan , string _hinhAnh , string _ghiChu)
        {
            this.maHang = _maHang;
            this.tenHang = _tenHang;
            this.soLuong = _soLuong;
            this.donGiaNhap = _donGiaNhap;
            this.donGiaBan = _donGiaBan;
            this.hinhAnh = _hinhAnh;
            this.ghiChu = _ghiChu;
        }
        public DTO_Hang(string _tenHang, int _soLuong, float _donGiaNhap, float _donGiaBan, string _hinhAnh, string _ghiChu , string _email)
        {
            this.tenHang = _tenHang;
            this.soLuong = _soLuong;
            this.donGiaNhap = _donGiaNhap;
            this.donGiaBan = _donGiaBan;
            this.hinhAnh = _hinhAnh;
            this.ghiChu = _ghiChu;
            this.email = _email;
        }
        public DTO_Hang() { }
 
    }
}
