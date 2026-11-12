
using System;

namespace Day21_Lesson03_AutoProperties
{
    class Player
    {
        public string PlayerName { get; set; } = "Dark Knight";

        public int Gold { get; set; } = 500;

        public int Level { get; set; } = 1;
    }

    class Lesson03Runner
    {
        static void Main(string[] args)
        {
            Player player = new Player();

            Console.WriteLine("Player: " + player.PlayerName);
            Console.WriteLine("Gold: " + player.Gold);
            Console.WriteLine("Level: " + player.Level);

            player.Gold = 800;

            Console.WriteLine("Updated Gold: " + player.Gold);
        }
    }
}
