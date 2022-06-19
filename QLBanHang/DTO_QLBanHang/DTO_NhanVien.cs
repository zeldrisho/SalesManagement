namespace DTO_QLBanHang
{
   public class DTO_NhanVien
   {
        private string emailNV;
        private string tenNhanVien;
        private string diaChi;
        private int vaiTro; // true = 1, false = 0
        private int tinhTrang;
        private string matKhau;

        public string TenNhanVien { get => tenNhanVien; set => tenNhanVien = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public int VaiTro { get => vaiTro; set => vaiTro = value; }
        public string EmailNV { get => emailNV; set => emailNV = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }
        public int TinhTrang { get => tinhTrang; set => tinhTrang = value; }

        public DTO_NhanVien() { }

        public DTO_NhanVien(string emailNV, string tenNhanVien, string diaChi, int vaiTro, int tinhTrang, string matKhau)
        {
            this.emailNV = emailNV;
            this.tenNhanVien = tenNhanVien;
            this.diaChi = diaChi;
            this.vaiTro = vaiTro;
            this.tinhTrang = tinhTrang;
            this.matKhau = matKhau;
        }

        public DTO_NhanVien(string emailNV, string tenNhanVien, string diaChi, int vaiTro, int tinhTrang)
        {
            this.emailNV = emailNV;
            this.tenNhanVien = tenNhanVien;
            this.diaChi = diaChi;
            this.vaiTro = vaiTro;
            this.tinhTrang = tinhTrang;
        }
    }
}
