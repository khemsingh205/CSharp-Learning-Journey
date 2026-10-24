
using System;

class UserInputCalculations
{
    static void Main()
    {
        // Ask the player for base damage
        Console.Write("Enter your sword damage: ");
        int swordDamage = int.Parse(Console.ReadLine());

        // Ask for enemy defense
        Console.Write("Enter enemy defense: ");
        int enemyDefense = int.Parse(Console.ReadLine());

        // Calculate final damage
        int finalDamage = swordDamage - enemyDefense;

        // Display the result
        Console.WriteLine("Final Damage: " + finalDamage);
    }
}
