using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Web.Http;
using BusinessEntities;
using Core.Services.Products;
using Microsoft.Ajax.Utilities;
using WebApi.Models.Products;
using WebApi.Models.Users;

namespace WebApi.Controllers
{
    [RoutePrefix("products")]
    public class ProductController : BaseApiController
    {

        private readonly IGetProductService _getProductService;
        private readonly ICreateProductService _createProductService;
        private readonly IUpdateProductService _updateProductService;
        private readonly IDeleteProductService _deleteProductService;

        public ProductController(IGetProductService productService,ICreateProductService createProductService,IUpdateProductService updateProductService,IDeleteProductService deleteProductService)
        {
            _getProductService = productService;
            _createProductService = createProductService;
            _updateProductService = updateProductService;
            _deleteProductService = deleteProductService;
        }


        // GET api/<controller>/5
        // [Route("{productid:int}")]
        [Route("{productid:int}")]
        [HttpGet]
        public HttpResponseMessage Get(int productid)
        {
            var product =  _getProductService.Get(productid);
            return Found(product);
        }

        // GET api/<controller>
        [Route("list")]
        [HttpGet]
        public HttpResponseMessage GetProduct()
        {
            var products =  _getProductService.GetProducts().ToList();
            return Found(products);
        }

        // POST api/<controller>
      
        [Route("create")]
        [HttpPost]
        public HttpResponseMessage Post([FromBody] Product model)
        {            
            var createdProduct = _createProductService.Create(model);
            return Found(createdProduct);
        }
    

        // PUT api/<controller>/5
        [Route("update")]
        [HttpPut]
        public HttpResponseMessage Put([FromBody] Product model)
        {
            var product = _getProductService.Get(model.Id);
            if (product == null)
            {
                return DoesNotExist();
            }
            var updateProduct =  _updateProductService.update(model);
          return Found(updateProduct);
        }

        // DELETE api/<controller>/5
        [Route("{productid:int}")]
        [HttpDelete]
        public HttpResponseMessage Delete(int productid)
        {
            var product = _getProductService.Get(productid);
            if (product == null)
            {
                return DoesNotExist();
            }
            _deleteProductService.Delete(productid);
            return Found();
        }
    }
}