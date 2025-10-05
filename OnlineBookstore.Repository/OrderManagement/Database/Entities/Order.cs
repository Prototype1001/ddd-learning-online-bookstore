using OnlineBookstore.Domain.OrderManagement.Entities;
using OnlineBookstore.Domain.OrderManagement.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBookstore.Repository.OrderManagement.Database.Entities
{
    public class Order
    {
        public Guid Id { get; set; }
        public DateTime OrderDate { get; set; }
        public OrderStatus Status { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public OrderShippingAddress ShippingAddress { get; set; }

        public List<OrderItem> OrderItems { get; set; }
    }
}
