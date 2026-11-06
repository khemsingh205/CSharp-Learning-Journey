using System;

namespace Day15_Lesson08_ThrowException
{
    class Lesson08Runner
    {
        static void AddGold(int currentGold, int amount)
        {
            if (amount < 0)
            {
                throw new ArgumentException("Gold amount cannot be negative!");
            }

            int total = currentGold + amount;
            Console.WriteLine("New gold total: " + total);
        }

        static void Main()
        {
            Console.WriteLine("Dark Fantasy RPG - Gold Reward");

            try
            {
                AddGold(100, 50);
                AddGold(100, -20);
                AddGold(100, 30);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            Console.WriteLine("The game keeps running!");
        }
    }
}