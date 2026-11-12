
using System;

namespace Day21_Lesson09_UnityInspectorConnection
{
    class Player
    {
        private int health = 100;

        public int Health
        {
            get { return health; }
            private set { health = value; }
        }

        public void TakeDamage(int damage)
        {
            Health = Math.Max(0, Health - damage);
        }
    }

    class Lesson09Runner
    {
        static void Main(string[] args)
        {
            Player player = new Player();

            Console.WriteLine("Player Health: " + player.Health);

            player.TakeDamage(25);

            Console.WriteLine("After Enemy Attack: " + player.Health);
        }
    }
}
