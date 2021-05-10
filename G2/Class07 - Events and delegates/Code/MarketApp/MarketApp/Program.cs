using MarketApp.Domain;
using MarketApp.Domain.Enums;
using System;

namespace MarketApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Market superMarket = new Market()
            {
                Name = "SuperMarket",
                CurrentPromotionType = ProductType.Food
            };
            Market bestMarket = new Market()
            {
                Name = "BestMarket",
                CurrentPromotionType = ProductType.Cosmetics
            };

            User bob = new User()
            {
                FirstName = "Bob",
                LastName = "Bobsky",
                FavouriteProductType = ProductType.Electronics
            };
            User anne = new User()
            {
                FirstName = "Anne",
                LastName = "Bobsky",
                FavouriteProductType = ProductType.Food
            };

            superMarket.SubscribeForPromotion(bob.GetPromotion, "bob.bobsky@gmail.com");
            superMarket.SubscribeForPromotion(anne.GetPromotion, "anne.bobsky@gmail.com");
            bestMarket.SubscribeForInformation(anne.GetInformation, "anne.bobsky@gmail.com");

            superMarket.AnnouncePromotion();

            superMarket.UnsubscribeFromPromotion(bob.GetPromotion, "Too many emails!");
            superMarket.AnnouncePromotion();

            Console.ReadLine();
        }
    }
}
