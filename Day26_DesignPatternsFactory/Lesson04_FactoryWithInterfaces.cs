using System;

namespace Day26.Lesson04
{
    public interface ILogger
    {
        void Log(string message);
    }

    public class ConsoleLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine("  [Console] " + message);
        }
    }

    public class FileLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine("  [File] log.txt me likha gaya: " + message);
        }
    }

    public class DatabaseLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine("  [Database] Logs table me save hua: " + message);
        }
    }

    public enum LoggerType
    {
        Console,
        File,
        Database
    }

    public class LoggerFactory
    {
        public static ILogger Create(LoggerType type)
        {
            switch (type)
            {
                case LoggerType.Console:
                    return new ConsoleLogger();
                case LoggerType.File:
                    return new FileLogger();
                case LoggerType.Database:
                    return new DatabaseLogger();
                default:
                    throw new ArgumentException("Unknown logger type");
            }
        }
    }

    public class OrderService
    {
        private readonly ILogger _logger;

        public OrderService(ILogger logger)
        {
            _logger = logger;
        }

        public void PlaceOrder(string item)
        {
            _logger.Log("Order place hua: " + item);
        }
    }

    public static class Lesson04_FactoryWithInterfaces
    {
        public static void Run()
        {
            Console.WriteLine("=== Lesson 04: Factory With Interfaces ===\n");

            LoggerType[] types = { LoggerType.Console, LoggerType.File, LoggerType.Database };

            foreach (LoggerType type in types)
            {
                ILogger logger = LoggerFactory.Create(type);
                OrderService service = new OrderService(logger);
                service.PlaceOrder("Magic Sword");
            }
        }
    }
}