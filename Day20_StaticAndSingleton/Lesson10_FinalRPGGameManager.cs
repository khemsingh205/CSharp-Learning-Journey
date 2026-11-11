
using System;

namespace Day20_Lesson10_FinalRPGGameManager
{
    class GameManager
    {
        public static readonly GameManager Instance =
            new GameManager();

        public int Score = 0;
        public int Gold = 0;
        public int TotalEnemies = 0;

        private GameManager()
        {
        }

        public void AddScore(int points)
        {
            Score += points;
        }

        public void AddGold(int amount)
        {
            Gold += amount;
        }

        public void SpawnEnemy()
        {
            TotalEnemies++;
        }

        public void DefeatEnemy()
        {
            TotalEnemies--;
        }
    }

    static class RPGHelper
    {
        public static void CollectTreasure(int amount)
        {
            GameManager.Instance.AddGold(amount);
            Console.WriteLine("Treasure collected!");
        }
    }

    class Lesson10Runner
    {
        static void Main(string[] args)
        {
            GameManager game = GameManager.Instance;

            Console.WriteLine("=== Dark Fantasy RPG ===");

            game.AddScore(250);
            RPGHelper.CollectTreasure(100);

            game.SpawnEnemy();
            game.SpawnEnemy();
            game.SpawnEnemy();

            game.DefeatEnemy();

            Console.WriteLine("Player Score: " + game.Score);
            Console.WriteLine("Player Gold: " + game.Gold);
            Console.WriteLine("Enemies Alive: " + game.TotalEnemies);
        }
    }
}
