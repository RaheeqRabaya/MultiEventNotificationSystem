using System;

namespace MultiEventNotificationSystem
{
    public class Subscriber
    {
        public string Name { get; }

        public Subscriber(string name)
        {
            Name = name;
        }

        public void ReceiveEmail(string message)
        {
            Console.WriteLine($"[Subscriber: {Name}] Received EMAIL: {message}");
        }

        public void ReceiveAlert(string message)
        {
            Console.WriteLine($"[Subscriber: {Name}] Received ALERT: {message}");
        }

        public void ReceiveUpdate(string message)
        {
            Console.WriteLine($"[Subscriber: {Name}] Received UPDATE: {message}");
        }
    }
}
