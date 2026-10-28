
using System;

class Day06Lesson10
{
    static void Main()
    {
        int enemyHealth = 80;
        int playerDamage = 30;

        Console.WriteLine("=== Dark Fantasy Dungeon ===");
        Console.WriteLine("A Skeleton blocks your path!");
        Console.WriteLine("Skeleton starting health: " + enemyHealth);

        enemyHealth = AttackEnemy(enemyHealth, playerDamage);

        if (enemyHealth > 0)
        {
            enemyHealth = AttackEnemy(enemyHealth, playerDamage);
        }

        if (enemyHealth > 0)
        {
            enemyHealth = AttackEnemy(enemyHealth, playerDamage);
        }

        Console.WriteLine("Combat ended.");
    }

    static int AttackEnemy(int currentHealth, int damage)
    {
        Console.WriteLine();
        Console.WriteLine("Knight attacks with sword!");

        currentHealth = currentHealth - damage;

        if (currentHealth <= 0)
        {
            currentHealth = 0;
            Console.WriteLine("Skeleton defeated!");
        }
        else
        {
            Console.WriteLine("Skeleton takes " + damage + " damage!");
        }

        Console.WriteLine("Skeleton remaining health: " + currentHealth);

        return currentHealth;
    }
}

