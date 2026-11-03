using System;
using System.Collections.Generic;

namespace Day12_Lesson08_IntroHashSet
{
    public class IntroHashSetLesson
    {
        public void Run()
        {
            HashSet<string> unlockedSkills = new HashSet<string>();

            Console.WriteLine("Add Fireball: " + unlockedSkills.Add("Fireball"));
            Console.WriteLine("Add Shadow Step: " + unlockedSkills.Add("Shadow Step"));
            Console.WriteLine("Add Fireball again: " + unlockedSkills.Add("Fireball"));

            Console.WriteLine("Total skills: " + unlockedSkills.Count);
            Console.WriteLine("Has Fireball: " + unlockedSkills.Contains("Fireball"));

            foreach (string skill in unlockedSkills)
            {
                Console.WriteLine("Skill: " + skill);
            }
        }
    }

    public class Lesson08Runner
    {
        static void Main()
        {
            IntroHashSetLesson lesson = new IntroHashSetLesson();
            lesson.Run();
            Console.ReadLine();
        }
    }
}