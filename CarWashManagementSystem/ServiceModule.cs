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
    public partial class ServiceModule : Form
    {
        SqlCommand cm = new SqlCommand();
        dbConnect dbcon = new dbConnect();
        string title = "Car Wash Management System";
        Service service;
        public ServiceModule(Service ser)
        {
            InitializeComponent();
            service = ser;
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            // only allow digit number
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            // only allow one decimal 
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtName.Text == "" || txtPrice.Text=="")
                {
                    MessageBox.Show("Required data field!", "Warning");
                    return; // return to the data field and form
                }
                if (MessageBox.Show("Are you sure you want to register this service?", "Service Registration", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cm = new SqlCommand("INSERT INTO tbService(name,price)VALUES(@name,@price)", dbcon.connect());
                    cm.Parameters.AddWithValue("@name", txtName.Text);
                    cm.Parameters.AddWithValue("@price", txtPrice.Text);

                    dbcon.open();// to open connection
                    cm.ExecuteNonQuery();
                    dbcon.close();// to close connection
                    MessageBox.Show("Service has been successfully registered!", title);
                    Clear();//to clear data field, after data inserted into the database
                    service.loadService();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, title);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtName.Text == "" || txtPrice.Text == "")
                {
                    MessageBox.Show("Required data field!", "Warning");
                    return; // return to the data field and form
                }
                if (MessageBox.Show("Are you sure you want to edit this service?", "Service Editing", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cm = new SqlCommand("UPDATE tbService SET name=@name, price=@price WHERE id=@id", dbcon.connect());
                    cm.Parameters.AddWithValue("@id", lblSid.Text);
                    cm.Parameters.AddWithValue("@name", txtName.Text);
                    cm.Parameters.AddWithValue("@price", txtPrice.Text);

                    dbcon.open();// to open connection
                    cm.ExecuteNonQuery();
                    dbcon.close();// to close connection
                    MessageBox.Show("Service has been successfully edited!", title);
                    this.Dispose();                    
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
        }

        #region method
        public void Clear()
        {
            txtName.Clear();
            txtPrice.Clear();

            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
                
        }
        #endregion method
    }
}
