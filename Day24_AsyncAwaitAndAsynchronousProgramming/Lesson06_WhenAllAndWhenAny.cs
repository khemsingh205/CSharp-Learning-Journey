using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Day24_Lesson06_WhenAllAndWhenAny
{
    public class GameLoader
    {
        public async Task LoadAssetAsync(string assetName, int milliseconds)
        {
            Console.WriteLine("[Loader] Loading " + assetName + "...");
            await Task.Delay(milliseconds);
            Console.WriteLine("[Loader] " + assetName + " loaded.");
        }
    }

    public class LeaderboardClient
    {
        public async Task<string> FetchAsync(string serverName, int milliseconds)
        {
            Console.WriteLine("[Net] Requesting leaderboard from " + serverName + "...");
            await Task.Delay(milliseconds);
            Console.WriteLine("[Net] " + serverName + " responded.");
            return serverName;
        }
    }

    public class Lesson06Runner
    {
        public static void Main()
        {
            Console.WriteLine("=== Lesson 06: Task.WhenAll and Task.WhenAny ===");
            Console.WriteLine();

            RunGameAsync().GetAwaiter().GetResult();

            Console.WriteLine();
            Console.WriteLine("Lesson 06 completed.");
        }

        private static async Task RunGameAsync()
        {
            GameLoader loader = new GameLoader();
            LeaderboardClient client = new LeaderboardClient();

            Console.WriteLine("--- Task.WhenAll ---");
            Stopwatch stopwatch = Stopwatch.StartNew();

            Task mapTask = loader.LoadAssetAsync("Map", 1200);
            Task enemiesTask = loader.LoadAssetAsync("Enemies", 800);
            Task soundsTask = loader.LoadAssetAsync("Sounds", 400);

            await Task.WhenAll(mapTask, enemiesTask, soundsTask);
            stopwatch.Stop();

            Console.WriteLine("[Game] All assets loaded.");
            Console.WriteLine("[Game] Total loading time: " + (int)Math.Round(stopwatch.Elapsed.TotalSeconds) + " seconds");
            Console.WriteLine();

            Console.WriteLine("--- Task.WhenAny ---");
            Task<string> serverA = client.FetchAsync("Server A", 1500);
            Task<string> serverB = client.FetchAsync("Server B", 600);

            Task<string> firstTask = await Task.WhenAny(serverA, serverB);
            string winner = await firstTask;

            Console.WriteLine("[Game] First response came from: " + winner);
            Console.WriteLine("[Game] Waiting for the slower server too...");

            await serverA;
            Console.WriteLine("[Game] Both servers finished.");
        }
    }
}