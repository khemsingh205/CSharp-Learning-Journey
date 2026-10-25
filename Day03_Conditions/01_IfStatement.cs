
using System;

class Step01_IfStatement
{
    static void Main()
    {
        int playerHealth = 75;

        Console.WriteLine("=== Dark Fantasy Game ===");
        Console.WriteLine("Player Health: " + playerHealth);

        if (playerHealth >= 50)
        {
            Console.WriteLine("Player is ready for battle!");
        }

        Console.WriteLine("Game continues...");
        Console.ReadKey();
    }
}
