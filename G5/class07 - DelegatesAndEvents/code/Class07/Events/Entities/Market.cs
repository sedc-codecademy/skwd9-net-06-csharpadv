using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Events.Entities
{
    // This is a publisher class

    // This class sends messages to all objects that subscribe for getting such messages
    // In our case, its a Market and it sends promotion materials to anyone that subscried for those
    // Users can also unsubscribe so they wont get any promotions in the future
    // The email is required for marketing purposes for the Market
    // Reason is required for unsubscribing so that the market knows why people are unsubscribing
    public class Market
    {
        // 1. Define a delegate
        // 2. Define a event based on that delegeate
        // 3. Trigger the even

        // Delegates are like a type of method that is allowed to be subscribed for some event 
        // All methods that has that signature can be allowed as subscribers on the event
        public delegate void PromotionSender(ProductType product);

        // These are the events and they keep track of who is subscribed to listen to some message when it is sent
        // The events use delegates to only accept methods of that delegate signature
        public event PromotionSender Promotions;

        public string Name { get; set; }
        public ProductType CurrentPromotion { get; set; }
        public List<string> Emails { get; set; }
        public List<string> Critics { get; set; }

        public Market()
        {
            Emails = new List<string>();
            Critics = new List<string>();
        }

        // A method that does some work
        // Thread.Sleep(3000) simulates that something is being done for 3 seconds
        public void SendPromotion() 
        {
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine($"{Name} is sending a promotion for {CurrentPromotion}");
            Console.WriteLine($"...Sending");
            Console.WriteLine("------------------------------------------------------");
            Thread.Sleep(3000);

            Send();
        }

        // The event is executed here, informing all the methods that subscribed with some value ( currentPromotion in our case )
        private void Send() 
        {
            Promotions(CurrentPromotion);
        }

        // A method that accepts a subscriber method that must follow the PromotionSender delegate
        // It also takes the email of the subscriber
        // This subscriber expects to get a promotion each time the market sends one
        public void SubscribeForPromotion(PromotionSender subscriber, string email) 
        {
            Promotions += subscriber;
            Emails.Add(email);
        }

        // A method that removes a subscriber method from the Promotions event 
        // It also requires a reason so it can be saved in ZalbiIPoplaki as feedback
        // This subscriber expects to not get any promotions when the market sends some in the future
        public void UnsubscribeForPromotion(PromotionSender unsubscriber, string reason) 
        {
            Promotions -= unsubscriber;
            Critics.Add(reason);
        }

        public void ReadCritics()
        {
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine($"[{Name}] Critics:");
            foreach (string critic in Critics)
            {
                Console.WriteLine(critic);
            }
        }
    }

    public enum ProductType 
    {
        Food, 
        Cosmetics,
        Electronics,
        Other
    }
}
