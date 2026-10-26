
using System;

namespace Day04_Loops
{
    class BreakStatementLesson
    {
        static void Main()
        {
            for (int enemy = 1; enemy <= 5; enemy++)
            {
                if (enemy == 3)
                {
                    Console.WriteLine("Target enemy found!");
                    break;
                }

                Console.WriteLine("Searching enemy: " + enemy);
            }

            Console.WriteLine("Enemy search stopped!");

            Console.ReadKey();
        }
    }
}
