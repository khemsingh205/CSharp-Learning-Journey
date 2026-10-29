
using System;

class DungeonWarrior
{
    public string unitName;
    public int health;
    public int damage;

    // Constructor
    public DungeonWarrior(string name, int startingHealth, int attackDamage)
    {
        unitName = name;
        health = startingHealth;
        damage = attackDamage;
    }

    public void ShowStatus()
    {
        Console.WriteLine("Name: " + unitName);
        Console.WriteLine("Health: " + health);
        Console.WriteLine("Damage: " + damage);
    }
}

class ConstructorLesson
{
    static void Main()
    {
        DungeonWarrior knight =
            new DungeonWarrior("Dark Knight", 150, 35);

        DungeonWarrior skeleton =
            new DungeonWarrior("Skeleton Warrior", 80, 15);

        Console.WriteLine("=== Dungeon Characters ===");

        knight.ShowStatus();

        Console.WriteLine();

        skeleton.ShowStatus();
    }
}

