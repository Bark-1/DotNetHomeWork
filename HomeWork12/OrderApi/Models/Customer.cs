using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OrderApi.Models
{
    [Serializable]
    public class Customer
    {
        [Key]
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
