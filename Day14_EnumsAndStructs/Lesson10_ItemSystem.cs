using System;
using System.Collections.Generic;

namespace Day14_Lesson10_ItemSystem
{
    public enum ItemType
    {
        Weapon,
        Potion,
        Armor
    }

    public enum ItemRarity
    {
        Common,
        Rare,
        Legendary
    }

    public struct Item
    {
        public string Name;
        public ItemType Type;
        public ItemRarity Rarity;
        public int BaseValue;

        public Item(string name, ItemType type, ItemRarity rarity, int baseValue)
        {
            Name = name;
            Type = type;
            Rarity = rarity;
            BaseValue = baseValue;
        }
    }

    public class Inventory
    {
        private List<Item> items = new List<Item>();

        private Dictionary<ItemRarity, int> multiplier = new Dictionary<ItemRarity, int>
        {
            { ItemRarity.Common, 1 },
            { ItemRarity.Rare, 3 },
            { ItemRarity.Legendary, 10 }
        };

        public void AddItem(Item item)
        {
            items.Add(item);
            Console.WriteLine("Picked up: " + item.Name);
        }

        public void UseItem(Item item)
        {
            switch (item.Type)
            {
                case ItemType.Weapon:
                    Console.WriteLine("Equipped weapon: " + item.Name);
                    break;
                case ItemType.Potion:
                    Console.WriteLine("Drank potion: " + item.Name);
                    break;
                case ItemType.Armor:
                    Console.WriteLine("Wore armor: " + item.Name);
                    break;
            }
        }

        public void ShowAll()
        {
            Console.WriteLine("--- Inventory ---");
            int totalValue = 0;

            foreach (Item item in items)
            {
                int price = item.BaseValue * multiplier[item.Rarity];
                Console.WriteLine(item.Name + " [" + item.Type + ", " + item.Rarity + "] sells for " + price);
                totalValue = totalValue + price;
            }

            Console.WriteLine("Total sell value: " + totalValue);
        }

        public Item GetItem(int index)
        {
            return items[index];
        }
    }

    public class Lesson10Runner
    {
        static void Main()
        {
            Inventory inventory = new Inventory();

            inventory.AddItem(new Item("Iron Sword", ItemType.Weapon, ItemRarity.Common, 10));
            inventory.AddItem(new Item("Blood Elixir", ItemType.Potion, ItemRarity.Rare, 20));
            inventory.AddItem(new Item("Dragon Plate", ItemType.Armor, ItemRarity.Legendary, 100));

            inventory.ShowAll();

            Console.WriteLine("--- Using Items ---");
            inventory.UseItem(inventory.GetItem(0));
            inventory.UseItem(inventory.GetItem(1));
            inventory.UseItem(inventory.GetItem(2));

            Console.ReadLine();
        }
    }
}