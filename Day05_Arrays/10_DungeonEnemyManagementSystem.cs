
using System;

namespace Day05_Arrays
{
    class DungeonEnemyManagementSystem
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

            int[] enemyHealth = { 100, 150, 300, 500 };
            int[] enemyDamage = { 20, 35, 60, 90 };

            Console.WriteLine("================================");
            Console.WriteLine("   DUNGEON ENEMY MANAGEMENT");
            Console.WriteLine("================================");

            for (int i = 0; i < enemyNames.Length; i++)
            {
                Console.WriteLine();
                Console.WriteLine("Enemy: " + enemyNames[i]);
                Console.WriteLine("Health: " + enemyHealth[i]);
                Console.WriteLine("Damage: " + enemyDamage[i]);

                if (enemyHealth[i] > 0)
                {
                    Console.WriteLine("Status: Alive");
                }
                else
                {
                    Console.WriteLine("Status: Dead");
                }
            }

            Console.WriteLine();
            Console.WriteLine("================================");
            Console.WriteLine("       PLAYER ATTACK");
            Console.WriteLine("================================");

            int targetIndex = 1;
            int playerDamage = 50;

            Console.WriteLine("Target: " + enemyNames[targetIndex]);
            Console.WriteLine("Player Damage: " + playerDamage);

            enemyHealth[targetIndex] =
                enemyHealth[targetIndex] - playerDamage;

            if (enemyHealth[targetIndex] < 0)
            {
                enemyHealth[targetIndex] = 0;
            }

            Console.WriteLine(
                "Remaining Health: " + enemyHealth[targetIndex]);

            if (enemyHealth[targetIndex] > 0)
            {
                Console.WriteLine("Status: Enemy Survived");
            }
            else
            {
                Console.WriteLine("Status: Enemy Defeated!");
            }

            Console.WriteLine();
            Console.WriteLine("================================");
            Console.WriteLine("      UPDATED ENEMY STATUS");
            Console.WriteLine("================================");

            for (int i = 0; i < enemyNames.Length; i++)
            {
                Console.WriteLine(
                    enemyNames[i] + " - Health: " + enemyHealth[i]);
            }

            Console.WriteLine();
            Console.WriteLine("Dungeon check complete!");

            Console.ReadKey();
        }
    }
}
