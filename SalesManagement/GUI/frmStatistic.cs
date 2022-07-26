using Guna.Charts.WinForms;
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
    public partial class frmStatistic : Form
    {
        BUS_Bill busBill = new BUS_Bill();

        public frmStatistic()
        {
            InitializeComponent();
        }

        private void chtImportProduct_Load(object sender, EventArgs e)
        {
            Doughnut(chtImportProduct);
        }

        public void Doughnut(GunaChart chart)
        {
            string[] months = { "Tháng 5", "Tháng 6", "Tháng 7" };

            //Chart configuration
            chart.Title.Text = "Doanh thu theo tháng";
            chart.Legend.Position = LegendPosition.Right;
            chart.XAxes.Display = false;
            chart.YAxes.Display = false;



            //Create a new dataset 
            var dataset = new GunaDoughnutDataset();

            dataset.DataPoints.Add(months[0], busBill.GetRevenueInMay());
            dataset.DataPoints.Add(months[1], busBill.GetRevenueInJune());
            dataset.DataPoints.Add(months[2], busBill.GetRevenueInJuly());

            //Add a new dataset to a chart.Datasets
            chart.Datasets.Add(dataset);

            //An update was made to re-render the chart
            chart.Update();
        }
    }
}
