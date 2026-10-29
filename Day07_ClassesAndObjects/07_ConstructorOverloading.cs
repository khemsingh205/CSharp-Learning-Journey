
using System;

class DungeonEnemy
{
    public string enemyName;
    public int health;
    public int damage;

    // Constructor 1: Default values
    public DungeonEnemy()
    {
        enemyName = "Unknown Enemy";
        health = 50;
        damage = 10;
    }

    // Constructor 2: Custom values
    public DungeonEnemy(string name, int startingHealth, int attackDamage)
    {
        enemyName = name;
        health = startingHealth;
        damage = attackDamage;
    }

    public void ShowStatus()
    {
        Console.WriteLine("Enemy: " + enemyName);
        Console.WriteLine("Health: " + health);
        Console.WriteLine("Damage: " + damage);
    }
}

class ConstructorOverloadingLesson
{
    static void Main()
    {
        DungeonEnemy enemy1 = new DungeonEnemy();

        DungeonEnemy enemy2 =
            new DungeonEnemy("Skeleton Warrior", 80, 15);

        Console.WriteLine("=== Enemy 1: Default Constructor ===");
        enemy1.ShowStatus();

        Console.WriteLine();

        Console.WriteLine("=== Enemy 2: Custom Constructor ===");
        enemy2.ShowStatus();
    }
}
