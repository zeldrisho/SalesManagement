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
    public partial class EmployerModule : Form
    {
        SqlCommand cm = new SqlCommand();
        dbConnect dbcon = new dbConnect();
        string title = "Car Wash Management System";
        bool check = false;
        Employer employer;
        public EmployerModule(Employer emp)
        {
            InitializeComponent();
            employer = emp;
            cbRole.SelectedIndex = 3;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        //to insert employer data in the database
        private void btnSave_Click(object sender, EventArgs e)
        {//type try and then double press Tab key
            try
            {
                checkField();
                if(check)
                {
                    if (MessageBox.Show("Are you sure you want to register this employer?", "Employer Registration", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        cm = new SqlCommand("INSERT INTO tbEmployer(name,phone,address,dob,gender,role,salary,password)VALUES(@name,@phone,@address,@dob,@gender,@role,@salary,@password)",dbcon.connect());
                        cm.Parameters.AddWithValue("@name",txtName.Text);
                        cm.Parameters.AddWithValue("@phone", txtPhone.Text);
                        cm.Parameters.AddWithValue("@address", txtAddress.Text);
                        cm.Parameters.AddWithValue("@dob", dtDob.Value);
                        cm.Parameters.AddWithValue("@gender", rdMale.Checked ? "Male" : "Female");//like if condition
                        cm.Parameters.AddWithValue("@role", cbRole.Text);
                        cm.Parameters.AddWithValue("@salary", txtSalary.Text);
                        cm.Parameters.AddWithValue("@password", txtPassword.Text);

                        dbcon.open();// to open connection
                        cm.ExecuteNonQuery();
                        dbcon.close();// to close connection
                        MessageBox.Show("Employer has been successfully registered!",title);
                        check = false;
                        Clear();//to clear data field, after data inserted into the database                        
                        employer.loadEmployer(); // refresh the employer list after insert data in the table
                    }
                }
 
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message,title);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                checkField();
                if (check)
                {
                    if (MessageBox.Show("Are you sure you want to edit this record?", "Employer Editing", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        cm = new SqlCommand("UPDATE tbEmployer SET name=@name, phone=@phone, address=@address, dob=@dob, gender=@gender, role=@role, salary=@salary, password=@password WHERE id=@id", dbcon.connect());
                        cm.Parameters.AddWithValue("@id", lblEid.Text);
                        cm.Parameters.AddWithValue("@name", txtName.Text);
                        cm.Parameters.AddWithValue("@phone", txtPhone.Text);
                        cm.Parameters.AddWithValue("@address", txtAddress.Text);
                        cm.Parameters.AddWithValue("@dob", dtDob.Value);
                        cm.Parameters.AddWithValue("@gender", rdMale.Checked ? "Male" : "Female");//like if condition
                        cm.Parameters.AddWithValue("@role", cbRole.Text);
                        cm.Parameters.AddWithValue("@salary", txtSalary.Text);
                        cm.Parameters.AddWithValue("@password", txtPassword.Text);

                        dbcon.open();// to open connection
                        cm.ExecuteNonQuery();
                        dbcon.close();// to close connection
                        MessageBox.Show("Employer has been successfully registered!", title);
                        Clear();//to clear data field, after data inserted into the database
                        this.Dispose();
                        employer.loadEmployer();
                    }
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, title);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
            btnUpdate.Enabled = false;
            btnSave.Enabled = true;
        }

        private void txtSalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            // only allow digit number
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar !='.'))
            {
                e.Handled = true;
            }
            // only allow one decimal 
            if((e.KeyChar=='.') && ((sender as TextBox).Text.IndexOf('.')>-1))
            {
                e.Handled = true;
            }
        }

        private void cbRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbRole.Text=="Supervisor" || cbRole.Text=="Worker")
            {
                this.Height = 453 - 26;
                txtPassword.Clear();
                lblPass.Visible = false;// to hide password label and textbox
                txtPassword.Visible = false;
            }
            else
            {
                lblPass.Visible = true;
                txtPassword.Visible = true;
                this.Height = 453;
            }
        }
        // to create a function for clear all field
        #region method
        public void Clear()
        {
            txtAddress.Clear();
            txtName.Clear();
            txtPassword.Clear();
            txtPhone.Clear();
            txtSalary.Clear();

            dtDob.Value = DateTime.Now;
            cbRole.SelectedIndex = 3;//default is worker
        }

        //to check data field and date of birth
        public void checkField()
        {
            if(txtAddress.Text==""||txtName.Text==""||txtPhone.Text==""||txtSalary.Text=="")
            {
                MessageBox.Show("Required data Field!", "Warning");
                return; // return to the data field and form
            }

            if(checkAge(dtDob.Value)<18)
            {
                MessageBox.Show("Employer is under 18!", "Warning");
                return;
            }
            check = true;
        }

        // to check the age and calculate for under 18
        private static int checkAge(DateTime dateofBirth)
        {
            int age = DateTime.Now.Year - dateofBirth.Year;
            if (DateTime.Now.DayOfYear < dateofBirth.DayOfYear)
                age = age - 1;
            return age;
        }

        #endregion method

       
    }
}
