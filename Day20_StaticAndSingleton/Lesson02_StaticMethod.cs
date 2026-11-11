using System;

namespace Day20_Lesson02_StaticMethod
{
    class CombatMath
    {
        public static int CalculateDamage(int baseDamage, int armor)
        {
            int damage = baseDamage - armor;

            if (damage < 0)
            {
                damage = 0;
            }

            return damage;
        }

        public static bool IsCritical(int roll)
        {
            return roll >= 90;
        }
    }

    class Lesson02Runner
    {
        static void Main()
        {
            Console.WriteLine("Dark Fantasy RPG - Static Method");

            int hit = CombatMath.CalculateDamage(50, 20);
            Console.WriteLine("Damage dealt: " + hit);

            int blocked = CombatMath.CalculateDamage(10, 20);
            Console.WriteLine("Damage against heavy armor: " + blocked);

            Console.WriteLine("Roll 95 critical? " + CombatMath.IsCritical(95));
            Console.WriteLine("Roll 40 critical? " + CombatMath.IsCritical(40));
        }
    }
}
