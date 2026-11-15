using System;
using System.Threading;
using System.Threading.Tasks;

namespace Day24_Lesson08_Cancellation
{
    public class LevelLoader
    {
        public async Task LoadLevelAsync(CancellationToken token)
        {
            string[] steps = { "Terrain", "Enemies", "Sounds", "Lighting" };

            foreach (string step in steps)
            {
                token.ThrowIfCancellationRequested();

                Console.WriteLine("[Loader] Loading " + step + "...");
                await Task.Delay(400);
                Console.WriteLine("[Loader] " + step + " loaded.");
            }

            Console.WriteLine("[Loader] Level fully loaded.");
        }

        public async Task WaitForBossAsync(CancellationToken token)
        {
            Console.WriteLine("[Boss] Boss will arrive in 5 seconds...");
            await Task.Delay(5000, token);
            Console.WriteLine("[Boss] Boss arrived.");
        }
    }

    public class Lesson08Runner
    {
        public static void Main()
        {
            Console.WriteLine("=== Lesson 08: Cancellation (CancellationToken) ===");
            Console.WriteLine();

            RunGameAsync().GetAwaiter().GetResult();

            Console.WriteLine();
            Console.WriteLine("Lesson 08 completed.");
        }

        private static async Task RunGameAsync()
        {
            LevelLoader loader = new LevelLoader();

            Console.WriteLine("--- Manual cancel ---");

            using (CancellationTokenSource cts = new CancellationTokenSource())
            {
                Task loadTask = loader.LoadLevelAsync(cts.Token);

                await Task.Delay(1000);
                Console.WriteLine("[Game] Player pressed Cancel.");
                cts.Cancel();

                try
                {
                    await loadTask;
                }
                catch (OperationCanceledException)
                {
                    Console.WriteLine("[Game] Level loading was cancelled.");
                }
            }

            Console.WriteLine();
            Console.WriteLine("--- Cancel after timeout ---");

            using (CancellationTokenSource cts = new CancellationTokenSource())
            {
                cts.CancelAfter(1000);

                try
                {
                    await loader.WaitForBossAsync(cts.Token);
                }
                catch (OperationCanceledException)
                {
                    Console.WriteLine("[Game] Boss wait cancelled by timeout.");
                }
            }

            Console.WriteLine();
            Console.WriteLine("--- Normal completion ---");

            using (CancellationTokenSource cts = new CancellationTokenSource())
            {
                await loader.LoadLevelAsync(cts.Token);
            }
        }
    }
}