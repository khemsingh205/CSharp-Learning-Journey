using System;
using System.Collections.Generic;

namespace Day12_Lesson09_ListVsDictVsHashSet
{
    public class CompareLesson
    {
        public void Run()
        {
            List<string> backpack = new List<string>();
            backpack.Add("Health Potion");
            backpack.Add("Health Potion");
            Console.WriteLine("List count: " + backpack.Count);

            Dictionary<string, int> potionPrice = new Dictionary<string, int>();
            potionPrice["Health Potion"] = 50;
            potionPrice["Health Potion"] = 60;
            Console.WriteLine("Dictionary count: " + potionPrice.Count);
            Console.WriteLine("Potion price: " + potionPrice["Health Potion"]);

            HashSet<string> skills = new HashSet<string>();
            skills.Add("Fireball");
            skills.Add("Fireball");
            Console.WriteLine("HashSet count: " + skills.Count);
        }
    }

    public class Lesson09Runner
    {
        static void Main()
        {
            CompareLesson lesson = new CompareLesson();
            lesson.Run();
            Console.ReadLine();
        }
    }
}