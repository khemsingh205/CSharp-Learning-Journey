
using System;

namespace Day21_Lesson02_GetAndSet
{
    class Player
    {
        private int stamina = 100;

        public int Stamina
        {
            get
            {
                return stamina;
            }
            set
            {
                stamina = value;
            }
        }
    }

    class Lesson02Runner
    {
        static void Main(string[] args)
        {
            Player player = new Player();

            Console.WriteLine("Current Stamina: " + player.Stamina);

            player.Stamina = 60;

            Console.WriteLine("After Sprint: " + player.Stamina);
        }
    }
}
