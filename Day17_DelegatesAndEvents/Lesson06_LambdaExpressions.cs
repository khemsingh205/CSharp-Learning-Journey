using System;

namespace Day17_Lesson06_LambdaExpressions
{
    class Lesson06Runner
    {
        static void Main()
        {
            Console.WriteLine("Dark Fantasy RPG - Lambda Expressions");

            Action warning = () => Console.WriteLine("Warning: Boss is near!");
            warning();

            Action<int> damageText = damage => Console.WriteLine("You took " + damage + " damage.");
            damageText(30);

            Func<int, int> critical = damage => damage * 2;
            Console.WriteLine("Critical damage: " + critical(30));

            Func<int, int, int> total = (a, b) => a + b;
            Console.WriteLine("Total damage: " + total(20, 15));
        }
    }
}