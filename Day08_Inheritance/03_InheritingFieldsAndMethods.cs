
using System;

// Parent Class
class CombatCharacter
{
    public string name;
    public int health;
    public int damage;

    // Parent Method 1
    public void ShowStats()
    {
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Health: " + health);
        Console.WriteLine("Damage: " + damage);
    }

    // Parent Method 2
    public void Attack()
    {
        Console.WriteLine(name + " attacks for " + damage + " damage!");
    }

    // Parent Method 3
    public void TakeDamage(int incomingDamage)
    {
        health = health - incomingDamage;

        Console.WriteLine(name + " received " + incomingDamage + " damage.");

        Console.WriteLine("Remaining Health: " + health);
    }
}

// Child Class 1
class DarkKnight : CombatCharacter
{
}

// Child Class 2
class SkeletonWarrior : CombatCharacter
{
}

// Child Class 3
class DarkMage : CombatCharacter
{
}

// Main Program
class Lesson03_InheritingMembers
{
    static void Main(string[] args)
    {
        
        DarkKnight knight = new DarkKnight();

        knight.name = "Dark Knight";
        knight.health = 500;
        knight.damage = 80;

      
        SkeletonWarrior skeleton = new SkeletonWarrior();

        skeleton.name = "Skeleton Warrior";
        skeleton.health = 200;
        skeleton.damage = 35;

       
        DarkMage mage = new DarkMage();

        mage.name = "Dark Mage";
        mage.health = 350;
        mage.damage = 65;

       
        Console.WriteLine("=== KNIGHT ===");

        knight.ShowStats();
        knight.Attack();
        knight.TakeDamage(100);

        Console.WriteLine();

        
        Console.WriteLine("=== SKELETON ===");

        skeleton.ShowStats();
        skeleton.Attack();
        skeleton.TakeDamage(50);

        Console.WriteLine();

      
        Console.WriteLine("=== DARK MAGE ===");

        mage.ShowStats();
        mage.Attack();
        mage.TakeDamage(75);

        Console.ReadLine();
    }
}
