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
    public class BUS_BillInfo
    {
        DAL_BillInfo dalBillInfo = new DAL_BillInfo();

        public DataTable ListBillInfo()
        {
            return dalBillInfo.ListBillInfo();
        }

        public bool InsertBillInfo(DTO_BillInfo billInfo)
        {
            return dalBillInfo.InsertBillInfo(billInfo);
        }

        public double GetTotalPrice()
        {
            return dalBillInfo.GetTotalPrice();
        }
    }
}
