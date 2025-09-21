using OnlineBookstore.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBookstore.Domain.OrderManagement.ValueObjects
{
    public class PersonName : ValueObject
    {
        public readonly string FirstName;
        public readonly string LastName;
        public readonly string? MiddleName;

        public PersonName(string firstName,
            string lastName,
            string? middeName)
        {
            FirstName = firstName;
            LastName = lastName;
            MiddleName = middeName;
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            return [FirstName, LastName, MiddleName];
        }
    }
}
