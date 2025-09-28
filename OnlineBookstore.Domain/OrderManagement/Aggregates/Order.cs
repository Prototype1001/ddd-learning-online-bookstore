using OnlineBookstore.Common;
using OnlineBookstore.Domain.OrderManagement.Commands.Order;
using OnlineBookstore.Domain.OrderManagement.Entities;
using OnlineBookstore.Domain.OrderManagement.Enums;
using OnlineBookstore.Domain.OrderManagement.Events;
using OnlineBookstore.Domain.OrderManagement.Events.Order;
using OnlineBookstore.Domain.OrderManagement.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBookstore.Domain.OrderManagement.Aggregates
{
    public class Order
    {
        public OrderId Id { get; private set; } = null!;

        private Entities.Order _order = null!;

        private CustomerId _customerId = null!;

        private List<OrderItem> _orderItems = new List<OrderItem>();

        private List<IDomainEvent> _events = new List<IDomainEvent>();


        public void Execute(CreateOrder command)
        {
            if (Id.HasValue())
            {
                throw new InvalidOperationException("Order already created");
            }

            if (!command.CustomerId.HasValue())
            {
                throw new ArgumentNullException(nameof(command.CustomerId), "CustomerId is required");
            }

            if (command.Items.Count == 0)
            {
                throw new InvalidOperationException("Order must have one or more order item.");
            }

            ValidateAddress(command.ShippingAddress);

            Id = new OrderId(Guid.NewGuid());

            _customerId = command.CustomerId;
            _order = new Entities.Order(
                Id,
                command.ShippingAddress,
                DateTime.UtcNow,
                OrderStatus.Pending,
                null);

            _events.Add(new OrderAdded(_order.Id, _customerId, DateTime.UtcNow));

            foreach (var item in command.Items)
            {
                Execute(new UpsertOrderItem(item.BookId, item.Quantity));
            }
        }

        public void Execute(UpsertOrderItem command)
        {

            if (!command.BookId.HasValue())
            {
                throw new ArgumentNullException(nameof(command.BookId), "BookId is required");
            }

            var previousItem = _orderItems.FirstOrDefault(o => o.BookId == command.BookId);
            _orderItems = [.. _orderItems.Where(oi => oi.BookId != command.BookId)];

            if (command.Quantity > 0)
            {
                var item = new OrderItem(command.BookId, command.Quantity);

                _orderItems = [.. _orderItems, item];
            }


            _events.Add(new OrderItemUpserted(_order.Id,
                command.BookId,
                previousItem?.Quantity,
                command.Quantity,
                DateTime.UtcNow));
        }

        public void Execute(UpdateShippingAddress command)
        {
            ValidateAddress(command.ShippingAddress);
            var previousAddress = _order.ShippingAddress;

            _order.ShippingAddress = command.ShippingAddress;

            _events.Add(new OrderShippingAddressUpdated(_order.Id,
                previousAddress,
                command.ShippingAddress,
                DateTime.UtcNow));
        }

        public void Execute(UpdateOrderStatus command)
        {
            var previousStatus = _order.Status;

            if (previousStatus == OrderStatus.Pending)
            {
                if (command.Status != OrderStatus.Confirmed || command.Status != OrderStatus.Cancelled)
                    throw new InvalidOperationException("Invalid status. Pending status can only be transitioned to confirmed or cancelled.");
            }
            else if (previousStatus == OrderStatus.Confirmed)
            {
                if (command.Status != OrderStatus.Processing || command.Status != OrderStatus.Cancelled)
                    throw new InvalidOperationException("Invalid status. Confirmed status can only be transitioned to processing or cancelled.");

            }
            else if (previousStatus == OrderStatus.Processing)
            {
                if (command.Status != OrderStatus.Processing || command.Status != OrderStatus.Cancelled)
                    throw new InvalidOperationException("Invalid status. Proccessing status can only be transitioned to processing or cancelled.");
            }
            else if (previousStatus == OrderStatus.Shipped)
            {
                if (command.Status != OrderStatus.Delivered || command.Status != OrderStatus.Returned)
                    throw new InvalidOperationException("Invalid status. Shipped status can only be transitioned to delivered or returned.");
            }
            else if (previousStatus == OrderStatus.Delivered)
            {
                if (command.Status != OrderStatus.Returned)
                    throw new InvalidOperationException("Invalid status. Shipped status can only be transitioned to returned.");
            }
            else if (previousStatus == OrderStatus.Returned || previousStatus == OrderStatus.Cancelled)
            {
                throw new InvalidCastException("Invalid status. Current status is in terminal state no further update is allowed.");
            }

            _order.Status = command.Status;

            _events.Add(new OrderStatusUpdated(previousStatus, command.Status, DateTime.UtcNow));
        }

        #region Private Methods
        private void ValidateAddress(Address address)
        {
            if (address == null)
                throw new ArgumentNullException(nameof(address), "No address provided.");

            if (string.IsNullOrEmpty(address.Street1))
                throw new ArgumentNullException(nameof(address), "Street 1 is required.");

            if (string.IsNullOrEmpty(address.City))
                throw new ArgumentNullException(nameof(address), "City is required.");

            if (string.IsNullOrEmpty(address.PostalCode))
                throw new ArgumentNullException(nameof(address), "Postal code is required.");


            if (string.IsNullOrEmpty(address.Country))
                throw new ArgumentNullException(nameof(address), "Country is required.");
        }
        #endregion


    }
}
