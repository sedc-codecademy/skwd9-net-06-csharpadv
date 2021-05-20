using System;

namespace RestaurantApp.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }

        public Order(string name, int price)
        {
            Random rnd = new Random();
            Id = rnd.Next(1, int.MaxValue);
            Name = name;
            Price = price;
        }
    }
}
