using System;

namespace Day17_Lesson04_Callback
{
    delegate void OnFinishedDelegate();

    class Lesson04Runner
    {
        static void CastSpell(string spellName, OnFinishedDelegate onFinished)
        {
            Console.WriteLine("Casting " + spellName + "...");
            Console.WriteLine(spellName + " hits the enemy!");

            onFinished();
        }

        static void StartCooldown()
        {
            Console.WriteLine("Spell cooldown started: 5 seconds.");
        }

        static void PlayEndAnimation()
        {
            Console.WriteLine("Animation: Spell effect fades away.");
        }

        static void Main()
        {
            Console.WriteLine("Dark Fantasy RPG - Spell Callback");

            CastSpell("Fireball", StartCooldown);
            CastSpell("Shadow Bolt", PlayEndAnimation);
        }
    }
}