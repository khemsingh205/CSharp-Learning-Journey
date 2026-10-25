
using System;

class Step05_LogicalOperators
{
    static void Main()
    {
        int playerHealth = 80;
        int playerStamina = 40;
        bool playerAlive = true;

        Console.WriteLine("=== Dark Fantasy Game ===");

        Console.WriteLine("Player Health: " + playerHealth);
        Console.WriteLine("Player Stamina: " + playerStamina);


        if (playerAlive && playerStamina >= 30)
        {
            Console.WriteLine("Heavy sword attack is possible!");
        }


        if (playerHealth < 30 || playerStamina < 20)
        {
            Console.WriteLine("Warning! Player is in danger!");
        }


        if (!playerAlive)
        {
            Console.WriteLine("Player is defeated!");
        }

        Console.ReadKey();
    }
}
