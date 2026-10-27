
using System;

namespace Day05_Arrays
{
    class ForeachLoopWithArrays
    {
        static void Main(string[] args)
        {
            int[] enemyHealth = { 80, 120, 250, 400 };

            Console.WriteLine("=== Dungeon Enemy Health ===");

            foreach (int health in enemyHealth)
            {
                Console.WriteLine("Enemy Health: " + health);
            }

            Console.ReadKey();
        }
    }
}
