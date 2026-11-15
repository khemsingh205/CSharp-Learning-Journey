using System;
using System.Threading.Tasks;

namespace Day24_Lesson04_TaskOfTAndReturnValues
{
    public class PlayerData
    {
        public string Name { get; private set; }
        public int Level { get; private set; }
        public int Gold { get; private set; }

        public PlayerData(string name, int level, int gold)
        {
            Name = name;
            Level = level;
            Gold = gold;
        }
    }

    public class SaveSystem
    {
        public async Task<string> GetMapNameAsync()
        {
            Console.WriteLine("[Save] Reading map name...");
            await Task.Delay(500);
            return "Ruined Castle";
        }

        public async Task<int> GetEnemyCountAsync()
        {
            Console.WriteLine("[Save] Counting enemies in the map...");
            await Task.Delay(500);
            return 12;
        }

        public async Task<PlayerData> LoadPlayerAsync()
        {
            Console.WriteLine("[Save] Loading player data...");
            await Task.Delay(500);
            return new PlayerData("Knight Arthur", 15, 2500);
        }
    }

    public class Lesson04Runner
    {
        public static void Main()
        {
            Console.WriteLine("=== Lesson 04: Task<T> and Return Values ===");
            Console.WriteLine();

            RunGameAsync().GetAwaiter().GetResult();

            Console.WriteLine();
            Console.WriteLine("Lesson 04 completed.");
        }

        private static async Task RunGameAsync()
        {
            SaveSystem save = new SaveSystem();

            Console.WriteLine("--- Await and get a string ---");
            string mapName = await save.GetMapNameAsync();
            Console.WriteLine("[Game] Map name: " + mapName);
            Console.WriteLine();

            Console.WriteLine("--- Store Task<int> first, await later ---");
            Task<int> enemyTask = save.GetEnemyCountAsync();
            Console.WriteLine("[Game] Enemy count task started. Result is not ready yet.");
            int enemyCount = await enemyTask;
            Console.WriteLine("[Game] Enemy count: " + enemyCount);
            Console.WriteLine();

            Console.WriteLine("--- Custom class as result ---");
            PlayerData player = await save.LoadPlayerAsync();
            Console.WriteLine("[Game] Player: " + player.Name + " | Level: " + player.Level + " | Gold: " + player.Gold);
        }
    }
}