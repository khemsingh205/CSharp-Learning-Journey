using System;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace Day24_Lesson10_FinalRPGAsyncLoadingSystem
{
    public class LoadProgress
    {
        public string StepName { get; private set; }
        public int Percent { get; private set; }

        public LoadProgress(string stepName, int percent)
        {
            StepName = stepName;
            Percent = percent;
        }
    }

    public class SyncProgress<T> : IProgress<T>
    {
        private readonly Action<T> handler;

        public SyncProgress(Action<T> handler)
        {
            this.handler = handler;
        }

        public void Report(T value)
        {
            handler(value);
        }
    }

    public class GameLoader
    {
        private readonly int totalSteps;
        private int completedSteps;

        public GameLoader(int totalSteps)
        {
            this.totalSteps = totalSteps;
        }

        public async Task<int> LoadAssetAsync(string assetName, int milliseconds, int itemCount, CancellationToken token, IProgress<LoadProgress> progress)
        {
            Console.WriteLine("[Loader] Loading " + assetName + "...");
            await Task.Delay(milliseconds, token);
            Console.WriteLine("[Loader] " + assetName + " loaded.");

            int done = Interlocked.Increment(ref completedSteps);

            if (progress != null)
            {
                progress.Report(new LoadProgress(assetName, done * 100 / totalSteps));
            }

            return itemCount;
        }

        public async Task LoadSaveAsync(CancellationToken token)
        {
            Console.WriteLine("[Loader] Loading Save data...");
            await Task.Delay(300, token);
            throw new FileNotFoundException("Save file is corrupted");
        }
    }

    public class Lesson10Runner
    {
        public static void Main()
        {
            Console.WriteLine("=== Lesson 10: Final RPG Async Loading System ===");
            Console.WriteLine();

            RunGameAsync().GetAwaiter().GetResult();

            Console.WriteLine();
            Console.WriteLine("Lesson 10 completed.");
        }

        private static void ShowProgress(LoadProgress p)
        {
            int filled = p.Percent / 10;
            string bar = new string('#', filled) + new string('-', 10 - filled);
            Console.WriteLine("[UI] [" + bar + "] " + p.Percent + "% - " + p.StepName);
        }

        private static async Task RunGameAsync()
        {
            IProgress<LoadProgress> progress = new SyncProgress<LoadProgress>(ShowProgress);

            Console.WriteLine("--- Scenario 1: Successful loading ---");

            using (CancellationTokenSource cts = new CancellationTokenSource())
            {
                GameLoader loader = new GameLoader(3);
                Stopwatch stopwatch = Stopwatch.StartNew();

                Task<int> mapTask = loader.LoadAssetAsync("Map", 1200, 5, cts.Token, progress);
                Task<int> enemiesTask = loader.LoadAssetAsync("Enemies", 800, 12, cts.Token, progress);
                Task<int> soundsTask = loader.LoadAssetAsync("Sounds", 400, 30, cts.Token, progress);

                await Task.WhenAll(mapTask, enemiesTask, soundsTask);
                stopwatch.Stop();

                int zones = await mapTask;
                int enemies = await enemiesTask;
                int sounds = await soundsTask;

                Console.WriteLine("[Game] Map zones: " + zones + " | Enemies: " + enemies + " | Sounds: " + sounds);
                Console.WriteLine("[Game] Game ready! Loading time: " + (int)Math.Round(stopwatch.Elapsed.TotalSeconds) + " seconds");
            }

            Console.WriteLine();
            Console.WriteLine("--- Scenario 2: Player cancels loading ---");

            using (CancellationTokenSource cts = new CancellationTokenSource())
            {
                GameLoader loader = new GameLoader(3);

                Task<int> mapTask = loader.LoadAssetAsync("Map", 1200, 5, cts.Token, progress);
                Task<int> enemiesTask = loader.LoadAssetAsync("Enemies", 800, 12, cts.Token, progress);
                Task<int> soundsTask = loader.LoadAssetAsync("Sounds", 400, 30, cts.Token, progress);
                Task allTasks = Task.WhenAll(mapTask, enemiesTask, soundsTask);

                await Task.Delay(600);
                Console.WriteLine("[Game] Player pressed Cancel.");
                cts.Cancel();

                try
                {
                    await allTasks;
                    Console.WriteLine("[Game] Game ready!");
                }
                catch (OperationCanceledException)
                {
                    Console.WriteLine("[Game] Loading cancelled. Returning to main menu.");
                }
            }

            Console.WriteLine();
            Console.WriteLine("--- Scenario 3: Loading failure ---");

            using (CancellationTokenSource cts = new CancellationTokenSource())
            {
                GameLoader loader = new GameLoader(1);

                Task soundsTask = loader.LoadAssetAsync("Sounds", 400, 30, cts.Token, null);
                Task saveTask = loader.LoadSaveAsync(cts.Token);

                try
                {
                    await Task.WhenAll(soundsTask, saveTask);
                    Console.WriteLine("[Game] Game ready!");
                }
                catch (FileNotFoundException ex)
                {
                    Console.WriteLine("[Game] Loading failed: " + ex.Message);
                    Console.WriteLine("[Game] Starting a new game with default settings.");
                }
            }
        }
    }
}