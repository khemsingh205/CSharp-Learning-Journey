

using System;

class DungeonCreature
{
    public DungeonCreature()
    {
        Console.WriteLine("Parent Constructor: Dungeon Creature Created!");
    }
}

class ShadowKnight : DungeonCreature
{
    public ShadowKnight()
    {
        Console.WriteLine("Child Constructor: Shadow Knight Created!");
    }
}

class Lesson04_Constructors
{
    static void Main()
    {
        Console.WriteLine("=== DARK DUNGEON ===");

        ShadowKnight knight = new ShadowKnight();

        Console.WriteLine("Shadow Knight is ready for battle!");
        Console.ReadKey();
    }
}
