using System;
using System.Collections.Generic;

namespace Day20_Lesson06_StaticConstructor
{
    class LootTable
    {
        private static Dictionary<string, int> prices;

        static LootTable()
        {
            Console.WriteLine("Static constructor: loading prices...");
            prices = new Dictionary<string, int>();
            prices.Add("Iron Sword", 150);
            prices.Add("Health Potion", 50);
        }

        public static int GetPrice(string item)
        {
            int price;

            if (prices.TryGetValue(item, out price))
            {
                return price;
            }

            return 0;
        }
    }

    class Lesson06Runner
    {
        static void Main()
        {
            Console.WriteLine("Dark Fantasy RPG - Static Constructor");
            Console.WriteLine("Before first use of LootTable.");

            Console.WriteLine("Iron Sword: " + LootTable.GetPrice("Iron Sword"));
            Console.WriteLine("Health Potion: " + LootTable.GetPrice("Health Potion"));
            Console.WriteLine("Dragon Armor: " + LootTable.GetPrice("Dragon Armor"));
        }
    }
}