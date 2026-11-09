using System;
using System.Collections.Generic;
using System.Linq;

namespace Day18_Lesson05_FirstOrDefault
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

    class Lesson05Runner
    {
        static void Main()
        {
            Console.WriteLine("Dark Fantasy RPG - Find a Weapon");

            List<Weapon> weapons = new List<Weapon>
            {
                new Weapon("Rusty Dagger", 8),
                new Weapon("Iron Sword", 25),
                new Weapon("Shadow Blade", 55)
            };

            Weapon strong = weapons.FirstOrDefault(w => w.Damage >= 50);

            if (strong != null)
            {
                Console.WriteLine("Found: " + strong.Name);
            }
            else
            {
                Console.WriteLine("No strong weapon found.");
            }

            Weapon legendary = weapons.FirstOrDefault(w => w.Damage >= 100);

            if (legendary != null)
            {
                Console.WriteLine("Found: " + legendary.Name);
            }
            else
            {
                Console.WriteLine("No legendary weapon found.");
            }
        }
    }
}