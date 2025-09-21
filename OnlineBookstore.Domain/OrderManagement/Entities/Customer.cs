using OnlineBookstore.Domain.OrderManagement.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBookstore.Domain.OrderManagement.Entities
{
    public class Customer
    {
        public CustomerId Id { get; set; }
        public PersonName Name { get; set; }
        public Address Address{ get; set; }
        public MobileNumber MobileNumber { get; set; }
        public string Email { get; set; }

        public Customer(CustomerId id,
            PersonName name,
            Address address,
            MobileNumber mobileNumber,
            string email)
        {
            Id = id;
            Name = name;
            Address = address;
            MobileNumber = mobileNumber;
            Email = email;  
        }
    }
}
