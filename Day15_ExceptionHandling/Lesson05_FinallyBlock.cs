using System;

namespace Day15_Lesson05_FinallyBlock
{
    class Lesson05Runner
    {
        static void Main()
        {
            Console.WriteLine("Dark Fantasy RPG - Opening Treasure Chest");

            int keys = 0;

            try
            {
                Console.WriteLine("Trying to open the chest...");
                int chestsOpened = 10 / keys;
                Console.WriteLine("Chests opened: " + chestsOpened);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error: You have no keys!");
            }
            finally
            {
                Console.WriteLine("Closing the chest menu.");
            }

            Console.WriteLine("The game keeps running!");
        }
    }
}
