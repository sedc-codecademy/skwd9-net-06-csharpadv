using System;

namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
            string ourMessage = "This is the famous message";
            Publisher publisher = new Publisher();
            FirstSubscriber firstSubscriber = new FirstSubscriber();
            SecondSubscriber secondSubscriber = new SecondSubscriber();

            publisher.MessageProcessingEvent += firstSubscriber.ProcessMessage;
            publisher.MessageProcessingEvent += secondSubscriber.GetMessage;
            publisher.MessageProcessingEvent += x =>
            {
                Console.WriteLine("Anonymous subscriber!!!");
                Console.WriteLine($"But I also got the message {x}");
            };

            publisher.ProcessData(ourMessage);
            publisher.MessageProcessingEvent -= secondSubscriber.GetMessage;
            publisher.ProcessData("New message");


            Console.ReadLine();
        }
    }
}
