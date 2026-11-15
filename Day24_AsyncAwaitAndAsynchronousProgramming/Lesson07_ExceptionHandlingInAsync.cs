using System;
using System.IO;
using System.Threading.Tasks;

namespace Day24_Lesson07_ExceptionHandlingInAsync
{
    public class SaveSystem
    {
        public async Task<string> LoadSaveAsync(string slotName)
        {
            Console.WriteLine("[Save] Loading " + slotName + "...");
            await Task.Delay(300);

            if (slotName == "Slot3")
            {
                throw new FileNotFoundException("Save file not found for " + slotName);
            }

            return slotName + " data";
        }

        public async Task ConnectToServerAsync(string serverName)
        {
            await Task.Delay(200);
            throw new InvalidOperationException(serverName + " connection failed");
        }
    }

    public class Lesson07Runner
    {
        public static void Main()
        {
            Console.WriteLine("=== Lesson 07: Exception Handling in Async ===");
            Console.WriteLine();

            RunGameAsync().GetAwaiter().GetResult();

            Console.WriteLine();
            Console.WriteLine("Lesson 07 completed.");
        }

        private static async Task RunGameAsync()
        {
            SaveSystem save = new SaveSystem();

            Console.WriteLine("--- try/catch with await ---");

            try
            {
                string data = await save.LoadSaveAsync("Slot1");
                Console.WriteLine("[Game] Loaded: " + data);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("[Game] Error caught: " + ex.Message);
            }

            try
            {
                string data = await save.LoadSaveAsync("Slot3");
                Console.WriteLine("[Game] Loaded: " + data);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("[Game] Error caught: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("[Game] Save loading attempt finished.");
            }

            Console.WriteLine();

            Console.WriteLine("--- Task.WhenAll with multiple failures ---");

            Task serverA = save.ConnectToServerAsync("Server A");
            Task serverB = save.ConnectToServerAsync("Server B");
            Task allServers = Task.WhenAll(serverA, serverB);

            try
            {
                await allServers;
            }
            catch (Exception ex)
            {
                Console.WriteLine("[Game] await rethrew only: " + ex.Message);
                Console.WriteLine("[Game] Total failures: " + allServers.Exception.InnerExceptions.Count);

                foreach (Exception inner in allServers.Exception.InnerExceptions)
                {
                    Console.WriteLine("[Game] Failure: " + inner.Message);
                }
            }

            Console.WriteLine();

            Console.WriteLine("--- Wait() wraps the exception ---");

            try
            {
                save.ConnectToServerAsync("Server C").Wait();
            }
            catch (AggregateException ex)
            {
                Console.WriteLine("[Game] Wait() threw an AggregateException.");
                Console.WriteLine("[Game] Real error: " + ex.InnerException.Message);
            }
        }
    }
}