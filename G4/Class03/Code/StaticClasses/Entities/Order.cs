using System;
using System.Collections.Generic;
using System.Text;

namespace StaticClasses.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public OrderStatus Status { get; set; }

        public Order()
        {
            Status = OrderStatus.Processing;
        }
        public Order(int id, string title, string desc, OrderStatus status)
        {
            Id = id;
            Title = title;
            Description = desc;
            Status = status;
        }
        public string Print()
        {
            // use of a method from a static class (no instance, only name of class and with dot notation we use members)
            return $"{TextHelper.CapitalFirstLetter(Title)} - {Description}";
        }
    }
}
