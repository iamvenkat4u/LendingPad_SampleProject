using BusinessEntities;
using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data.Repositories
{
    [AutoRegister]
    public class OrderRepository : IOrderRepository
    {
        public Order Create(Order order)
        {
            Orders.Add(order);
            return order;
        }

        public void Delete(int id)
        {
            Order s = Orders.FirstOrDefault(u => u.Id == id);
            Orders.Remove(s);
        }

        public Order Get(int Id)
        {
            return Orders.Where(n => n.Id == Id).FirstOrDefault();
        }

        public IEnumerable<Order> GetOrders()
        {
            return Orders;
        }

        public Order Update(Order order)
        {
            Order orderModel = Orders.First(u => u.Id == order.Id);
            orderModel.Name = order.Name;
            orderModel.TotalPrice = order.TotalPrice;
      
            return orderModel;
        }

        public static List<Order> Orders { get; set; } = new List<Order>()
        {
            new Order
            {
                Id = 1,
                Name ="Bread",
                TotalPrice = 5.00
            },
            new Order
            {
                Id = 2,
                Name ="Milk",
                TotalPrice = 15.00
            },
            new Order
            {
                Id = 3,
                Name ="Egg",
                TotalPrice = 25.00
            },

        };
    }
}
