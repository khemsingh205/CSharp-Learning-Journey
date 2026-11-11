
using System;

namespace Day20_Lesson09_StaticHelperWithSingleton
{
    class GameManager
    {
        public static GameManager Instance = new GameManager();

        public int Gold = 0;

        private GameManager()
        {
        }

        public void AddGold(int amount)
        {
            Gold += amount;
        }
    }

    static class RPGHelper
    {
        public static void CollectTreasure(int gold)
        {
            GameManager.Instance.AddGold(gold);

            Console.WriteLine("Treasure collected!");
        }
    }

    class Lesson09Runner
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dark Fantasy RPG");

            RPGHelper.CollectTreasure(100);
            RPGHelper.CollectTreasure(50);

            Console.WriteLine(
                "Total Gold: " + GameManager.Instance.Gold
            );
        }
    }
}
