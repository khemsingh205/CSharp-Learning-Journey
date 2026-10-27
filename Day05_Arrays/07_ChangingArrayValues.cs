
using System;

namespace Day05_Arrays
{
    class ChangingArrayValues
    {
        static void Main(string[] args)
        {
            int[] enemyHealth = { 80, 120, 250, 400 };

            Console.WriteLine("=== Dungeon Combat ===");

            Console.WriteLine("Goblin Health Before Attack: " + enemyHealth[1]);

            enemyHealth[1] = enemyHealth[1] - 30;

            Console.WriteLine("Goblin Health After Attack: " + enemyHealth[1]);

            Console.ReadKey();
        }
    }
}
