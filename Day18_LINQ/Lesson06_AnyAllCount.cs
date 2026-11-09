using System;
using System.Collections.Generic;
using System.Linq;

namespace Day18_Lesson06_AnyAllCount
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

    class Lesson06Runner
    {
        static void Main()
        {
            Console.WriteLine("Dark Fantasy RPG - Inventory Questions");

            List<Weapon> weapons = new List<Weapon>
            {
                new Weapon("Rusty Dagger", 8, "Common"),
                new Weapon("Iron Sword", 25, "Common"),
                new Weapon("Shadow Blade", 55, "Rare")
            };

            bool hasLegendary = weapons.Any(w => w.Rarity == "Legendary");
            Console.WriteLine("Has legendary weapon? " + hasLegendary);

            bool allStrong = weapons.All(w => w.Damage >= 20);
            Console.WriteLine("All weapons strong? " + allStrong);

            int commonCount = weapons.Count(w => w.Rarity == "Common");
            Console.WriteLine("Common weapons: " + commonCount);

            Console.WriteLine("Total weapons: " + weapons.Count());
        }
    }
}