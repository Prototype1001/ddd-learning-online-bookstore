using OnlineBookstore.Domain.OrderManagement.Entities;
using OnlineBookstore.Domain.OrderManagement.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBookstore.Domain.OrderManagement.Aggregates
{
    public class OrderAggregate
    {
        public OrderId Id { get; set; }

        public Order Order { get; set; }

    }
}
