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
    public class ClientController : ControllerBase
    {
        private readonly ILogger<ClientController> _logger;
        private readonly InMemStore<Client> _store;

        public ClientController(ILogger<ClientController> logger, InMemStore<Client> store)
        {
            _logger = logger;
            _store = store;
        }

        [HttpGet]
        public IEnumerable<Client> Get()
        {
            return _store.GetAll();
        }

        [HttpPost]
        [Route("create/usingJson")]
        public Client PostCreate(Client item)
        {
            if (!item.Email.Contains("@"))
                throw new Exception("Email must have an @");
            return _store.Create(item);
        }

        [HttpPost]
        [Route("create/usingFormData")]
        public Client PostCreateForm([FromForm] Client item)
        {
            if (!item.Email.Contains("@"))
                throw new Exception("Email must have an @");
            return _store.Create(item);
        }


        [HttpPost]
        [Route("update/usingJson")]
        public Client PostUpdate(Client item)
        {
            if (!item.Email.Contains("@"))
                throw new Exception("Email must have an @");
            return _store.Update(item);
        }

        [HttpPost]
        [Route("update/usingFormData")]
        public Client PostUpdateForm([FromBody] Client item)
        {
            if (!item.Email.Contains("@"))
                throw new Exception("Email must have an @");
            return _store.Update(item);
        }



        [HttpGet]
        [Route("{id}")]
        public Client GetItem(int id)
        {
            return _store.Get(id);
        }
    }
}
