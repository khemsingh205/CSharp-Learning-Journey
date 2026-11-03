using System;
using System.Collections.Generic;

namespace Day12_Lesson02_WhatIsList
{
    public class WhatIsListLesson
    {
        public void Run()
        {
            List<string> weapons = new List<string>
            {
                "Iron Sword",
                "Shadow Dagger",
                "Cursed Bow"
            };

            Console.WriteLine("Weapons count: " + weapons.Count);

            foreach (string weapon in weapons)
            {
                Console.WriteLine("Weapon: " + weapon);
            }
        }
    }

    public class Lesson02Runner
    {
        static void Main()
        {
            WhatIsListLesson lesson = new WhatIsListLesson();
            lesson.Run();
            Console.ReadLine();
        }
    }
}