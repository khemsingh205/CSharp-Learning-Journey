
using System;

namespace Day21_Lesson10_FinalRPGPlayerSystem
{
    class Player
    {
        public string PlayerName { get; private set; }

        public int Health { get; private set; } = 100;

        public int Stamina { get; private set; } = 100;

        public int Gold { get; private set; } = 500;

        public int Level { get; private set; } = 1;

        public Player(string name)
        {
            PlayerName = name;
        }

        public void TakeDamage(int damage)
        {
            if (damage > 0)
            {
                Health = Math.Max(0, Health - damage);
            }
        }

        public void Heal(int amount)
        {
            if (amount > 0)
            {
                Health = Math.Min(100, Health + amount);
            }
        }

        public void UseStamina(int amount)
        {
            if (amount > 0 && amount <= Stamina)
            {
                Stamina -= amount;
            }
        }

        public void AddGold(int amount)
        {
            if (amount > 0)
            {
                Gold += amount;
            }
        }

        public void ShowStatus()
        {
            Console.WriteLine("Player: " + PlayerName);
            Console.WriteLine("Health: " + Health);
            Console.WriteLine("Stamina: " + Stamina);
            Console.WriteLine("Gold: " + Gold);
            Console.WriteLine("Level: " + Level);
        }
    }

    class Lesson10Runner
    {
        static void Main(string[] args)
        {
            Player player = new Player("Dark Knight");

            Console.WriteLine("=== INITIAL PLAYER STATUS ===");
            player.ShowStatus();

            Console.WriteLine("\n=== PLAYER ACTIONS ===");

            player.TakeDamage(30);
            player.UseStamina(20);
            player.AddGold(200);
            player.Heal(10);

            Console.WriteLine("\n=== UPDATED PLAYER STATUS ===");
            player.ShowStatus();
        }
    }
}
