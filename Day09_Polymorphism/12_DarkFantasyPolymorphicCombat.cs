
using System;

class AbyssWarrior
{
    public string Name;
    public int Health;

    public AbyssWarrior(string name, int health)
    {
        Name = name;
        Health = health;
    }

    public virtual void PerformCombatMove()
    {
        Console.WriteLine(Name + " performs a basic attack!");
    }
}

class CursedKnight : AbyssWarrior
{
    public CursedKnight() : base("Cursed Knight", 180)
    {
    }

    public override void PerformCombatMove()
    {
        Console.WriteLine(Name + " swings a cursed greatsword!");
    }
}

class PlagueHunter : AbyssWarrior
{
    public PlagueHunter() : base("Plague Hunter", 120)
    {
    }

    public override void PerformCombatMove()
    {
        Console.WriteLine(Name + " fires a poisonous crossbow bolt!");
    }
}

class AbyssSorcerer : AbyssWarrior
{
    public AbyssSorcerer() : base("Abyss Sorcerer", 100)
    {
    }

    public override void PerformCombatMove()
    {
        Console.WriteLine(Name + " summons a dark magical explosion!");
    }
}

class AncientTyrant : AbyssWarrior
{
    public AncientTyrant() : base("Ancient Tyrant", 350)
    {
    }

    public override void PerformCombatMove()
    {
        Console.WriteLine(Name + " unleashes a devastating ground smash!");
    }
}

class Day09Lesson12
{
    static void Main()
    {
        Console.WriteLine("================================");
        Console.WriteLine("   ABYSS DUNGEON BATTLE");
        Console.WriteLine("================================");
        Console.WriteLine();

        AbyssWarrior[] enemies =
        {
            new CursedKnight(),
            new PlagueHunter(),
            new AbyssSorcerer(),
            new AncientTyrant()
        };

        for (int i = 0; i < enemies.Length; i++)
        {
            Console.WriteLine("Enemy " + (i + 1));
            Console.WriteLine("Name: " + enemies[i].Name);
            Console.WriteLine("Health: " + enemies[i].Health);

            enemies[i].PerformCombatMove();

            Console.WriteLine("--------------------------------");
        }

        Console.WriteLine();
        Console.WriteLine("Dungeon battle simulation completed!");
    }
}
