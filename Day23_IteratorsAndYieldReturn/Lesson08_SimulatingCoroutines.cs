

using System;

using System.Collections.Generic;

namespace Day23_Lesson08_SimulatingCoroutines
{
    class BossRunner
    {
        static IEnumerator<int> BossAttack()
        {
            Console.WriteLine("Boss is preparing attack!");

            yield return 2;

            Console.WriteLine("Boss performs Sword Attack!");

            yield return 3;

            Console.WriteLine("Boss performs Ultimate Attack!");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Dark Fantasy RPG");
            Console.WriteLine("Coroutine Simulation");
            Console.WriteLine();

            IEnumerator<int> coroutine = BossAttack();

            Console.WriteLine("Coroutine started!");
            Console.WriteLine();

            while (coroutine.MoveNext())
            {
                int waitTime = coroutine.Current;

                Console.WriteLine("Waiting for " + waitTime + " seconds...");
                Console.WriteLine("Press Enter to continue.");

                Console.ReadLine();
            }

            coroutine.Dispose();

            Console.WriteLine();
            Console.WriteLine("Boss attack sequence completed!");
        }
    }
}
