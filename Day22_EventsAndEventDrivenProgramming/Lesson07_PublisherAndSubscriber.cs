using System;

namespace Day22_Lesson07_PublisherAndSubscriber
{
    public class Enemy
    {
        public string Name { get; private set; }

        public event EventHandler Defeated;

        public Enemy(string name)
        {
            Name = name;
        }

        public void Defeat()
        {
            Console.WriteLine("[Enemy] " + Name + " is defeated.");

            if (Defeated != null)
            {
                Defeated(this, EventArgs.Empty);
            }
        }
    }

    public class QuestTracker
    {
        private int killCount;

        public void OnEnemyDefeated(object sender, EventArgs e)
        {
            Enemy enemy = sender as Enemy;
            killCount++;

            Console.WriteLine("[Quest] Enemy defeated: " + enemy.Name + " | Total kills: " + killCount);
        }
    }

    public class Lesson07Runner
    {
        public static void Main()
        {
            Console.WriteLine("=== Lesson 07: Publisher and Subscriber ===");
            Console.WriteLine();

            Enemy soldier = new Enemy("Hollow Soldier");
            Enemy knight = new Enemy("Cursed Knight");
            Enemy giant = new Enemy("Fallen Giant");

            QuestTracker tracker = new QuestTracker();

            Console.WriteLine("--- No subscriber yet ---");
            soldier.Defeat();
            Console.WriteLine();

            knight.Defeated += tracker.OnEnemyDefeated;
            giant.Defeated += tracker.OnEnemyDefeated;

            Console.WriteLine("--- Subscriber attached ---");
            knight.Defeat();
            giant.Defeat();

            Console.WriteLine();
            Console.WriteLine("Lesson 07 completed.");
        }
    }
}