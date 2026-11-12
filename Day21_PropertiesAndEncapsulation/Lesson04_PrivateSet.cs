
using System;

namespace Day21_Lesson04_PrivateSet
{
    class Player
    {
        public int Health { get; private set; } = 100;

        public void TakeDamage(int damage)
        {
            Health = Health - damage;
        }
    }

    class Lesson04Runner
    {
        static void Main(string[] args)
        {
            Player player = new Player();

            Console.WriteLine("Starting Health: " + player.Health);

            player.TakeDamage(30);

            Console.WriteLine("After Enemy Attack: " + player.Health);
        }
    }
}
