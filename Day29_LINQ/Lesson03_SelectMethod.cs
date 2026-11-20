using System;
using System.Collections.Generic;
using System.Linq;

class MagicWeapon
{
    public string Name { get; set; }
    public int Damage { get; set; }
    public int Price { get; set; }
}

class LINQSelectDemo
{
    static void Main()
    {
        List<MagicWeapon> weapons = new List<MagicWeapon>()
        {
            new MagicWeapon { Name = "Flame Sword", Damage = 80, Price = 500 },
            new MagicWeapon { Name = "Ice Staff", Damage = 60, Price = 400 },
            new MagicWeapon { Name = "Shadow Dagger", Damage = 95, Price = 700 },
            new MagicWeapon { Name = "Thunder Axe", Damage = 100, Price = 900 }
        };

        var weaponNames = weapons.Select(weapon => weapon.Name);

        Console.WriteLine("Weapon Names:");

        foreach (var name in weaponNames)
        {
            Console.WriteLine(name);
        }

        var doubleDamage = weapons.Select(weapon => weapon.Damage * 2);

        Console.WriteLine("\nDouble Weapon Damage:");

        foreach (var damage in doubleDamage)
        {
            Console.WriteLine(damage);
        }
    }
}