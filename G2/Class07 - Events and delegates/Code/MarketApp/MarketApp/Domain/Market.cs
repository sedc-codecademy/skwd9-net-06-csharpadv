using MarketApp.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Threading;

namespace MarketApp.Domain
{
    // This is a publisher class
    // This class sends messages to all objects that subscribe for getting such messages
    // In our case, its a Market and it sends promotion materials to anyone that subscried for those
    // Users can also unsubscribe so they wont get any promotions in the future
    // The email is required for marketing purposes for the Market
    // Reason is required for unsubscribing so that the market knows why people are unsubscribing
    public class Market
    {
        // Delegates are like a type of method that is allowed to be subscribed for some event
        // All methods that have that signature can be allowed as subscribers on the event
        public delegate void InformationSender(string info);
        public delegate void PromotionSender(ProductType productType);
        // These are the events and they keep track of who is subscribed to listen to some message when it is sent
        // The events use delegates to only accept methods of that delegate signature
        public event InformationSender InformationEvent;
        public event PromotionSender PromotionEvent;

        public string Name { get; set; }
        public ProductType CurrentPromotionType { get; set; }
        public List<string> Emails { get; set; }
        public List<string> Complaints { get; set; }

        public Market()
        {
            Emails = new List<string>();
            Complaints = new List<string>();
        }
        // A method that does some work
        // Thread.Sleep(3000) simulates that something is being done for 3 seconds
        public void AnnouncePromotion()
        {
            Console.WriteLine("====New promotion=====");
            Console.WriteLine($"In the market {Name} there is promotion for {CurrentPromotionType}");
            Thread.Sleep(3000);
            PromotionEvent(CurrentPromotionType);
        }
        // A method that accepts a subscriber method that must follow the PromotionSender delegate
        // It also takes the email of the subscriber
        // This subscriber expects to get a promotion each time the market sends one
        public void SubscribeForPromotion(PromotionSender subscriber, string email)
        {
            PromotionEvent += subscriber;
            Emails.Add(email);
        }

        public void UnsubscribeFromPromotion(PromotionSender unsubscriber, string reason)
        {
            PromotionEvent -= unsubscriber;
            Complaints.Add(reason);
        }

        public void SendInformation(string message)
        {
            Console.WriteLine("===Sending info..====");
            InformationEvent(message);
        }
        // A method that accepts a subscriber method that must follow the InformationSender delegate
        // It also takes the email of the subscriber
        // This subscriber expects to get only relevant information each time the market sends one
        // This is used just as an example that we can have multiple events with different delegates for different business logic
        public void SubscribeForInformation(InformationSender subscriber, string email)
        {
            InformationEvent += subscriber;
            Emails.Add(email);
        }

        public void UnsubscribeFromInformation(InformationSender unsubscriber, string reason)
        {
            InformationEvent -= unsubscriber;
            Complaints.Add(reason);
        }

    }
}
