
using System;

namespace Day05_Arrays
{
    class ArrayInitialization
    {
        static void Main(string[] args)
        {
            // Declaration
            int[] enemyHealth;

            // Initialization
            enemyHealth = new int[] { 80, 120, 250, 400 };

            Console.WriteLine("=== Dark Dungeon Enemy Health ===");

            Console.WriteLine("Skeleton Health: " + enemyHealth[0]);
            Console.WriteLine("Goblin Health: " + enemyHealth[1]);
            Console.WriteLine("Orc Health: " + enemyHealth[2]);
            Console.WriteLine("Dark Knight Health: " + enemyHealth[3]);

            Console.ReadKey();
        }
    }
}
