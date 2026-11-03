using System;
using System.Collections.Generic;

namespace Day12_Lesson04_AccessUpdate
{
    public class AccessUpdateLesson
    {
        public void Run()
        {
            List<string> backpack = new List<string>
            {
                "Iron Sword",
                "Health Potion",
                "Dark Shield"
            };

            Console.WriteLine("First item: " + backpack[0]);
            Console.WriteLine("Last item: " + backpack[2]);

            backpack[0] = "Steel Sword";
            Console.WriteLine("Updated first item: " + backpack[0]);
        }
    }

    public class Lesson04Runner
    {
        static void Main()
        {
            AccessUpdateLesson lesson = new AccessUpdateLesson();
            lesson.Run();
            Console.ReadLine();
        }
    }
}