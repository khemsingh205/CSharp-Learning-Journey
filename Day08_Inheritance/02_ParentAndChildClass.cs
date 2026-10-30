
using System;


class GameCharacter
{
    public string name;
    public int health;

    public void ShowCharacter()
    {
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Health: " + health);
    }
}


class KnightCharacter : GameCharacter
{

}

class SkeletonCharacter : GameCharacter
{

}


class MageCharacter : GameCharacter
{
}
class Lesson02_ParentChild
{
    static void Main(string[] args)
    {
        
        KnightCharacter knight = new KnightCharacter();

        knight.name = "Ancient Knight";
        knight.health = 500;

        
        SkeletonCharacter skeleton = new SkeletonCharacter();

        skeleton.name = "Dungeon Skeleton";
        skeleton.health = 200;

        
        MageCharacter mage = new MageCharacter();

        mage.name = "Dark Mage";
        mage.health = 350;

        
        Console.WriteLine("=== KNIGHT ===");
        knight.ShowCharacter();

        Console.WriteLine();

        Console.WriteLine("=== SKELETON ===");
        skeleton.ShowCharacter();

        Console.WriteLine();

        Console.WriteLine("=== DARK MAGE ===");
        mage.ShowCharacter();

        Console.ReadLine();
    }
}
