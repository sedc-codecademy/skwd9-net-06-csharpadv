using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.CSharpAdv.Class03.StaticClasses.Entities
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

        public Order(int id, string title, string desc, OrderStatus orderStatus)
        {
            Id = id;
            Title = title;
            Description = desc;
            Status = orderStatus;
        }

        public string Print()
        {
            return $"{Title} - ({Description})";
        }
    }

    public enum OrderStatus
    {
        Processing,
        DeliveryInProgress,
        Delivered,
        CouldNotDeliver
    }
}
