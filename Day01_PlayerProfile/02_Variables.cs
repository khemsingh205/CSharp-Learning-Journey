using System;

namespace Day01_PlayerProfile
{
    internal class Variables
    {
        static void Main(string[] args)
        {
            string playerName = "Knight";
            int health = 100;
            float speed = 5.5f;
            double damage = 25.75;
            char rank = 'A';
            bool isAlive = true;

            Console.WriteLine(playerName);
            Console.WriteLine(health);
            Console.WriteLine(speed);
            Console.WriteLine(damage);
            Console.WriteLine(rank);
            Console.WriteLine(isAlive);
        }
    }
}
