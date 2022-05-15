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
using Microsoft.Reporting.WinForms;

namespace CarWashManagementSystem
{
    public partial class receipt : Form
    {
        SqlCommand cm = new SqlCommand();
        dbConnect dbcon = new dbConnect();
        SqlDataReader dr;
        string title = "Car Wash Management System";
        string company, address;
        Cash cash;
        public receipt(Cash cashform)
        {
            InitializeComponent();
            cash = cashform;
            loadCompany();
        }

        private void receipt_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
        }
        // load conpany and address
        public void loadCompany()
        {
            cm = new SqlCommand("SELECT * FROM tbCompany", dbcon.connect());
            dbcon.open();
            dr = cm.ExecuteReader();
            dr.Read();
            if(dr.HasRows)
            {
                company = dr["name"].ToString();
                address = dr["address"].ToString();
            }
            dr.Close();
            dbcon.close();
        }
        //with two argurement 
        public void loadReceipt(string pcash,string pchange)
        {
            ReportDataSource rptDataSource;
            try
            {
                this.reportViewer1.LocalReport.ReportPath = Application.StartupPath + @"\Reports\rptReceipt.rdlc";
                this.reportViewer1.LocalReport.DataSources.Clear();

                DataSet1 ds = new DataSet1();
                SqlDataAdapter da = new SqlDataAdapter();
                //service name and price form tbservice and tbcash 
                dbcon.open();
                da.SelectCommand = new SqlCommand("SELECT s.name, c.price FROM tbCash AS c INNER JOIN tbService AS s ON c.sid=s.id WHERE c.transno LIKE '"+ cash.lblTransno.Text+"'",dbcon.connect());
                da.Fill(ds.Tables["dtReceipt"]);
                dbcon.close();

                ReportParameter pCompany = new ReportParameter("pCompany",company);
                ReportParameter pAddress = new ReportParameter("pAddress",address);
                ReportParameter pChange = new ReportParameter("pChange",pchange);
                ReportParameter pCash = new ReportParameter("pCash",pcash);
                ReportParameter pTotal = new ReportParameter("pTotal",cash.lblTotal.Text);
                ReportParameter pTransaction = new ReportParameter("pTransaction",cash.lblTransno.Text);
                ReportParameter pCarno = new ReportParameter("pCarno",cash.carno);
                ReportParameter pCarModel = new ReportParameter("pCarModel",cash.carmodel);


                // now add to the local reportViewer
                reportViewer1.LocalReport.SetParameters(pCompany);
                reportViewer1.LocalReport.SetParameters(pAddress);
                reportViewer1.LocalReport.SetParameters(pChange);
                reportViewer1.LocalReport.SetParameters(pCash);
                reportViewer1.LocalReport.SetParameters(pTotal);
                reportViewer1.LocalReport.SetParameters(pTransaction);
                reportViewer1.LocalReport.SetParameters(pCarno);
                reportViewer1.LocalReport.SetParameters(pCarModel);

                rptDataSource = new ReportDataSource("DataSet1", ds.Tables["dtReceipt"]);
                reportViewer1.LocalReport.DataSources.Add(rptDataSource);
                reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
                reportViewer1.ZoomMode = ZoomMode.FullPage;
                reportViewer1.ZoomPercent = 30;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, title);
            }
        }
    }
}
