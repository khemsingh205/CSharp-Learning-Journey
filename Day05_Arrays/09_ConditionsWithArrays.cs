
using System;

namespace Day05_Arrays
{
    class ConditionsWithArrays
    {
        static void Main(string[] args)
        {
            string[] enemyNames =
            {
                "Skeleton",
                "Goblin",
                "Orc"
            };

            int[] enemyHealth = { 100, 0, 300 };

            Console.WriteLine("=== Dungeon Enemy Status ===");

            for (int i = 0; i < enemyHealth.Length; i++)
            {
                Console.WriteLine("Enemy: " + enemyNames[i]);
                Console.WriteLine("Health: " + enemyHealth[i]);

                if (enemyHealth[i] > 0)
                {
                    Console.WriteLine("Status: Alive");
                }
                else
                {
                    Console.WriteLine("Status: Dead");
                }

                Console.WriteLine("--------------------");
            }

            Console.ReadKey();
        }
    }
}
