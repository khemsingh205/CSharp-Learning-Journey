using System;
using System.Collections.Generic;
using System.Linq;

namespace Day18_Lesson07_SumAverageMaxMin
{
    class Weapon
    {
        public string Name;
        public int Damage;
        public int Price;

        public Weapon(string name, int damage, int price)
        {
            Name = name;
            Damage = damage;
            Price = price;
        }
    }

    class Lesson07Runner
    {
        static void Main()
        {
            Console.WriteLine("Dark Fantasy RPG - Inventory Stats");

            List<Weapon> weapons = new List<Weapon>
            {
                new Weapon("Rusty Dagger", 8, 20),
                new Weapon("Iron Sword", 25, 150),
                new Weapon("Shadow Blade", 55, 400)
            };

            int totalValue = weapons.Sum(w => w.Price);
            Console.WriteLine("Total value: " + totalValue + " gold");

            double averageDamage = weapons.Average(w => w.Damage);
            Console.WriteLine("Average damage: " + averageDamage);

            int maxDamage = weapons.Max(w => w.Damage);
            Console.WriteLine("Highest damage: " + maxDamage);

            int minPrice = weapons.Min(w => w.Price);
            Console.WriteLine("Cheapest price: " + minPrice);
        }
    }
}