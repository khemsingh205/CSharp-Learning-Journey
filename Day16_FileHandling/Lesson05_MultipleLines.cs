using System;
using System.IO;

namespace Day16_Lesson05_MultipleLines
{
    class Lesson05Runner
    {
        static void Main()
        {
            Console.WriteLine("Dark Fantasy RPG - Multi-Line Save");

            string[] saveLines = { "Shadow Knight", "250", "5" };

            File.WriteAllLines("player_save.txt", saveLines);
            Console.WriteLine("Game saved!");

            string[] loadedLines = File.ReadAllLines("player_save.txt");

            Console.WriteLine("Name: " + loadedLines[0]);
            Console.WriteLine("Gold: " + loadedLines[1]);
            Console.WriteLine("Level: " + loadedLines[2]);
        }
    }
}