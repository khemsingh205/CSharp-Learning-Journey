
using System;
using System.Collections.Generic;

namespace Day23_Lesson05_YieldBreak
{
    class BossRunner
    {
        static IEnumerable<string> GetBossAttacks()
        {
            yield return "Sword Slash";
            yield return "Fire Blast";

            Console.WriteLine("Boss energy is critically low!");

            yield break;

            yield return "Dark Explosion";
            yield return "Ultimate Attack";
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Dark Fantasy RPG");
            Console.WriteLine("Boss Attack Sequence:");
            Console.WriteLine();

            foreach (string attack in GetBossAttacks())
            {
                Console.WriteLine("Boss Attack: " + attack);
            }

            Console.WriteLine();
            Console.WriteLine("Boss attack sequence ended!");
        }
    }
}
