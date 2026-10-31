

using System;

class ArenaFighterBase
{
    public virtual void UseSkill()
    {
        Console.WriteLine("Fighter uses a basic skill.");
    }
}

class ThunderPaladin : ArenaFighterBase
{
    public override void UseSkill()
    {
        Console.WriteLine("Thunder Paladin summons a lightning hammer!");
    }
}

class VoidReaper : ArenaFighterBase
{
    public override void UseSkill()
    {
        Console.WriteLine("Void Reaper opens a dark energy portal!");
    }
}

class CrystalGuardian : ArenaFighterBase
{
    public override void UseSkill()
    {
        Console.WriteLine("Crystal Guardian creates a protective crystal shield!");
    }
}

class BloodSorcerer : ArenaFighterBase
{
    public override void UseSkill()
    {
        Console.WriteLine("Blood Sorcerer releases a forbidden blood curse!");
    }
}

class Day09Lesson11
{
    static void Main()
    {
        Console.WriteLine("=== FORGOTTEN ARENA ===");
        Console.WriteLine();

        ArenaFighterBase[] fighters = new ArenaFighterBase[4];

        fighters[0] = new ThunderPaladin();
        fighters[1] = new VoidReaper();
        fighters[2] = new CrystalGuardian();
        fighters[3] = new BloodSorcerer();

        for (int i = 0; i < fighters.Length; i++)
        {
            Console.WriteLine("Fighter " + (i + 1) + " uses skill:");
            fighters[i].UseSkill();
            Console.WriteLine();
        }

        Console.WriteLine("Arena battle is finished!");
    }
}
