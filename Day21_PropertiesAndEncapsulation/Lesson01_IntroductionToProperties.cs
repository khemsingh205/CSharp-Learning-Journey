
using System;

namespace Day21_Lesson01_IntroductionToProperties
{
    class Player
    {
        private int health = 100;

        public int Health
        {
            get { return health; }
            set { health = value; }
        }
    }

    class Lesson01Runner
    {
        static void Main(string[] args)
        {
            Player player = new Player();

            Console.WriteLine("Player Health: " + player.Health);

            player.Health = 80;

            Console.WriteLine("Updated Health: " + player.Health);
        }
    }
}
