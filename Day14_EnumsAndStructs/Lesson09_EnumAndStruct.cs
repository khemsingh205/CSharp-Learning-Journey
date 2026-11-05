using System;
using System.Collections.Generic;

namespace Day14_Lesson09_EnumAndStruct
{
    public enum WeaponRarity
    {
        Common,
        Rare,
        Epic,
        Legendary
    }

    public struct ItemData
    {
        public string Name;
        public WeaponRarity Rarity;
        public int Price;

        public ItemData(string name, WeaponRarity rarity, int price)
        {
            Name = name;
            Rarity = rarity;
            Price = price;
        }

        public void Show()
        {
            Console.WriteLine(Name + " [" + Rarity + "] - " + Price + " gold");
        }
    }

    public class Lesson09Runner
    {
        static void Main()
        {
            List<ItemData> items = new List<ItemData>();
            items.Add(new ItemData("Iron Sword", WeaponRarity.Common, 10));
            items.Add(new ItemData("Shadow Dagger", WeaponRarity.Rare, 50));
            items.Add(new ItemData("Dragon Slayer", WeaponRarity.Legendary, 1000));

            foreach (ItemData item in items)
            {
                item.Show();
            }

            Console.ReadLine();
        }
    }
}