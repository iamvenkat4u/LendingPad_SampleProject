using BusinessEntities;
using Common;
using Data.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Services.Products
{
    [AutoRegister]
    public class CreateProductService : ICreateProductService
    {

        private readonly IProductRepository _productRepository;

        public CreateProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public Product Create(Product product)
        {
           return _productRepository.Create(product);
        }
    }
}
