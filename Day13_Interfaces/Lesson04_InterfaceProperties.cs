using System;

namespace Day13_Lesson04_InterfaceProperties
{
    public interface IDamageable
    {
        string Name { get; }
        int Health { get; set; }
    }

    public class Skeleton : IDamageable
    {
        public string Name { get; private set; }
        public int Health { get; set; }

        public Skeleton()
        {
            Name = "Skeleton";
            Health = 100;
        }
    }

    public class Lesson04Runner
    {
        static void Main()
        {
            Skeleton skeleton = new Skeleton();

            Console.WriteLine(skeleton.Name + " health: " + skeleton.Health);

            skeleton.Health = skeleton.Health - 40;
            Console.WriteLine(skeleton.Name + " health: " + skeleton.Health);

            Console.ReadLine();
        }
    }
}