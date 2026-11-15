using System;
using System.Threading;
using System.Threading.Tasks;

namespace Day24_Lesson05_TaskDelayVsThreadSleep
{
    public class MapLoader
    {
        public void LoadMapBlocking()
        {
            Console.WriteLine("[Loader] Loading map with Thread.Sleep...");
            Thread.Sleep(1500);
            Console.WriteLine("[Loader] Map loaded.");
        }

        public async Task LoadMapAsync()
        {
            Console.WriteLine("[Loader] Loading map with Task.Delay...");
            await Task.Delay(1500);
            Console.WriteLine("[Loader] Map loaded.");
        }
    }

    public class Lesson05Runner
    {
        public static void Main()
        {
            Console.WriteLine("=== Lesson 05: Task.Delay vs Thread.Sleep ===");
            Console.WriteLine();

            RunGameAsync().GetAwaiter().GetResult();

            Console.WriteLine();
            Console.WriteLine("Lesson 05 completed.");
        }

        private static async Task RunGameAsync()
        {
            MapLoader loader = new MapLoader();

            Console.WriteLine("--- Thread.Sleep (blocking) ---");
            Console.WriteLine("[Game] Calling blocking LoadMapBlocking...");
            loader.LoadMapBlocking();
            Console.WriteLine("[Game] Control came back only after loading finished.");
            Console.WriteLine("[Game] No animation could run during loading.");
            Console.WriteLine();

            Console.WriteLine("--- Task.Delay (non-blocking) ---");
            Console.WriteLine("[Game] Calling LoadMapAsync...");
            Task mapTask = loader.LoadMapAsync();
            Console.WriteLine("[Game] Control came back immediately.");

            for (int frame = 1; frame <= 3; frame++)
            {
                Console.WriteLine("[Game] Loading animation frame " + frame);
                await Task.Delay(300);
            }

            await mapTask;
            Console.WriteLine("[Game] Game ready!");
        }
    }
}