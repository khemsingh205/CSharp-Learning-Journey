using System;

namespace Day26.Lesson01
{
    public class Sword
    {
        public string Name => "Iron Sword";
    }

    public class PlayerWithoutPattern
    {
        private readonly Sword _weapon = new Sword();

        public void ShowWeapon() => Console.WriteLine($"Player ke paas hai: {_weapon.Name}");
    }

    public sealed class GameLogger
    {
        private static readonly Lazy<GameLogger> _instance =
            new Lazy<GameLogger>(() => new GameLogger());

        public static GameLogger Instance => _instance.Value;

        private GameLogger()
        {
            Console.WriteLine("  (GameLogger ka object SIRF EK BAAR bana)");
        }

        public void Log(string message) => Console.WriteLine($"  [LOG] {message}");
    }

    public static class Lesson01_IntroductionToDesignPatterns
    {
        public static void Run()
        {
            Console.WriteLine("=== Lesson 01: Introduction To Design Patterns ===\n");

            Console.WriteLine("1) Design Patterns ki 3 categories:");
            Console.WriteLine("   - Creational : object banana   (Factory, Singleton, Builder)");
            Console.WriteLine("   - Structural : objects jodna   (Adapter, Decorator, Facade)");
            Console.WriteLine("   - Behavioral : communication   (Observer, Strategy, Command)\n");

            Console.WriteLine("2) Bina pattern ka code (tight coupling):");
            new PlayerWithoutPattern().ShowWeapon();
            Console.WriteLine("   Problem: Player class Sword se chipak gayi hai.\n");

            Console.WriteLine("3) Singleton ka demo (Creational pattern):");
            GameLogger.Instance.Log("Game start hua");
            GameLogger.Instance.Log("Level 1 load hua");
            bool same = ReferenceEquals(GameLogger.Instance, GameLogger.Instance);
            Console.WriteLine($"  Dono baar same object mila? {same}\n");

            Console.WriteLine("Next lesson me dekhenge ki object creation ki problem Factory se kaise solve hoti hai.");
        }
    }
}