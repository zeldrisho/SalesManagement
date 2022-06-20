using System;
using System.Windows.Forms;
using System.Data;
using System.IO;
using Microsoft.Reporting.WinForms;
using BUS_QLBanHang;

namespace GUI_QLBanHang
{
    public partial class frmProductReport : Form
    {
        BUS_Hang busProduct = new BUS_Hang();

        public frmProductReport()
        {
            InitializeComponent();
        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            rptProductViewer.LocalReport.ReportEmbeddedResource = "GUI_QLBanHang.rptProduct.rdlc";
            ReportDataSource reportDataSource = new ReportDataSource();
            reportDataSource.Name = "Product";
            reportDataSource.Value = busProduct.DanhSachHang();
            rptProductViewer.LocalReport.DataSources.Add(reportDataSource);
            this.rptProductViewer.RefreshReport();
        }
    }
}
