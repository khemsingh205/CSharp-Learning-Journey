
using System;
using System.Collections.Generic;

namespace Day12_Lesson01_Collections
{
    class CollectionIntroductionRunner
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== DARK FANTASY RPG ===");


            List<string> weapons = new List<string>();


            weapons.Add("Iron Sword");
            weapons.Add("Dark Axe");
            weapons.Add("Shadow Blade");

            Console.WriteLine("\nPlayer Weapons:");


            foreach (string weapon in weapons)
            {
                Console.WriteLine(weapon);
            }

            Console.WriteLine("\nTotal Weapons: " + weapons.Count);

            Console.ReadLine();
        }
    }
}
