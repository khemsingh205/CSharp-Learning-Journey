
using System;

namespace Day05_Arrays
{
    class ArrayLength
    {
        static void Main(string[] args)
        {
            int[] enemyHealth = { 80, 120, 250, 400 };

            Console.WriteLine("=== Dungeon Enemy Information ===");

            Console.WriteLine("First Enemy Health: " + enemyHealth[0]);

            Console.WriteLine("Total Enemies: " + enemyHealth.Length);

            Console.WriteLine("Last Enemy Health: " + enemyHealth[enemyHealth.Length - 1]);

            Console.ReadKey();
        }
    }
}
