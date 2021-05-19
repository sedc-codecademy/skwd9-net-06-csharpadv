using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SEDC.SubscriptionModel.Models
{
    public enum ProductType
    {
        Food = 1, 
        Drinks, 
        Cosmetics,
        Electronics, 
        Other
    }


    public class Market
    {
        public delegate void PromotionSender(ProductType product);

        public event PromotionSender PromotionHandler;


        public string Name { get; set; }
        public ProductType CurrentPromotion { get; set; }
        public List<string> ZhalbiIPoplaki { get; set; }
        public List<string> Emails { get; set; }


        public Market()
        {
            ZhalbiIPoplaki = new List<string>();
            Emails = new List<string>();
        }

        public void SendPromotion()
        {
            Console.WriteLine("---------------------------");
            Console.WriteLine($"{ Name } is sending promotion for { CurrentPromotion }");
            Console.WriteLine("Sending.....");
            Thread.Sleep(3000);
            PromotionHandler(CurrentPromotion);
        }

        public void SubcriebeForPromotions(PromotionSender subscriber, string email)
        {
            PromotionHandler += subscriber;
            Emails.Add(email);
        }

        public void UnSubcriebeForPromotions(PromotionSender subscriber, string reason)
        {
            PromotionHandler -= subscriber;
            ZhalbiIPoplaki.Add(reason);
        }

    }
}
