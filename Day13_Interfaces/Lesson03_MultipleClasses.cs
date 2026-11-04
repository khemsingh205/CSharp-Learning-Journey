using System;

namespace Day13_Lesson03_MultipleClasses
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
            int reduced = amount - 10;
            Console.WriteLine("Knight armor blocks 10. Knight takes " + reduced + " damage.");
        }
    }

    public class Lesson03Runner
    {
        static void Main()
        {
            Skeleton skeleton = new Skeleton();
            Knight knight = new Knight();

            skeleton.TakeDamage(30);
            knight.TakeDamage(30);

            Console.ReadLine();
        }
    }
}