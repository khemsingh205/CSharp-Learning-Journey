
using System;

class PolySkeletonWarrior
{
    public void Attack()
    {
        Console.WriteLine("Skeleton Warrior attacks with a sword!");
    }
}

class PolySkeletonArcher
{
    public void Attack()
    {
        Console.WriteLine("Skeleton Archer shoots an arrow!");
    }
}

class PolyDarkMage
{
    public void Attack()
    {
        Console.WriteLine("Dark Mage casts a dark magic spell!");
    }
}

class Day09Lesson01
{
    static void Main()
    {
        Console.WriteLine("=== DARK FANTASY COMBAT SYSTEM ===");
        Console.WriteLine();


        PolySkeletonWarrior warrior = new PolySkeletonWarrior();
        PolySkeletonArcher archer = new PolySkeletonArcher();
        PolyDarkMage mage = new PolyDarkMage();


        warrior.Attack();

        archer.Attack();

        mage.Attack();

        Console.WriteLine();
        Console.WriteLine("Combat demonstration completed!");

        Console.ReadKey();
    }
}
