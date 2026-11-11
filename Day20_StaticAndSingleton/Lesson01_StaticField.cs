using System;

namespace Day20_Lesson01_StaticField
{
    class Enemy
    {
        public static int TotalEnemies = 0;

        public string Name;

        public Enemy(string name)
        {
            Name = name;
            TotalEnemies++;
            Console.WriteLine("Enemy spawned: " + Name);
        }
    }

    class Lesson01Runner
    {
        static void Main()
        {
            Console.WriteLine("Dark Fantasy RPG - Static Field");

            Enemy skeleton = new Enemy("Skeleton");
            Enemy goblin = new Enemy("Goblin");
            Enemy wraith = new Enemy("Wraith");

            Console.WriteLine("Total enemies: " + Enemy.TotalEnemies);
        }
    }
}