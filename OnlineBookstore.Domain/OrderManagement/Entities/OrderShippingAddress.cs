using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBookstore.Domain.OrderManagement.Entities
{
    public class OrderShippingAddress
    {
        public Guid OrderId { get; set; }
        public readonly string Street1;
        public readonly string Street2;
        public readonly string City;
        public readonly string PostalCode;
        public readonly string Country;

    }
}
