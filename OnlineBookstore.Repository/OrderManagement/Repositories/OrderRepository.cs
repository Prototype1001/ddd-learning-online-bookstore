using OnlineBookstore.Domain.OrderManagement.Aggregates;
using OnlineBookstore.Domain.OrderManagement.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBookstore.Repository.OrderManagement.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        public Task<Order> GetOrder(OrderId id)
        {
            throw new NotImplementedException();
        }

        public Task SaveOrder(Order order)
        {
            throw new NotImplementedException();
        }
    }
}
