using System;
using System.Collections.Generic;
using System.Linq;

namespace Day18_Lesson09_ToListToArray
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

    class Lesson09Runner
    {
        static void Main()
        {
            Console.WriteLine("Dark Fantasy RPG - ToList and ToArray");

            List<Weapon> weapons = new List<Weapon>
            {
                new Weapon("Rusty Dagger", 8),
                new Weapon("Iron Sword", 25),
                new Weapon("Shadow Blade", 55),
                new Weapon("Dragon Slayer", 90)
            };

            List<Weapon> strongList = weapons.Where(w => w.Damage >= 50).ToList();
            strongList.Add(new Weapon("Frost Axe", 70));

            Console.WriteLine("Strong weapons count: " + strongList.Count);
            Console.WriteLine("First strong weapon: " + strongList[0].Name);

            string[] namesArray = weapons.Select(w => w.Name).ToArray();

            Console.WriteLine("Array length: " + namesArray.Length);
            Console.WriteLine("Last name: " + namesArray[namesArray.Length - 1]);
        }
    }
}