
using System;

namespace Day04_Loops
{
    class WhileLoopLesson
    {
        static void Main()
        {
            int enemyCount = 1;

            while (enemyCount <= 3)
            {
                Console.WriteLine("Enemy " + enemyCount + " defeated!");

                enemyCount++;
            }

            Console.WriteLine("Dungeon area cleared!");
            Console.ReadKey();
        }
    }
}
