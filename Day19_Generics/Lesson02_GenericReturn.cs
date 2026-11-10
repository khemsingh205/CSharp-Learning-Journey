using System;

namespace Day19_Lesson02_GenericReturn
{
    class Lesson02Runner
    {
        static T GetStronger<T>(T first, T second) where T : IComparable<T>
        {
            if (first.CompareTo(second) >= 0)
            {
                return first;
            }

            return second;
        }

        static void Main()
        {
            Console.WriteLine("Dark Fantasy RPG - Generic Return");

            int strongerDamage = GetStronger(25, 40);
            Console.WriteLine("Stronger damage: " + strongerDamage);

            double heavierWeight = GetStronger(3.5, 1.2);
            Console.WriteLine("Heavier weight: " + heavierWeight);

            string lastName = GetStronger("Iron Sword", "Shadow Blade");
            Console.WriteLine("Later in alphabet: " + lastName);
        }
    }
}