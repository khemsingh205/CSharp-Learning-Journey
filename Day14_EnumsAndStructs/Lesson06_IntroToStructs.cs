using System;

namespace Day14_Lesson06_IntroToStructs
{
    public struct Position
    {
        public int X;
        public int Y;
    }

    public class Lesson06Runner
    {
        static void Main()
        {
            Position playerPos = new Position();
            playerPos.X = 5;
            playerPos.Y = 10;

            Console.WriteLine("Player position: " + playerPos.X + ", " + playerPos.Y);

            playerPos.X = 8;
            Console.WriteLine("After moving: " + playerPos.X + ", " + playerPos.Y);

            Console.ReadLine();
        }
    }
}