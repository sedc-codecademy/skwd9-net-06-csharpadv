using System;
using System.Collections.Generic;

namespace EventsDemo.Models
{
    public class Market
    {
        public delegate void PromotionDelegate(ProductType productType);

        public delegate void NotificationDelegate(string message, string marketName);

        private event PromotionDelegate Promotions;
        private event NotificationDelegate Notifications;

        public string Name { get; set; }
        public ProductType CurrentPromotion { get; set; }
        public List<string> Emails { get; set; }
        public List<string> Complaints { get; set; }

        public Market(string name)
        {
            Name = name;
            Emails = new List<string>();
            Complaints = new List<string>();
        }

        public void SubscribeForPromotion(string email, PromotionDelegate subscriber)
        {
            Promotions += subscriber;
            Emails.Add(email);
        }

        public void UnsubscribeForPromotion(string complaint, PromotionDelegate unsubscribe)
        {
            Promotions -= unsubscribe;
            Complaints.Add(complaint);
        }

        public void SubscribeForNotifications(NotificationDelegate subscribe)
        {
            Notifications += subscribe;
        }

        public void UnsubscribeForNotifications(NotificationDelegate unsubscribe)
        {
            Notifications -= unsubscribe;
        }

        public void PrintAllComplaints()
        {
            Console.WriteLine("------------------------------------");
            Console.WriteLine($"Complaints for {Name}:");
            foreach (string c in Complaints)
            {
                Console.WriteLine(c);
            }
        }

        public void SendPromotion(ProductType promotion)
        {
            CurrentPromotion = promotion;
            Console.WriteLine("------------------------------------");
            Console.WriteLine($"{Name} is sending a promotion for {CurrentPromotion}");

            if (Promotions != null)
            {
                Promotions(CurrentPromotion);
            }

            //Promotions?.Invoke(CurrentPromotion);
        }

        public void SendNotification(string notification)
        {
            Console.WriteLine("------------------------------------");
            Console.WriteLine($"{Name} is sending a notification");

            if (Notifications != null)
            {
                Notifications(notification, Name);
            }
        }
    }
}
