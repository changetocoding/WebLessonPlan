using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lesson16Webserver.ViewModels
{
    public class Order: IStoreType
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public List<ProductQty> Products { get; set; }

        public static List<Order> Init()
        {
            return  new List<Order>()
            {
                new Order()
                {
                    Id = 1,
                    ClientId = 1,
                    Products = new List<ProductQty>()
                    {
                        new ProductQty(1, 2),
                        new ProductQty(2, 5),
                    }
                },
                new Order()
                {
                    Id = 2,
                    ClientId = 1,
                    Products = new List<ProductQty>()
                    {
                        new ProductQty(1, 4),
                    }
                },
            };
        }
    }

    public class SimpleOrder : IStoreType
    {
        public SimpleOrder()
        {
            
        }
        public SimpleOrder(string productName, decimal productPrice, string clientName, int qty)
        {
            ProductName = productName;
            ProductPrice = productPrice;
            ClientName = clientName;
            Qty = qty;
        }
        public int Id { get; set; }
        public string ClientName { get; set; }
        public int Qty { get; set; }
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }

        public static List<SimpleOrder> Init()
        {
            return new List<SimpleOrder>()
            {
                new SimpleOrder("Stainless Steel Bonsai Tool kit", 295, "Jacob",1 ),
                new SimpleOrder("Tool Bag", 25, "Jacob", 1),
                new SimpleOrder("Flat Iron Bonsai Tree Jin Cleaning Brush 230mm", 15, "Jacob", 2),
            };
        }
    }

    public class ProductQty{
        public ProductQty(int productId, int qty)
        {
            ProductId = productId;
            Qty = qty;
        }
        public int ProductId { get; set; }
        public int Qty { get; set; }
    }
}
