
using System;

namespace Day23_Lesson01_IntroductionToIterationAndForeach
{
    class EnemyRunner
    {
        static void Main(string[] args)
        {
            string[] enemies =
            {
                "Skeleton",
                "Goblin",
                "Dark Knight",
                "Fire Demon"
            };

            Console.WriteLine("Dark Fantasy RPG");
            Console.WriteLine("Enemy List:");

            foreach (string enemy in enemies)
            {
                Console.WriteLine("Enemy: " + enemy);
            }

            Console.WriteLine("All enemies loaded!");
        }
    }
}
