
using System;

// PARENT CLASS
class FinalDungeonCharacter
{
    public string name;
    protected int health;

    public FinalDungeonCharacter(string characterName, int characterHealth)
    {
        name = characterName;
        health = characterHealth;

        Console.WriteLine(name + " has entered the dungeon!");
    }

    public void ShowHealth()
    {
        Console.WriteLine(name + " Health: " + health);
    }

    public void TakeDamage(int damage)
    {
        health -= damage;

        if (health < 0)
        {
            health = 0;
        }

        Console.WriteLine(name + " takes " + damage + " damage!");
        Console.WriteLine("Remaining Health: " + health);
    }

    public virtual void Attack()
    {
        Console.WriteLine(name + " performs a basic attack!");
    }
}

// CHILD CLASS 1
class FinalKnight : FinalDungeonCharacter
{
    public FinalKnight()
        : base("Dark Knight", 500)
    {
    }

    public override void Attack()
    {
        Console.WriteLine(name + " attacks with a cursed sword!");
    }
}

// CHILD CLASS 2
class FinalMage : FinalDungeonCharacter
{
    public FinalMage()
        : base("Dark Mage", 350)
    {
    }

    public override void Attack()
    {
        Console.WriteLine(name + " casts a powerful dark spell!");
    }
}

// CHILD CLASS 3
class FinalSkeleton : FinalDungeonCharacter
{
    public FinalSkeleton()
        : base("Skeleton Warrior", 200)
    {
    }

    public override void Attack()
    {
        Console.WriteLine(name + " attacks with a bone sword!");
    }
}

// MAIN CLASS
class Lesson11_DarkFantasyInheritance
{
    static void Main()
    {
        Console.WriteLine("=== DARK FANTASY DUNGEON ===");
        Console.WriteLine();

        FinalKnight knight = new FinalKnight();
        FinalMage mage = new FinalMage();
        FinalSkeleton skeleton = new FinalSkeleton();

        Console.WriteLine();
        Console.WriteLine("=== CHARACTER ATTACKS ===");

        knight.Attack();
        mage.Attack();
        skeleton.Attack();

        Console.WriteLine();
        Console.WriteLine("=== COMBAT DAMAGE ===");

        knight.TakeDamage(100);
        mage.TakeDamage(150);
        skeleton.TakeDamage(50);

        Console.WriteLine();
        Console.WriteLine("=== FINAL CHARACTER STATUS ===");

        knight.ShowHealth();
        mage.ShowHealth();
        skeleton.ShowHealth();

        Console.ReadKey();
    }
}
