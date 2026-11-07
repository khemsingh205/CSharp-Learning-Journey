using System;
using System.IO;

namespace Day16_Lesson06_StreamWriter
{
    class Lesson06Runner
    {
        static void Main()
        {
            Console.WriteLine("Dark Fantasy RPG - StreamWriter Save");

            using (StreamWriter writer = new StreamWriter("stream_save.txt"))
            {
                writer.WriteLine("Shadow Knight");
                writer.WriteLine("250");
                writer.WriteLine("5");
            }

            Console.WriteLine("Game saved!");
            Console.WriteLine(File.ReadAllText("stream_save.txt"));
        }
    }
}