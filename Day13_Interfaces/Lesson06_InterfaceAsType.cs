using System;
using System.Collections.Generic;

namespace Day13_Lesson06_InterfaceAsType
{
    public interface IDamageable
    {
        void TakeDamage(int amount);
    }

    public class Skeleton : IDamageable
    {
        public void TakeDamage(int amount)
        {
            Console.WriteLine("Skeleton takes " + amount + " damage.");
        }
    }

    public class Knight : IDamageable
    {
        public void TakeDamage(int amount)
        {
            Console.WriteLine("Knight armor blocks 10. Takes " + (amount - 10) + " damage.");
        }
    }

    public class Lesson06Runner
    {
        static void Main()
        {
            List<IDamageable> targets = new List<IDamageable>();
            targets.Add(new Skeleton());
            targets.Add(new Knight());

            foreach (IDamageable target in targets)
            {
                target.TakeDamage(30);
            }

            Console.ReadLine();
        }
    }
}