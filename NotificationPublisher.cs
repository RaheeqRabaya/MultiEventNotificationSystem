using System;

namespace MultiEventNotificationSystem
{
    public delegate void EmailNotificationHandler(string message);
    public delegate void AlertNotificationHandler(string message);
    public delegate void UpdateNotificationHandler(string message);

    public class NotificationPublisher
    {
        public event EmailNotificationHandler OnEmailNotification;
        public event AlertNotificationHandler OnAlertNotification;
        public event UpdateNotificationHandler OnUpdateNotification;

        public void SendEmail(string message)
        {
            Console.WriteLine($"[Publisher] Sending Email: {message}");
            OnEmailNotification?.Invoke(message);
        }

        public void SendAlert(string message)
        {
            Console.WriteLine($"[Publisher] Sending Alert: {message}");
            OnAlertNotification?.Invoke(message);
        }

        public void SendUpdate(string message)
        {
            Console.WriteLine($"[Publisher] Sending Update: {message}");
            OnUpdateNotification?.Invoke(message);
        }
    }
}
