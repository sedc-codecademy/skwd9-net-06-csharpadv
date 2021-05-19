using SEDC.SubscriptionModel.Models;
using System;

namespace SEDC.SubscriptionModel
{
    class Program
    {
        public static Market Vero = new Market
        {
            Name = "Vero",
            CurrentPromotion = ProductType.Food
        };

        public static Market Tinex = new Market
        {
            Name = "Tinex",
            CurrentPromotion = ProductType.Drinks
        };

        public static Market TehnoMarket = new Market
        {
            Name = "TehnoMarket",
            CurrentPromotion = ProductType.Electronics
        };

        static void Main(string[] args)
        {
            User martin = new User { Name = "Martin", Age = 27, FavouriteType = ProductType.Electronics };
            User petre = new User { Name = "Petre", Age = 27, FavouriteType = ProductType.Drinks };
            User dejan = new User { Name = "Dejan", Age = 28, FavouriteType = ProductType.Food };


            // Users subscribe to Vero for their promotions
            Vero.SubcriebeForPromotions(martin.ReadPromotion, "martin@gmail.com");
            Vero.SubcriebeForPromotions(petre.ReadPromotion, "petre@gmail.com");
            Vero.SubcriebeForPromotions(dejan.ReadPromotion, "dejan@gmail.com");

            Vero.SendPromotion();

            // Users subscribe to Tinex for their promotions
            Tinex.SubcriebeForPromotions(petre.ReadPromotion, "petre@gmail.com");
            Tinex.SubcriebeForPromotions(dejan.ReadPromotion, "dejan@gmail.com");
            Tinex.SendPromotion();

            Tinex.UnSubcriebeForPromotions(petre.ReadPromotion, "Too much emails from your market!");
            Tinex.SendPromotion();

            Tinex.ZhalbiIPoplaki.ForEach(Console.WriteLine);



            // Users subscribe to TehnoMarket for their promotions
            TehnoMarket.SubcriebeForPromotions(martin.ReadPromotion, "martin@gmail.com");
            TehnoMarket.SendPromotion();




            Console.ReadLine();
        }
    }
}
