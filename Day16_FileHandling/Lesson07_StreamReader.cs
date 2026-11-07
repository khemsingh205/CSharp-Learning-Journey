using System;
using System.IO;

namespace Day16_Lesson07_StreamReader
{
    class Lesson07Runner
    {
        static void Main()
        {
            Console.WriteLine("Dark Fantasy RPG - StreamReader Load");

            using (StreamReader reader = new StreamReader("stream_save.txt"))
            {
                string name = reader.ReadLine();
                string gold = reader.ReadLine();
                string level = reader.ReadLine();

                Console.WriteLine("Name: " + name);
                Console.WriteLine("Gold: " + gold);
                Console.WriteLine("Level: " + level);
            }

            Console.WriteLine("Game loaded!");
        }
    }
}