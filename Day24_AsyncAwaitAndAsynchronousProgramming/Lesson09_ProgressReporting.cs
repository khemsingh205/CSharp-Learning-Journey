using System;
using System.Threading.Tasks;

namespace Day24_Lesson09_ProgressReporting
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

    public class LevelLoader
    {
        public async Task LoadLevelAsync(IProgress<LoadProgress> progress)
        {
            string[] steps = { "Terrain", "Enemies", "Sounds", "Lighting" };

            for (int i = 0; i < steps.Length; i++)
            {
                Console.WriteLine("[Loader] Loading " + steps[i] + "...");
                await Task.Delay(300);

                if (progress != null)
                {
                    progress.Report(new LoadProgress(steps[i], (i + 1) * 100 / steps.Length));
                }

                await Task.Delay(100);
            }

            Console.WriteLine("[Loader] Level fully loaded.");
        }
    }

    public class Lesson09Runner
    {
        public static void Main()
        {
            Console.WriteLine("=== Lesson 09: Progress Reporting (IProgress<T>) ===");
            Console.WriteLine();

            RunGameAsync().GetAwaiter().GetResult();

            Console.WriteLine();
            Console.WriteLine("Lesson 09 completed.");
        }

        private static void ShowProgress(LoadProgress p)
        {
            int filled = p.Percent / 10;
            string bar = new string('#', filled) + new string('-', 10 - filled);
            Console.WriteLine("[UI] [" + bar + "] " + p.Percent + "% - " + p.StepName + " loaded");
        }

        private static async Task RunGameAsync()
        {
            LevelLoader loader = new LevelLoader();

            Console.WriteLine("--- Custom synchronous IProgress<T> ---");
            IProgress<LoadProgress> syncProgress = new SyncProgress<LoadProgress>(ShowProgress);
            await loader.LoadLevelAsync(syncProgress);
            Console.WriteLine();

            Console.WriteLine("--- Built-in Progress<T> ---");
            Console.WriteLine("[Game] In a console app, Progress<T> handler runs on a thread pool thread.");
            Progress<LoadProgress> builtInProgress = new Progress<LoadProgress>(ShowProgress);
            await loader.LoadLevelAsync(builtInProgress);
            Console.WriteLine();

            Console.WriteLine("--- No progress (null) ---");
            await loader.LoadLevelAsync(null);
        }
    }
}