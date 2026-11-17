using System;

namespace Day26.Lesson05
{
    public interface ITransport
    {
        string Name { get; }
        int SpeedKmh { get; }
        void Deliver(string cargo, int distanceKm);
    }

    public class Truck : ITransport
    {
        public string Name { get { return "Truck"; } }
        public int SpeedKmh { get { return 60; } }

        public void Deliver(string cargo, int distanceKm)
        {
            Console.WriteLine("  Truck ne '" + cargo + "' sadak se " + distanceKm + " km pahunchaya");
        }
    }

    public class Ship : ITransport
    {
        public string Name { get { return "Ship"; } }
        public int SpeedKmh { get { return 30; } }

        public void Deliver(string cargo, int distanceKm)
        {
            Console.WriteLine("  Ship ne '" + cargo + "' samundar se " + distanceKm + " km pahunchaya");
        }
    }

    public class Plane : ITransport
    {
        public string Name { get { return "Plane"; } }
        public int SpeedKmh { get { return 800; } }

        public void Deliver(string cargo, int distanceKm)
        {
            Console.WriteLine("  Plane ne '" + cargo + "' hawa se " + distanceKm + " km pahunchaya");
        }
    }

    public abstract class Logistics
    {
        protected abstract ITransport CreateTransport();

        public void PlanDelivery(string cargo, int distanceKm)
        {
            ITransport transport = CreateTransport();
            double hours = (double)distanceKm / transport.SpeedKmh;

            Console.WriteLine("Plan: " + cargo + " -> " + distanceKm + " km via " + transport.Name +
                              " (~" + hours.ToString("F1") + " ghante)");
            transport.Deliver(cargo, distanceKm);
        }
    }

    public class RoadLogistics : Logistics
    {
        protected override ITransport CreateTransport()
        {
            return new Truck();
        }
    }

    public class SeaLogistics : Logistics
    {
        protected override ITransport CreateTransport()
        {
            return new Ship();
        }
    }

    public class AirLogistics : Logistics
    {
        protected override ITransport CreateTransport()
        {
            return new Plane();
        }
    }

    public static class Lesson05_FactoryWithInheritance
    {
        public static void Run()
        {
            Console.WriteLine("=== Lesson 05: Factory With Inheritance ===\n");

            Logistics[] companies =
            {
                new RoadLogistics(),
                new SeaLogistics(),
                new AirLogistics()
            };

            foreach (Logistics company in companies)
            {
                company.PlanDelivery("Laptops", 1200);
                Console.WriteLine();
            }
        }
    }
}