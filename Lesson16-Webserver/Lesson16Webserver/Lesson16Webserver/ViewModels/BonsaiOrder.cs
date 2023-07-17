using Microsoft.AspNetCore.Http.Features;
using System.Collections.Generic;
using System.Linq;

namespace Lesson16Webserver.ViewModels
{
    public class BonsaiOrder
    {

        public int ClientId { get; set; }
        public List<Item> Items { get; set; }
    }

    public class Item
    {
        public int ProductId { get; set; }
        public List<int> CheckoutOptionsIds { get; set; }

        public int? Qty { get; set; }
    }

    public class BonsaiOrderDetails : IStoreType
    {
        public BonsaiOrderDetails()
        {
            Items = new List<ItemDetails>();
        }
        public int ClientId { get; set; }
        public int Id { get; set; }
        public decimal TotalPrice => Items.Sum(x => x.Price * x.Qty);

        public List<ItemDetails> Items {get; set; }



        public static List<BonsaiOrderDetails> Init()
        {
            var clients = BonsaiClient.Init();
            var orderId = 0;
            var orders = new List<BonsaiOrderDetails>();
            foreach (var client in clients)
            {
                var order = CreateOrder();
                order.Id = orderId++;
                order.ClientId = client.Id;
                orders.Add(order);
            }

            return orders;
        }

        public static BonsaiOrderDetails CreateOrder()
        {
            var firstItem = Bonsai.Init().First();
            var firstOption = CheckoutOption.Init().First();
            var it = new BonsaiOrderDetails();
            it.Items = new List<ItemDetails> { new ItemDetails() {
                ProductId = firstItem.Id, ProductTitle =firstItem.ProductTitle,
                Price = firstItem.ProductPrice + firstOption.Price,
                CheckoutOptions = new List<string> { firstOption.Name}
            } };
            return it;
        }
    }

    public class ItemDetails
    {
        public ItemDetails()
        {
            Qty = 1;
        }
        public int Qty { get; set; }
        public int ProductId { get; set; }
        public string ProductTitle { get; set; }
        public decimal Price { get; set; }
        public List<string> CheckoutOptions { get; set; }
    }

    public class BonsaiClient : IStoreType
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public static List<BonsaiClient> Init()
        {
            return new List<BonsaiClient>
            {
                new BonsaiClient(){ Id = 1, Name="Patience"},
                new BonsaiClient(){ Id = 2,  Name="Jonathan"},
                new BonsaiClient(){ Id = 3,  Name="Simon"},
                new BonsaiClient(){ Id = 4,  Name="Sarah"},
            };
        }
    }
}
