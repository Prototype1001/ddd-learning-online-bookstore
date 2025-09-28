using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBookstore.Domain.OrderManagement.ValueObjects
{
    public class OrderItem
    {
        public BookId BookId { get; set; }
        public int Quantity { get; set; }

        public OrderItem(BookId bookId,
            int quantity)
        {
            BookId = bookId;
            Quantity = quantity;
        }
    }
}
