using System;
using System.Collections.Generic;
using System.Linq;

class BattleWeapon
{
    public string Name { get; set; }
    public int Damage { get; set; }
    public int Price { get; set; }
}

class LINQSortingDemo
{
    static void Main()
    {
        List<BattleWeapon> weapons = new List<BattleWeapon>()
        {
            new BattleWeapon { Name = "Iron Sword", Damage = 50, Price = 300 },
            new BattleWeapon { Name = "Fire Blade", Damage = 90, Price = 700 },
            new BattleWeapon { Name = "Dark Axe", Damage = 70, Price = 500 },
            new BattleWeapon { Name = "Crystal Sword", Damage = 50, Price = 600 },
            new BattleWeapon { Name = "Dragon Spear", Damage = 90, Price = 1000 }
        };

        var sortedWeapons = weapons
            .OrderBy(weapon => weapon.Damage)
            .ThenBy(weapon => weapon.Name);

        Console.WriteLine("Weapons Sorted by Damage and Name:");

        foreach (var weapon in sortedWeapons)
        {
            Console.WriteLine(weapon.Name + " - Damage: " + weapon.Damage);
        }

        var highestDamage = weapons.OrderByDescending(weapon => weapon.Damage);

        Console.WriteLine("\nHighest Damage First:");

        foreach (var weapon in highestDamage)
        {
            Console.WriteLine(weapon.Name + " - Damage: " + weapon.Damage);
        }
    }
}