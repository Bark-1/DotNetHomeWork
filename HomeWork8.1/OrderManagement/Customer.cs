using System;
using System.Collections.Generic;
using System.Text;

namespace OrderManagement
{
    [Serializable]
    public class Customer
    {
        public string CustomerName { get; set; }
        public string PhoneNumber { get; set; }

        public Customer(string customerName, string phoneNumber)
        {
            CustomerName = customerName;
            PhoneNumber = phoneNumber;
        }
        public Customer() { }

        public override string ToString()
        {
            return $"{CustomerName}(Phone:{PhoneNumber})";
        }
    }
}
