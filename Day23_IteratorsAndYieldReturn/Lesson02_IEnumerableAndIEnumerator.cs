
using System;
using System.Collections;
using System.Collections.Generic;

namespace Day23_Lesson02_IEnumerableAndIEnumerator
{
    class EnemyRunner
    {
        static void Main(string[] args)
        {
            string[] enemies =
            {
                "Skeleton",
                "Goblin",
                "Dark Knight",
                "Fire Demon"
            };

            IEnumerable<string> enemyCollection = enemies;

            IEnumerator<string> enumerator =
                enemyCollection.GetEnumerator();

            Console.WriteLine("RPG Enemy Scanner");
            Console.WriteLine();

            while (enumerator.MoveNext())
            {
                string currentEnemy = enumerator.Current;

                Console.WriteLine("Detected Enemy: " + currentEnemy);
            }

            enumerator.Dispose();

            Console.WriteLine();
            Console.WriteLine("Enemy scanning completed!");
        }
    }
}
