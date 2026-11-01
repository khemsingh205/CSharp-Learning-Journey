
using System;

class FinalDarkKnight
{
    public string Name { get; private set; }

    public int Health { get; private set; }

    public int Stamina { get; private set; }

    public int MaxHealth { get; private set; }

    public FinalDarkKnight(string name)
    {
        Name = name;
        MaxHealth = 100;
        Health = 100;
        Stamina = 50;
    }

    public void Attack(FinalDungeonEnemy enemy)
    {
        if (Health <= 0)
        {
            Console.WriteLine(Name + " is dead!");
            return;
        }

        if (Stamina < 10)
        {
            Console.WriteLine("Not enough stamina to attack!");
            return;
        }

        Stamina = Stamina - 10;

        Console.WriteLine(Name + " attacks " + enemy.Name + "!");

        enemy.ReceiveDamage(30);
    }

    public void ReceiveDamage(int damage)
    {
        if (Health <= 0)
        {
            Console.WriteLine(Name + " is already defeated!");
            return;
        }

        if (damage <= 0)
        {
            Console.WriteLine("Invalid damage!");
            return;
        }

        Health = Health - damage;

        if (Health < 0)
        {
            Health = 0;
        }

        Console.WriteLine(Name + " received " + damage + " damage!");
    }

    public void UseHealingPotion(int healing)
    {
        if (Health <= 0)
        {
            Console.WriteLine("Cannot heal a defeated character!");
            return;
        }

        if (healing <= 0)
        {
            Console.WriteLine("Invalid healing amount!");
            return;
        }

        Health = Health + healing;

        if (Health > MaxHealth)
        {
            Health = MaxHealth;
        }

        Console.WriteLine(Name + " used a Healing Potion!");
    }

    public void ShowCharacterStatus()
    {
        Console.WriteLine("----- CHARACTER STATUS -----");
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Health: " + Health + "/" + MaxHealth);
        Console.WriteLine("Stamina: " + Stamina);
    }
}

class FinalDungeonEnemy
{
    public string Name { get; private set; }

    public int Health { get; private set; }

    public FinalDungeonEnemy(string name)
    {
        Name = name;
        Health = 90;
    }

    public void ReceiveDamage(int damage)
    {
        if (Health <= 0)
        {
            Console.WriteLine(Name + " is already defeated!");
            return;
        }

        Health = Health - damage;

        if (Health < 0)
        {
            Health = 0;
        }

        Console.WriteLine(Name + " received " + damage + " damage!");

        if (Health == 0)
        {
            Console.WriteLine(Name + " has been defeated!");
        }
    }

    public void AttackHero(FinalDarkKnight hero)
    {
        if (Health <= 0)
        {
            Console.WriteLine(Name + " cannot attack. Enemy is defeated!");
            return;
        }

        Console.WriteLine(Name + " attacks " + hero.Name + "!");

        hero.ReceiveDamage(25);
    }

    public void ShowEnemyStatus()
    {
        Console.WriteLine("Enemy: " + Name);
        Console.WriteLine("Enemy Health: " + Health);
    }
}

class Day10Lesson08Runner
{
    static void Main()
    {
        FinalDarkKnight hero = new FinalDarkKnight("Shadow Knight");

        FinalDungeonEnemy enemy = new FinalDungeonEnemy("Ancient Demon");

        Console.WriteLine("=== DARK FANTASY CHARACTER SYSTEM ===");

        hero.ShowCharacterStatus();

        Console.WriteLine();

        enemy.ShowEnemyStatus();

        Console.WriteLine("\n=== BATTLE START ===");

        hero.Attack(enemy);

        enemy.ShowEnemyStatus();

        Console.WriteLine();

        enemy.AttackHero(hero);

        hero.ShowCharacterStatus();

        Console.WriteLine();

        hero.UseHealingPotion(20);

        hero.ShowCharacterStatus();

        Console.WriteLine();

        hero.Attack(enemy);

        hero.Attack(enemy);

        Console.WriteLine();

        enemy.ShowEnemyStatus();

        Console.WriteLine("\n=== FINAL BATTLE STATUS ===");

        hero.ShowCharacterStatus();

        enemy.ShowEnemyStatus();

        Console.ReadLine();
    }
}
