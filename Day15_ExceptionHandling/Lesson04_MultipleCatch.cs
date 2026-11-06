using System;

namespace Day15_Lesson04_MultipleCatch
{
    class Lesson04Runner
    {
        static void Main()
        {
            Console.WriteLine("Dark Fantasy RPG - Potion Sharing");

            string input = "abc";
            int potions = 12;

            try
            {
                int players = int.Parse(input);
                int each = potions / players;
                Console.WriteLine("Each player gets " + each + " potions.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter a valid number!");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("You cannot share potions with 0 players!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unexpected error: " + ex.Message);
            }

            Console.WriteLine("The game keeps running!");
        }
    }
}