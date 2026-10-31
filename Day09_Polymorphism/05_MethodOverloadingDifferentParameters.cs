
using System;

// Player Combat System
class DifferentParameterPlayer
{
    // Method 1: Integer parameter
    public void Attack(int damage)
    {
        Console.WriteLine("Basic Attack!");
        Console.WriteLine("Damage: " + damage);
    }

    // Method 2: String parameter
    public void Attack(string weapon)
    {
        Console.WriteLine("Weapon Attack!");
        Console.WriteLine("Weapon: " + weapon);
    }

    // Method 3: Two integer parameters
    public void Attack(int damage, int stamina)
    {
        Console.WriteLine("Heavy Attack!");
        Console.WriteLine("Damage: " + damage);
        Console.WriteLine("Stamina: " + stamina);
    }

    // Method 4: Different parameter order
    public void Attack(string weapon, int damage)
    {
        Console.WriteLine("Special Weapon Attack!");
        Console.WriteLine("Weapon: " + weapon);
        Console.WriteLine("Damage: " + damage);
    }

    // Method 5: Different parameter order
    public void Attack(int damage, string weapon)
    {
        Console.WriteLine("Powerful Weapon Attack!");
        Console.WriteLine("Damage: " + damage);
        Console.WriteLine("Weapon: " + weapon);
    }
}

// Main Program
class Day09Lesson05
{
    static void Main()
    {
        Console.WriteLine("=== DARK FANTASY WEAPON SYSTEM ===");
        Console.WriteLine();

        // Creating player object
        DifferentParameterPlayer player =
            new DifferentParameterPlayer();

        // Different parameter types
        player.Attack(25);

        Console.WriteLine();

        player.Attack("Iron Sword");

        Console.WriteLine();

        // Different number of parameters
        player.Attack(50, 20);

        Console.WriteLine();

        // Different parameter order
        player.Attack("Dark Blade", 100);

        Console.WriteLine();

        player.Attack(150, "Fire Sword");

        Console.WriteLine();
        Console.WriteLine("Weapon demonstration completed!");

        Console.ReadKey();
    }
}
