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
using WebApi.Models.Orders;
using Core.Services.Orders;

namespace WebApi.Controllers
{
    [RoutePrefix("orders")]
    public class OrderController : BaseApiController
    {
        private readonly IGetOrderService _getOrderService;
        private readonly ICreateOrderService _createOrderService;
        private readonly IUpdateOrderService _updateOrderService;
        private readonly IDeleteOrderService _deleteOrderService;


        public OrderController(IGetOrderService getOrderService, ICreateOrderService createOrderService, IUpdateOrderService updateOrderService, IDeleteOrderService deleteOrderService)
        {
            _getOrderService = getOrderService;
            _createOrderService = createOrderService;
            _updateOrderService = updateOrderService;
            _deleteOrderService = deleteOrderService;
        }
        // GET api/<controller>
        [Route("list")]
        [HttpGet]
        public HttpResponseMessage GetOrders()
        {
            var orders = _getOrderService.GetOrders().ToList();
            return Found(orders);
        }

        // GET api/<controller>/5
        [Route("{orderid:int}")]
        [HttpGet]
        public HttpResponseMessage Get(int orderid)
        {
            var order = _getOrderService.Get(orderid);
            return Found(order);
        }

        // POST api/<controller>

        [Route("create")]
        [HttpPost]
        public HttpResponseMessage Post([FromBody] Order model)
        {
            var createdOrder = _createOrderService.Create(model);
            return Found(createdOrder);
        }

        // PUT api/<controller>/5
        [Route("update")]
        [HttpPut]
        public HttpResponseMessage Put([FromBody] Order model)
        {
            var order = _getOrderService.Get(model.Id);
            if (order == null)
            {
                return DoesNotExist();
            }
            var updateOrder = _updateOrderService.update(model);
            return Found(updateOrder);
        }

        // DELETE api/<controller>/5
        [Route("{orderid:int}")]
        [HttpDelete]
        public HttpResponseMessage Delete(int orderid)
        {
            var order = _getOrderService.Get(orderid);
            if (order == null)
            {
                return DoesNotExist();
            }
            _deleteOrderService.Delete(orderid);
            return Found();
        }
    }
}