using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;

namespace GUI
{
    public partial class frmLogin : Form
    {
        BUS_Employee busEmployee = new BUS_Employee();

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text != "" && txtPassword.Text != "")
            {
                if (busEmployee.Login(txtEmail.Text, txtPassword.Text))
                {
                    Properties.Settings.Default.isSave = tglRememberMe.Checked;
                    if (tglRememberMe.Checked)
                    {
                        Properties.Settings.Default.email = txtEmail.Text;
                        Properties.Settings.Default.password = txtPassword.Text;
                    }
                    Properties.Settings.Default.Save();
                    frmMain fMain = new frmMain(txtEmail.Text);
                    this.Hide();
                    fMain.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Sai email hoặc mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtEmail.Text = "";
                    txtPassword.Text = "";
                    txtEmail.Focus();
                }
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.isSave)
            {
                txtEmail.Text = Properties.Settings.Default.email;
                txtPassword.Text = Properties.Settings.Default.password;
                tglRememberMe.Checked = true;
            }
        }

        private void lblForgotPassword_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text != "")
            {
                busEmployee = new BUS_Employee();
                if (busEmployee.IsExistEmail(txtEmail.Text))
                {
                    string password = busEmployee.GetRandomPassword();
                    if (busEmployee.UpdatePassword(txtEmail.Text, password))
                    {
                        SendMail loader = new SendMail(txtEmail.Text, password, true);
                        loader.ShowDialog();
                        MessageBox.Show(loader.Result, "Thông báo");
                    }
                    else
                        MessageBox.Show("Không thực hiện được", "Thông báo");
                }
            }
        }
    }
}
