using BusinessEntities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Repositories
{
    public interface IOrderRepository
    {
        Order Get(int Id);
        IEnumerable<Order> GetOrders();
        //void DeleteAll();
        Order Create(Order order);
        Order Update(Order order);
        void Delete(int id);
    }
}
