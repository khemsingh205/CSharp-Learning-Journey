
using System;

namespace Day01_PlayerProfile
{
    internal class User_Input
    {
        static void Main(string[] args)
        {
            // Get the player's name
            Console.WriteLine("Enter player name:");
            string playerName = Console.ReadLine() ?? "";

            // Get the player's health
            Console.WriteLine("Enter player health:");
            string healthInput = Console.ReadLine() ?? "";
            int health = int.Parse(healthInput);

            // Get the player's movement speed
            Console.WriteLine("Enter player speed:");
            string speedInput = Console.ReadLine() ?? "";
            float speed = float.Parse(speedInput);

            // Get the player's damage
            Console.WriteLine("Enter player damage:");
            string damageInput = Console.ReadLine() ?? "";
            double damage = double.Parse(damageInput);

            // Get the player's rank
            Console.WriteLine("Enter player rank (A, B, C):");
            string rankInput = Console.ReadLine() ?? "";
            char rank = char.Parse(rankInput);

            // Check whether the player is alive
            Console.WriteLine("Is player alive? (true/false):");
            string aliveInput = Console.ReadLine() ?? "";
            bool isAlive = bool.Parse(aliveInput);

            // Display the player's complete profile
            Console.WriteLine("\n--- PLAYER PROFILE ---");
            Console.WriteLine($"Name: {playerName}");
            Console.WriteLine($"Health: {health}");
            Console.WriteLine($"Speed: {speed}");
            Console.WriteLine($"Damage: {damage}");
            Console.WriteLine($"Rank: {rank}");
            Console.WriteLine($"Alive: {isAlive}");
        }
    }
}
