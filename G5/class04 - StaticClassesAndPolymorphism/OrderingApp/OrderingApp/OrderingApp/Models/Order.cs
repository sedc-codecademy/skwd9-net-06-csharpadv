using OrderingApp.Enums;
using OrderingApp.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderingApp.Models
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

        public Order(int id, string title, string description, OrderStatus status)
        {
            Id = id;
            Title = title;
            Description = description;
            Status = status;
        }

        public string Print() 
        {
            return $"Title: {TextHelper.CapitalFirstLetter(Title)}, Description: {Description}";
        }
    }
}
