using OnlineBookstore.Common;
using OnlineBookstore.Domain.OrderManagement.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBookstore.Domain.OrderManagement.Events.Order
{
    public class OrderItemUpserted : IDomainEvent
    {
        public readonly OrderId OrderId;

        public readonly BookId BookId;

        public readonly int? OldQuantity;

        public readonly int NewQuantity;
        public DateTime OccuredAt { get; set; }

        public OrderItemUpserted(OrderId orderId, BookId bookId, int? oldQuantity, int newQuantity, DateTime occuredAt)
        {
            OrderId = orderId;
            BookId = bookId;
            OldQuantity = oldQuantity;
            NewQuantity = newQuantity;
            OccuredAt = occuredAt;
        }

    }
}
