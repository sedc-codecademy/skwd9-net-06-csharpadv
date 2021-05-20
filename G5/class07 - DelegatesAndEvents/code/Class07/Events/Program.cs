using Events.Entities;
using System;

namespace Events
{
    class Program
    {
        public static Market Tinex = new Market()
        {
            Name = "Tinex",
            CurrentPromotion = ProductType.Food
        };

        public static Market Vero = new Market()
        {
            Name = "Vero",
            CurrentPromotion = ProductType.Cosmetics
        };

        public static User Bob = new User()
        {
            Name = "Bob",
            Age = 22,
            FavouriteType = ProductType.Food
        };

        public static User Jill = new User()
        {
            Name = "Jill",
            Age = 25,
            FavouriteType = ProductType.Cosmetics
        };

        public static User Greg = new User()
        {
            Name = "Greg",
            Age = 32,
            FavouriteType = ProductType.Electronics
        };

        static void Main(string[] args)
        {
            // Users subscribe to Tinex for their promotions
            Tinex.SubscribeForPromotion(Bob.ReadPromotion, "bob@gmail.com");
            Tinex.SubscribeForPromotion(Jill.ReadPromotion, "jill@gmail.com");
            Tinex.SubscribeForPromotion(Greg.ReadPromotion, "greg@gmail.com");

            Tinex.SendPromotion();

            // Users subscribe to Vero for their promotions
            Vero.SubscribeForPromotion(Jill.ReadPromotion, "jill@gmail.com");
            Vero.SubscribeForPromotion(Greg.ReadPromotion, "greg@gmail.com");

            // This will send promotions to everyone who subscribed ( Will call the methods that were sent to the event )
            Vero.SendPromotion();

            // Jill unsubscribes because he hated the last promotion he got
            Vero.UnsubscribeForPromotion(Jill.ReadPromotion, "I don't like the promotion.");

            // Vero change their promotion
            Vero.CurrentPromotion = ProductType.Electronics;

            Vero.SendPromotion();

            // All the critics will be displayed
            Vero.ReadCritics();

            Console.ReadLine();
        }
    }
}
