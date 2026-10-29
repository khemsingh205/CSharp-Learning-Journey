
using System;

class CombatUnit
{
    public string unitName;
    public int health;
    public int damage;
}

class FieldsLesson
{
    static void Main()
    {
        CombatUnit knight = new CombatUnit();
        CombatUnit skeleton = new CombatUnit();

        knight.unitName = "Dark Knight";
        knight.health = 150;
        knight.damage = 35;

        skeleton.unitName = "Skeleton Warrior";
        skeleton.health = 80;
        skeleton.damage = 15;

        Console.WriteLine("=== Dungeon Combat Status ===");

        Console.WriteLine("Knight: " + knight.unitName);
        Console.WriteLine("Health: " + knight.health);
        Console.WriteLine("Damage: " + knight.damage);

        Console.WriteLine();

        Console.WriteLine("Enemy: " + skeleton.unitName);
        Console.WriteLine("Health: " + skeleton.health);
        Console.WriteLine("Damage: " + skeleton.damage);
    }
}
