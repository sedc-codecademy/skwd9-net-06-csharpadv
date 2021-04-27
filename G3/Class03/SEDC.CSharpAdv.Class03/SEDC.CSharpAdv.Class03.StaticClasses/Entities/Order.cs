using SEDC.CSharpAdv.Class03.StaticClasses.Helpers;
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

        public static void GenerateStatusMessage(Order order)
        {
            string result = string.Empty;
            switch (order.Status)
            {
                case OrderStatus.Processing:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    result = "[Processing] The order is being processed";
                    break;
                case OrderStatus.DeliveryInProgress:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    result = "[In proggress] The delivery is in proggress..";
                    break;
                case OrderStatus.Delivered:
                    Console.ForegroundColor = ConsoleColor.Green;
                    result = "[Delivered] The order is successfuly delivered";
                    break;
                case OrderStatus.CouldNotDeliver:
                    Console.ForegroundColor = ConsoleColor.Red;
                    result = "[Not delivered] There was a problem with the delivery";
                    break;
                default:
                    break;
            }
            Console.WriteLine(result);
            Console.ResetColor();
            TextHelper.MessageGenerated++;
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
