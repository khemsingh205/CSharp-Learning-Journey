
using System;

namespace Day04_Loops
{
    class ConditionsInsideLoopLesson
    {
        static void Main()
        {
            for (int enemy = 1; enemy <= 5; enemy++)
            {
                if (enemy % 2 == 0)
                {
                    Console.WriteLine("Powerful enemy found: " + enemy);
                }
                else
                {
                    Console.WriteLine("Normal enemy found: " + enemy);
                }
            }

            Console.WriteLine("All enemies checked!");

            Console.ReadKey();
        }
    }
}
