using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarWashManagementSystem
{
    public partial class MainForm : Form
    {
        SqlCommand cm = new SqlCommand();
        dbConnect dbcon = new dbConnect();
        SqlDataReader dr;

        public MainForm()
        {
            InitializeComponent();
            loadCompany();
            loadGrossProfit();
            openChildForm(new Dashboard());
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            panelSlide.Height = btnDashboard.Height;
            panelSlide.Top = btnDashboard.Top;
            openChildForm(new Dashboard());
        }

        private void btnEmployer_Click(object sender, EventArgs e)
        {
            panelSlide.Height = btnEmployer.Height;
            panelSlide.Top = btnEmployer.Top;
            openChildForm(new Employer());
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            panelSlide.Height = btnCustomer.Height;
            panelSlide.Top = btnCustomer.Top;
            openChildForm(new Customer());
        }

        private void btnService_Click(object sender, EventArgs e)
        {
            panelSlide.Height = btnService.Height;
            panelSlide.Top = btnService.Top;
            openChildForm(new Service());
        }

        private void btncash_Click(object sender, EventArgs e)
        {
            panelSlide.Height = btncash.Height;
            panelSlide.Top = btncash.Top;
            openChildForm(new Cash(this));
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            panelSlide.Height = btnReport.Height;
            panelSlide.Top = btnReport.Top;
            openChildForm(new Report());
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            panelSlide.Height = btnSetting.Height;
            panelSlide.Top = btnSetting.Top;
            openChildForm(new Setting());
      
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            panelSlide.Height = btnLogout.Height;
            panelSlide.Top = btnLogout.Top;
            if (MessageBox.Show("Logout Application?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                Login login = new Login();
                login.ShowDialog();
            }
        }

        #region method
        // create a function any form to the panelChild on the mainform

        private Form activeForm = null;
        public void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChild.Controls.Add(childForm);
            panelChild.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        // to extract data for dashboard
        // to show only seven day
        public void loadGrossProfit()
        {
            Report module = new Report();
            lblRevenus.Text = module.extractData("SELECT ISNULL(SUM(price),0) AS total FROM tbCash WHERE date >'" + DateTime.Now.AddDays(-7) + "' AND status LIKE 'Sold' ").ToString("#,##0.00");
            lblCostofGood.Text = module.extractData("SELECT ISNULL(SUM(cost),0) AS Cost FROM tbCostofGood WHERE date > '" + DateTime.Now.AddDays(-7) + "'").ToString("#,##0.00");
            lblGrossProfit.Text = (double.Parse(lblRevenus.Text) - double.Parse(lblCostofGood.Text)).ToString("#,##0.00");

            double revlast7 = module.extractData("SELECT ISNULL(SUM(price),0) AS total FROM tbCash WHERE date BETWEEN '" + DateTime.Now.AddDays(-14) + "' AND '" + DateTime.Now.AddDays(-7) + "' AND status LIKE 'Sold' ");
            double coglast7 = module.extractData("SELECT ISNULL(SUM(cost),0) AS Cost FROM tbCostofGood WHERE date BETWEEN  '" + DateTime.Now.AddDays(-14) + "' AND '" + DateTime.Now.AddDays(-7) + "'");
            double gplast7 = revlast7 - coglast7;


            if (revlast7 > double.Parse(lblRevenus.Text))
                picRevenus.Image = Properties.Resources.down_25px;
            else
                picRevenus.Image = Properties.Resources.up_25px;

            if (gplast7 > double.Parse(lblGrossProfit.Text))
            {
                picGrossProfit.Image = Properties.Resources.down_25px;
                lblGrossProfit.ForeColor = Color.Red;
            }
            else
            {
                picGrossProfit.Image = Properties.Resources.up_25px;
                lblGrossProfit.ForeColor = Color.Green;
            }
        }
        #endregion method

        public void loadCompany()
        {
            cm = new SqlCommand("SELECT * FROM tbCompany", dbcon.connect());
            dbcon.open();
            dr = cm.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                lblCompany.Text = dr["name"].ToString();
            }
            dr.Close();
            dbcon.close();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.ExitThread();
        }
    }
}
