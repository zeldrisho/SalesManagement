using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Bill
    {
        private int id;
        private int employeeId;
        private int customerId;
        private DateTime dateOfPayment;

        public DTO_Bill()
        {
        }

        public DTO_Bill(int id, int employeeId, int customerId, DateTime dateOfPayment)
        {
            this.Id = id;
            this.EmployeeId = employeeId;
            this.CustomerId = customerId;
            this.DateOfPayment = dateOfPayment;
        }

        public int Id { get => id; set => id = value; }
        public int EmployeeId { get => employeeId; set => employeeId = value; }
        public int CustomerId { get => customerId; set => customerId = value; }
        public DateTime DateOfPayment { get => dateOfPayment; set => dateOfPayment = value; }
    }
}
