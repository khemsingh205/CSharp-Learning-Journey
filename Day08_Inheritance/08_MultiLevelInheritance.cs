

using System;

class DungeonBaseHero
{
    public void ShowHeroName()
    {
        Console.WriteLine("Hero: Blood Hunter");
    }
}

class DungeonAdvancedHero : DungeonBaseHero
{
    public void ShowWeapon()
    {
        Console.WriteLine("Weapon: Cursed Sword");
    }
}

class DungeonFinalHero : DungeonAdvancedHero
{
    public void ShowSpecialPower()
    {
        Console.WriteLine("Special Power: Shadow Explosion!");
    }
}

class Lesson08_NewMultiLevel
{
    static void Main()
    {
        Console.WriteLine("=== DUNGEON HERO SYSTEM ===");

        DungeonFinalHero hero = new DungeonFinalHero();

        hero.ShowHeroName();
        hero.ShowWeapon();
        hero.ShowSpecialPower();

        Console.ReadKey();
    }
}
