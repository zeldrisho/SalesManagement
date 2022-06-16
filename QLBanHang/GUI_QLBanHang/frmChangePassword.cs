using System;
using System.Windows.Forms;
using BUS_QLBanHang;
namespace GUI_QLBanHang
{
    public partial class frmChangePassword : Form
    {
        public frmChangePassword(string email)
        {
            InitializeComponent();
            txtEmail.Text = email;
        }

        private bool isSuccess = false;

        public bool getSuccess
        {
            get { return isSuccess; }
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            if (txtOldPassword.Text != "")
            {
                if (txtNewPassword.Text == txtNewPassword2.Text)
                {
                    BUS_NhanVien nv = new BUS_NhanVien();
                    if (nv.QuenMatKhau(txtEmail.Text, txtOldPassword.Text, txtNewPassword.Text))
                    {
                        MessageBox.Show("Đổi mật khẩu thành công! Vui lòng đăng nhập lại", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        isSuccess = true;
                        Close();
                    }
                    else MessageBox.Show("Mật khẩu cũ không đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else MessageBox.Show("Mật khẩu mới không trùng nhau!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else MessageBox.Show("Vui lòng nhập mật khẩu cũ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
