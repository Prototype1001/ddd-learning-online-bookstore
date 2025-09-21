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
        public CustomerId CustomerId { get; set; }
        public DateTime OrderDate { get; set; }
        public OrderStatus Status { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public Order(OrderId id,
            CustomerId customerId,
            BookId bookId,
            DateTime orderDate,
            OrderStatus orderStatus,
            DateTime? modifiedDate)
        {
            Id = id;
            CustomerId = customerId;
            OrderDate = orderDate;
            Status = orderStatus;
            ModifiedDate = modifiedDate;
        }


    }
}
