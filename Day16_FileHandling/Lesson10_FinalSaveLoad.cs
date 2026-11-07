using System;
using System.IO;

namespace Day16_Lesson10_FinalSaveLoad
{
    class Lesson10Runner
    {
        const string SaveFile = "final_save.txt";

        static void SaveGame(string name, int gold, int level)
        {
            try
            {
                string[] lines = { name, gold.ToString(), level.ToString() };
                File.WriteAllLines(SaveFile, lines);
                Console.WriteLine("Game saved!");
            }
            catch (IOException ex)
            {
                Console.WriteLine("Save failed: " + ex.Message);
            }
        }

        static void LoadGame()
        {
            if (!File.Exists(SaveFile))
            {
                Console.WriteLine("No save file found. Starting a new game!");
                return;
            }

            try
            {
                string[] lines = File.ReadAllLines(SaveFile);

                if (lines.Length < 3)
                {
                    Console.WriteLine("Save file is incomplete! Starting a new game.");
                    return;
                }

                int gold;
                int level;

                if (!int.TryParse(lines[1], out gold))
                {
                    gold = 0;
                    Console.WriteLine("Gold is corrupted! Using 0.");
                }

                if (!int.TryParse(lines[2], out level))
                {
                    level = 1;
                    Console.WriteLine("Level is corrupted! Using 1.");
                }

                Console.WriteLine("Game loaded!");
                Console.WriteLine("Name: " + lines[0]);
                Console.WriteLine("Gold: " + gold);
                Console.WriteLine("Level: " + level);
            }
            catch (IOException ex)
            {
                Console.WriteLine("Load failed: " + ex.Message);
            }
        }

        static void Main()
        {
            Console.WriteLine("Dark Fantasy RPG - Final Save and Load System");

            LoadGame();
            SaveGame("Shadow Knight", 250, 5);
            LoadGame();

            Console.WriteLine("The game keeps running!");
        }
    }
}