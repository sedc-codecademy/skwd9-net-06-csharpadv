using System;
using System.Threading;

namespace Events
{
    public class Publisher
    {
        public delegate void MessageProcessingDelegate(string message);
        public event MessageProcessingDelegate MessageProcessingEvent;

        public void ProcessData(string message)
        {
            Console.WriteLine("Processing data..");
            Thread.Sleep(3000); //simulate that data processing takes time
            DataProcessingFinished(message);
        }

        public void DataProcessingFinished(string message)
        {
            if(MessageProcessingEvent != null)
            {
                MessageProcessingEvent(message); //event firing
            }
        }
    }
}
