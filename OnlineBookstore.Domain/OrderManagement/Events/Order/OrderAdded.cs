using OnlineBookstore.Common;
using OnlineBookstore.Domain.OrderManagement.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBookstore.Domain.OrderManagement.Events.Order
{
    internal class OrderAdded : IDomainEvent
    {
        public OrderId OrderId { get; set; }
        public CustomerId CustomerId { get; set; }
        public DateTime OccuredAt { get; set; }

        public OrderAdded(OrderId orderId,
            CustomerId customerId,
            DateTime occuredAt)
        {
            OrderId = orderId;
            CustomerId = customerId;
            OccuredAt = occuredAt;
        }
    }
}
