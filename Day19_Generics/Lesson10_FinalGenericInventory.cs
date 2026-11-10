using System;
using System.Collections.Generic;

namespace Day19_Lesson10_FinalGenericInventory
{
    interface IItem
    {
        string Name { get; }
        int Value { get; }
    }

    class Weapon : IItem
    {
        public string Name { get; private set; }
        public int Value { get; private set; }
        public int Damage { get; private set; }

        public Weapon(string name, int value, int damage)
        {
            Name = name;
            Value = value;
            Damage = damage;
        }
    }

    class Potion : IItem
    {
        public string Name { get; private set; }
        public int Value { get; private set; }
        public int Healing { get; private set; }

        public Potion(string name, int value, int healing)
        {
            Name = name;
            Value = value;
            Healing = healing;
        }
    }

    class Inventory<T> where T : class, IItem
    {
        private List<T> items = new List<T>();
        private int maxSlots;

        public Inventory(int maxSlots)
        {
            this.maxSlots = maxSlots;
        }

        public bool Add(T item)
        {
            if (item == null)
            {
                Console.WriteLine("Cannot add an empty item.");
                return false;
            }

            if (items.Count >= maxSlots)
            {
                Console.WriteLine("Inventory full! Cannot add " + item.Name);
                return false;
            }

            items.Add(item);
            Console.WriteLine("Added: " + item.Name);
            return true;
        }

        public T Get(int index)
        {
            if (index < 0 || index >= items.Count)
            {
                return default(T);
            }

            return items[index];
        }

        public int TotalValue()
        {
            int total = 0;
            foreach (T item in items)
            {
                total += item.Value;
            }
            return total;
        }
    }

    class Lesson10Runner
    {
        static void Main()
        {
            Console.WriteLine("Dark Fantasy RPG - Final Generic Inventory");

            Inventory<Weapon> weapons = new Inventory<Weapon>(2);
            weapons.Add(new Weapon("Iron Sword", 150, 25));
            weapons.Add(new Weapon("Shadow Blade", 400, 55));
            weapons.Add(new Weapon("Dragon Slayer", 900, 90));
            weapons.Add(null);

            Console.WriteLine("Weapons value: " + weapons.TotalValue() + " gold");

            Weapon first = weapons.Get(0);
            if (first != null)
            {
                Console.WriteLine("First weapon: " + first.Name + " (" + first.Damage + " damage)");
            }

            Weapon missing = weapons.Get(7);
            if (missing == null)
            {
                Console.WriteLine("Slot 7 is empty (safe).");
            }

            Inventory<Potion> potions = new Inventory<Potion>(3);
            potions.Add(new Potion("Health Potion", 50, 30));
            Console.WriteLine("Potions value: " + potions.TotalValue() + " gold");
        }
    }
}