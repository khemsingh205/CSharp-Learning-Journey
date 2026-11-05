using System;

namespace Day14_Lesson03_EnumCasting
{
    public enum WeaponRarity
    {
        Common,
        Rare,
        Epic,
        Legendary
    }

    public enum GoldReward
    {
        Small = 10,
        Medium = 50,
        Large = 200
    }

    public class Lesson03Runner
    {
        static void Main()
        {
            WeaponRarity rarity = WeaponRarity.Epic;

            int number = (int)rarity;
            Console.WriteLine("Epic as number: " + number);

            WeaponRarity fromNumber = (WeaponRarity)3;
            Console.WriteLine("Number 3 is: " + fromNumber);

            int reward = (int)GoldReward.Large;
            Console.WriteLine("Large reward: " + reward + " gold");

            if (WeaponRarity.Epic > WeaponRarity.Rare)
            {
                Console.WriteLine("Epic is better than Rare.");
            }

            Console.ReadLine();
        }
    }
}