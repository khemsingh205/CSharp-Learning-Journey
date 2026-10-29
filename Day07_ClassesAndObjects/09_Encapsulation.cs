
using System;

class ProtectedKnight
{
    public string Name { get; private set; }

    private int health;

    public ProtectedKnight(string knightName, int startingHealth)
    {
        Name = knightName;
        health = startingHealth;
    }

    public void ShowStatus()
    {
        Console.WriteLine("Knight: " + Name);
        Console.WriteLine("Health: " + health);
    }

    public void TakeDamage(int damage)
    {
        if (damage <= 0)
        {
            Console.WriteLine("Damage must be greater than zero.");
            return;
        }

        health -= damage;

        if (health < 0)
        {
            health = 0;
        }

        Console.WriteLine(Name + " took " + damage + " damage.");
    }
}

class EncapsulationLesson
{
    static void Main()
    {
        ProtectedKnight knight = new ProtectedKnight("Dark Knight", 150);

        Console.WriteLine("=== Before Battle ===");
        knight.ShowStatus();

        Console.WriteLine();

        knight.TakeDamage(40);

        Console.WriteLine();
        Console.WriteLine("=== After Battle ===");
        knight.ShowStatus();
    }
}
