using System;

namespace Day14_Lesson01_IntroToEnums
{
    public enum WeaponRarity
    {
        Common,
        Rare,
        Epic,
        Legendary
    }

    public class Lesson01Runner
    {
        static void Main()
        {
            WeaponRarity rarity = WeaponRarity.Rare;

            Console.WriteLine("Weapon rarity: " + rarity);

            if (rarity == WeaponRarity.Rare)
            {
                Console.WriteLine("This is a Rare weapon!");
            }

            Console.ReadLine();
        }
    }
}
