using OnlineBookstore.Domain.OrderManagement.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBookstore.Domain.OrderManagement.Commands.Order
{
    public class UpdateShippingAddress
    {
        public Address ShippingAddress { get; set; }

        public UpdateShippingAddress(Address shippingAddress)
        {
            ShippingAddress = shippingAddress;
        }
    }
}
