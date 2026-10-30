
using System;

class VirtualGameCharacter
{
    public string name;
    public int health;

    public VirtualGameCharacter(string characterName, int characterHealth)
    {
        name = characterName;
        health = characterHealth;
    }

    public virtual void TakeDamage(int damage)
    {
        health -= damage;

        Console.WriteLine(name + " takes " + damage + " damage!");
        Console.WriteLine("Remaining Health: " + health);
    }
}

class VirtualArmoredKnight : VirtualGameCharacter
{
    public VirtualArmoredKnight()
        : base("Armored Knight", 500)
    {
    }

    public override void TakeDamage(int damage)
    {
        int reducedDamage = damage / 2;

        health -= reducedDamage;

        Console.WriteLine(name + " blocks half of the damage!");
        Console.WriteLine("Actual Damage: " + reducedDamage);
        Console.WriteLine("Remaining Health: " + health);
    }
}

class VirtualSkeleton : VirtualGameCharacter
{
    public VirtualSkeleton()
        : base("Skeleton Warrior", 200)
    {
    }

    
}

class Lesson07_VirtualAndOverride
{
    static void Main()
    {
        Console.WriteLine("=== DUNGEON DAMAGE SYSTEM ===");

        VirtualArmoredKnight knight = new VirtualArmoredKnight();
        VirtualSkeleton skeleton = new VirtualSkeleton();

        Console.WriteLine("\n--- Knight Takes Damage ---");
        knight.TakeDamage(100);

        Console.WriteLine("\n--- Skeleton Takes Damage ---");
        skeleton.TakeDamage(100);

        Console.ReadKey();
    }
}
