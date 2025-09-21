using OnlineBookstore.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBookstore.Domain.OrderManagement.ValueObjects
{
    public class Address : ValueObject
    {
        public readonly string Street1;
        public readonly string Street2;
        public readonly string City;
        public readonly string PostalCode;
        public readonly string Country;

        public Address(string street1,
            string street2,
            string city,
            string postalCode,
            string country)
        {
            Street1 = street1;
            Street2 = street2;
            City = city;
            PostalCode = postalCode;
            Country = country;
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            return [Street1, Street2, City, PostalCode, Country];
        }
    }
}
