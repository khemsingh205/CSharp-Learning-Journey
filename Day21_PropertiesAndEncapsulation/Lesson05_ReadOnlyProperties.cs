
using System;

namespace Day21_Lesson05_ReadOnlyProperties
{
    class Player
    {
        public int PlayerID { get; }

        public string PlayerName { get; }

        public Player(int id, string name)
        {
            PlayerID = id;
            PlayerName = name;
        }
    }

    class Lesson05Runner
    {
        static void Main(string[] args)
        {
            Player player = new Player(101, "Dark Knight");

            Console.WriteLine("Player ID: " + player.PlayerID);
            Console.WriteLine("Player Name: " + player.PlayerName);
        }
    }
}
