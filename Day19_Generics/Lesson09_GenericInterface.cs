using System;
using System.Collections.Generic;

namespace Day19_Lesson09_GenericInterface
{
    interface IRepository<T>
    {
        void Add(T item);
        T Get(int index);
        int Count { get; }
    }

    class ItemStore<T> : IRepository<T>
    {
        private List<T> items = new List<T>();

        public int Count
        {
            get { return items.Count; }
        }

        public void Add(T item)
        {
            items.Add(item);
            Console.WriteLine("Stored: " + item);
        }

        public T Get(int index)
        {
            if (index < 0 || index >= items.Count)
            {
                return default(T);
            }

            return items[index];
        }
    }

    class Lesson09Runner
    {
        static void Main()
        {
            Console.WriteLine("Dark Fantasy RPG - Generic Interface");

            IRepository<string> weapons = new ItemStore<string>();
            weapons.Add("Iron Sword");
            weapons.Add("Shadow Blade");

            Console.WriteLine("Weapon count: " + weapons.Count);
            Console.WriteLine("Weapon 1: " + weapons.Get(1));

            IRepository<int> gold = new ItemStore<int>();
            gold.Add(250);

            Console.WriteLine("Gold entries: " + gold.Count);
            Console.WriteLine("Missing gold: " + gold.Get(9));
        }
    }
}