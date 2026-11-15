using System;
using System.Threading.Tasks;

namespace Day24_Lesson03_AsyncAndAwait
{
    public class GameLoader
    {
        public async Task LoadMapAsync()
        {
            Console.WriteLine("[Loader] Loading map...");
            await Task.Delay(1000);
            Console.WriteLine("[Loader] Map loaded.");
        }

        public async Task LoadEnemiesAsync()
        {
            Console.WriteLine("[Loader] Loading enemies...");
            await Task.Delay(1000);
            Console.WriteLine("[Loader] Enemies loaded.");
        }
    }

    public class Lesson03Runner
    {
        public static void Main()
        {
            Console.WriteLine("=== Lesson 03: async and await ===");
            Console.WriteLine();

            RunGameAsync().GetAwaiter().GetResult();

            Console.WriteLine();
            Console.WriteLine("Lesson 03 completed.");
        }

        private static async Task RunGameAsync()
        {
            GameLoader loader = new GameLoader();

            Console.WriteLine("--- Async Loading ---");
            Console.WriteLine("[Game] Starting loading...");

            Task mapTask = loader.LoadMapAsync();

            Console.WriteLine("[Game] LoadMapAsync returned control. Game can do other work.");
            Console.WriteLine("[Game] Showing loading screen animation...");

            await mapTask;
            await loader.LoadEnemiesAsync();

            Console.WriteLine("[Game] Game ready!");
        }
    }
}