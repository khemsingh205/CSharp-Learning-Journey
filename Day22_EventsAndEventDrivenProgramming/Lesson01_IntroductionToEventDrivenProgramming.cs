
using System;

namespace Day22.Lesson01
{
    class DarkFantasyBoss
    {
        public void DefeatBoss()
        {
            Console.WriteLine("The Dark Knight has been defeated!");

            OnBossDefeated();
        }

        private void OnBossDefeated()
        {
            Console.WriteLine("Event: Boss Defeated!");
            Console.WriteLine("The Ancient Gate is now unlocked!");
            Console.WriteLine("Victory!");
        }
    }

    class Lesson01Runner
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== DARK FANTASY RPG ===");

            DarkFantasyBoss boss = new DarkFantasyBoss();

            Console.WriteLine("Player is fighting the Dark Knight...");

            boss.DefeatBoss();

            Console.WriteLine("Game continues...");
        }
    }
}
