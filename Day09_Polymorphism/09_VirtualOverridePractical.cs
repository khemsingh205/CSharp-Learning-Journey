
using System;

class MagicEnemy
{
    public virtual void UsePower()
    {
        Console.WriteLine("Enemy uses a normal power!");
    }
}

class BloodSkeleton : MagicEnemy
{
    public override void UsePower()
    {
        Console.WriteLine("Blood Skeleton uses a blood sword attack!");
    }
}

class FireMonster : MagicEnemy
{
    public override void UsePower()
    {
        Console.WriteLine("Fire Monster releases burning flames!");
    }
}

class IceGuardian : MagicEnemy
{
    public override void UsePower()
    {
        Console.WriteLine("Ice Guardian creates a freezing storm!");
    }
}

class Day09Lesson09
{
    static void Main()
    {
        Console.WriteLine("=== ENEMY SPECIAL ABILITIES ===");
        Console.WriteLine();

        MagicEnemy enemy1 = new BloodSkeleton();
        MagicEnemy enemy2 = new FireMonster();
        MagicEnemy enemy3 = new IceGuardian();

        enemy1.UsePower();
        enemy2.UsePower();
        enemy3.UsePower();

        Console.WriteLine();
        Console.WriteLine("All special abilities completed!");
    }
}
