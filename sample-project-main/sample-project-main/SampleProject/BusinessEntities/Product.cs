using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessEntities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public double UnitPrice { get; set; }
        public int QuantityInStock { get; set; }
    }
}
