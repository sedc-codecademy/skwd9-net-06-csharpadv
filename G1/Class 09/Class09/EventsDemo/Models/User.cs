using System;

namespace EventsDemo.Models
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => $"{FirstName} {LastName}";
        public int Age { get; set; }
        public ProductType FavoriteProduct { get; set; }

        public User(string firstName, string lastName, int age, ProductType favoriteProduct)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            FavoriteProduct = favoriteProduct;  
        }

        //Listen for promotion
        public void ReadPromotion(ProductType type)
        {
            if (type == FavoriteProduct)
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }

            Console.WriteLine($"Mr/Ms {FullName}, The product from category {type} is on promotion");
            Console.ResetColor();
        }

        public void ReadNotification(string notification, string marketName)
        {
            Console.WriteLine($"Mr/Ms {FullName}, {marketName}: {notification}!!!!!");
        }
    }
}
