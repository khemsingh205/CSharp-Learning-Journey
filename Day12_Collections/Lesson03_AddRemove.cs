using System;
using System.Collections.Generic;

namespace Day12_Lesson03_AddRemove
{
    public class AddRemoveLesson
    {
        public void Run()
        {
            List<string> backpack = new List<string>();

            backpack.Add("Iron Sword");
            backpack.Add("Health Potion");
            backpack.Add("Dark Shield");
            Console.WriteLine("After Add: " + backpack.Count);

            backpack.Remove("Health Potion");
            Console.WriteLine("After Remove: " + backpack.Count);

            foreach (string item in backpack)
            {
                Console.WriteLine("Item: " + item);
            }
        }
    }

    public class Lesson03Runner
    {
        static void Main()
        {
            AddRemoveLesson lesson = new AddRemoveLesson();
            lesson.Run();
            Console.ReadLine();
        }
    }
}
