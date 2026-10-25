
using System;

class Step03_ElseIf
{
    static void Main()
    {
        int playerHealth = 40;

        Console.WriteLine("=== Dark Fantasy Game ===");
        Console.WriteLine("Player Health: " + playerHealth);

        if (playerHealth >= 75)
        {
            Console.WriteLine("Excellent condition!");
        }
        else if (playerHealth >= 50)
        {
            Console.WriteLine("Player is ready for battle!");
        }
        else if (playerHealth >= 25)
        {
            Console.WriteLine("Warning! Low health!");
        }
        else
        {
            Console.WriteLine("Critical health! Find a safe place!");
        }

        Console.ReadKey();
    }
}
