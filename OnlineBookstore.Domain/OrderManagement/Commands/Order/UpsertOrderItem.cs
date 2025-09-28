using OnlineBookstore.Domain.OrderManagement.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBookstore.Domain.OrderManagement.Commands.Order
{
    public class UpsertOrderItem
    {
        public BookId BookId { get; set; }
        public int Quantity { get; set; }

        public UpsertOrderItem(BookId bookId, 
            int quantity) 
        { 
            BookId = bookId;
            Quantity = quantity;
        }
    }
}
