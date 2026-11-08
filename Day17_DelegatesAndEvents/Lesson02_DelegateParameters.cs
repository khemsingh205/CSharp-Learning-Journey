using System;

namespace Day17_Lesson02_DelegateParameters
{
    delegate int DamageDelegate(int baseDamage);

    class Lesson02Runner
    {
        static int NormalHit(int baseDamage)
        {
            return baseDamage;
        }

        static int CriticalHit(int baseDamage)
        {
            return baseDamage * 2;
        }

        static void Main()
        {
            Console.WriteLine("Dark Fantasy RPG - Damage Delegate");

            DamageDelegate damage = NormalHit;
            int result = damage(20);
            Console.WriteLine("Normal hit: " + result);

            damage = CriticalHit;
            result = damage(20);
            Console.WriteLine("Critical hit: " + result);
        }
    }
}