using OnlineBookstore.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBookstore.Domain.OrderManagement.ValueObjects
{
    public class CustomerId : ValueObject
    {
        public readonly int Value;

        public CustomerId(int id)
        {
            Value = id;
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            return [Value];
        }
    }
}
