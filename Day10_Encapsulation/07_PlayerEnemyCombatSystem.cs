
using System;

class DungeonHero
{
    private int health = 100;

    public string PlayerName { get; private set; }

    public DungeonHero(string name)
    {
        PlayerName = name;
    }

    public void Attack(DungeonMonster enemy)
    {
        if (health <= 0)
        {
            Console.WriteLine(PlayerName + " is dead and cannot attack!");
            return;
        }

        Console.WriteLine(PlayerName + " attacks the enemy!");

        enemy.TakeDamage(30);
    }

    public void TakeDamage(int damage)
    {
        if (health <= 0)
        {
            Console.WriteLine(PlayerName + " is already dead!");
            return;
        }

        health = health - damage;

        if (health < 0)
        {
            health = 0;
        }

        Console.WriteLine(PlayerName + " received " + damage + " damage!");
    }

    public void ShowHealth()
    {
        Console.WriteLine(PlayerName + " Health: " + health);
    }
}

class DungeonMonster
{
    private int health = 80;

    public string MonsterName { get; private set; }

    public DungeonMonster(string name)
    {
        MonsterName = name;
    }

    public void AttackHero(DungeonHero hero)
    {
        if (health <= 0)
        {
            Console.WriteLine(MonsterName + " is dead and cannot attack!");
            return;
        }

        Console.WriteLine(MonsterName + " attacks the hero!");

        hero.TakeDamage(20);
    }

    public void TakeDamage(int damage)
    {
        if (health <= 0)
        {
            Console.WriteLine(MonsterName + " is already dead!");
            return;
        }

        health = health - damage;

        if (health < 0)
        {
            health = 0;
        }

        Console.WriteLine(MonsterName + " received " + damage + " damage!");
    }

    public void ShowHealth()
    {
        Console.WriteLine(MonsterName + " Health: " + health);
    }
}

class Day10Lesson07Runner
{
    static void Main()
    {
        DungeonHero hero = new DungeonHero("Dark Knight");

        DungeonMonster monster = new DungeonMonster("Skeleton Warrior");

        Console.WriteLine("=== DARK FANTASY COMBAT ===");

        hero.ShowHealth();
        monster.ShowHealth();

        Console.WriteLine();

        hero.Attack(monster);

        monster.ShowHealth();

        Console.WriteLine();

        monster.AttackHero(hero);

        hero.ShowHealth();

        Console.WriteLine();

        hero.Attack(monster);

        monster.ShowHealth();

        Console.WriteLine();

        hero.Attack(monster);

        monster.ShowHealth();

        Console.WriteLine();

        monster.AttackHero(hero);

        hero.ShowHealth();

        Console.ReadLine();
    }
}
