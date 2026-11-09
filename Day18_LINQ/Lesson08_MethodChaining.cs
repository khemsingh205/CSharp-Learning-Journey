using System;
using System.Collections.Generic;
using System.Linq;

namespace Day18_Lesson08_MethodChaining
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

    class Lesson08Runner
    {
        static void Main()
        {
            Console.WriteLine("Dark Fantasy RPG - Chained Query");

            List<Weapon> weapons = new List<Weapon>
            {
                new Weapon("Rusty Dagger", 8, "Common"),
                new Weapon("Shadow Blade", 55, "Rare"),
                new Weapon("Iron Sword", 25, "Common"),
                new Weapon("Dragon Slayer", 90, "Legendary"),
                new Weapon("Frost Axe", 40, "Rare")
            };

            var result = weapons
                .Where(w => w.Rarity != "Common")
                .OrderByDescending(w => w.Damage)
                .Select(w => w.Name + " (" + w.Damage + ")");

            Console.WriteLine("Best non-common weapons:");
            foreach (string text in result)
            {
                Console.WriteLine("- " + text);
            }
        }
    }
}
