using System;

namespace Day20_Lesson03_StaticClass
{
    static class GameUtility
    {
        public static int Clamp(int value, int min, int max)
        {
            if (value < min)
            {
                return min;
            }

            if (value > max)
            {
                return max;
            }

            return value;
        }

        public static string HealthStatus(int health)
        {
            if (health <= 0)
            {
                return "Dead";
            }

            if (health <= 30)
            {
                return "Critical";
            }

            return "Healthy";
        }
    }

    class Lesson03Runner
    {
        static void Main()
        {
            Console.WriteLine("Dark Fantasy RPG - Static Class");

            int health = GameUtility.Clamp(150, 0, 100);
            Console.WriteLine("Health after clamp: " + health);

            int lowHealth = GameUtility.Clamp(-20, 0, 100);
            Console.WriteLine("Low health after clamp: " + lowHealth);

            Console.WriteLine("Status at 100: " + GameUtility.HealthStatus(100));
            Console.WriteLine("Status at 20: " + GameUtility.HealthStatus(20));
            Console.WriteLine("Status at 0: " + GameUtility.HealthStatus(0));
        }
    }
}