
using System;

namespace Day21_Lesson08_PropertiesWithMethods
{
    class Player
    {
        public int Health { get; private set; } = 100;

        public void TakeDamage(int damage)
        {
            Health = Math.Max(0, Health - damage);
        }

        public void Heal(int amount)
        {
            Health = Math.Min(100, Health + amount);
        }
    }

    class Lesson08Runner
    {
        static void Main(string[] args)
        {
            Player player = new Player();

            Console.WriteLine("Starting Health: " + player.Health);

            player.TakeDamage(30);
            Console.WriteLine("After Attack: " + player.Health);

            player.Heal(20);
            Console.WriteLine("After Healing: " + player.Health);
        }
    }
}
