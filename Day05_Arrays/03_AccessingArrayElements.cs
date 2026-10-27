
using System;

namespace Day05_Arrays
{
    class AccessingArrayElements
    {
        static void Main(string[] args)
        {
            int[] enemyHealth = { 80, 120, 250, 400 };

            Console.WriteLine("=== Dungeon Enemy Health ===");

            Console.WriteLine("First Enemy: " + enemyHealth[0]);
            Console.WriteLine("Second Enemy: " + enemyHealth[1]);
            Console.WriteLine("Third Enemy: " + enemyHealth[2]);
            Console.WriteLine("Fourth Enemy: " + enemyHealth[3]);

            Console.WriteLine();
            Console.WriteLine("Orc Health: " + enemyHealth[2]);

            Console.ReadKey();
        }
    }
}
