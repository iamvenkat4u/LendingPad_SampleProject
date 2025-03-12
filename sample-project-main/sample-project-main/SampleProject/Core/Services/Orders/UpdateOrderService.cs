using BusinessEntities;
using Common;
using Data.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Services.Orders
{
    [AutoRegister]
    public class UpdateOrderService : IUpdateOrderService
    {
        private IOrderRepository _orderRepository;

        public UpdateOrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }
        public Order update(Order order)
        {
            return _orderRepository.Update(order);
        }
    }
}
