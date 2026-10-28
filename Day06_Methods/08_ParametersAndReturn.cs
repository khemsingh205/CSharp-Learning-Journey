
using System;

class Day06Lesson07
{
    static void Main()
    {
        int enemyHealth = 100;
        int damage = 30;

        Console.WriteLine("=== Dungeon Combat ===");
        Console.WriteLine("Enemy health before attack: " + enemyHealth);

        enemyHealth = CalculateRemainingHealth(enemyHealth, damage);

        Console.WriteLine("Damage taken: " + damage);
        Console.WriteLine("Enemy health after attack: " + enemyHealth);
    }

    static int CalculateRemainingHealth(int currentHealth, int damage)
    {
        return currentHealth - damage;
    }
}
