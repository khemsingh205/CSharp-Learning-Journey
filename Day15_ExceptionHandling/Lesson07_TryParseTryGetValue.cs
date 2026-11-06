using System;
using System.Collections.Generic;

namespace Day15_Lesson07_TryParseTryGetValue
{
    class Lesson07Runner
    {
        static void Main()
        {
            Console.WriteLine("Dark Fantasy RPG - Safe Checks");

            string input = "abc";

            if (int.TryParse(input, out int gold))
            {
                Console.WriteLine("You have " + gold + " gold.");
            }
            else
            {
                Console.WriteLine("Invalid number entered!");
            }

            Dictionary<string, int> prices = new Dictionary<string, int>();
            prices.Add("Iron Sword", 150);

            if (prices.TryGetValue("Dragon Armor", out int price))
            {
                Console.WriteLine("Price: " + price);
            }
            else
            {
                Console.WriteLine("Item not found in price list!");
            }

            Console.WriteLine("The game keeps running!");
        }
    }
}