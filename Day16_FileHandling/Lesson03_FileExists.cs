using System;
using System.IO;

namespace Day16_Lesson03_FileExists
{
    class Lesson03Runner
    {
        static void Main()
        {
            Console.WriteLine("Dark Fantasy RPG - Safe Load");

            string fileName = "missing_save.txt";

            if (File.Exists(fileName))
            {
                string saveText = File.ReadAllText(fileName);
                Console.WriteLine("Game loaded: " + saveText);
            }
            else
            {
                Console.WriteLine("No save file found. Starting a new game!");
            }

            Console.WriteLine("The game keeps running!");
        }
    }
}