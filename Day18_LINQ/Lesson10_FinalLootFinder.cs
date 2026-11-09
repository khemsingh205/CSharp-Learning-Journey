using System;
using System.Collections.Generic;
using System.Linq;

namespace Day18_Lesson10_FinalLootFinder
{
    class LootItem
    {
        public string Name;
        public string Rarity;
        public int Value;

        public LootItem(string name, string rarity, int value)
        {
            Name = name;
            Rarity = rarity;
            Value = value;
        }
    }

    class Lesson10Runner
    {
        static void Main()
        {
            Console.WriteLine("Dark Fantasy RPG - Loot Finder");

            List<LootItem> loot = new List<LootItem>
            {
                new LootItem("Bone Fragment", "Common", 5),
                new LootItem("Cursed Ring", "Rare", 300),
                new LootItem("Dragon Scale", "Legendary", 900),
                new LootItem("Iron Ore", "Common", 20),
                new LootItem("Shadow Gem", "Rare", 450)
            };

            Console.WriteLine("Total loot: " + loot.Count());
            Console.WriteLine("Total value: " + loot.Sum(l => l.Value) + " gold");

            if (loot.Any(l => l.Rarity == "Legendary"))
            {
                Console.WriteLine("Legendary drop found!");
            }

            List<LootItem> rareLoot = loot
                .Where(l => l.Rarity != "Common")
                .OrderByDescending(l => l.Value)
                .ToList();

            Console.WriteLine("Valuable loot:");
            foreach (LootItem item in rareLoot)
            {
                Console.WriteLine("- " + item.Name + " (" + item.Rarity + ", " + item.Value + " gold)");
            }

            LootItem sellable = loot.FirstOrDefault(l => l.Value >= 1000);

            if (sellable != null)
            {
                Console.WriteLine("Jackpot: " + sellable.Name);
            }
            else
            {
                Console.WriteLine("No item worth 1000+ gold.");
            }

            if (loot.Any())
            {
                Console.WriteLine("Best item value: " + loot.Max(l => l.Value));
            }

            var names = loot.Where(l => l.Rarity == "Common").Select(l => l.Name);
            Console.WriteLine("Junk to sell: " + string.Join(", ", names));
        }
    }
}