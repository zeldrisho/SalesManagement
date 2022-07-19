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
    public class BUS_Customer
    {
        DAL_Customer dalCustomer = new DAL_Customer();

        public DataTable ListOfCustomers()
        {
            return dalCustomer.ListOfCustomers();
        }

        public bool InsertKhachHang(DTO_Customer customer)
        {
            return dalCustomer.InsertCustomer(customer);
        }

        public bool DeleteKhachHang(int id)
        {
            return dalCustomer.DeleteCustomer(id);
        }

        public bool UpdateCustomer(DTO_Customer customer)
        {
            return dalCustomer.UpdateCustomer(customer);
        }

        public DataTable SearchCustomer(string name)
        {
            return dalCustomer.SearchCustomer(name);
        }
    }
}
