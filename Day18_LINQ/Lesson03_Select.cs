using System;
using System.Collections.Generic;
using System.Linq;

namespace Day18_Lesson03_Select
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

    class Lesson03Runner
    {
        static void Main()
        {
            Console.WriteLine("Dark Fantasy RPG - Select");

            List<Weapon> weapons = new List<Weapon>
            {
                new Weapon("Rusty Dagger", 8),
                new Weapon("Iron Sword", 25),
                new Weapon("Shadow Blade", 55)
            };

            var names = weapons.Select(w => w.Name);

            Console.WriteLine("Weapon names:");
            foreach (string name in names)
            {
                Console.WriteLine("- " + name);
            }

            var doubled = weapons.Select(w => w.Damage * 2);

            Console.WriteLine("Damage after 2x buff:");
            foreach (int damage in doubled)
            {
                Console.WriteLine("- " + damage);
            }
        }
    }
}