using System;

namespace Day15_Lesson01_IntroToExceptions
{
    class Lesson01Runner
    {
        static void Main()
        {
            Console.WriteLine("Dark Fantasy RPG - Damage Calculator");

            int totalDamage = 100;
            int attackers = 0;

            Console.WriteLine("Calculating damage per attacker...");
            int damageEach = totalDamage / attackers;

            Console.WriteLine("Damage each: " + damageEach);
            Console.WriteLine("Will the program reach this line?");
        }
    }
}