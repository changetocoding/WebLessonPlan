using Lesson16Webserver.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace Lesson16Webserver.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BonsaiV2Controller : ControllerBase
    {
        private readonly ILogger<BonsaiController> _logger;
        private readonly InMemStore<Bonsai> _store;
        private readonly InMemStore<CheckoutOption> _options;
        private readonly InMemStore<BonsaiOrderDetails> _orders;
        private readonly InMemStore<BonsaiClient> _clients;

        public BonsaiV2Controller(ILogger<BonsaiController> logger, InMemStore<Bonsai> store, InMemStore<CheckoutOption> options
            , InMemStore<BonsaiOrderDetails> orders, InMemStore<BonsaiClient> clients)
        {
            _logger = logger;
            _store = store;
            _options = options;
            _orders = orders;
            _clients = clients;
        }

        /// <summary>
        /// Gets all the products
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("All")]
        public IEnumerable<BonsaiListing> Get()
        {
            var results = _store.GetAll().Select(x => new BonsaiListing(x));
            return results;
        }

        /// <summary>
        /// Get products for a category
        /// </summary>
        /// <param name="category">one of "outdoor", "indoor", "care". Case insensitive</param>
        /// <returns>an array containing product ids with that category.</returns>
        [HttpGet]
        [Route("Category")]
        public IEnumerable<int> GetForType(string category)
        {
            if ("outdoor".Equals(category, StringComparison.InvariantCultureIgnoreCase))
                return Enumerable.Range(1, 9);


            if ("indoor".Equals(category, StringComparison.InvariantCultureIgnoreCase))
                return new[] { 4, 5,  101, 102, 103, 104, 105, 106, 107, 108, 109 };

            if ("care".Equals(category, StringComparison.InvariantCultureIgnoreCase))
                return Enumerable.Range(10001, 9);

            throw new Exception($"Category '{category}' not found.");
        }

        /// <summary>
        /// Gets the different check out options
        /// </summary>
        /// <param name="option">An case-insensitive string containing the checkout options you want. One of "tools", "soil", "care"</param>
        /// <returns>A list of checkout options for that type</returns>
        [HttpGet]
        [Route("Options")]
        public IEnumerable<CheckoutOption> GetOptions(string option)
        {
            var options = _options.GetAll();
            if ("tools".Equals(option, StringComparison.InvariantCultureIgnoreCase))
            {
                return options.Where(x => x.Type.Equals("Tools"));
            }
            if ("soil".Equals(option, StringComparison.InvariantCultureIgnoreCase))
            {
                return options.Where(x => x.Type.Equals("Soil"));
            }
            if ("care".Equals(option, StringComparison.InvariantCultureIgnoreCase))
            {
                return options.Where(x => x.Type.Equals("Care"));
            }

            throw new Exception($"Option '{option}' not found.");
        }

        /// <summary>
        /// Gets the details of a Bonsai Product. This includes a description, a rating and a checkout options field
        /// </summary>
        /// <param name="id">Id of the product</param>
        /// <returns>Detailed description of a Bonsai Product. This includes a description, a rating and a checkout options field</returns>
        [HttpGet]
        [Route("{id}")]
        public BonsaiDescription GetDetails(int id)
        {
            var bonsai = GetBonsai(id);
            return new BonsaiDescription(bonsai);
        }

        /// <summary>
        /// Place an order
        /// </summary>
        /// <param name="order">The order. Items must contain at least one element. 
        /// CheckoutOptionsIds contains the ids of the checkout options that have been added to the item. It may be null or an empty array</param>
        /// <returns>an array containing product ids with that category.</returns>
        [HttpPost]
        [Route("PlaceOrder")]
        public BonsaiOrderDetails Order(BonsaiOrder order)
        {
            if (order.Items == null || order.Items.Count == 0)
                throw new Exception("Order has no items or items is null");

            var toSave = new BonsaiOrderDetails();
            var client = GetClient(order.ClientId);// Throws if client does not exist
            toSave.ClientId = client.Id;
            
            foreach (var item in order.Items)
            {
                var bonsai = GetBonsai(item.ProductId);
                var options = new List<CheckoutOption>();
                if(item.CheckoutOptionsIds != null && item.CheckoutOptionsIds.Count > 0)
                {
                    foreach (var optionId in item.CheckoutOptionsIds)
                    {
                        options.Add(GetOption(optionId));
                    }
                }

                var orderItem = new ItemDetails()
                {
                    ProductId = item.ProductId,
                    CheckoutOptions = options.Select(x => x.Name).ToList(),
                    ProductTitle = bonsai.ProductTitle,
                    Price = bonsai.ProductPrice + options.Sum(x => x.Price),
                    Qty = item.Qty ?? 1
                };
                toSave.Items.Add(orderItem);
            }

            var result = _orders.Create(toSave);
            return result;
        }

        private Bonsai GetBonsai(int id)
        {
            try
            {
                return _store.Get(id);
            }
            catch (Exception)
            {
                throw new Exception($"Unable to find product with id: {id}");
            }
        }
        private CheckoutOption GetOption(int id)
        {
            try
            {
                return _options.Get(id);
            }
            catch (Exception)
            {
                throw new Exception($"Unable to find CheckoutOption with id: {id}");
            }
        }

        /// <summary>
        /// Gets the details for a given username
        /// </summary>
        /// <param name="username">the user name</param>
        /// <returns>the details for the username</returns>
        /// <exception cref="Exception">if username is not a user</exception>
        [HttpGet]
        [Route("ClientIdForUser")]
        public BonsaiClient ClientId(string username)
        {
            try
            {
                var client = _clients.GetAll().First(x => x.Name.Equals(username, StringComparison.InvariantCultureIgnoreCase));
                return client;
            }
            catch (Exception)
            {
                var clients = string.Join(",", _clients.GetAll().Select(x => x.Name));
                throw new Exception($"Unable to find client. This may be because the server restarted. Clients we have are: {clients}");
            }
        }

        /// <summary>
        /// Gets all the orders for a client
        /// </summary>
        /// <param name="clientId">the client id of the client</param>
        /// <returns>All the orders for a client</returns>
        /// <exception cref="Exception">if the client name is not found</exception>
        [HttpGet]
        [Route("OrdersForClient")]
        public List<BonsaiOrderDetails> OrdersForClient(int clientId)
        {
            BonsaiClient client = GetClient(clientId);

            var orders = _orders.GetAll().Where(x => x.ClientId == clientId);
            return orders.ToList();
        }

        private BonsaiClient GetClient(int clientId)
        {
            BonsaiClient client;
            try
            {
                client = _clients.Get(clientId);
            }
            catch (Exception)
            {
                var clients = string.Join(",", _clients.GetAll().Select(x => x.Id));
                throw new Exception($"Unable to find client. This may be because the server restarted. ClientIds we have are: {clients}");
            }

            return client;
        }

        /// <summary>
        /// Register a client
        /// </summary>
        /// <param name="username">The username of the client</param>
        /// <returns>The newly created client</returns>
        /// <exception cref="Exception">If username is not set or is an empty string</exception>
        [HttpGet]
        [Route("RegisterUser")]
        public BonsaiClient Register(string username)
        {
            if (string.IsNullOrEmpty(username))
            {
                throw new Exception("Invalid client Name");
            }

            var created = _clients.Create(new BonsaiClient() { Name = username });
            return created;
        }

        /// <summary>
        /// Get all clients (For testing purposes)
        /// </summary>
        /// <returns>All clients the system has. For testing purposes</returns>
        [HttpGet]
        [Route("AllClients")]
        public List<BonsaiClient> GetAllClients()
        {
            return _clients.GetAll();
        }
    }
}
