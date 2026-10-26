
using System;

namespace Day04_Loops
{
    class RepeatedAttacksLesson
    {
        static void Main()
        {
            int enemyHealth = 100;
            int attackDamage = 30;
            int attackCount = 1;

            while (enemyHealth > 0)
            {
                Console.WriteLine("Knight attack: " + attackCount);

                enemyHealth = enemyHealth - attackDamage;

                if (enemyHealth < 0)
                {
                    enemyHealth = 0;
                }

                Console.WriteLine("Enemy health: " + enemyHealth);

                attackCount++;
                Console.WriteLine();
            }

            Console.WriteLine("Enemy defeated!");

            Console.ReadKey();
        }
    }
}
