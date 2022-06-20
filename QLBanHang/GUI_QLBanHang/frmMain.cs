using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using BUS_QLBanHang;

namespace GUI_QLBanHang
{
    public partial class frmMain : Form
    {
        BUS_NhanVien busNV = new BUS_NhanVien();
        public string email;

        public frmMain()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            menuHuongDan.Cursor = Cursors.Hand;
            menuTaiKhoan.Cursor = Cursors.Hand;
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            panelControl.Controls.Clear();
            QL_NhanVien fnhanvien = new QL_NhanVien();
            fnhanvien.Dock = DockStyle.Fill;
            panelControl.Controls.Add(fnhanvien);
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            panelControl.Controls.Clear();
            QL_KhachHang fkhachhang = new QL_KhachHang(email);
            fkhachhang.Dock = DockStyle.Fill;
            panelControl.Controls.Add(fkhachhang);
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            panelControl.Controls.Clear();
            QL_Hang fhang = new QL_Hang(email);
            fhang.Dock = DockStyle.Fill;
            panelControl.Controls.Add(fhang);
        }

        private void btnGuild_Click(object sender, EventArgs e)
        {
            menuHuongDan.Show(pnMenu, new Point(206,456));
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            menuTaiKhoan.Show(pnMenu, new Point(206, 405));
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (btnLogin.Text == "Đăng nhập")
            {
                using (frmLogin flogin = new frmLogin())
                {
                    flogin.ShowDialog();
                    if (flogin.getSuccess)
                    {
                        email = flogin.getEmail;
                        resetValue();
                        btnLogin.Text = "Đăng xuất";
                        btnLogin.CustomImages.Image = Properties.Resources.logout;
                        BUS_NhanVien busNV = new BUS_NhanVien();
                        if (busNV.LayVaiTro(email))
                        {
                            btnEmployee_Click(sender, e);
                        }
                        else
                        {
                            btnProduct_Click(sender, e);
                        }
                    }
                }
            }
            else
            {
                panelControl.Controls.Clear();
                resetValue(false);
                lblEmail.Text = "Đăng nhập để sử dụng";
                btnLogin.Text = "Đăng nhập";
                btnLogin.CustomImages.Image = Properties.Resources.login_64px;
            }
        }

        private void resetValue(bool isVisible = true)
        {
            lblEmail.Text = "Chào nhân viên \n" + email;
            btnEmployee.Visible = isVisible;
            btnCustomer.Visible = isVisible;
            btnProduct.Visible = isVisible;
            btnStatistic.Visible = isVisible;
            btnAccount.Visible = isVisible;
            // Kiểm tra vai tro: true = admin, false = nhân viên
            if (!busNV.LayVaiTro(email))
            {
                btnEmployee.Visible = false;
                btnStatistic.Visible = false;
            }
        }

        private void itemDoiMatKhau_Click(object sender, EventArgs e)
        {
            using (frmChangePassword fquenmk = new frmChangePassword(email))
            {
                fquenmk.ShowDialog();
                if (fquenmk.getSuccess)
                {
                    resetValue(isVisible:false);
                    btnLogin.Text = "Đăng nhập";
                    Properties.Settings.Default.Password = "";
                    Properties.Settings.Default.Save();
                    btnLogin.PerformClick();
                }
            }

        }

        private void btnStatistic_Click(object sender, EventArgs e)
        {
            panelControl.Controls.Clear();
            QL_ThongKe thongke = new QL_ThongKe();
            thongke.Dock = DockStyle.Fill;
            panelControl.Controls.Add(thongke);
        }

        private void itemThongTinNV_Click(object sender, EventArgs e)
        {
            frmThongTinNV frmThongTin = new frmThongTinNV(email);
            frmThongTin.ShowDialog();
        }

        private void itemHuongDan_Click(object sender, EventArgs e)
        {
            Process.Start("Huongdan.txt");
        }

        private void itemGioiThieu_Click(object sender, EventArgs e)
        {
            Process.Start("Gioithieu.txt");
        }
    }
}
