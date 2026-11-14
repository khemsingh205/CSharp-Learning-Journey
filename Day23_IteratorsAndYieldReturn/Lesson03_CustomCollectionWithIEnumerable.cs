
using System;
using System.Collections;
using System.Collections.Generic;

namespace Day23_Lesson03_CustomCollectionWithIEnumerable
{
    class EnemyCollection : IEnumerable<string>
    {
        private List<string> enemies = new List<string>();

        public void AddEnemy(string enemy)
        {
            enemies.Add(enemy);
        }

        public IEnumerator<string> GetEnumerator()
        {
            return enemies.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    class EnemyRunner
    {
        static void Main(string[] args)
        {
            EnemyCollection enemies = new EnemyCollection();

            enemies.AddEnemy("Skeleton");
            enemies.AddEnemy("Goblin");
            enemies.AddEnemy("Dark Knight");
            enemies.AddEnemy("Fire Demon");

            Console.WriteLine("Dark Fantasy RPG");
            Console.WriteLine("Custom Enemy Collection:");
            Console.WriteLine();

            foreach (string enemy in enemies)
            {
                Console.WriteLine("Enemy Found: " + enemy);
            }

            Console.WriteLine();
            Console.WriteLine("Enemy collection scanned!");
        }
    }
}
