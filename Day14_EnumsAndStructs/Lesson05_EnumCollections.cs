using System;
using System.Collections.Generic;

namespace Day14_Lesson05_EnumCollections
{
    public enum WeaponRarity
    {
        Common,
        Rare,
        Epic,
        Legendary
    }

    public class Lesson05Runner
    {
        static void Main()
        {
            List<WeaponRarity> lootDrops = new List<WeaponRarity>();
            lootDrops.Add(WeaponRarity.Common);
            lootDrops.Add(WeaponRarity.Epic);
            lootDrops.Add(WeaponRarity.Common);

            Dictionary<WeaponRarity, int> sellPrice = new Dictionary<WeaponRarity, int>
            {
                { WeaponRarity.Common, 10 },
                { WeaponRarity.Rare, 50 },
                { WeaponRarity.Epic, 200 },
                { WeaponRarity.Legendary, 1000 }
            };

            int totalGold = 0;

            foreach (WeaponRarity drop in lootDrops)
            {
                int price = sellPrice[drop];
                Console.WriteLine(drop + " sells for " + price + " gold");
                totalGold = totalGold + price;
            }

            Console.WriteLine("Total gold: " + totalGold);

            Console.ReadLine();
        }
    }
}