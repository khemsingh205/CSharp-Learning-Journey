using System;
using System.Collections.Generic;

namespace Day12_Lesson10_InventorySystem
{
    public class InventorySystem
    {
        private List<string> backpack = new List<string>();
        private Dictionary<string, int> itemDamage = new Dictionary<string, int>();
        private HashSet<string> completedQuests = new HashSet<string>();

        public void Setup()
        {
            itemDamage.Add("Iron Sword", 25);
            itemDamage.Add("Cursed Bow", 30);

            backpack.Add("Iron Sword");
            backpack.Add("Health Potion");
            backpack.Add("Cursed Bow");

            completedQuests.Add("Slay the Wraith");
            completedQuests.Add("Slay the Wraith");
            completedQuests.Add("Find the Crypt Key");
        }

        public void ShowBackpack()
        {
            Console.WriteLine("--- Backpack ---");
            foreach (string item in backpack)
            {
                int damage;
                if (itemDamage.TryGetValue(item, out damage))
                {
                    Console.WriteLine(item + " (Damage: " + damage + ")");
                }
                else
                {
                    Console.WriteLine(item);
                }
            }
        }

        public void DropItem(string itemName)
        {
            if (backpack.Contains(itemName))
            {
                backpack.Remove(itemName);
                Console.WriteLine("Dropped: " + itemName);
            }
            else
            {
                Console.WriteLine("Item not found: " + itemName);
            }
        }

        public void ShowQuests()
        {
            Console.WriteLine("--- Completed Quests ---");
            Console.WriteLine("Total: " + completedQuests.Count);
            foreach (string quest in completedQuests)
            {
                Console.WriteLine("Quest: " + quest);
            }
        }
    }

    public class Lesson10Runner
    {
        static void Main()
        {
            InventorySystem inventory = new InventorySystem();
            inventory.Setup();

            inventory.ShowBackpack();
            inventory.DropItem("Health Potion");
            inventory.DropItem("Mana Potion");
            inventory.ShowBackpack();
            inventory.ShowQuests();

            Console.ReadLine();
        }
    }
}