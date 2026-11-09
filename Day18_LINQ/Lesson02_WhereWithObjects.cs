using System;
using System.Collections.Generic;
using System.Linq;

namespace Day18_Lesson02_WhereWithObjects
{
    class Weapon
    {
        public string Name;
        public int Damage;
        public string Rarity;

        public Weapon(string name, int damage, string rarity)
        {
            Name = name;
            Damage = damage;
            Rarity = rarity;
        }
    }

    class Lesson02Runner
    {
        static void Main()
        {
            Console.WriteLine("Dark Fantasy RPG - Weapon Filter");

            List<Weapon> weapons = new List<Weapon>
            {
                new Weapon("Rusty Dagger", 8, "Common"),
                new Weapon("Iron Sword", 25, "Common"),
                new Weapon("Shadow Blade", 55, "Rare"),
                new Weapon("Dragon Slayer", 90, "Legendary")
            };

            var rareWeapons = weapons.Where(w => w.Rarity != "Common");

            foreach (Weapon weapon in rareWeapons)
            {
                Console.WriteLine(weapon.Name + " - " + weapon.Rarity + " (" + weapon.Damage + " damage)");
            }
        }
    }
}