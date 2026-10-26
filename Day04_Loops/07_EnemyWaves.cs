
using System;

namespace Day04_Loops
{
    class EnemyWavesLesson
    {
        static void Main()
        {
            for (int wave = 1; wave <= 3; wave++)
            {
                Console.WriteLine("Wave " + wave + " started!");

                for (int enemy = 1; enemy <= 2; enemy++)
                {
                    Console.WriteLine(
                        "Knight attacks Enemy " + enemy
                    );
                }

                Console.WriteLine("Wave " + wave + " completed!");
                Console.WriteLine();
            }

            Console.WriteLine("Dungeon cleared!");

            Console.ReadKey();
        }
    }
}

