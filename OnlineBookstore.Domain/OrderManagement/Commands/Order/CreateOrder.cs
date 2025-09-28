using OnlineBookstore.Domain.OrderManagement.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBookstore.Domain.OrderManagement.Commands.Order
{
    public class CreateOrder
    {
        public readonly CustomerId CustomerId;

        public readonly Address ShippingAddress;

        public readonly List<OrderItem> Items = new();

        public CreateOrder(CustomerId customerId, 
            Address shippingAddress,
            List<OrderItem> items)
        {
            CustomerId = customerId;
            ShippingAddress = shippingAddress;
            Items = items;
        }
    }
}
