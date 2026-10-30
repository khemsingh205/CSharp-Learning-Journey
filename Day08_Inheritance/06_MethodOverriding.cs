
using System;

class OverrideDungeonEnemy
{
    public virtual void Attack()
    {
        Console.WriteLine("Dungeon Enemy performs a basic attack!");
    }
}

class OverrideDarkKnight : OverrideDungeonEnemy
{
    public override void Attack()
    {
        Console.WriteLine("Dark Knight attacks with a heavy sword!");
    }
}

class OverrideSkeletonWarrior : OverrideDungeonEnemy
{
    public override void Attack()
    {
        Console.WriteLine("Skeleton Warrior attacks with a bone sword!");
    }
}

class OverrideDarkMage : OverrideDungeonEnemy
{
    public override void Attack()
    {
        Console.WriteLine("Dark Mage launches a dark magic attack!");
    }
}

class Lesson06_MethodOverriding
{
    static void Main()
    {
        Console.WriteLine("=== DUNGEON ENEMY COMBAT ===");

        OverrideDungeonEnemy enemy1 = new OverrideDarkKnight();
        OverrideDungeonEnemy enemy2 = new OverrideSkeletonWarrior();
        OverrideDungeonEnemy enemy3 = new OverrideDarkMage();

        enemy1.Attack();
        enemy2.Attack();
        enemy3.Attack();

        Console.ReadKey();
    }
}
