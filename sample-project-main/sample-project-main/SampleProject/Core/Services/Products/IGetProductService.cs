using System;
using System.Collections.Generic;
using BusinessEntities;

namespace Core.Services.Products
{
    public interface IGetProductService
    {
        Product Get(int Id);

        IEnumerable<Product> GetProducts();

    }
}
