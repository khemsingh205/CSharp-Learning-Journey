
using System;

namespace Day22.Lesson02
{
    class DarkKnight
    {
        public event Action BossDefeated;

        public void TakeDamage(int damage)
        {
            Console.WriteLine("Dark Knight takes " + damage + " damage!");

            int bossHealth = 0;

            if (bossHealth <= 0)
            {
                Console.WriteLine("Dark Knight has been defeated!");

                BossDefeated?.Invoke();
            }
        }
    }

    class Lesson02Runner
    {
        static void Main(string[] args)
        {
            DarkKnight boss = new DarkKnight();

            boss.BossDefeated += ShowVictoryMessage;

            Console.WriteLine("Player attacks the Dark Knight!");

            boss.TakeDamage(100);
        }

        static void ShowVictoryMessage()
        {
            Console.WriteLine("Victory! The boss has been defeated.");
            Console.WriteLine("The Ancient Gate is unlocked!");
        }
    }
}
