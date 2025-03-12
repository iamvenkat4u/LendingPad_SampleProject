using BusinessEntities;
using Common;
using Data.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Services.Orders
{
    [AutoRegister]
    public class CreateOrderService : ICreateOrderService
    {
        private IOrderRepository _orderRepository;
        public CreateOrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }
        public Order Create(Order order)
        {
            return _orderRepository.Create(order);
        }
    }
}
