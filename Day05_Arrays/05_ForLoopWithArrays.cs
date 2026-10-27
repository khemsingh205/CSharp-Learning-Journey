
using System;

namespace Day05_Arrays
{
    class ForLoopWithArrays
    {
        static void Main(string[] args)
        {
            string[] enemyNames =
            {
                "Skeleton",
                "Goblin",
                "Orc",
                "Dark Knight"
            };

            int[] enemyHealth = { 80, 120, 250, 400 };

            Console.WriteLine("=== Dungeon Enemy List ===");

            for (int i = 0; i < enemyHealth.Length; i++)
            {
                Console.WriteLine(
                    enemyNames[i] + " Health: " + enemyHealth[i]);
            }

            Console.ReadKey();
        }
    }
}
