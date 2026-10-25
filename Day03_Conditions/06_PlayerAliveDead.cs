
using System;

class Step06_PlayerAliveDead
{
    static void Main()
    {
        int playerHealth = 0;

        Console.WriteLine("=== Dark Fantasy Game ===");
        Console.WriteLine("Player Health: " + playerHealth);

        if (playerHealth > 0)
        {
            Console.WriteLine("Player is ALIVE!");
            Console.WriteLine("You can continue fighting.");
        }
        else
        {
            Console.WriteLine("Player is DEAD!");
            Console.WriteLine("Game Over!");
        }

        Console.ReadKey();
    }
}
