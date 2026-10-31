
using System;

class DarkCreatureBase
{
    public virtual void PerformMove()
    {
        Console.WriteLine("Creature performs a normal move.");
    }
}

class CaveTroll : DarkCreatureBase
{
    public override void PerformMove()
    {
        Console.WriteLine("Cave Troll smashes the ground with its hammer!");
    }
}

class GhostAssassin : DarkCreatureBase
{
    public override void PerformMove()
    {
        Console.WriteLine("Ghost Assassin disappears and strikes from behind!");
    }
}

class LavaBeast : DarkCreatureBase
{
    public override void PerformMove()
    {
        Console.WriteLine("Lava Beast breathes burning lava!");
    }
}

class AncientDragon : DarkCreatureBase
{
    public override void PerformMove()
    {
        Console.WriteLine("Ancient Dragon unleashes a massive flame attack!");
    }
}

class Day09Lesson10
{
    static void Main()
    {
        Console.WriteLine("=== ANCIENT DUNGEON BATTLE ===");
        Console.WriteLine();

        DarkCreatureBase creature1 = new CaveTroll();
        DarkCreatureBase creature2 = new GhostAssassin();
        DarkCreatureBase creature3 = new LavaBeast();
        DarkCreatureBase creature4 = new AncientDragon();

        creature1.PerformMove();
        creature2.PerformMove();
        creature3.PerformMove();
        creature4.PerformMove();

        Console.WriteLine();
        Console.WriteLine("All dungeon creatures have attacked!");
    }
}
