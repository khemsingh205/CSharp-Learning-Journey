using System;

namespace Day19_Lesson06_InterfaceConstraint
{
    interface IDamageable
    {
        void TakeDamage(int amount);
    }

    class Skeleton : IDamageable
    {
        public void TakeDamage(int amount)
        {
            Console.WriteLine("Skeleton loses " + amount + " HP.");
        }
    }

    class Wall : IDamageable
    {
        public void TakeDamage(int amount)
        {
            Console.WriteLine("Wall cracks! -" + amount + " durability.");
        }
    }

    class Lesson06Runner
    {
        static void Attack<T>(T target, int damage) where T : IDamageable
        {
            Console.WriteLine("Attacking...");
            target.TakeDamage(damage);
        }

        static void Main()
        {
            Console.WriteLine("Dark Fantasy RPG - Interface Constraint");

            Attack(new Skeleton(), 20);
            Attack(new Wall(), 10);
        }
    }
}