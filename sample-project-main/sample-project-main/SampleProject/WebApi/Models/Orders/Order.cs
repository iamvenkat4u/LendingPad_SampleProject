using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi.Models.Orders
{
    public class OrderModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public double TotalPrice { get; set; }
    }
}