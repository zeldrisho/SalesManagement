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
using BUS;

namespace GUI
{
    public partial class frmBill : Form
    {
        BUS_Customer busCustomer = new BUS_Customer();

        public frmBill()
        {
            InitializeComponent();
            LoadData();
        }

        public void LoadData()
        {
            string[] listCustomerName = busCustomer.ListCustomerName();
            foreach (string name in listCustomerName)
            {
                cboCustomer.Items.Add(name);
            }
        }
    }
}
