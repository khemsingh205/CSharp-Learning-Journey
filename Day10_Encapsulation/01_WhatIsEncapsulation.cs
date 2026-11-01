
using System;

class DarkKnight
{
    private int health = 100;
    public void ShowHealth()
    {
        Console.WriteLine("Dark Knight Health: " + health);
    }

    public void TakeDamage(int damage)
    {
        health = health - damage;

        Console.WriteLine("Dark Knight took " + damage + " damage!");
    }
}

class Program
{
    static void Main()
    {
        DarkKnight knight = new DarkKnight();

        Console.WriteLine("=== DARK FANTASY COMBAT ===");

        knight.ShowHealth();

        knight.TakeDamage(30);

        knight.ShowHealth();

        Console.ReadLine();
    }
}
