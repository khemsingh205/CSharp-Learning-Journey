
using System;
class OverloadPlayer
{
    public void Attack(int damage)
    {
        Console.WriteLine("Player performs a basic attack!");
        Console.WriteLine("Damage: " + damage);
    }

    public void Attack(string weapon)
    {
        Console.WriteLine("Player attacks using: " + weapon);
    }

    public void Attack(int damage, int stamina)
    {
        Console.WriteLine("Player performs a heavy attack!");
        Console.WriteLine("Damage: " + damage);
        Console.WriteLine("Stamina Used: " + stamina);
    }

    public void Attack(string weapon, int damage)
    {
        Console.WriteLine("Player performs a weapon attack!");
        Console.WriteLine("Weapon: " + weapon);
        Console.WriteLine("Damage: " + damage);
    }
}

class Day09Lesson04
{
    static void Main()
    {
        Console.WriteLine("=== DARK FANTASY PLAYER COMBAT ===");
        Console.WriteLine();
        OverloadPlayer player = new OverloadPlayer();
        player.Attack(25);

        Console.WriteLine();
        player.Attack("Great Sword");

        Console.WriteLine();
        player.Attack(60, 20);

        Console.WriteLine();
        player.Attack("Dark Blade", 100);

        Console.WriteLine();
        Console.WriteLine("All attacks completed!");

        Console.ReadKey();
    }
}
