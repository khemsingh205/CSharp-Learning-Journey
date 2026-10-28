
using System;

class Day06Lesson06
{
    static void Main()
    {
        Console.WriteLine("=== Dungeon Combat ===");

        Attack();

        int remainingHealth = CalculateHealth();

        Console.WriteLine("Enemy remaining health: " + remainingHealth);
    }

    static void Attack()
    {
        Console.WriteLine("Knight attacks with sword!");
    }

    static int CalculateHealth()
    {
        return 75;
    }
}

