
using System;

class BaseDungeonFighter
{
    public string name;
    public int health;

    public BaseDungeonFighter(string characterName, int characterHealth)
    {
        name = characterName;
        health = characterHealth;

        Console.WriteLine("Parent Constructor Called!");
    }

    public void Attack()
    {
        Console.WriteLine(name + " performs a normal attack!");
    }
}

class BaseDarkWarrior : BaseDungeonFighter
{
    public BaseDarkWarrior()
        : base("Dark Warrior", 500)
    {
        Console.WriteLine("Child Constructor Called!");
    }

    public void SpecialAttack()
    {
        base.Attack();

        Console.WriteLine(name + " performs a powerful special attack!");
    }
}

class Lesson05_BaseKeyword
{
    static void Main()
    {
        Console.WriteLine("=== DARK DUNGEON COMBAT ===");

        BaseDarkWarrior warrior = new BaseDarkWarrior();

        Console.WriteLine("Name: " + warrior.name);
        Console.WriteLine("Health: " + warrior.health);

        Console.WriteLine();

        warrior.SpecialAttack();

        Console.ReadKey();
    }
}
