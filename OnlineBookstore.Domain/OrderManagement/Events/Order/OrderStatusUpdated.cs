using OnlineBookstore.Common;
using OnlineBookstore.Domain.OrderManagement.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBookstore.Domain.OrderManagement.Events.Order
{
    public class OrderStatusUpdated : IDomainEvent
    {
        public OrderStatus PreviousStatus { get; }
        public OrderStatus NewStatus { get; }
        public DateTime OccuredAt { get; set; }

        public OrderStatusUpdated(OrderStatus previousStatus, OrderStatus newStatus, DateTime occuredAt)
        {
            PreviousStatus = previousStatus;
            NewStatus = newStatus;
            OccuredAt = occuredAt;
        }
    }
}
