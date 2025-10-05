using OnlineBookstore.Domain.OrderManagement.Enums;
using OnlineBookstore.Domain.OrderManagement.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBookstore.Repository.OrderManagement.Database.Entities
{
    public class Book
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Currency PriceCurrency { get; set; }
        public decimal PriceAmount { get; set; }
        public int Stock { get; set; }
        public DateTime? LastStockUpdateDate { get; set; }
    }
}
