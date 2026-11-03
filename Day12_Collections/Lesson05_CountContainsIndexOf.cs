using System;
using System.Collections.Generic;

namespace Day12_Lesson05_CountContainsIndexOf
{
    public class CountContainsLesson
    {
        public void Run()
        {
            List<string> backpack = new List<string>
            {
                "Iron Sword",
                "Health Potion",
                "Dark Shield"
            };

            Console.WriteLine("Count: " + backpack.Count);
            Console.WriteLine("Has Health Potion: " + backpack.Contains("Health Potion"));
            Console.WriteLine("Has Mana Potion: " + backpack.Contains("Mana Potion"));
            Console.WriteLine("Index of Dark Shield: " + backpack.IndexOf("Dark Shield"));
            Console.WriteLine("Index of Mana Potion: " + backpack.IndexOf("Mana Potion"));
        }
    }

    public class Lesson05Runner
    {
        static void Main()
        {
            CountContainsLesson lesson = new CountContainsLesson();
            lesson.Run();
            Console.ReadLine();
        }
    }
}