using System;
using System.Collections.Generic;
using System.Linq;

class InventoryArtifact
{
    public string Name { get; set; }
    public string Rarity { get; set; }
    public int Price { get; set; }
}

class LINQObjectsDemo
{
    static void Main()
    {
        List<InventoryArtifact> inventory = new List<InventoryArtifact>()
        {
            new InventoryArtifact { Name = "Iron Ring", Rarity = "Common", Price = 100 },
            new InventoryArtifact { Name = "Fire Crystal", Rarity = "Rare", Price = 500 },
            new InventoryArtifact { Name = "Dragon Heart", Rarity = "Legendary", Price = 1500 },
            new InventoryArtifact { Name = "Shadow Gem", Rarity = "Rare", Price = 800 },
            new InventoryArtifact { Name = "Wooden Shield", Rarity = "Common", Price = 200 },
            new InventoryArtifact { Name = "Dark Crown", Rarity = "Legendary", Price = 2000 }
        };

        var rareItems = inventory
            .Where(item => item.Rarity == "Rare")
            .OrderBy(item => item.Price)
            .Select(item => item.Name);

        Console.WriteLine("Rare Items Sorted by Price:");

        foreach (var item in rareItems)
        {
            Console.WriteLine(item);
        }

        var legendaryItems = inventory
            .Where(item => item.Rarity == "Legendary")
            .OrderByDescending(item => item.Price);

        Console.WriteLine("\nLegendary Items:");

        foreach (var item in legendaryItems)
        {
            Console.WriteLine(item.Name + " - " + item.Price + " Gold");
        }

        var totalItems = inventory.Count();

        Console.WriteLine("\nTotal Inventory Items: " + totalItems);
    }
}
