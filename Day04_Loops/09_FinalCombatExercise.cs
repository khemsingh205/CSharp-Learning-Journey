
using System;

namespace Day04_Loops
{
    class FinalCombatExercise
    {
        static void Main()
        {
            int enemyHealth = 100;
            int attackDamage = 35;
            int attackCount = 1;

            Console.WriteLine("Dark Dungeon Combat Started!");
            Console.WriteLine();

            while (enemyHealth > 0)
            {
                Console.WriteLine("Knight attack: " + attackCount);

                enemyHealth = enemyHealth - attackDamage;

                if (enemyHealth < 0)
                {
                    enemyHealth = 0;
                }

                Console.WriteLine("Enemy health: " + enemyHealth);

                if (enemyHealth == 0)
                {
                    Console.WriteLine("Enemy defeated!");
                    break;
                }
                else
                {
                    Console.WriteLine("Enemy is still alive!");
                }

                attackCount++;
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Combat Finished!");

            Console.ReadKey();
        }
    }
}
