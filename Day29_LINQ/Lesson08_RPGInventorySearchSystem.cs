using System;
using System.Collections.Generic;
using System.Linq;

class RPGInventoryItem
{
    public string Name { get; set; }
    public string Category { get; set; }
    public string Rarity { get; set; }
    public int Price { get; set; }
    public int Damage { get; set; }
}

class RPGInventorySearchSystem
{
    static void Main()
    {
        List<RPGInventoryItem> inventory = new List<RPGInventoryItem>()
        {
            new RPGInventoryItem { Name = "Iron Sword", Category = "Weapon", Rarity = "Common", Price = 100, Damage = 30 },
            new RPGInventoryItem { Name = "Fire Blade", Category = "Weapon", Rarity = "Rare", Price = 500, Damage = 80 },
            new RPGInventoryItem { Name = "Dragon Axe", Category = "Weapon", Rarity = "Legendary", Price = 1500, Damage = 120 },
            new RPGInventoryItem { Name = "Leather Armor", Category = "Armor", Rarity = "Common", Price = 200, Damage = 0 },
            new RPGInventoryItem { Name = "Shadow Shield", Category = "Armor", Rarity = "Rare", Price = 700, Damage = 0 },
            new RPGInventoryItem { Name = "Magic Ring", Category = "Accessory", Rarity = "Epic", Price = 1000, Damage = 40 },
            new RPGInventoryItem { Name = "Dragon Helmet", Category = "Armor", Rarity = "Legendary", Price = 2000, Damage = 0 }
        };

        Console.WriteLine("===== ALL INVENTORY ITEMS =====");

        foreach (var item in inventory)
        {
            Console.WriteLine(item.Name + " | " + item.Rarity + " | " + item.Price + " Gold");
        }

        Console.WriteLine("\n===== RARE ITEMS =====");

        var rareItems = inventory.Where(item => item.Rarity == "Rare");

        foreach (var item in rareItems)
        {
            Console.WriteLine(item.Name);
        }

        Console.WriteLine("\n===== ITEMS SORTED BY PRICE =====");

        var sortedItems = inventory.OrderBy(item => item.Price);

        foreach (var item in sortedItems)
        {
            Console.WriteLine(item.Name + " - " + item.Price + " Gold");
        }

        Console.WriteLine("\n===== HIGH DAMAGE ITEMS =====");

        var powerfulItems = inventory
            .Where(item => item.Damage >= 50)
            .OrderByDescending(item => item.Damage)
            .Select(item => item.Name);

        foreach (var name in powerfulItems)
        {
            Console.WriteLine(name);
        }

        Console.WriteLine("\n===== ITEM SEARCH =====");

        var searchedItem = inventory.FirstOrDefault(item => item.Name == "Dragon Axe");

        if (searchedItem != null)
        {
            Console.WriteLine("Found: " + searchedItem.Name);
            Console.WriteLine("Damage: " + searchedItem.Damage);
        }
        else
        {
            Console.WriteLine("Item Not Found");
        }

        Console.WriteLine("\n===== GROUP BY CATEGORY =====");

        var groupedItems = inventory.GroupBy(item => item.Category);

        foreach (var group in groupedItems)
        {
            Console.WriteLine("\nCategory: " + group.Key);

            foreach (var item in group)
            {
                Console.WriteLine(item.Name);
            }
        }

        Console.WriteLine("\n===== INVENTORY SUMMARY =====");

        Console.WriteLine("Total Items: " + inventory.Count());

        Console.WriteLine("Legendary Items: " +
            inventory.Count(item => item.Rarity == "Legendary"));

        Console.WriteLine("Most Expensive Item: " +
            inventory.OrderByDescending(item => item.Price).First().Name);
    }
}