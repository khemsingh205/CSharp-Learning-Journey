using System;

namespace Day14_Lesson02_EnumSwitch
{
    public enum WeaponRarity
    {
        Common,
        Rare,
        Epic,
        Legendary
    }

    public class Lesson02Runner
    {
        static void ShowRarityInfo(WeaponRarity rarity)
        {
            switch (rarity)
            {
                case WeaponRarity.Common:
                    Console.WriteLine("Common: gray color, 60% drop chance.");
                    break;
                case WeaponRarity.Rare:
                    Console.WriteLine("Rare: blue color, 25% drop chance.");
                    break;
                case WeaponRarity.Epic:
                    Console.WriteLine("Epic: purple color, 10% drop chance.");
                    break;
                case WeaponRarity.Legendary:
                    Console.WriteLine("Legendary: gold color, 5% drop chance.");
                    break;
                default:
                    Console.WriteLine("Unknown rarity.");
                    break;
            }
        }

        static void Main()
        {
            ShowRarityInfo(WeaponRarity.Common);
            ShowRarityInfo(WeaponRarity.Epic);
            ShowRarityInfo(WeaponRarity.Legendary);

            Console.ReadLine();
        }
    }
}