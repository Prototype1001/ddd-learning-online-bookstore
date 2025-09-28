using OnlineBookstore.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBookstore.Domain.OrderManagement.ValueObjects
{
    public class BookId : EntityId<Guid>
    {
        public BookId(Guid value)
            : base(value)
        {
            
        }
    }
}
