
using System;
using System.Collections.Generic;

namespace Day23_Lesson10_FinalRPGSkillSequencer
{
    class RPGSkillSequencer
    {
        static IEnumerable<string> UsePlayerSkill(string skillName, int cooldown)
        {
            yield return skillName + " activated!";

            for (int i = cooldown; i > 0; i--)
            {
                yield return skillName + " cooldown: " + i + " seconds";
            }

            yield return skillName + " is ready again!";
        }

        static IEnumerable<string> RunBossAttackPattern()
        {
            string[] attacks =
            {
                "Sword Strike",
                "Dark Flame",
                "Ultimate Explosion"
            };

            foreach (string attack in attacks)
            {
                yield return "Boss prepares " + attack;
                yield return "Boss attack: " + attack;
            }

            yield return "Boss attack pattern completed!";
        }

        static IEnumerable<string> RunRPGSequence()
        {
            foreach (string message in UsePlayerSkill("Fire Slash", 3))
            {
                yield return message;
            }

            yield return "";

            foreach (string message in UsePlayerSkill("Shadow Blast", 2))
            {
                yield return message;
            }

            yield return "";
            yield return "Player skill sequence completed!";
            yield return "";

            foreach (string message in RunBossAttackPattern())
            {
                yield return message;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Dark Fantasy RPG");
            Console.WriteLine("Final RPG Skill Sequencer");
            Console.WriteLine();

            foreach (string message in RunRPGSequence())
            {
                Console.WriteLine(message);
            }

            Console.WriteLine();
            Console.WriteLine("RPG sequence completed!");
        }
    }
}
