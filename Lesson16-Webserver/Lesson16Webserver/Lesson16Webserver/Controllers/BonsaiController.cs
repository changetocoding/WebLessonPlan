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
    [Route("api/[controller]")]
    [ApiController]
    public class BonsaiController : ControllerBase
    {
        private readonly ILogger<BonsaiController> _logger;
        private readonly InMemStore<Bonsai> _store;
        private readonly InMemStore<CheckoutOption> _options;

        public BonsaiController(ILogger<BonsaiController> logger, InMemStore<Bonsai> store, InMemStore<CheckoutOption> options)
        {
            _logger = logger;
            _store = store;
            _options = options;
        }

        [HttpGet]
        public IEnumerable<Bonsai> Get()
        {
            return _store.GetAll();
        }

        [HttpGet]
        [Route("Options")]
        public IEnumerable<CheckoutOption> GetOptions()
        {
            return _options.GetAll();
        }

        [HttpGet]
        [Route("{id}")]
        public Bonsai GetItem(int id)
        {
            return _store.Get(id);
        }
    }
}
