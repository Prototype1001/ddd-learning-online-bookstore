using OnlineBookstore.Common;
using OnlineBookstore.Domain.OrderManagement.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBookstore.Domain.OrderManagement.Events.Order
{
    public class OrderShippingAddressUpdated : IDomainEvent
    {
        public OrderId OrderId { get; }
        public Address OldShippingAddress { get; }
        public Address NewShippingAddress { get; }
        public DateTime OccuredAt { get; set; }

        public OrderShippingAddressUpdated(OrderId orderId, Address oldShippingAddress, Address newShippingAddress, DateTime occuredAt)
        {
            OrderId = orderId;
            OldShippingAddress = oldShippingAddress;
            NewShippingAddress = newShippingAddress;
            OccuredAt = occuredAt;
        }
    }
}
