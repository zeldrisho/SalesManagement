using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUS
{
    public class BUS_Bill
    {
        DAL_Bill dalBill = new DAL_Bill();

        public DataTable ListOfBills()
        {
            return dalBill.ListOfBills();
        }

        public bool InsertBill(DTO_Bill bill)
        {
            return dalBill.InsertBill(bill);
        }

        public DataTable SearchCustomerInBill(string name)
        {
            return dalBill.SearchCustomerInBill(name);
        }

        public double GetRevenueInMay()
        {
            return dalBill.GetRevenueInMay();
        }

        public double GetRevenueInJune()
        {
            return dalBill.GetRevenueInJune();
        }

        public double GetRevenueInJuly()
        {
            return dalBill.GetRevenueInJuly();
        }
    }
}
