using System;
using System.Collections.Generic;

namespace Day15_Lesson06_ListDictionaryErrors
{
    class Lesson06Runner
    {
        static void Main()
        {
            Console.WriteLine("Dark Fantasy RPG - Inventory Errors");

            List<string> inventory = new List<string>();
            inventory.Add("Iron Sword");
            inventory.Add("Health Potion");

            Dictionary<string, int> prices = new Dictionary<string, int>();
            prices.Add("Iron Sword", 150);

            try
            {
                Console.WriteLine("Slot 5: " + inventory[5]);
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Error: That inventory slot does not exist!");
            }

            try
            {
                Console.WriteLine("Price: " + prices["Dragon Armor"]);
            }
            catch (KeyNotFoundException)
            {
                Console.WriteLine("Error: Item not found in price list!");
            }

            Console.WriteLine("The game keeps running!");
        }
    }
}