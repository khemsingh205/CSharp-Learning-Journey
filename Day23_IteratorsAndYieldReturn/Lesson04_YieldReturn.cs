
using System;
using System.Collections.Generic;

namespace Day23_Lesson04_YieldReturn
{
    class EnemyRunner
    {
        static IEnumerable<string> GetBossEnemies()
        {
            yield return "Skeleton Warrior";
            yield return "Goblin Assassin";
            yield return "Dark Knight";
            yield return "Ancient Dragon";
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Dark Fantasy RPG");
            Console.WriteLine("Boss Enemy Sequence:");
            Console.WriteLine();

            foreach (string enemy in GetBossEnemies())
            {
                Console.WriteLine("Enemy Spawned: " + enemy);
            }

            Console.WriteLine();
            Console.WriteLine("All enemies spawned!");
        }
    }
}
