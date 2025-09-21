using OnlineBookstore.Common;
using OnlineBookstore.Domain.OrderManagement.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBookstore.Domain.OrderManagement.ValueObjects
{
    public class MobileNumber : ValueObject
    {
        public readonly CountryCode CountryCode;
        public readonly string Number;

        public MobileNumber(CountryCode countryCode, string number)
        {
            CountryCode = countryCode;
            Number = number;
        }
        protected override IEnumerable<object> GetEqualityComponents()
        {
            return [CountryCode, Number];
        }
    }
}
