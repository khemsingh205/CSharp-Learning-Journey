
using System;

namespace Day04_Loops
{
    class ContinueStatementLesson
    {
        static void Main()
        {
            for (int enemy = 1; enemy <= 5; enemy++)
            {
                if (enemy == 2)
                {
                    Console.WriteLine("Enemy 2 skipped!");
                    continue;
                }

                Console.WriteLine("Knight attacks enemy: " + enemy);
            }

            Console.WriteLine("Enemy round complete!");

            Console.ReadKey();
        }
    }
}
