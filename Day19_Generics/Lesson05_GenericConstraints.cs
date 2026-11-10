using System;

namespace Day19_Lesson05_GenericConstraints
{
    class Enemy
    {
        public string Name = "Skeleton";
    }

    class Spawner<T> where T : class, new()
    {
        public T Spawn()
        {
            T creature = new T();
            Console.WriteLine("Spawned: " + creature.GetType().Name);
            return creature;
        }

        public bool IsEmpty(T item)
        {
            return item == null;
        }
    }

    class Lesson05Runner
    {
        static void Main()
        {
            Console.WriteLine("Dark Fantasy RPG - Generic Constraints");

            Spawner<Enemy> spawner = new Spawner<Enemy>();

            Enemy enemy = spawner.Spawn();
            Console.WriteLine("Enemy name: " + enemy.Name);

            Console.WriteLine("Is empty? " + spawner.IsEmpty(enemy));
            Console.WriteLine("Is empty (null)? " + spawner.IsEmpty(null));
        }
    }
}