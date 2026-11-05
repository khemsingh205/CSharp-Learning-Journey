using System;

namespace Day14_Lesson07_StructMethods
{
    public struct Position
    {
        public int X;
        public int Y;

        public Position(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public void MoveRight(int steps)
        {
            X = X + steps;
        }

        public void Show()
        {
            Console.WriteLine("Position: " + X + ", " + Y);
        }
    }

    public class Lesson07Runner
    {
        static void Main()
        {
            Position playerPos = new Position(5, 10);
            playerPos.Show();

            playerPos.MoveRight(3);
            playerPos.Show();

            Console.ReadLine();
        }
    }
}