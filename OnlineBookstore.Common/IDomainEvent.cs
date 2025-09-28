using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBookstore.Common
{
    public interface IDomainEvent
    {
        public DateTime OccuredAt { get; set; }
    }
}
