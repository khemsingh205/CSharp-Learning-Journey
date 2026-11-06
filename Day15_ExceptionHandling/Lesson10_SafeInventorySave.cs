using System;
using System.Collections.Generic;

namespace Day15_Lesson10_SafeInventorySave
{
    class InventoryFullException : Exception
    {
        public InventoryFullException(string message) : base(message)
        {
        }
    }

    class Lesson10Runner
    {
        static List<string> inventory = new List<string>();
        static Dictionary<string, int> prices = new Dictionary<string, int>();

        static void AddItem(string item)
        {
            if (string.IsNullOrEmpty(item))
            {
                throw new ArgumentException("Item name cannot be empty!");
            }

            if (inventory.Count >= 2)
            {
                throw new InventoryFullException("Inventory is full! Cannot add " + item);
            }

            inventory.Add(item);
            Console.WriteLine("Added: " + item);
        }

        static void SafeAdd(string item)
        {
            try
            {
                AddItem(item);
            }
            catch (InventoryFullException ex)
            {
                Console.WriteLine("Inventory error: " + ex.Message);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Item error: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Slots used: " + inventory.Count + "/2");
            }
        }

        static void ShowPrice(string item)
        {
            if (prices.TryGetValue(item, out int price))
            {
                Console.WriteLine("Price of " + item + ": " + price);
            }
            else
            {
                Console.WriteLine(item + " has no price listed.");
            }
        }

        static void LoadGold(string saveText)
        {
            if (int.TryParse(saveText, out int gold))
            {
                Console.WriteLine("Save loaded! Gold: " + gold);
            }
            else
            {
                Console.WriteLine("Save corrupted! Starting with 0 gold.");
            }
        }

        static void Main()
        {
            Console.WriteLine("Dark Fantasy RPG - Safe Inventory and Save System");

            prices.Add("Iron Sword", 150);

            SafeAdd("Iron Sword");
            SafeAdd("Health Potion");
            SafeAdd("Dragon Armor");
            SafeAdd("");

            ShowPrice("Iron Sword");
            ShowPrice("Dragon Armor");

            LoadGold("abc");
            LoadGold("250");

            Console.WriteLine("The game keeps running!");
        }
    }
}