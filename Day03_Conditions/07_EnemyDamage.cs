
using System;

class Step07_EnemyDamage
{
    static void Main()
    {
        int enemyDifficulty = 3;
        int enemyDamage;

        Console.WriteLine("=== Dark Fantasy Game ===");
        Console.WriteLine("Enemy Difficulty: " + enemyDifficulty);

        if (enemyDifficulty == 1)
        {
            enemyDamage = 10;
            Console.WriteLine("Easy Enemy!");
        }
        else if (enemyDifficulty == 2)
        {
            enemyDamage = 20;
            Console.WriteLine("Medium Enemy!");
        }
        else if (enemyDifficulty == 3)
        {
            enemyDamage = 40;
            Console.WriteLine("Boss Enemy!");
        }
        else
        {
            enemyDamage = 0;
            Console.WriteLine("Unknown Enemy Difficulty!");
        }

        Console.WriteLine("Enemy Damage: " + enemyDamage);

        Console.ReadKey();
    }
}
