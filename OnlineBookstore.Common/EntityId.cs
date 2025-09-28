using OnlineBookstore.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBookstore.Common
{
    public class EntityId<T> : ValueObject
    {
        public readonly T Value;

        public EntityId(T id)
        {
            Value = id;
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            return [Value];
        }

        public bool HasValue()
        {
            return Value != null && !Value.Equals(default(T));
        }

    }
}
