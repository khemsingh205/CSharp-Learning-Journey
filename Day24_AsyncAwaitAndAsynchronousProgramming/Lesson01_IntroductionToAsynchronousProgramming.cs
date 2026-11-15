using System;
using System.Diagnostics;
using System.Threading;

namespace Day24_Lesson01_IntroductionToAsyncProgramming
{
    public class GameLoader
    {
        public void LoadMap()
        {
            Console.WriteLine("[Loader] Loading map...");
            Thread.Sleep(1000);
            Console.WriteLine("[Loader] Map loaded.");
        }

        public void LoadEnemies()
        {
            Console.WriteLine("[Loader] Loading enemies...");
            Thread.Sleep(1000);
            Console.WriteLine("[Loader] Enemies loaded.");
        }

        public void LoadSounds()
        {
            Console.WriteLine("[Loader] Loading sounds...");
            Thread.Sleep(1000);
            Console.WriteLine("[Loader] Sounds loaded.");
        }
    }

    public class Lesson01Runner
    {
        public static void Main()
        {
            Console.WriteLine("=== Lesson 01: Introduction to Asynchronous Programming ===");
            Console.WriteLine();

            GameLoader loader = new GameLoader();
            Stopwatch stopwatch = Stopwatch.StartNew();

            Console.WriteLine("--- Synchronous Loading ---");
            loader.LoadMap();
            loader.LoadEnemies();
            loader.LoadSounds();

            stopwatch.Stop();

            Console.WriteLine();
            Console.WriteLine("Game ready!");
            Console.WriteLine("Total loading time: " + (int)Math.Round(stopwatch.Elapsed.TotalSeconds) + " seconds");
            Console.WriteLine("The program was blocked during the entire loading.");

            Console.WriteLine();
            Console.WriteLine("Lesson 01 completed.");
        }
    }
}