using System;
using System.Collections.Generic;

namespace Day19_Lesson08_DefaultAndNullSafety
{
    class Inventory<T>
    {
        private List<T> items = new List<T>();

        public void Add(T item)
        {
            items.Add(item);
        }

        public T GetItem(int index)
        {
            if (index < 0 || index >= items.Count)
            {
                Console.WriteLine("Slot " + index + " does not exist.");
                return default(T);
            }

            return items[index];
        }
    }

    class Lesson08Runner
    {
        static void Main()
        {
            Console.WriteLine("Dark Fantasy RPG - default(T)");

            Inventory<string> weapons = new Inventory<string>();
            weapons.Add("Iron Sword");

            string found = weapons.GetItem(0);
            Console.WriteLine("Found: " + found);

            string missing = weapons.GetItem(5);

            if (missing == null)
            {
                Console.WriteLine("Result is null (safe).");
            }

            Inventory<int> gold = new Inventory<int>();
            gold.Add(250);

            int missingGold = gold.GetItem(3);
            Console.WriteLine("Missing gold default: " + missingGold);
        }
    }
}