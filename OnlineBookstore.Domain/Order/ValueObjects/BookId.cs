using OnlineBookstore.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBookstore.Domain.Order.ValueObjects
{
    public class BookId : ValueObject
    {
        public int Value { get; private set; }

        public BookId(int id)
        {
            Value = id;
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            throw new NotImplementedException();
        }
    }
}
