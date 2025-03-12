using BusinessEntities;
using Common;
using Raven.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace Data.Repositories
{

    [AutoRegister]
    public class ProductRepository : IProductRepository
    {

        public Product Get(int Id)
        {
            return Products.Where(n => n.Id == Id).FirstOrDefault();
        }

        public IEnumerable<Product> GetProducts()
        {
            return Products;
        }

        public Product Create(Product product)
        {
            Products.Add(product);
            return product;
        }

        public Product Update(Product product)
        {
            Product productModel = Products.First(u => u.Id == product.Id);
            productModel.Name = product.Name;
            productModel.UnitPrice = product.UnitPrice;
            productModel.QuantityInStock = product.QuantityInStock;
            return productModel;
        }

        public void Delete(int id)
        {
            Product s = Products.FirstOrDefault(u => u.Id == id);
            Products.Remove(s);
        }

        public static List<Product> Products { get; set; } = new List<Product>()
        {
            new Product
            {
                Id = 1,
                Name ="Bread",
                UnitPrice = 5.00,
                QuantityInStock = 5
            },
            new Product
            {
                Id = 2,
                Name ="Milk",
                UnitPrice = 3.00,
                QuantityInStock = 8
            },
            new Product
            {
                Id = 3,
                Name ="Egg",
                UnitPrice = 15.00,
                QuantityInStock = 2
            },

        };

    }
}
