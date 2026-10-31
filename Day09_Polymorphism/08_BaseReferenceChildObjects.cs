
using System;

class DungeonCreature
{
    public virtual void ShowAbility()
    {
        Console.WriteLine("Creature uses a basic ability.");
    }
}

class IceSkeleton : DungeonCreature
{
    public override void ShowAbility()
    {
        Console.WriteLine("Ice Skeleton freezes the enemy!");
    }
}

class FireDemon : DungeonCreature
{
    public override void ShowAbility()
    {
        Console.WriteLine("Fire Demon launches a fireball!");
    }
}

class ShadowBeast : DungeonCreature
{
    public override void ShowAbility()
    {
        Console.WriteLine("Shadow Beast attacks from darkness!");
    }
}

class Day09Lesson08
{
    static void Main()
    {
        Console.WriteLine("=== DARK FANTASY CREATURES ===");
        Console.WriteLine();

        DungeonCreature creature1 = new IceSkeleton();
        DungeonCreature creature2 = new FireDemon();
        DungeonCreature creature3 = new ShadowBeast();

        creature1.ShowAbility();
        creature2.ShowAbility();
        creature3.ShowAbility();

        Console.WriteLine();
        Console.WriteLine("All creatures used their abilities!");
        Console.ReadKey();
    }
}
