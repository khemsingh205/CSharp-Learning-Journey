using System;

namespace Day17_Lesson05_ActionAndFunc
{
    class Lesson05Runner
    {
        static void ShowWarning()
        {
            Console.WriteLine("Warning: Boss is near!");
        }

        static void ShowDamage(int damage)
        {
            Console.WriteLine("You took " + damage + " damage.");
        }

        static int DoubleDamage(int damage)
        {
            return damage * 2;
        }

        static void Main()
        {
            Console.WriteLine("Dark Fantasy RPG - Action and Func");

            Action warning = ShowWarning;
            warning();

            Action<int> damageText = ShowDamage;
            damageText(30);

            Func<int, int> critical = DoubleDamage;
            int result = critical(30);
            Console.WriteLine("Critical damage: " + result);
        }
    }
}