using OnlineBookstore.Domain.OrderManagement.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBookstore.Repository.OrderManagement.Database.Entities
{
    public class OrderItem
    {
        public Guid OrderId { get; set; }
        public Guid BookId { get; set; }
        public int Quantity { get; set; }

        public Order Order { get; set; }

        public Book Book { get; set; }
    }
}
