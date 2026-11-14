
using System;
using System.Collections.Generic;

namespace Day23_Lesson07_IteratorMethodsWithParameters
{
    class EnemyRunner
    {
        static IEnumerable<string> GetUnlockedEnemies(int playerLevel)
        {
            yield return "Skeleton";

            if (playerLevel >= 10)
            {
                yield return "Dark Knight";
            }

            if (playerLevel >= 20)
            {
                yield return "Ancient Dragon";
            }

            if (playerLevel >= 30)
            {
                yield return "Demon King";
            }
        }

        static void Main(string[] args)
        {
            int playerLevel = 20;

            Console.WriteLine("Dark Fantasy RPG");
            Console.WriteLine("Player Level: " + playerLevel);
            Console.WriteLine();
            Console.WriteLine("Unlocked Enemies:");

            foreach (string enemy in GetUnlockedEnemies(playerLevel))
            {
                Console.WriteLine("Enemy: " + enemy);
            }

            Console.WriteLine();
            Console.WriteLine("Enemy unlocking completed!");
        }
    }
}
