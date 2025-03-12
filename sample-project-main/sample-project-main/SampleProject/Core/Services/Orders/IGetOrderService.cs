using BusinessEntities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Services.Orders
{
    public interface IGetOrderService
    {
        Order Get(int Id);

        IEnumerable<Order> GetOrders();
    }
}
