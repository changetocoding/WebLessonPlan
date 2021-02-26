using System.Collections.Generic;

namespace Lesson16Webserver.ViewModels
{
    public class CheckoutOption: IStoreType
    {
        public CheckoutOption(int id, string name, decimal price, string type)
        {
            Id = id;
            Name = name;
            Price = price;
            Type = type;
        }
        public string Name { get; }
        public decimal Price { get; }
        public string Type { get; }
        public int Id { get; set; }

        public static List<CheckoutOption> Init()
        {
            return new List<CheckoutOption>()
            {
                new CheckoutOption(1, "All In One Basic Bonsai Tool Kit (+£95.00)", 95, "Tool"),
                new CheckoutOption(2, "Carbon Steel Japanese Bonsai Tool kit (+£195.00)", 195, "Tool"),
                new CheckoutOption(3, "Stainless Steel Bonsai Tool kit (+295.00)", 295, "Tool"),
                new CheckoutOption(4, "2L (+£4.00)", 4, "Soil"),
                new CheckoutOption(5, "5L (+£8.00)", 8, "Soil"),
                new CheckoutOption(6, "10L (+£14.00)", 14, "Soil"),
                new CheckoutOption(7, "Yes (+£13.00)", 13, "Care"),
            };

        }
    }
}