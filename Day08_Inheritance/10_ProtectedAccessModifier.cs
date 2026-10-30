
using System;

class ProtectedDungeonCreature
{
    protected int health = 500;

    public void ShowCreature()
    {
        Console.WriteLine("Dungeon Creature Created!");
    }
}

class ProtectedShadowBeast : ProtectedDungeonCreature
{
    public void TakeDamage(int damage)
    {
        health = health - damage;

        Console.WriteLine("Shadow Beast takes damage!");
        Console.WriteLine("Remaining Health: " + health);
    }

    public void ShowHealth()
    {
        Console.WriteLine("Current Health: " + health);
    }
}

class Lesson10_ProtectedAccess
{
    static void Main()
    {
        Console.WriteLine("=== SHADOW BEAST COMBAT ===");

        ProtectedShadowBeast beast = new ProtectedShadowBeast();

        beast.ShowCreature();
        beast.ShowHealth();

        Console.WriteLine();

        beast.TakeDamage(100);

        Console.WriteLine();

        beast.TakeDamage(150);

        Console.ReadKey();
    }
}
