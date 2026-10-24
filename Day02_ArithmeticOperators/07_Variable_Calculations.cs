
using System;

class VariableCalculations
{
    static void Main()
    {
        // Store player stats
        int playerHealth = 100;
        int enemyDamage = 25;
        int playerArmor = 5;

        // Calculate damage after armor reduction
        int actualDamage = enemyDamage - playerArmor;

        // Calculate remaining health
        int remainingHealth = playerHealth - actualDamage;

        // Display the results
        Console.WriteLine("Starting Health: " + playerHealth);
        Console.WriteLine("Enemy Damage: " + enemyDamage);
        Console.WriteLine("Armor Protection: " + playerArmor);
        Console.WriteLine("Actual Damage: " + actualDamage);
        Console.WriteLine("Remaining Health: " + remainingHealth);
    }
}

