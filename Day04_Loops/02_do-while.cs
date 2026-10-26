
using System;

namespace Day04_Loops
{
    class DoWhileLoopLesson
    {
        static void Main()
        {
            int patrolCount = 1;

            do
            {
                Console.WriteLine("Enemy patrol action: " + patrolCount);

                patrolCount++;

            } while (patrolCount <= 3);

            Console.WriteLine("Enemy patrol finished!");

            Console.ReadKey();
        }
    }
}
