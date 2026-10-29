
using System;

class DarkFantasyPlayer
{
    public string Name { get; private set; }

    private int health;
    private int stamina;

    public DarkFantasyPlayer(string playerName, int startingHealth, int startingStamina)
    {
        Name = playerName;

        health = startingHealth;
        stamina = startingStamina;
    }

    public void ShowStatus()
    {
        Console.WriteLine("Player: " + Name);
        Console.WriteLine("Health: " + health);
        Console.WriteLine("Stamina: " + stamina);
    }

    public void Attack()
    {
        if (health <= 0)
        {
            Console.WriteLine(Name + " cannot attack because they are defeated.");
            return;
        }

        if (stamina < 20)
        {
            Console.WriteLine("Not enough stamina to attack!");
            return;
        }

        stamina -= 20;

        Console.WriteLine(Name + " attacks the enemy!");
        Console.WriteLine("Stamina decreased by 20.");
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

        Console.WriteLine(Name + " takes " + damage + " damage!");
    }
}

class PlayerStatusSystemLesson
{
    static void Main()
    {
        DarkFantasyPlayer player =
            new DarkFantasyPlayer("Ashen Knight", 100, 60);

        Console.WriteLine("=== Initial Status ===");
        player.ShowStatus();

        Console.WriteLine();

        player.Attack();

        Console.WriteLine();

        player.TakeDamage(35);

        Console.WriteLine();
        Console.WriteLine("=== Final Status ===");
        player.ShowStatus();
    }
}
