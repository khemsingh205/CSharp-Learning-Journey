using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace Day24_Lesson02_ThreadsAndTasks
{
    public class AssetLoader
    {
        public void Load(string assetName, int milliseconds)
        {
            Thread.Sleep(milliseconds);
            Console.WriteLine("[Loader] " + assetName + " loaded. IsThreadPoolThread: " + Thread.CurrentThread.IsThreadPoolThread);
        }
    }

    public class Lesson02Runner
    {
        public static void Main()
        {
            Console.WriteLine("=== Lesson 02: Threads and Tasks ===");
            Console.WriteLine();

            AssetLoader loader = new AssetLoader();

            Console.WriteLine("[Main] IsThreadPoolThread: " + Thread.CurrentThread.IsThreadPoolThread);
            Console.WriteLine();

            Console.WriteLine("--- Using Thread ---");
            Thread mapThread = new Thread(() => loader.Load("Map", 500));
            mapThread.Start();
            Console.WriteLine("[Main] Map thread started. Main continues working.");
            Console.WriteLine("[Main] Preparing menu UI...");
            mapThread.Join();
            Console.WriteLine("[Main] Map thread finished.");
            Console.WriteLine();

            Console.WriteLine("--- Using Task ---");
            Stopwatch stopwatch = Stopwatch.StartNew();

            Task enemiesTask = Task.Run(() => loader.Load("Enemies", 500));
            Task soundsTask = Task.Run(() => loader.Load("Sounds", 1000));
            Console.WriteLine("[Main] Enemies and Sounds tasks started.");
            Console.WriteLine("[Main] Both tasks are running in parallel.");

            Task.WaitAll(enemiesTask, soundsTask);
            stopwatch.Stop();

            Console.WriteLine("[Main] All tasks finished.");
            Console.WriteLine("Total task time: " + (int)Math.Round(stopwatch.Elapsed.TotalSeconds) + " seconds");

            Console.WriteLine();
            Console.WriteLine("Lesson 02 completed.");
        }
    }
}