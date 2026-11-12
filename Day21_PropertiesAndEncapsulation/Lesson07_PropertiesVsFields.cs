
using System;

namespace Day21_Lesson07_PropertiesVsFields
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

    class Lesson07Runner
    {
        static void Main(string[] args)
        {
            Player player = new Player();

            Console.WriteLine("Player Health: " + player.Health);

            player.Health = 60;

            Console.WriteLine("Updated Health: " + player.Health);
        }
    }
}
