using System;
using System.Collections.Generic;
using System.Text;

namespace Events.Entities
{
    // This is a subscriber class

    // It can subscribe to publishers and can get info every time the publisher decides to send some info to all subscribers
    // This subscriber class is representing a user that has the ability to subscribe for promotions
    public class User
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public ProductType FavouriteType { get; set; }

        // A method that can read a promotion and get excited if that is the favorite type of this person
        public void ReadPromotion(ProductType product) 
        {
            Console.WriteLine($"Mr/Ms: {Name}, The product {product} is on sale");
            if (product == FavouriteType) 
            {
                Console.WriteLine("MY FAVOURITE!");
            }
        }
    }
}
