
using System;

class DungeonEnemy
{
    public virtual void Attack()
    {
        Console.WriteLine("Enemy performs a basic attack!");
    }
}

class SkeletonWarrior : DungeonEnemy
{
    public override void Attack()
    {
        Console.WriteLine("Skeleton Warrior attacks with a rusty sword!");
    }
}

class DarkKnight : DungeonEnemy
{
    public override void Attack()
    {
        Console.WriteLine("Dark Knight attacks with a cursed greatsword!");
    }
}

class DungeonBoss : DungeonEnemy
{
    public override void Attack()
    {
        Console.WriteLine("Dungeon Boss unleashes a devastating attack!");
    }
}

class Day09Lesson07
{
    static void Main()
    {
        Console.WriteLine("=== DUNGEON ENEMY COMBAT ===");
        Console.WriteLine();

        DungeonEnemy enemy1 = new SkeletonWarrior();
        DungeonEnemy enemy2 = new DarkKnight();
        DungeonEnemy enemy3 = new DungeonBoss();

        enemy1.Attack();
        enemy2.Attack();
        enemy3.Attack();

        Console.WriteLine();
        Console.WriteLine("All enemies have attacked!");
    }
}
