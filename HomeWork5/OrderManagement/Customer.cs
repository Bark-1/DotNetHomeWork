using System;
using System.Collections.Generic;
using System.Text;

namespace OrderManagement
{
    class Customer
    {
        public string CustomerName { get; set; }
        public string PhoneNumber { get; set; }

        public Customer(string customerName, string phoneNumber)
        {
            CustomerName = customerName;
            PhoneNumber = phoneNumber;
        }

        public override string ToString()
        {
            return $"CustomerName:{CustomerName}  PhoneNumber:{PhoneNumber}";
        }
    }
}
