using OnlineBookstore.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBookstore.Domain.Order.ValueObjects
{
    public class CustomerId : ValueObject
    {
        public int Value { get; private set; }

        public CustomerId(int id)
        {
            Value = id;
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            throw new NotImplementedException();
        }
    }
}
