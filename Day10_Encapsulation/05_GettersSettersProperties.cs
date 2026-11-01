
using System;

class ShadowKnight
{
    private int hiddenHealth = 100;

    public int Health
    {
        get
        {
            return hiddenHealth;
        }

        set
        {
            if (value >= 0 && value <= 100)
            {
                hiddenHealth = value;
            }
            else
            {
                Console.WriteLine("Invalid Health Value!");
            }
        }
    }

    public void DisplayKnightHealth()
    {
        Console.WriteLine("Shadow Knight Health: " + Health);
    }
}

class Day10Lesson05Runner
{
    static void Main()
    {
        ShadowKnight darkWarrior = new ShadowKnight();

        Console.WriteLine("=== SHADOW KNIGHT STATUS ===");

        darkWarrior.DisplayKnightHealth();

        darkWarrior.Health = 70;

        darkWarrior.DisplayKnightHealth();

        darkWarrior.Health = 150;

        darkWarrior.DisplayKnightHealth();

        darkWarrior.Health = 0;

        darkWarrior.DisplayKnightHealth();

        Console.ReadLine();
    }
}
