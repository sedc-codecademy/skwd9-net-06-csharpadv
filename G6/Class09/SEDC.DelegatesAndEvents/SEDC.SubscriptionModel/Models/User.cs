using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.SubscriptionModel.Models
{
    // This is a subscriber class
    public class User
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public ProductType FavouriteType { get; set; }


        public void ReadPromotion(ProductType product)
        {
            Console.WriteLine($"Mr/Ms: { Name }, the product { product } is on sale Take it with 10% discount!");
            if(product == FavouriteType)
                Console.WriteLine("Your favourite type is on sale now with 10% discount!!!");
        }

    }
}
