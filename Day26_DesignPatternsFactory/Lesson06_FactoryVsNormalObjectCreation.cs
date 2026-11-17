using System;

namespace Day26.Lesson06
{
    public interface IVehicle
    {
        string Describe();
    }

    public class Car : IVehicle
    {
        public string Describe()
        {
            return "Car: 4 wheels, AC, 5 seats";
        }
    }

    public class Bike : IVehicle
    {
        public string Describe()
        {
            return "Bike: 2 wheels, helmet zaroori";
        }
    }

    public class Truck : IVehicle
    {
        public string Describe()
        {
            return "Truck: 6 wheels, heavy load";
        }
    }

    public static class WithoutFactory
    {
        public static void Book(string type)
        {
            IVehicle v;
            if (type == "car") v = new Car();
            else if (type == "bike") v = new Bike();
            else v = new Truck();
            Console.WriteLine("  Booking  -> " + v.Describe());
        }

        public static void Service(string type)
        {
            IVehicle v;
            if (type == "car") v = new Car();
            else if (type == "bike") v = new Bike();
            else v = new Truck();
            Console.WriteLine("  Service  -> " + v.Describe());
        }
    }

    public static class VehicleFactory
    {
        public static IVehicle Create(string type)
        {
            switch (type)
            {
                case "car":
                    return new Car();
                case "bike":
                    return new Bike();
                case "truck":
                    return new Truck();
                default:
                    throw new ArgumentException("Unknown vehicle: " + type);
            }
        }
    }

    public static class WithFactory
    {
        public static void Book(string type)
        {
            Console.WriteLine("  Booking  -> " + VehicleFactory.Create(type).Describe());
        }

        public static void Service(string type)
        {
            Console.WriteLine("  Service  -> " + VehicleFactory.Create(type).Describe());
        }
    }

    public static class Lesson06_FactoryVsNormalObjectCreation
    {
        public static void Run()
        {
            Console.WriteLine("=== Lesson 06: Factory vs Normal Object Creation ===\n");

            Console.WriteLine("Normal creation (if/else 2 jagah duplicate):");
            WithoutFactory.Book("car");
            WithoutFactory.Service("bike");

            Console.WriteLine("\nFactory creation (logic sirf VehicleFactory me):");
            WithFactory.Book("car");
            WithFactory.Service("bike");

            Console.WriteLine("\nNaya vehicle 'Bus' add karna ho to:");
            Console.WriteLine("  Normal  : Book() aur Service() dono ka if/else badlo");
            Console.WriteLine("  Factory : sirf VehicleFactory.Create() me ek case add karo");
        }
    }
}