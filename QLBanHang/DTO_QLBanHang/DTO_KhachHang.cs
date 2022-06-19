namespace DTO_QLBanHang
{
    public class DTO_KhachHang
    {
        private string soDienThoai;
        private string tenKhach;
        private string diaChi;
        private string phai;
        private string emailNV;

        public string SoDienThoai { get => soDienThoai; set => soDienThoai = value; }
        public string TenKhach { get => tenKhach; set => tenKhach = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string Phai { get => phai; set => phai = value; }
        public string EmailNV { get => emailNV; set => emailNV = value; }

        public DTO_KhachHang() { }

        public DTO_KhachHang(string soDienThoai, string tenKhach, string diaChi, string phai)
        {
            this.soDienThoai = soDienThoai;
            this.tenKhach = tenKhach;
            this.diaChi = diaChi;
            this.phai = phai;
        }

        public DTO_KhachHang(string soDienThoai, string tenKhach, string diaChi, string phai, string emailNV)
        {
            this.soDienThoai = soDienThoai;
            this.tenKhach = tenKhach;
            this.diaChi = diaChi;
            this.phai = phai;
            this.emailNV = emailNV;
        }
    }
}
