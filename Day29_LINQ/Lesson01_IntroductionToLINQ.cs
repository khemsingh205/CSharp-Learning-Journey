using System;
using System.Collections.Generic;
using System.Linq;

class WeaponData
{
    public string Name { get; set; }
    public int Damage { get; set; }
}

class LINQIntroductionDemo
{
    static void Main()
    {
        List<WeaponData> weapons = new List<WeaponData>()
        {
            new WeaponData { Name = "Iron Sword", Damage = 30 },
            new WeaponData { Name = "Fire Blade", Damage = 75 },
            new WeaponData { Name = "Dark Axe", Damage = 90 },
            new WeaponData { Name = "Wooden Staff", Damage = 20 },
            new WeaponData { Name = "Dragon Spear", Damage = 100 }
        };

        var powerfulWeapons = from weapon in weapons
                              where weapon.Damage > 50
                              select weapon;

        Console.WriteLine("Powerful Weapons:");

        foreach (var weapon in powerfulWeapons)
        {
            Console.WriteLine(weapon.Name + " - Damage: " + weapon.Damage);
        }
    }
}