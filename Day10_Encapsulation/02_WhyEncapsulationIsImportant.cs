
using System;

class RPGPlayer
{
    private int health = 100;

    public void DisplayHealth()
    {
        Console.WriteLine("Player Health: " + health);
    }

    public void ReceiveDamage(int damage)
    {
        if (damage > 0)
        {
            health = health - damage;

            if (health < 0)
            {
                health = 0;
            }

            Console.WriteLine("Enemy attacked the player!");
        }
        else
        {
            Console.WriteLine("Invalid damage!");
        }
    }

    public void RestoreHealth(int healing)
    {
        if (healing > 0)
        {
            health = health + healing;

            if (health > 100)
            {
                health = 100;
            }

            Console.WriteLine("Player recovered health!");
        }
        else
        {
            Console.WriteLine("Invalid healing!");
        }
    }
}

class Lesson02_Encapsulation
{
    static void Main()
    {
        RPGPlayer hero = new RPGPlayer();

        Console.WriteLine("=== DARK FANTASY BATTLE ===");

        hero.DisplayHealth();

        hero.ReceiveDamage(40);
        hero.DisplayHealth();

        hero.RestoreHealth(20);
        hero.DisplayHealth();

        hero.ReceiveDamage(200);
        hero.DisplayHealth();

        Console.ReadLine();
    }
}
