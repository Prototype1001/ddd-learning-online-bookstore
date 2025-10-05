using OnlineBookstore.Domain.OrderManagement.Enums;
using OnlineBookstore.Domain.OrderManagement.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBookstore.Repository.OrderManagement.Database.Entities
{
    public class Customer
    {
        public Guid Id { get; set; }

        public readonly string FirstName;
        public readonly string LastName;
        public readonly string? MiddleName;
        public readonly string Street1;
        public readonly string Street2;
        public readonly string City;
        public readonly string PostalCode;
        public readonly string Country;
        public readonly CountryCode MobileCountryCode;
        public readonly string MobileNumber;
        public string Email { get; set; }
    }
}
