using System;
using System.IO;

namespace Day16_Lesson01_WriteSaveFile
{
    class Lesson01Runner
    {
        static void Main()
        {
            Console.WriteLine("Dark Fantasy RPG - Save File");

            string saveText = "Player: Shadow Knight, Gold: 250";

            File.WriteAllText("save.txt", saveText);

            Console.WriteLine("Game saved!");
            Console.WriteLine("Saved at: " + Path.GetFullPath("save.txt"));
        }
    }
}