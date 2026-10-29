
using System;

class DungeonFighter
{
    public string fighterName;
    public int health;
    public int damage;

    public void ShowStatus()
    {
        Console.WriteLine("Fighter: " + fighterName);
        Console.WriteLine("Health: " + health);
        Console.WriteLine("Damage: " + damage);
    }

    public void Attack()
    {
        Console.WriteLine(fighterName + " attacks for " + damage + " damage!");
    }
}

class MethodsLesson
{
    static void Main()
    {
        DungeonFighter knight = new DungeonFighter();

        knight.fighterName = "Dark Knight";
        knight.health = 150;
        knight.damage = 35;

        Console.WriteLine("=== Dungeon Battle ===");

        knight.ShowStatus();

        Console.WriteLine();

        knight.Attack();
    }
}
