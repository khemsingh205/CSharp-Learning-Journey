
using System;

class Step04_ComparisonOperators
{
    static void Main()
    {
        int playerHealth = 100;
        int enemyHealth = 40;

        Console.WriteLine("=== Dark Fantasy Game ===");

        Console.WriteLine("Player Health: " + playerHealth);
        Console.WriteLine("Enemy Health: " + enemyHealth);

        Console.WriteLine("Player health is full: " + (playerHealth == 100));
        Console.WriteLine("Enemy is not defeated: " + (enemyHealth != 0));
        Console.WriteLine("Player has more than 50 HP: " + (playerHealth > 50));
        Console.WriteLine("Enemy health is below 50: " + (enemyHealth < 50));
        Console.WriteLine("Player has at least 100 HP: " + (playerHealth >= 100));
        Console.WriteLine("Enemy has at most 40 HP: " + (enemyHealth <= 40));

        Console.ReadKey();
    }
}
