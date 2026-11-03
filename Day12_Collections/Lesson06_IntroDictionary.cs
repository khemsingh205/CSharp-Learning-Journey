using System;
using System.Collections.Generic;

namespace Day12_Lesson06_IntroDictionary
{
    public class IntroDictionaryLesson
    {
        public void Run()
        {
            Dictionary<string, int> weaponDamage = new Dictionary<string, int>
            {
                { "Iron Sword", 25 },
                { "Shadow Dagger", 18 },
                { "Cursed Bow", 30 }
            };

            Console.WriteLine("Total weapons: " + weaponDamage.Count);
            Console.WriteLine("Iron Sword damage: " + weaponDamage["Iron Sword"]);

            foreach (KeyValuePair<string, int> weapon in weaponDamage)
            {
                Console.WriteLine(weapon.Key + " = " + weapon.Value);
            }
        }
    }

    public class Lesson06Runner
    {
        static void Main()
        {
            IntroDictionaryLesson lesson = new IntroDictionaryLesson();
            lesson.Run();
            Console.ReadLine();
        }
    }
}