
using System;

class DungeonCreature
{
    public string creatureName = "Ancient Demon";

    private int secretHealth = 200;

    protected int specialDamage = 80;

    internal int rewardGold = 500;

    public void ShowCreatureInfo()
    {
        Console.WriteLine("Creature: " + creatureName);
        Console.WriteLine("Health: " + secretHealth);
        Console.WriteLine("Special Damage: " + specialDamage);
        Console.WriteLine("Reward Gold: " + rewardGold);
    }
}

class DemonWarrior : DungeonCreature
{
    public void UseSpecialAttack()
    {
        Console.WriteLine("Demon Warrior uses special attack!");

        Console.WriteLine("Special Damage: " + specialDamage);
    }
}

class Day10Lesson04Runner
{
    static void Main()
    {
        DungeonCreature boss = new DungeonCreature();

        Console.WriteLine("=== DUNGEON BOSS INFORMATION ===");

        Console.WriteLine("Name: " + boss.creatureName);

        boss.ShowCreatureInfo();

        Console.WriteLine();

        DemonWarrior warrior = new DemonWarrior();

        warrior.UseSpecialAttack();

        Console.WriteLine("Reward Gold: " + warrior.rewardGold);

        Console.ReadLine();
    }
}
