using System;

namespace Day13_Lesson02_InterfaceParameters
{
    public interface IDamageable
    {
        int TakeDamage(int amount);
    }

    public class Skeleton : IDamageable
    {
        private int health = 100;

        public int TakeDamage(int amount)
        {
            health = health - amount;
            Console.WriteLine("Skeleton took " + amount + " damage.");
            return health;
        }
    }

    public class Lesson02Runner
    {
        static void Main()
        {
            Skeleton skeleton = new Skeleton();

            int healthLeft = skeleton.TakeDamage(30);
            Console.WriteLine("Health left: " + healthLeft);

            healthLeft = skeleton.TakeDamage(50);
            Console.WriteLine("Health left: " + healthLeft);

            Console.ReadLine();
        }
    }
}