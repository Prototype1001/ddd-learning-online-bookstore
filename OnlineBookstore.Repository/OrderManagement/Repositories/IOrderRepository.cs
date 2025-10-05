using OnlineBookstore.Domain.OrderManagement.Aggregates;
using OnlineBookstore.Domain.OrderManagement.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBookstore.Repository.OrderManagement.Repositories
{
    public interface IOrderRepository
    {
        Task<Order> GetOrder(OrderId id);

        Task SaveOrder(Order order);
    }
}
