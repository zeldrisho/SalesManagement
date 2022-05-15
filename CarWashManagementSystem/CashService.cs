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
    public partial class CashService : Form
    {
        SqlCommand cm = new SqlCommand();
        dbConnect dbcon = new dbConnect();
        SqlDataReader dr;
        string title = "Car Wash Management System";
        Cash cash;
        public CashService(Cash cashForm)
        {
            InitializeComponent();
            cash = cashForm;
            loadService();
        }

        private void textSearch_TextChanged(object sender, EventArgs e)
        {
            loadService();
        }



        private void btnSubmit_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow dr in dgvService.Rows)
            {
                bool chkbox = Convert.ToBoolean(dr.Cells["Select"].Value);
                if(chkbox)
                {
                    try
                    {
                        cm = new SqlCommand("IF NOT EXISTS (SELECT * FROM tbCash WHERE sid=@sid AND transno=@transno) INSERT INTO tbCash(transno,cid,sid,vid,price,date) VALUES(@transno,@cid,@sid,@vid,@price,@date)", dbcon.connect());
                        cm.Parameters.AddWithValue("@transno", cash.lblTransno.Text);
                        cm.Parameters.AddWithValue("@cid", cash.customerId);
                        cm.Parameters.AddWithValue("@sid", dr.Cells[1].Value.ToString());
                        cm.Parameters.AddWithValue("@vid", cash.vehicleTypeId);
                        cm.Parameters.AddWithValue("@price", dr.Cells[3].Value.ToString());
                        cm.Parameters.AddWithValue("@date", DateTime.Now);

                        dbcon.open();
                        cm.ExecuteNonQuery();
                        dbcon.close();

                        cash.btnCash.Enabled = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, title);
                    }
                }
            }
            this.Dispose();
            cash.panelCash.Height = 1;
            cash.loadCash();
        }

        #region method
        public void loadService()
        {
            try
            {
                int i = 0; // to show number for service list
                dgvService.Rows.Clear();
                cm = new SqlCommand("SELECT * FROM tbService WHERE name LIKE '%" + txtSearch.Text + "%'", dbcon.connect());
                dbcon.open();
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    i++;
                    // to add data to the datagridview from the database
                    dgvService.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString());
                }
                dbcon.close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, title);
            }
        }
        #endregion method
    }
}
