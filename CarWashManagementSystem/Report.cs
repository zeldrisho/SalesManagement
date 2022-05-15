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
    public partial class Report : Form
    {
        SqlCommand cm = new SqlCommand();
        dbConnect dbcon = new dbConnect();
        SqlDataReader dr;
        string title = "Car Wash Management System";
        public Report()
        {
            InitializeComponent();
            loadTopSelling();
            loadRevenus();
            loadCostofGood();
            loadGrossProfit();
        }

        #region TopSelling
        
        private void dtFromTopSelling_ValueChanged(object sender, EventArgs e)
        {
            loadTopSelling();
        }

        private void dtToTopSelling_ValueChanged(object sender, EventArgs e)
        {
            loadTopSelling();
        }

        // to load top selling 
        public void loadTopSelling()
        {
            try
            {
                int i = 0;
                dgvTopSelling.Rows.Clear();
                cm = new SqlCommand("SELECT TOP 10 se.name,count(ca.sid) AS qty, ISNULL(SUM(ca.price),0) AS total FROM tbCash AS ca JOIN tbService AS se ON ca.sid=se.id WHERE ca.date BETWEEN '"+dtFromTopSelling.Value.ToString()+ "' AND '" + dtToTopSelling.Value.ToString() + "' AND status LIKE 'Sold' " +
                    "GROUP BY se.name ORDER BY qty DESC",dbcon.connect());
                dbcon.open();
                dr = cm.ExecuteReader();
                while(dr.Read())
                {
                    i++;
                    dgvTopSelling.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString());
                }
                dr.Close();
                dbcon.close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, title);
            }
        }
        #endregion TopSelling

        #region Revenus
      
        private void dtFromRevenud_ValueChanged(object sender, EventArgs e)
        {
            loadRevenus();
        }

        private void dtToRevenus_ValueChanged(object sender, EventArgs e)
        {
            loadRevenus();
        }

        public void loadRevenus()
        {
            // select query revenus data from the database
            try
            {
                int i = 0;
                dgvRevenus.Rows.Clear();
                double total = 0;
                cm = new SqlCommand("SELECT date,ISNULL(sum(price),0) AS total FROM tbCash WHERE date BETWEEN '" + dtFromRevenud.Value.ToString() + "' " +
                    "AND '" + dtToRevenus.Value.ToString() + "' AND status LIKE 'Sold' GROUP BY date", dbcon.connect());
                dbcon.open();
                dr = cm.ExecuteReader();
                while(dr.Read())
                {
                    i++;
                    dgvRevenus.Rows.Add(i,DateTime.Parse(dr[0].ToString()).ToShortDateString(), dr[1].ToString());
                    total += double.Parse(dr[1].ToString());
                }
                lblRevenus.Text = total.ToString("#,##0.00");
                dr.Close();
                dbcon.close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, title);
            }
        }
        #endregion Revenus

        #region CostofGood

      
        private void dtFromCoG_ValueChanged(object sender, EventArgs e)
        {
            loadCostofGood();
        }

        private void dtToCoG_ValueChanged(object sender, EventArgs e)
        {
            loadCostofGood();
        }

        public void loadCostofGood()
        {
            try
            {
                int i = 0; // to show number for cost of good sole
                dgvCostofGood.Rows.Clear();
                double total = 0;
                cm = new SqlCommand("SELECT costname,cost,date FROM tbCostofGood WHERE date BETWEEN '" + dtFromCoG.Value.ToString() + "' AND '" + dtToCoG.Value.ToString() + "'", dbcon.connect());
                dbcon.open();
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    i++;
                    // to add data to the datagridview from the database
                    dgvCostofGood.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), DateTime.Parse(dr[2].ToString()).ToShortDateString());
                    total += double.Parse(dr[1].ToString());
                }
                lblCoG.Text = total.ToString("#,##0.00");
                dr.Close();
                dbcon.close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, title);
            }
        }
        #endregion CostofGood

        #region GrossProfit
      
        private void dtFromGP_ValueChanged(object sender, EventArgs e)
        {
            loadGrossProfit();
        }

        private void dtToGP_ValueChanged(object sender, EventArgs e)
        {
            loadGrossProfit();
        }
        public void loadGrossProfit()
        {
            txtRevenus.Text = extractData("SELECT ISNULL(SUM(price),0) AS total FROM tbCash WHERE date BETWEEN '" + dtFromGP.Value.ToString() + "' AND '" + dtToGP.Value.ToString() + "'").ToString("#,##0.00");
            txtCoG.Text = extractData("SELECT ISNULL(SUM(cost),0) AS Cost FROM tbCostofGood WHERE date BETWEEN '" + dtFromGP.Value.ToString() + "' AND '" + dtToGP.Value.ToString() + "'").ToString("#,##0.00");
            txtGrossProfit.Text = (double.Parse(txtRevenus.Text) - double.Parse(txtCoG.Text)).ToString("#,##0.00");
            if (double.Parse(txtGrossProfit.Text) < 0)
                txtGrossProfit.ForeColor = Color.Red;
            else
                txtGrossProfit.ForeColor = Color.Green;
        }

        // now to create a function to exract data from database
        public double extractData(string sql)
        {
            dbcon.open();
            cm = new SqlCommand(sql, dbcon.connect());
            double data = double.Parse(cm.ExecuteScalar().ToString());
            dbcon.close();
            return data;
        }
        #endregion GrossProfit
    }
}
