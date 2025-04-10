using System.Collections;
using System.Collections.Generic;

namespace MultiEventNotificationSystem
{
    public class SubscriberCollection : IEnumerable<Subscriber>
    {
        private List<Subscriber> subscribers = new List<Subscriber>();

        public void Add(Subscriber subscriber)
        {
            subscribers.Add(subscriber);
        }

        public IEnumerator<Subscriber> GetEnumerator()
        {
            return subscribers.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
