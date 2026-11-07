using System;
using System.IO;

namespace Day16_Lesson04_AppendLog
{
    class Lesson04Runner
    {
        static void Main()
        {
            Console.WriteLine("Dark Fantasy RPG - Battle Log");

            File.AppendAllText("battle_log.txt", "Player entered the Dark Forest." + Environment.NewLine);
            File.AppendAllText("battle_log.txt", "Player defeated a Skeleton." + Environment.NewLine);

            Console.WriteLine("Log updated!");
            Console.WriteLine(File.ReadAllText("battle_log.txt"));
        }
    }
}