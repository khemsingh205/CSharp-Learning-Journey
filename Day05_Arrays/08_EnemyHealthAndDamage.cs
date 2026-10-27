
using System;

namespace Day05_Arrays
{
    class EnemyHealthAndDamage
    {
        static void Main(string[] args)
        {
            string[] enemyNames =
            {
                "Skeleton",
                "Goblin",
                "Orc"
            };

            int[] enemyHealth = { 100, 150, 300 };
            int[] enemyDamage = { 20, 35, 60 };

            Console.WriteLine("=== Dungeon Enemy Stats ===");

            for (int i = 0; i < enemyNames.Length; i++)
            {
                Console.WriteLine("Enemy: " + enemyNames[i]);
                Console.WriteLine("Health: " + enemyHealth[i]);
                Console.WriteLine("Damage: " + enemyDamage[i]);
                Console.WriteLine("--------------------");
            }

            Console.WriteLine("=== Player Attacks Goblin ===");

            enemyHealth[1] = enemyHealth[1] - 40;

            Console.WriteLine("Goblin Health After Attack: " + enemyHealth[1]);

            Console.ReadKey();
        }
    }
}
