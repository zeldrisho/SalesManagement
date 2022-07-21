using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_BillInfo
    {
        private int billId;
        private int productId;
        private int quantity;
        private float unitPrice;
        private float totalPrice;

        public DTO_BillInfo()
        {
        }

        public DTO_BillInfo(int billId, int productId, int quantity, float unitPrice, float totalPrice)
        {
            this.BillId = billId;
            this.ProductId = productId;
            this.Quantity = quantity;
            this.UnitPrice = unitPrice;
            this.TotalPrice = totalPrice;
        }

        public int BillId { get => billId; set => billId = value; }
        public int ProductId { get => productId; set => productId = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public float UnitPrice { get => unitPrice; set => unitPrice = value; }
        public float TotalPrice { get => totalPrice; set => totalPrice = value; }
    }
}
