using System;

namespace Day15_Lesson02_TryAndCatch
{
    class Lesson02Runner
    {
        static void Main()
        {
            Console.WriteLine("Dark Fantasy RPG - Damage Calculator");

            int totalDamage = 100;
            int attackers = 0;

            try
            {
                Console.WriteLine("Calculating damage per attacker...");
                int damageEach = totalDamage / attackers;
                Console.WriteLine("Damage each: " + damageEach);
            }
            catch (Exception)
            {
                Console.WriteLine("Error caught! No attackers found.");
            }

            Console.WriteLine("The game keeps running!");
        }
    }
}