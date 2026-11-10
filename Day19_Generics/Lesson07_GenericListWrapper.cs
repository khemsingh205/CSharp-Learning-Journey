using System;
using System.Collections.Generic;

namespace Day19_Lesson07_GenericListWrapper
{
    class Inventory<T>
    {
        private List<T> items = new List<T>();
        private int maxSlots;

        public Inventory(int maxSlots)
        {
            this.maxSlots = maxSlots;
        }

        public bool Add(T item)
        {
            if (items.Count >= maxSlots)
            {
                Console.WriteLine("Inventory full! Cannot add " + item);
                return false;
            }

            items.Add(item);
            Console.WriteLine("Added: " + item);
            return true;
        }

        public void ShowAll()
        {
            Console.WriteLine("Items (" + items.Count + "/" + maxSlots + "):");
            foreach (T item in items)
            {
                Console.WriteLine("- " + item);
            }
        }
    }

    class Lesson07Runner
    {
        static void Main()
        {
            Console.WriteLine("Dark Fantasy RPG - Generic Inventory");

            Inventory<string> weapons = new Inventory<string>(2);
            weapons.Add("Iron Sword");
            weapons.Add("Shadow Blade");
            weapons.Add("Dragon Slayer");
            weapons.ShowAll();

            Inventory<int> gems = new Inventory<int>(3);
            gems.Add(10);
            gems.Add(25);
            gems.ShowAll();
        }
    }
}