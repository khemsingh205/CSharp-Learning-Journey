
using System;

class DungeonBaseCharacter
{
    public void ShowWorld()
    {
        Console.WriteLine("Location: Cursed Dungeon");
    }
}

class DungeonKnight : DungeonBaseCharacter
{
    public void KnightAttack()
    {
        Console.WriteLine("Knight attacks with a heavy sword!");
    }
}

class DungeonMage : DungeonBaseCharacter
{
    public void MageAttack()
    {
        Console.WriteLine("Mage attacks with dark magic!");
    }
}

class DungeonArcher : DungeonBaseCharacter
{
    public void ArcherAttack()
    {
        Console.WriteLine("Archer attacks with a deadly arrow!");
    }
}

class Lesson09_Hierarchical
{
    static void Main()
    {
        Console.WriteLine("=== DUNGEON CHARACTER SYSTEM ===");

        DungeonKnight knight = new DungeonKnight();
        DungeonMage mage = new DungeonMage();
        DungeonArcher archer = new DungeonArcher();

        Console.WriteLine("\n--- Knight ---");
        knight.ShowWorld();
        knight.KnightAttack();

        Console.WriteLine("\n--- Mage ---");
        mage.ShowWorld();
        mage.MageAttack();

        Console.WriteLine("\n--- Archer ---");
        archer.ShowWorld();
        archer.ArcherAttack();

        Console.ReadKey();
    }
}
