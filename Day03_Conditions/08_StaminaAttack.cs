
using System;

class Step08_StaminaAttack
{
    static void Main()
    {
        int playerStamina = 40;
        int attackCost = 30;
        bool playerAlive = true;

        Console.WriteLine("=== Dark Fantasy Game ===");
        Console.WriteLine("Player Stamina: " + playerStamina);
        Console.WriteLine("Heavy Attack Cost: " + attackCost);

        if (playerAlive && playerStamina >= attackCost)
        {
            playerStamina = playerStamina - attackCost;

            Console.WriteLine("Heavy sword attack performed!");
            Console.WriteLine("Stamina remaining: " + playerStamina);
        }
        else
        {
            Console.WriteLine("Cannot attack! Not enough stamina or player is dead.");
        }

        Console.ReadKey();
    }
}
