using OnlineBookstore.Domain.OrderManagement.Enums;
using OnlineBookstore.Domain.OrderManagement.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBookstore.Domain.OrderManagement.Entities
{
    public class Order
    {
        public OrderId Id { get; set; }
        public Address ShippingAddress { get; set; }
        public DateTime OrderDate { get; set; }
        public OrderStatus Status { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public List<OrderItem> Items { get; set; }

        public Order(OrderId id,
            Address shippingAddress,
            DateTime orderDate,
            OrderStatus orderStatus,
            DateTime? modifiedDate)
        {
            Id = id;
            OrderDate = orderDate;
            ShippingAddress = shippingAddress;
            Status = orderStatus;
            ModifiedDate = modifiedDate;
        }


    }
}
