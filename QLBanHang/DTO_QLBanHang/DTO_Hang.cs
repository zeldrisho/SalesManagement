namespace DTO_QLBanHang
{
    public class DTO_Hang
    {
        private int maHang;
        private string tenHang;
        private int soLuong;
        private float donGiaNhap;
        private float donGiaBan;
        private byte[] hinhAnh;
        private string ghiChu;
        private string email;

        public DTO_Hang()
        {
        }

        public DTO_Hang(int maHang, string tenHang, int soLuong, float donGiaNhap, float donGiaBan, byte[] hinhAnh, string ghiChu, string email)
        {
            this.MaHang = maHang;
            this.TenHang = tenHang;
            this.SoLuong = soLuong;
            this.DonGiaNhap = donGiaNhap;
            this.DonGiaBan = donGiaBan;
            this.HinhAnh = hinhAnh;
            this.GhiChu = ghiChu;
            this.Email = email;
        }

        public DTO_Hang(string tenHang, int soLuong, float donGiaNhap, float donGiaBan, byte[] hinhAnh, string ghiChu, string email)
        {
            this.TenHang = tenHang;
            this.SoLuong = soLuong;
            this.DonGiaNhap = donGiaNhap;
            this.DonGiaBan = donGiaBan;
            this.HinhAnh = hinhAnh;
            this.GhiChu = ghiChu;
            this.Email = email;
        }

        public int MaHang { get => maHang; set => maHang = value; }
        public string TenHang { get => tenHang; set => tenHang = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public float DonGiaNhap { get => donGiaNhap; set => donGiaNhap = value; }
        public float DonGiaBan { get => donGiaBan; set => donGiaBan = value; }
        public byte[] HinhAnh { get => hinhAnh; set => hinhAnh = value; }
        public string GhiChu { get => ghiChu; set => ghiChu = value; }
        public string Email { get => email; set => email = value; }
    }
}
