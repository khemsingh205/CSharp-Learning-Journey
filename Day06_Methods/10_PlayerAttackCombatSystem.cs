
using System;

class Day06Lesson09
{
    static void Main()
    {
        int enemyHealth = 100;
        int playerDamage = 30;

        Console.WriteLine("=== Dark Fantasy Combat ===");
        Console.WriteLine("Skeleton health: " + enemyHealth);

        enemyHealth = AttackEnemy(enemyHealth, playerDamage);
        enemyHealth = AttackEnemy(enemyHealth, playerDamage);
        enemyHealth = AttackEnemy(enemyHealth, playerDamage);
        enemyHealth = AttackEnemy(enemyHealth, playerDamage);
    }

    static int AttackEnemy(int currentHealth, int damage)
    {
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

        Console.WriteLine("Remaining health: " + currentHealth);

        return currentHealth;
    }
}
