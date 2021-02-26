using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lesson16Webserver.ViewModels;

namespace Lesson16Webserver.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MessageController : ControllerBase
    {
        private readonly ILogger<MessageController> _logger;
        private readonly InMemStore<Message> _messageStore;

        public MessageController(ILogger<MessageController> logger, InMemStore<Message> messageStore)
        {
            _logger = logger;
            _messageStore = messageStore;
        }

        [HttpGet]
        public IEnumerable<Message> Get()
        {
            return _messageStore.GetAll();
        }


        [HttpGet]
        [Route("save/usingGet")]
        public Message SaveMessage(string to, string say)
        {
            return _messageStore.Create(new Message()
            {
                Say = say,
                To = to
            });
        }

        [HttpPost]
        [Route("save/usingJson")]
        public Message PostMessage(Message item)
        {
            return _messageStore.Create(item);
        }


        [HttpPost]
        [Route("save/usingFormData")]
        public Message PostMessageForm([FromForm] Message item)
        {
            return _messageStore.Create(item);
        }

        [HttpGet]
        [Route("{id}")]
        public Message GetSave(int id)
        {
            return _messageStore.Get(id);
        }
    }
}
