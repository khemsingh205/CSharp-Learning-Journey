using System;
using System.IO;

namespace Day16_Lesson09_FileExceptions
{
    class Lesson09Runner
    {
        static void Main()
        {
            Console.WriteLine("Dark Fantasy RPG - Safe File Save");

            try
            {
                File.WriteAllText("NoSuchFolder\\save.txt", "Gold: 250");
                Console.WriteLine("Game saved!");
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("Save folder does not exist!");
            }
            catch (IOException ex)
            {
                Console.WriteLine("File error: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unexpected error: " + ex.Message);
            }

            Console.WriteLine("The game keeps running!");
        }
    }
}