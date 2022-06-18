using System;
using System.Windows.Forms;
using BUS_QLBanHang;
namespace GUI_QLBanHang
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        
        private bool isSuccess = false;

        public bool getSuccess { get => isSuccess; }
        public string getEmail { get => txtEmail.Text; }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text != "" && txtPassword.Text != "")
            {
                BUS_NhanVien nv = new BUS_NhanVien();
                if (nv.DangNhap(txtEmail.Text , txtPassword.Text))
                {
                    isSuccess = true;
                    Properties.Settings.Default.isSave = chkRememberMe.Checked;
                    if (chkRememberMe.Checked)
                    {
                        Properties.Settings.Default.Email = txtEmail.Text;
                        Properties.Settings.Default.Password = txtPassword.Text;
                    }
                    Properties.Settings.Default.Save();
                    Close();
                }
                else
                {
                    MessageBox.Show("Sai email hoặc mật khẩu!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    isSuccess = false;
                    txtEmail.Text = "";
                    txtPassword.Text = "";
                    txtEmail.Focus();
                }
            }
        }
    
        private void lblForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (txtEmail.Text != "")
            {
                BUS_NhanVien busNV = new BUS_NhanVien();
                if (busNV.checkEmail(txtEmail.Text))
                {
                    string password = busNV.getPassword();

                    if (busNV.updateMatKhau(txtEmail.Text, password))
                    {
                        SendMail load = new SendMail(txtEmail.Text, password, true);
                        load.ShowDialog();
                        MessageBox.Show(load.getResult, "Thông báo");
                    }
                   else
                        MessageBox.Show("Không thực hiện được", "Thông báo");
                }
            }
        }
        
        private void QL_Login_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.isSave)
            {
                txtEmail.Text = Properties.Settings.Default.Email;
                txtPassword.Text = Properties.Settings.Default.Password;
                chkRememberMe.Checked = true;
                btnLogin.Focus();
            }
        }
    }
}
