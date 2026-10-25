
using System;

class Step02_IfElse
{
    static void Main()
    {
        int playerHealth = 30;

        Console.WriteLine("=== Dark Fantasy Game ===");
        Console.WriteLine("Player Health: " + playerHealth);

        if (playerHealth >= 50)
        {
            Console.WriteLine("Player is ready for battle!");
        }
        else
        {
            Console.WriteLine("Warning! Player is badly injured!");
        }

        Console.WriteLine("Game continues...");
        Console.ReadKey();
    }
}
