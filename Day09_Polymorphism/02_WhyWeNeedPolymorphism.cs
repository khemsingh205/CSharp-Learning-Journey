
using System;

// Skeleton Warrior
class NeedPolyWarrior
{
    public void Attack()
    {
        Console.WriteLine("Warrior attacks with a sword!");
    }
}

// Skeleton Archer
class NeedPolyArcher
{
    public void Attack()
    {
        Console.WriteLine("Archer shoots an arrow!");
    }
}

// Dark Mage
class NeedPolyMage
{
    public void Attack()
    {
        Console.WriteLine("Mage casts dark magic!");
    }
}

// Main Program
class Day09Lesson02
{
    static void Main()
    {
        Console.WriteLine("=== DUNGEON COMBAT ===");
        Console.WriteLine();

        // Creating enemy objects
        NeedPolyWarrior warrior = new NeedPolyWarrior();
        NeedPolyArcher archer = new NeedPolyArcher();
        NeedPolyMage mage = new NeedPolyMage();

        // Individually controlling enemies
        Console.WriteLine("Enemy 1:");
        warrior.Attack();

        Console.WriteLine();

        Console.WriteLine("Enemy 2:");
        archer.Attack();

        Console.WriteLine();

        Console.WriteLine("Enemy 3:");
        mage.Attack();

        Console.WriteLine();
        Console.WriteLine("Dungeon combat completed!");

        Console.ReadKey();
    }
}
