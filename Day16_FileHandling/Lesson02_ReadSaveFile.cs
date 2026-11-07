using System;
using System.IO;

namespace Day16_Lesson02_ReadSaveFile
{
    class Lesson02Runner
    {
        static void Main()
        {
            Console.WriteLine("Dark Fantasy RPG - Load Game");

            string saveText = File.ReadAllText("save.txt");

            Console.WriteLine("Game loaded!");
            Console.WriteLine("Save data: " + saveText);
        }
    }
}