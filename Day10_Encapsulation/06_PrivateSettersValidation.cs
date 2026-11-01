
using System;

class BloodKnight
{
    public int Health { get; private set; } = 100;

    public int MaxHealth { get; private set; } = 100;

    public void ReceiveBloodDamage(int damage)
    {
        if (damage <= 0)
        {
            Console.WriteLine("Invalid damage!");
            return;
        }

        Health = Health - damage;

        if (Health < 0)
        {
            Health = 0;
        }

        Console.WriteLine("Blood Knight received " + damage + " damage!");
    }

    public void DrinkHealingPotion(int healing)
    {
        if (healing <= 0)
        {
            Console.WriteLine("Invalid healing amount!");
            return;
        }

        Health = Health + healing;

        if (Health > MaxHealth)
        {
            Health = MaxHealth;
        }

        Console.WriteLine("Healing potion used!");
    }

    public void ShowStatus()
    {
        Console.WriteLine("Blood Knight Health: " + Health + "/" + MaxHealth);
    }
}

class Day10Lesson06Runner
{
    static void Main()
    {
        BloodKnight vampireWarrior = new BloodKnight();

        Console.WriteLine("=== BLOOD KNIGHT STATUS ===");

        vampireWarrior.ShowStatus();

        vampireWarrior.ReceiveBloodDamage(40);

        vampireWarrior.ShowStatus();

        vampireWarrior.DrinkHealingPotion(25);

        vampireWarrior.ShowStatus();

        vampireWarrior.DrinkHealingPotion(100);

        vampireWarrior.ShowStatus();

        vampireWarrior.ReceiveBloodDamage(200);

        vampireWarrior.ShowStatus();

        Console.ReadLine();
    }
}
