using System;

namespace Day17_Lesson07_IntroToEvents
{
    class Player
    {
        public event Action OnDeath;

        private int health = 50;

        public void TakeDamage(int damage)
        {
            health -= damage;
            Console.WriteLine("Player took " + damage + " damage. Health: " + health);

            if (health <= 0)
            {
                Console.WriteLine("Player has died!");

                if (OnDeath != null)
                {
                    OnDeath();
                }
            }
        }
    }

    class Lesson07Runner
    {
        static void ShowGameOver()
        {
            Console.WriteLine("UI: Game Over screen shown.");
        }

        static void PlaySound()
        {
            Console.WriteLine("Sound: You Died...");
        }

        static void Main()
        {
            Console.WriteLine("Dark Fantasy RPG - Player Death Event");

            Player player = new Player();

            player.OnDeath += ShowGameOver;
            player.OnDeath += PlaySound;

            player.TakeDamage(30);
            player.TakeDamage(30);
        }
    }
}