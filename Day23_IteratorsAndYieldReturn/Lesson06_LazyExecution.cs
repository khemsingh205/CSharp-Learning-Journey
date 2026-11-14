
using System;
using System.Collections.Generic;

namespace Day23_Lesson06_LazyExecution
{
    class EnemyRunner
    {
        static IEnumerable<string> GetEnemies()
        {
            Console.WriteLine("Enemy iterator started");

            yield return "Skeleton";
            Console.WriteLine("First enemy processed");

            yield return "Goblin";
            Console.WriteLine("Second enemy processed");

            yield return "Dark Knight";
            Console.WriteLine("Third enemy processed");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Dark Fantasy RPG");
            Console.WriteLine();

            IEnumerable<string> enemies = GetEnemies();

            Console.WriteLine("Iterator method called");
            Console.WriteLine();

            foreach (string enemy in enemies)
            {
                Console.WriteLine("Enemy Found: " + enemy);
            }

            Console.WriteLine();
            Console.WriteLine("Enemy scanning completed!");
        }
    }
}
