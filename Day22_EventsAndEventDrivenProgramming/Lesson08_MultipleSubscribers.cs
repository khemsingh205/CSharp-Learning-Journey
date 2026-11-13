using System;

namespace Day22_Lesson08_MultipleSubscribers
{
    public class Player
    {
        public string Name { get; private set; }
        public int Level { get; private set; }

        public event EventHandler LeveledUp;

        public Player(string name)
        {
            Name = name;
            Level = 1;
        }

        public void LevelUp()
        {
            Level++;
            Console.WriteLine("[Player] " + Name + " levels up!");

            if (LeveledUp != null)
            {
                LeveledUp(this, EventArgs.Empty);
            }
        }
    }

    public class UISystem
    {
        public void OnLeveledUp(object sender, EventArgs e)
        {
            Player player = sender as Player;
            Console.WriteLine("[UI] Level up banner shown: Level " + player.Level);
        }
    }

    public class AudioSystem
    {
        public void OnLeveledUp(object sender, EventArgs e)
        {
            Console.WriteLine("[Audio] Level up sound played.");
        }
    }

    public class StatsSystem
    {
        public void OnLeveledUp(object sender, EventArgs e)
        {
            Player player = sender as Player;
            Console.WriteLine("[Stats] Stat points added for level " + player.Level);
        }
    }

    public class AchievementSystem
    {
        public void OnLeveledUp(object sender, EventArgs e)
        {
            Player player = sender as Player;
            Console.WriteLine("[Achievement] Level " + player.Level + " reached.");
        }
    }

    public class Lesson08Runner
    {
        public static void Main()
        {
            Console.WriteLine("=== Lesson 08: Multiple Subscribers ===");
            Console.WriteLine();

            Player player = new Player("Knight Arthur");

            UISystem ui = new UISystem();
            AudioSystem audio = new AudioSystem();
            StatsSystem stats = new StatsSystem();
            AchievementSystem achievements = new AchievementSystem();

            player.LeveledUp += ui.OnLeveledUp;
            player.LeveledUp += audio.OnLeveledUp;
            player.LeveledUp += stats.OnLeveledUp;
            player.LeveledUp += achievements.OnLeveledUp;

            Console.WriteLine("--- All 4 subscribers attached ---");
            player.LevelUp();
            Console.WriteLine();

            player.LeveledUp -= audio.OnLeveledUp;

            Console.WriteLine("--- Audio system unsubscribed ---");
            player.LevelUp();

            Console.WriteLine();
            Console.WriteLine("Lesson 08 completed.");
        }
    }
}