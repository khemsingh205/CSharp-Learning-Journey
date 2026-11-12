
using System;

namespace Day21_Lesson06_PropertiesWithValidation
{
    class Player
    {
        private int health = 100;

        public int Health
        {
            get { return health; }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    health = value;
                }
            }
        }
    }

    class Lesson06Runner
    {
        static void Main(string[] args)
        {
            Player player = new Player();

            Console.WriteLine("Starting Health: " + player.Health);

            player.Health = 70;
            Console.WriteLine("Updated Health: " + player.Health);

            player.Health = 150;
            Console.WriteLine("After Invalid Update: " + player.Health);
        }
    }
}
