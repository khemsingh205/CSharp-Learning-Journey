using System;
using System.Collections.Generic;
using System.Linq;

namespace Day18_Lesson04_OrderBy
{
    class Weapon
    {
        public string Name;
        public int Damage;

        public Weapon(string name, int damage)
        {
            Name = name;
            Damage = damage;
        }
    }

    class Lesson04Runner
    {
        static void Main()
        {
            Console.WriteLine("Dark Fantasy RPG - Sorting Weapons");

            List<Weapon> weapons = new List<Weapon>
            {
                new Weapon("Iron Sword", 25),
                new Weapon("Dragon Slayer", 90),
                new Weapon("Rusty Dagger", 8),
                new Weapon("Shadow Blade", 55)
            };

            var weakestFirst = weapons.OrderBy(w => w.Damage);

            Console.WriteLine("Weakest to strongest:");
            foreach (Weapon weapon in weakestFirst)
            {
                Console.WriteLine("- " + weapon.Name + " (" + weapon.Damage + ")");
            }

            var strongestFirst = weapons.OrderByDescending(w => w.Damage);

            Console.WriteLine("Strongest to weakest:");
            foreach (Weapon weapon in strongestFirst)
            {
                Console.WriteLine("- " + weapon.Name + " (" + weapon.Damage + ")");
            }
        }
    }
}