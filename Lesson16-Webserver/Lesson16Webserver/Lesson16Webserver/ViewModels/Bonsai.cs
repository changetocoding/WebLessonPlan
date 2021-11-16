using System.Collections.Generic;

namespace Lesson16Webserver.ViewModels
{
    public class Bonsai : IStoreType
    {
        public Bonsai() { }
        public Bonsai(string productTitle, decimal productPrice, string productDescription, string productImage, List<string> checkoutOptions)
        {
            ProductTitle = productTitle;
            ProductPrice = productPrice;
            ProductDescription = productDescription;
            ProductImage = productImage;
            CheckoutOptions = checkoutOptions;
        }

        public int Id { get; set; }

        public string ProductTitle { get; set; }
        public decimal ProductPrice { get; set; }
        public string ProductDescription { get; set; }
        public string ProductImage { get; set; }
        public List<string> CheckoutOptions { get; set; }

        public static List<Bonsai> Init()
        {
            return new List<Bonsai>()
            {
                new Bonsai(){
                    Id = 1,
                    ProductTitle= "Chinese Juniper Itagawa",
                    ProductPrice= 2000.00m,
                    ProductDescription= "Spectacular Itoigawa Chinese Juniper Tree, approximately 35-39cm tall and in a ceramic bonsai pot.",
                    ProductImage= "./img/OutdoorBonsai/OutdoorBonsai_1.jpg",

                    CheckoutOptions= new List<string>() {"Tools", "Soil", "Care"}
                },
                new Bonsai(){
                    Id = 2,
                    ProductTitle= "Chinese Juniper Itagawa",
                    ProductPrice= 1495.00m,
                    ProductDescription= "Lovely Large Itoigawa Chinese Juniper Tree, approximately 98-100cm tall.",
                    ProductImage= "./img/OutdoorBonsai/OutdoorBonsai_2.jpg",

                    CheckoutOptions= new List<string>() {"Tools", "Soil", "Care"}
                },
                new Bonsai(){
                    Id = 3,
                    ProductTitle= "35-38cm Itagawa",
                    ProductPrice= 3250.00m,
                    ProductDescription= "Beautiful Chinese Itiogawa Juniper, approximately 35-38cm tall and planted in an oval ceramic bonsai pot.",
                    ProductImage= "./img/OutdoorBonsai/OutdoorBonsai_3.jpg",

                    CheckoutOptions= new List<string>() {"Tools", "Soil", "Care"}
                },
                new Bonsai(){
                    Id = 4,
                    ProductTitle= "Brussels Bonsai",
                    ProductPrice= 195.00m,
                    ProductDescription= "Lovely Brussels Bonsai Tree in a ceramic bonsai pot, approximately 27-29cm tall.",
                    ProductImage= "./img/OutdoorBonsai/OutdoorBonsai_4.jpg",

                    CheckoutOptions= new List<string>() {"Tools", "Soil", "Care"}
                },
                new Bonsai(){
                    Id = 5,
                    ProductTitle= "Satsuki Azalea",
                    ProductPrice= 595.00m,
                    ProductDescription= "Gorgeous Satsuki Azalea Bonsai Tree, approximately 28-33cm tall and planted in an unglazed oval ceramic bonsai pot.",
                    ProductImage= "./img/OutdoorBonsai/OutdoorBonsai_5.jpg",

                    CheckoutOptions= new List<string>() {"Tools", "Soil", "Care"}
                },
                new Bonsai(){
                    Id = 6,
                    ProductTitle= "Semi Cascade Juniper Procumbens",
                    ProductPrice= 225.00m,
                    ProductDescription= "Lovely outdoor Juniperus procumbens Nana Bonsai Tree planted cascade style and in a lovely ceramic pot and stands approximately 37-39cm tall. This item needs to be collected from the nursery.",
                    ProductImage= "./img/OutdoorBonsai/OutdoorBonsai_6.jpg",

                    CheckoutOptions= new List<string>() {"Tools", "Soil", "Care"}
                },
                new Bonsai(){
                    Id = 7,
                    ProductTitle= "Pyracantha Bonsai",
                    ProductPrice= 395.00m,
                    ProductDescription= "Beautiful Large Pyracantha Tree, approximately 56-60cm tall and planted in a plastic bosai pot.",
                    ProductImage= "./img/OutdoorBonsai/OutdoorBonsai_7.jpg",

                    CheckoutOptions= new List<string>() {"Tools", "Soil", "Care"}
                },
                new Bonsai(){
                    Id = 8,
                    ProductTitle= "Japanese White Pine",
                    ProductPrice= 295.00m,
                    ProductDescription= "Black Pine Bonsai Tree. Approximately 36-38cm tall planted in a plastic bonsai pot.",
                    ProductImage= "./img/OutdoorBonsai/OutdoorBonsai_8.jpg",

                    CheckoutOptions= new List<string>() {"Tools", "Soil", "Care"}
                },
                new Bonsai(){
                    Id = 9,
                    ProductTitle= "Punica Granatum (Pomegranate)",
                    ProductPrice= 79.00m,
                    ProductDescription= "Pomegranate Bonsai Tree, approximately 25-30cm tall and planted in a ceramic pot. Around 8 years old.",
                    ProductImage= "./img/OutdoorBonsai/OutdoorBonsai_9.jpg",

                    CheckoutOptions= new List<string>() {"Tools", "Soil", "Care"}
                },
                new Bonsai(){
                    Id = 101,
                    ProductTitle= "Ficus Bonsai with Amazing Arial Roots",
                    ProductPrice= 1200.00m,
                    ProductDescription= "Gorgeous Ficus Bonsai Tree, standing approximately 50-53cm tall with amazing aerial roots, looks incredible from all angles. Comes in a Ceramic Bonsai Pot.",
                    ProductImage= "./img/IndoorBonsai/IndoorBonsai_1.jpg",

                    CheckoutOptions= new List<string>() {"Tools", "Soil", "Care"}
                },
                new Bonsai(){
                    Id = 102,
                    ProductTitle= "Exposed Root Elm Forest Landscape",
                    ProductPrice= 415.00m,
                    ProductDescription= "This a delightful landscape made with Chinese Elms with exposed roots and planted in a Mica Pot. Stands approximately 35-45cm tall.",
                    ProductImage= "./img/IndoorBonsai/IndoorBonsai_2.jpg",

                    CheckoutOptions= new List<string>() {"Tools", "Soil", "Care"}
                },
                new Bonsai(){
                    Id = 103,
                    ProductTitle= "Ficus Bonsai with Amazing Arial Roots",
                    ProductPrice= 1200.00m,
                    ProductDescription= "This is a truly magnificent Ficus Bonsai Tree, standing approximately 53-57cm tall with amazing aerial roots, looks incredible from all angles. Comes in a Ceramic Bonsai Pot.",
                    ProductImage= "./img/IndoorBonsai/IndoorBonsai_3.jpg",

                    CheckoutOptions= new List<string>() {"Tools", "Soil", "Care"}
                },
                new Bonsai(){
                    Id = 104,
                    ProductTitle= "Syzygium (Brush Cherry) Bonsai",
                    ProductPrice= 149.00m,
                    ProductDescription= "Beautiful S-Shaped Syzygium (Brush Cherry) Bonsai Tree, in an oval ceramic Bonsai pot and approximately 50-52cm tall.",
                    ProductImage= "./img/IndoorBonsai/IndoorBonsai_4.jpg",

                    CheckoutOptions= new List<string>() {"Tools", "Soil", "Care"}
                },
                new Bonsai(){
                    Id = 105,
                    ProductTitle= "Podocarpus Bonsai in an Unglazed Pot",
                    ProductPrice= 59.00m,
                    ProductDescription= "Podocarpus Bonsai Tree, also known as the Buddhist Pine. Approximately 27-29cm tall, easy to care for, prefer a cool room, and displayed in a ceramic Bonsai pot.",
                    ProductImage= "./img/IndoorBonsai/IndoorBonsai_5.jpg",

                    CheckoutOptions= new List<string>() {"Tools", "Soil", "Care"}
                },
                new Bonsai(){
                    Id = 106,
                    ProductTitle= "Syzygium (Brush Cherry) Bonsai",
                    ProductPrice= 169.00m,
                    ProductDescription= "Beautiful S-Shaped Syzygium (Brush Cherry) Bonsai Tree, in an unglazed ceramic bonsai pot, approximately 50-53cm tall.",
                    ProductImage= "./img/IndoorBonsai/IndoorBonsai_6.jpg",

                    CheckoutOptions= new List<string>() {"Tools", "Soil", "Care"}
                },
                new Bonsai(){
                    Id = 107,
                    ProductTitle= "Ulmus parvifolia Chinese Elm",
                    ProductPrice= 295.00m,
                    ProductDescription= "Ulmus parvifolia ‘Chinese Elm’ (deciduous) Bonsai, approximately 54-56cm tall. Complete in a Ceramic Bonsai Pot. Easy to care for so a lovely tree for a beginner. This tree would thrive outdoors, if indoors would require lots of light.",
                    ProductImage= "./img/IndoorBonsai/IndoorBonsai_7.jpg",

                    CheckoutOptions= new List<string>() {"Tools", "Soil", "Care"}
                },
                new Bonsai(){
                    Id = 108,
                    ProductTitle= "Ulmus parvifolia Chinese Elm",
                    ProductPrice= 189.00m,
                    ProductDescription= "Ulmus parvifolia ‘Chinese Elm’ (deciduous) Bonsai, between 50-56cm tall. Complete in a ceramic bonsai pot. This would thrive outdoors, if kept indoors would require lots of light.",
                    ProductImage= "./img/IndoorBonsai/IndoorBonsai_8.jpg",

                    CheckoutOptions= new List<string>() {"Tools", "Soil", "Care"}
                },
                new Bonsai(){
                    Id = 109,
                    ProductTitle= "Ulmus parvifolia Chinese Elm",
                    ProductPrice= 99.00m,
                    ProductDescription= "Ulmus parvifolia ‘Chinese Elm’ (deciduous) Bonsai, between 45-52cm tall. Complete in a ceramic bonsai pot. Easy to care for so a lovely tree for a beginner.",
                    ProductImage= "./img/IndoorBonsai/IndoorBonsai_9.jpg",

                    CheckoutOptions= new List<string>() {"Tools", "Soil", "Care"}
                },
                new Bonsai(){
                    Id = 10001,
                    ProductTitle= "Stainless Steel Bonsai Tool kit",
                    ProductPrice= 295.00m,
                    ProductDescription= "High quality 7 Piece Stainless Steel Dingmu Bonsai Tool kit. An ideal gift for someone who wants to learn a bit more about bonsai.",
                    ProductImage= "./img/Care/BonsaiCare_1.jpg",

                    CheckoutOptions= new List<string>() {"Soil"}
                },
                new Bonsai(){
                    Id = 10002,
                    ProductTitle= "Tool Bag",
                    ProductPrice= 25.00m,
                    ProductDescription= "A treat for you bonsai tools. Lovely high quality leather effect tool bag made by Ryuga and has space for 9 tools.",
                    ProductImage= "./img/Care/BonsaiCare_2.jpg",

                    CheckoutOptions= new List<string>() {"Soil"}
                },
                new Bonsai(){
                    Id = 10003,
                    ProductTitle= "Bonsai Trimming or Twig Shears 200mm",
                    ProductPrice= 59.00m,
                    ProductDescription= "Bonsai Root Shears 200mm from Dingmu.",
                    ProductImage= "./img/Care/BonsaiCare_3.jpg",

                    CheckoutOptions= new List<string>() {"Soil"}
                },
                new Bonsai(){
                    Id = 10004,
                    ProductTitle= "Stainless Steel Bonsai Root Rake",
                    ProductPrice= 12.00m,
                    ProductDescription= "Premium Stainless Steel Chinese Bonsai Root Rake.",
                    ProductImage= "./img/Care/BonsaiCare_4.jpg",

                    CheckoutOptions= new List<string>() {"Soil"}
                },
                new Bonsai(){
                    Id = 10005,
                    ProductTitle= "Flat Iron Bonsai Tree Jin Cleaning Brush 230mm",
                    ProductPrice= 15.00m,
                    ProductDescription= "This iron bristle brush is ideal for cleaning delicate deadwood and bark where a softer brush won’t do. A must have for your bonsai kit.",
                    ProductImage= "./img/Care/BonsaiCare_5.jpg",

                    CheckoutOptions= new List<string>() {"Soil"}
                },
                new Bonsai(){
                    Id = 10006,
                    ProductTitle= "Bonsai Pot Mesh",
                    ProductPrice= 5.00m,
                    ProductDescription= "2 x A4 sized Sheets Of High Quality Bonsai Pot Mesh so you can cut to the size you require.",
                    ProductImage= "./img/Care/BonsaiCare_6.jpg",

                    CheckoutOptions= new List<string>() {"Soil"}
                },
                new Bonsai(){
                    Id = 10007,
                    ProductTitle= "Naruko Slow Release Bonsai Food",
                    ProductPrice= 5.00m,
                    ProductDescription= "Granular Naruko fertilizer is a granular slow release feed that has a rapid uptake by bonsai trees The bonsai feed is shaped so it has limited roll off from the soil.",
                    ProductImage= "./img/Care/BonsaiCare_7.jpg",

                    CheckoutOptions= new List<string>() {"Soil"}
                },
                new Bonsai(){
                    Id = 10008,
                    ProductTitle= "Ultra Fine Shohin Akadama Bonsai Soil",
                    ProductPrice= 4.00m,
                    ProductDescription= "Shohin Akadama Bonsai Soil",
                    ProductImage= "./img/Care/BonsaiCare_8.jpg",
                    CheckoutOptions= new List<string>() {"Soil"}
                },
                new Bonsai(){
                    Id = 10009,
                    ProductTitle= "Bonsai Cut Paste",
                    ProductPrice= 19.00m,
                    ProductDescription= "160g Japanese Bonsai Cut Paste particularly good for use on evergreen species.",
                    ProductImage= "./img/Care/BonsaiCare_9.jpg",
                    CheckoutOptions= new List<string>() {"Soil"}
                },


            };
        }
    }
}
