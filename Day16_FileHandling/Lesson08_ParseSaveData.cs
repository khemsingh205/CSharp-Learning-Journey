using System;
using System.IO;

namespace Day16_Lesson08_ParseSaveData
{
    class Lesson08Runner
    {
        static void Main()
        {
            Console.WriteLine("Dark Fantasy RPG - Safe Save Parsing");

            string[] lines = File.ReadAllLines("player_save.txt");

            if (lines.Length < 3)
            {
                Console.WriteLine("Save file is incomplete! Starting a new game.");
                return;
            }

            string name = lines[0];
            int gold = 0;
            int level = 1;

            if (!int.TryParse(lines[1], out gold))
            {
                Console.WriteLine("Gold is corrupted! Using 0.");
                gold = 0;
            }

            if (!int.TryParse(lines[2], out level))
            {
                Console.WriteLine("Level is corrupted! Using 1.");
                level = 1;
            }

            Console.WriteLine("Name: " + name);
            Console.WriteLine("Gold: " + gold);
            Console.WriteLine("Level: " + level);
        }
    }
}