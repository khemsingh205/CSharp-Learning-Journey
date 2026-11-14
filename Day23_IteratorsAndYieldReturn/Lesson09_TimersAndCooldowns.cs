
using System;
using System.Collections.Generic;

namespace Day23_Lesson09_TimersAndCooldowns
{
    class SkillRunner
    {
        static IEnumerable<int> StartCooldown(int seconds)
        {
            for (int i = seconds; i > 0; i--)
            {
                yield return i;
            }
        }

        static void UseSkill(string skillName, int cooldown)
        {
            Console.WriteLine(skillName + " activated!");

            Console.WriteLine("Cooldown started:");

            foreach (int remaining in StartCooldown(cooldown))
            {
                Console.WriteLine("Cooldown: " + remaining + " seconds");
            }

            Console.WriteLine(skillName + " is ready again!");
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Dark Fantasy RPG");
            Console.WriteLine("Player Skill System");
            Console.WriteLine();

            UseSkill("Fire Slash", 3);

            UseSkill("Shadow Blast", 2);

            Console.WriteLine("All skills are ready!");
        }
    }
}
