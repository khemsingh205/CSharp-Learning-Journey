using System;

namespace Day26.Lesson02
{
    public interface INotification
    {
        void Send(string message);
    }

    public class EmailNotification : INotification
    {
        public void Send(string message) => Console.WriteLine($"  [EMAIL] {message}");
    }

    public class SmsNotification : INotification
    {
        public void Send(string message) => Console.WriteLine($"  [SMS] {message}");
    }

    public class PushNotification : INotification
    {
        public void Send(string message) => Console.WriteLine($"  [PUSH] {message}");
    }

    public static class BadClient
    {
        public static void Notify(string type, string message)
        {
            INotification notification;

            if (type == "email") notification = new EmailNotification();
            else if (type == "sms") notification = new SmsNotification();
            else if (type == "push") notification = new PushNotification();
            else throw new ArgumentException("Unknown type");

            notification.Send(message);
        }
    }

    public class NotificationFactory
    {
        public INotification Create(string type)
        {
            switch (type.ToLower())
            {
                case "email": return new EmailNotification();
                case "sms": return new SmsNotification();
                case "push": return new PushNotification();
                default: throw new ArgumentException($"Unknown notification type: {type}");
            }
        }
    }

    public static class GoodClient
    {
        public static void Notify(NotificationFactory factory, string type, string message)
        {
            INotification notification = factory.Create(type);
            notification.Send(message);
        }
    }

    public static class Lesson02_UnderstandingFactoryPattern
    {
        public static void Run()
        {
            Console.WriteLine("=== Lesson 02: Understanding Factory Pattern ===\n");

            Console.WriteLine("BAD approach (client khud if/else karke object banata hai):");
            BadClient.Notify("email", "Welcome to the game!");

            Console.WriteLine("\nGOOD approach (Factory use karke):");
            var factory = new NotificationFactory();
            GoodClient.Notify(factory, "email", "Welcome to the game!");
            GoodClient.Notify(factory, "sms", "Your OTP is 4821");
            GoodClient.Notify(factory, "push", "New quest unlocked");

            Console.WriteLine("\nInvalid type ka test:");
            try
            {
                GoodClient.Notify(factory, "pigeon", "Hello");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"  Error pakda gaya: {ex.Message}");
            }

            Console.WriteLine("\nYaad rakho: Client -> Factory -> Product (interface).");
        }
    }
}