using System;
using System.Collections.Generic;
using System.Linq;

class DungeonWeapon
{
    public string Name { get; set; }
    public string Category { get; set; }
    public int Damage { get; set; }
}

class LINQGroupByDemo
{
    static void Main()
    {
        List<DungeonWeapon> weapons = new List<DungeonWeapon>()
        {
            new DungeonWeapon { Name = "Iron Sword", Category = "Sword", Damage = 50 },
            new DungeonWeapon { Name = "Fire Sword", Category = "Sword", Damage = 90 },
            new DungeonWeapon { Name = "Battle Axe", Category = "Axe", Damage = 70 },
            new DungeonWeapon { Name = "Dark Axe", Category = "Axe", Damage = 100 },
            new DungeonWeapon { Name = "Long Bow", Category = "Bow", Damage = 60 },
            new DungeonWeapon { Name = "Magic Staff", Category = "Staff", Damage = 85 }
        };

        var groupedWeapons = weapons.GroupBy(weapon => weapon.Category);

        foreach (var group in groupedWeapons)
        {
            Console.WriteLine("\nCategory: " + group.Key);

            foreach (var weapon in group)
            {
                Console.WriteLine(weapon.Name + " - Damage: " + weapon.Damage);
            }
        }
    }
}