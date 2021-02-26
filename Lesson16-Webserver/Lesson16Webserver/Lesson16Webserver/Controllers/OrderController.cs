using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lesson16Webserver.ViewModels;
using Microsoft.Extensions.Logging;

namespace Lesson16Webserver.Controllers
{
    [Route("api/[controller]/simple")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly ILogger<OrderController> _logger;
        private readonly InMemStore<SimpleOrder> _simpleOrders;

        public OrderController(ILogger<OrderController> logger, InMemStore<SimpleOrder> simpleOrders)
        {
            _logger = logger;
            _simpleOrders = simpleOrders;
        }


        [HttpGet]
        [Route("all")]
        public IEnumerable<SimpleOrder> Get()
        {
            return _simpleOrders.GetAll();
        }

        [HttpGet]
        [Route("save/usingGet")]
        public SimpleOrder GetSaveSimple(string productName, decimal productPrice, string clientName, int qty)
        {
            return _simpleOrders.Create(new SimpleOrder(productName, productPrice, clientName, qty));
        }

        [HttpPost]
        [Route("save/usingJson")]
        public SimpleOrder PostSave(SimpleOrder item)
        {
            return _simpleOrders.Create(item);
        }

        [HttpPost]
        [Route("save/usingFormData")]
        public SimpleOrder PostSaveForm([FromForm] SimpleOrder item)
        {
            return _simpleOrders.Create(item);
        }


        [HttpGet]
        [Route("order/{id}")]
        public SimpleOrder GetOrder(int id)
        {
            return _simpleOrders.Get(id);
        }

        [HttpGet]
        [Route("client")]
        public IEnumerable<SimpleOrder> GetOrdersForClient(string clientName)
        {
            return _simpleOrders.GetAll().Where(x => x.ClientName == clientName);
        }
    }
}
