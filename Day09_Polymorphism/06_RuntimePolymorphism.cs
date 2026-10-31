
using System;
class RuntimeEnemy
{
    public virtual void Attack()
    {
        Console.WriteLine("Enemy performs a basic attack!");
    }
}
class RuntimeSkeleton : RuntimeEnemy
{
    public override void Attack()
    {
        Console.WriteLine("Skeleton attacks with a rusty sword!");
    }
}
class RuntimeArcher : RuntimeEnemy
{
    public override void Attack()
    {
        Console.WriteLine("Skeleton Archer shoots a deadly arrow!");
    }
}
class RuntimeDarkMage : RuntimeEnemy
{
    public override void Attack()
    {
        Console.WriteLine("Dark Mage casts a dark magic spell!");
    }
}
class Day09Lesson06
{
    static void Main()
    {
        Console.WriteLine("=== DARK FANTASY DUNGEON ===");
        Console.WriteLine();

        RuntimeEnemy enemy1 = new RuntimeSkeleton();
        RuntimeEnemy enemy2 = new RuntimeArcher();
        RuntimeEnemy enemy3 = new RuntimeDarkMage();

        enemy1.Attack();

        enemy2.Attack();

        enemy3.Attack();

        Console.WriteLine();
        Console.WriteLine("Dungeon combat completed!");

        Console.ReadKey();
    }
}
