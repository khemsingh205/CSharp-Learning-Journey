using System;
using System.Collections.Generic;
using System.Linq;

namespace Day18_Lesson01_IntroToLinq
{
    class Lesson01Runner
    {
        static void Main()
        {
            Console.WriteLine("Dark Fantasy RPG - Strong Attacks");

            List<int> damages = new List<int> { 10, 45, 30, 60, 5 };

            var strongAttacks = damages.Where(d => d >= 30);

            foreach (int damage in strongAttacks)
            {
                Console.WriteLine("Strong attack: " + damage);
            }
        }
    }
}