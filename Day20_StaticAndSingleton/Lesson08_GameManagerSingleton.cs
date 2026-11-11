using System;

namespace Day20_Lesson08_GameManagerSingleton
{
    class GameManager
    {
        private static GameManager instance;

        public static GameManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new GameManager();
                }

                return instance;
            }
        }

        public int Score { get; private set; }
        public int Gold { get; private set; }

        private GameManager()
        {
            Score = 0;
            Gold = 0;
        }

        public void AddScore(int points)
        {
            Score += points;
            Console.WriteLine("Score: " + Score);
        }

        public void AddGold(int amount)
        {
            Gold += amount;
            Console.WriteLine("Gold: " + Gold);
        }
    }

    class Skeleton
    {
        public void Die()
        {
            Console.WriteLine("Skeleton defeated!");
            GameManager.Instance.AddScore(100);
            GameManager.Instance.AddGold(25);
        }
    }

    class Treasure
    {
        public void Collect()
        {
            Console.WriteLine("Treasure collected!");
            GameManager.Instance.AddGold(200);
        }
    }

    class Lesson08Runner
    {
        static void Main()
        {
            Console.WriteLine("Dark Fantasy RPG - GameManager");

            Skeleton skeleton = new Skeleton();
            Treasure treasure = new Treasure();

            skeleton.Die();
            treasure.Collect();

            Console.WriteLine("Final score: " + GameManager.Instance.Score);
            Console.WriteLine("Final gold: " + GameManager.Instance.Gold);
        }
    }
}