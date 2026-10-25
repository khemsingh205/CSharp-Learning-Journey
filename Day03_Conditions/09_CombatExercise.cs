
using System;

class Step09_CombatExercise
{
    static void Main()
    {
        int playerHealth = 100;
        int playerStamina = 40;
        int attackCost = 30;
        int enemyDamage = 25;

        bool playerAlive = true;

        Console.WriteLine("=== Dark Fantasy Combat ===");
        Console.WriteLine("Player Health: " + playerHealth);
        Console.WriteLine("Player Stamina: " + playerStamina);

        // Check whether the player can attack
        if (playerAlive && playerStamina >= attackCost)
        {
            playerStamina = playerStamina - attackCost;

            Console.WriteLine("Player performs a heavy sword attack!");
            Console.WriteLine("Stamina remaining: " + playerStamina);

            // Enemy counterattack
            playerHealth = playerHealth - enemyDamage;

            Console.WriteLine("Enemy counterattacks!");
            Console.WriteLine("Damage received: " + enemyDamage);
            Console.WriteLine("Player Health: " + playerHealth);
        }
        else
        {
            Console.WriteLine("Player cannot attack!");
        }

        // Check whether the player survived
        if (playerHealth > 0)
        {
            Console.WriteLine("Player is still alive!");
        }
        else
        {
            playerAlive = false;
            Console.WriteLine("Player is defeated! Game Over!");
        }

        Console.ReadKey();
    }
}
