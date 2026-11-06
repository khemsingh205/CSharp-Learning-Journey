using System;
using System.Collections.Generic;

namespace Day15_Lesson09_CustomException
{
    class InventoryFullException : Exception
    {
        public InventoryFullException(string message) : base(message)
        {
        }
    }

    class Lesson09Runner
    {
        static void AddItem(List<string> inventory, string item)
        {
            if (inventory.Count >= 2)
            {
                throw new InventoryFullException("Inventory is full! Cannot add " + item);
            }

            inventory.Add(item);
            Console.WriteLine("Added: " + item);
        }

        static void Main()
        {
            Console.WriteLine("Dark Fantasy RPG - Custom Exception");

            List<string> inventory = new List<string>();

            try
            {
                AddItem(inventory, "Iron Sword");
                AddItem(inventory, "Health Potion");
                AddItem(inventory, "Dragon Armor");
            }
            catch (InventoryFullException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            Console.WriteLine("The game keeps running!");
        }
    }
}