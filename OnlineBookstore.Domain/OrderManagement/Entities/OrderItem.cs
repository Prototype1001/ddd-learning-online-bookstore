using OnlineBookstore.Domain.OrderManagement.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBookstore.Domain.OrderManagement.Entities
{
    public class OrderItem
    {
        public OrderItemId Id { get; set; }
        public OrderId OrderId { get; set; }
        public BookId BookId { get; set; }
        public int Quantity { get; set; }
    }
}
