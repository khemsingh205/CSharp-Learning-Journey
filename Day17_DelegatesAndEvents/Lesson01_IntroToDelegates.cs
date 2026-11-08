using System;

namespace Day17_Lesson01_IntroToDelegates
{
    delegate void AttackDelegate();

    class Lesson01Runner
    {
        static void SwordSlash()
        {
            Console.WriteLine("Sword slash! 20 damage.");
        }

        static void FireSpell()
        {
            Console.WriteLine("Fire spell! 35 damage.");
        }

        static void Main()
        {
            Console.WriteLine("Dark Fantasy RPG - Attack Delegate");

            AttackDelegate attack = SwordSlash;
            attack();

            attack = FireSpell;
            attack();
        }
    }
}