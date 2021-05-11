using MarketApp.Domain.Enums;
using System;

namespace MarketApp.Domain
{
    // This class is a subscriber class
    // It can subscribe to publishers and can get info every time the publisher decides to send some info to all subscribers
    // This subscriber class is representing a user that has the ability to subscribe for promotions and information
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ProductType FavouriteProductType { get; set; }

        public void GetPromotion(ProductType productType)
        {
            Console.WriteLine($"So, on promotion is {productType}");
            if(productType == FavouriteProductType)
            {
                Console.WriteLine("My favourite!!!");
            }
        }

        public void GetInformation(string info)
        {
            Console.WriteLine($"Got the following info: {info}");
        }
    }
}
