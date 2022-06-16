using System;
using System.Data;
using System.Windows.Forms;
using BUS_QLBanHang;
namespace GUI_QLBanHang
{
    public partial class frmThongTinNV : Form
    {
        public frmThongTinNV(string email)
        {
            InitializeComponent();
            lblEmail.Text =  email;
        }

        BUS_NhanVien nhanVien = new BUS_NhanVien();

        private void frmThongTinNV_Load(object sender, EventArgs e)
        {
            DataTable table = nhanVien.thongTinNV(lblEmail.Text);

            int vaiTro;
            int tinhTrang;
            lblmaNV.Text = table.Rows[0][1].ToString();
            lblTenNV.Text = table.Rows[0][3].ToString();
            lblDiaChi.Text = table.Rows[0][4].ToString();
            vaiTro = int.Parse(table.Rows[0][5].ToString());
            tinhTrang = int.Parse(table.Rows[0][6].ToString());
            lblEmail.Text = "HỒ SƠ NHÂN VIÊN CỦA \n" + lblEmail.Text;
            lblVaiTro.Text = (vaiTro == 1) ? "Quản trị" : "Nhân viên";
            lblTinhTrang.Text = (tinhTrang == 1) ? "Đang hoạt động" : "Dừng hoạt động";

        }
    }
}
