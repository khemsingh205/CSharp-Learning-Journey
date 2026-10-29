
using System;

class Combatant
{
    public string unitName;
    public int health;
    public int damage;

    public void ShowStatus()
    {
        Console.WriteLine(unitName + " Health: " + health);
    }

    public void Attack(Combatant target)
    {
        Console.WriteLine(unitName + " attacks " + target.unitName + "!");

        target.health = target.health - damage;

        if (target.health < 0)
        {
            target.health = 0;
        }

        Console.WriteLine(target.unitName + " takes " + damage + " damage!");
    }
}

class ObjectCombatLesson
{
    static void Main()
    {
        Combatant knight = new Combatant();
        Combatant skeleton = new Combatant();

        knight.unitName = "Dark Knight";
        knight.health = 150;
        knight.damage = 35;

        skeleton.unitName = "Skeleton Warrior";
        skeleton.health = 80;
        skeleton.damage = 15;

        Console.WriteLine("=== Dungeon Combat ===");

        knight.ShowStatus();
        skeleton.ShowStatus();

        Console.WriteLine();

        knight.Attack(skeleton);

        Console.WriteLine();
        Console.WriteLine("=== After Attack ===");

        knight.ShowStatus();
        skeleton.ShowStatus();
    }
}

