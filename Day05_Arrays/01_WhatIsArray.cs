
using System;

namespace Day05_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] enemyHealth = { 100, 150, 300 };

            Console.WriteLine("=== Dark Dungeon Enemies ===");

            Console.WriteLine("Skeleton Health: " + enemyHealth[0]);
            Console.WriteLine("Goblin Health: " + enemyHealth[1]);
            Console.WriteLine("Dark Knight Health: " + enemyHealth[2]);

            Console.ReadKey();
        }
    }
}
