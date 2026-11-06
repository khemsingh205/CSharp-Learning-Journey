using System;

namespace Day15_Lesson03_SpecificExceptions
{
    class Lesson03Runner
    {
        static void Main()
        {
            Console.WriteLine("Dark Fantasy RPG - Gold Input");

            string input = "abc";

            try
            {
                int gold = int.Parse(input);
                Console.WriteLine("You have " + gold + " gold.");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Invalid number entered!");
                Console.WriteLine("Details: " + ex.Message);
            }

            Console.WriteLine("The game keeps running!");
        }
    }
}