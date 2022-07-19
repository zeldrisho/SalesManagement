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
    public class BUS_Product
    {
        DAL_Product dalProduct = new DAL_Product();

        public DataTable ListOfProducts()
        {
            return dalProduct.ListOfProducts();
        }

        public bool InsertProduct(DTO_Product product)
        {
            return dalProduct.InsertProduct(product);
        }

        public bool UpdateProduct(DTO_Product product)
        {
            return dalProduct.UpdateProduct(product);
        }

        public bool DeleteProduct(int id)
        {
            return dalProduct.DeleteProduct(id);
        }

        public DataTable SearchProduct(string name)
        {
            return dalProduct.SearchProduct(name);
        }
    }
}
