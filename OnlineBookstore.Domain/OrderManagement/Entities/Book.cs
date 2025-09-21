using OnlineBookstore.Domain.OrderManagement.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBookstore.Domain.OrderManagement.Entities
{
    public class Book
    {
        public BookId Id { get; set; }
        public string Name { get; set; }
        public Money Price { get; set; }
        public int Stock { get; set; }
        public DateTime? LastStockUpdateDate { get; set; }

        public Book(BookId id,
            string name,
            Money price,
            int stock,
            DateTime? lastStockUpdateDate)
        {
            Id = id;
            Name = name;
            Price = price;
            Stock = stock;
            LastStockUpdateDate = lastStockUpdateDate;
        }
    }
}
