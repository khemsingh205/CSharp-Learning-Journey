using System;

namespace Day22_Lesson10_FinalRPGEventSystem
{
    public class EnemyDefeatedEventArgs : EventArgs
    {
        public string EnemyName { get; private set; }
        public int XpReward { get; private set; }
        public bool IsBoss { get; private set; }

        public EnemyDefeatedEventArgs(string enemyName, int xpReward, bool isBoss)
        {
            EnemyName = enemyName;
            XpReward = xpReward;
            IsBoss = isBoss;
        }
    }

    public class PlayerDamagedEventArgs : EventArgs
    {
        public int DamageAmount { get; private set; }
        public int RemainingHealth { get; private set; }

        public PlayerDamagedEventArgs(int damageAmount, int remainingHealth)
        {
            DamageAmount = damageAmount;
            RemainingHealth = remainingHealth;
        }
    }

    public class LevelUpEventArgs : EventArgs
    {
        public int NewLevel { get; private set; }

        public LevelUpEventArgs(int newLevel)
        {
            NewLevel = newLevel;
        }
    }

    public static class GameEvents
    {
        public static event EventHandler<EnemyDefeatedEventArgs> EnemyDefeated;
        public static event EventHandler<PlayerDamagedEventArgs> PlayerDamaged;
        public static event EventHandler<LevelUpEventArgs> PlayerLeveledUp;
        public static event EventHandler PlayerDied;

        public static void RaiseEnemyDefeated(object sender, EnemyDefeatedEventArgs e)
        {
            if (EnemyDefeated != null)
            {
                EnemyDefeated(sender, e);
            }
        }

        public static void RaisePlayerDamaged(object sender, PlayerDamagedEventArgs e)
        {
            if (PlayerDamaged != null)
            {
                PlayerDamaged(sender, e);
            }
        }

        public static void RaisePlayerLeveledUp(object sender, LevelUpEventArgs e)
        {
            if (PlayerLeveledUp != null)
            {
                PlayerLeveledUp(sender, e);
            }
        }

        public static void RaisePlayerDied(object sender)
        {
            if (PlayerDied != null)
            {
                PlayerDied(sender, EventArgs.Empty);
            }
        }
    }

    public class Player
    {
        private int health;
        private int xp;

        public string Name { get; private set; }
        public int Level { get; private set; }

        public Player(string name, int maxHealth)
        {
            Name = name;
            health = maxHealth;
            Level = 1;
        }

        public void TakeDamage(int amount)
        {
            health -= amount;
            if (health < 0)
            {
                health = 0;
            }

            Console.WriteLine("[Player] " + Name + " takes " + amount + " damage.");
            GameEvents.RaisePlayerDamaged(this, new PlayerDamagedEventArgs(amount, health));

            if (health == 0)
            {
                GameEvents.RaisePlayerDied(this);
            }
        }

        public void OnEnemyDefeated(object sender, EnemyDefeatedEventArgs e)
        {
            xp += e.XpReward;
            Console.WriteLine("[Player] Gained " + e.XpReward + " XP. Total XP: " + xp);

            if (xp >= Level * 100)
            {
                Level++;
                GameEvents.RaisePlayerLeveledUp(this, new LevelUpEventArgs(Level));
            }
        }
    }

    public class Enemy
    {
        public string Name { get; private set; }
        private int xpReward;
        private bool isBoss;

        public Enemy(string name, int xpReward, bool isBoss)
        {
            Name = name;
            this.xpReward = xpReward;
            this.isBoss = isBoss;
        }

        public void Die()
        {
            Console.WriteLine("[Enemy] " + Name + " has been defeated.");
            GameEvents.RaiseEnemyDefeated(this, new EnemyDefeatedEventArgs(Name, xpReward, isBoss));
        }
    }

    public class QuestSystem
    {
        private int killCount;

        public void OnEnemyDefeated(object sender, EnemyDefeatedEventArgs e)
        {
            killCount++;
            Console.WriteLine("[Quest] Kills: " + killCount + "/3");

            if (killCount == 3)
            {
                Console.WriteLine("[Quest] Quest completed: Clear the Ruined Castle!");
            }
        }
    }

    public class LootSystem
    {
        public void OnEnemyDefeated(object sender, EnemyDefeatedEventArgs e)
        {
            if (e.IsBoss)
            {
                Console.WriteLine("[Loot] Legendary item dropped from " + e.EnemyName + "!");
            }
            else
            {
                Console.WriteLine("[Loot] Common item dropped from " + e.EnemyName + ".");
            }
        }
    }

    public class AudioSystem
    {
        public void OnEnemyDefeated(object sender, EnemyDefeatedEventArgs e)
        {
            if (e.IsBoss)
            {
                Console.WriteLine("[Audio] Victory music played.");
            }
        }

        public void OnPlayerLeveledUp(object sender, LevelUpEventArgs e)
        {
            Console.WriteLine("[Audio] Level up sound played.");
        }

        public void OnPlayerDied(object sender, EventArgs e)
        {
            Console.WriteLine("[Audio] Death theme played.");
        }
    }

    public class HealthBarUI
    {
        public void OnPlayerDamaged(object sender, PlayerDamagedEventArgs e)
        {
            Console.WriteLine("[UI] Health bar: " + e.RemainingHealth + " HP left (-" + e.DamageAmount + ")");
        }

        public void OnPlayerLeveledUp(object sender, LevelUpEventArgs e)
        {
            Console.WriteLine("[UI] Level up banner: Level " + e.NewLevel);
        }

        public void OnPlayerDied(object sender, EventArgs e)
        {
            Console.WriteLine("[UI] YOU DIED screen shown.");
        }
    }

    public class AchievementSystem
    {
        public void OnEnemyDefeated(object sender, EnemyDefeatedEventArgs e)
        {
            if (e.IsBoss)
            {
                Console.WriteLine("[Achievement] Unlocked: Boss Slayer!");
            }
        }

        public void OnPlayerLeveledUp(object sender, LevelUpEventArgs e)
        {
            Console.WriteLine("[Achievement] Reached level " + e.NewLevel + ".");
        }
    }

    public class Lesson10Runner
    {
        public static void Main()
        {
            Console.WriteLine("=== Lesson 10: Final RPG Event System ===");
            Console.WriteLine();

            Player player = new Player("Knight Arthur", 100);

            QuestSystem quest = new QuestSystem();
            LootSystem loot = new LootSystem();
            AudioSystem audio = new AudioSystem();
            HealthBarUI ui = new HealthBarUI();
            AchievementSystem achievements = new AchievementSystem();

            GameEvents.EnemyDefeated += player.OnEnemyDefeated;
            GameEvents.EnemyDefeated += quest.OnEnemyDefeated;
            GameEvents.EnemyDefeated += loot.OnEnemyDefeated;
            GameEvents.EnemyDefeated += audio.OnEnemyDefeated;
            GameEvents.EnemyDefeated += achievements.OnEnemyDefeated;

            GameEvents.PlayerDamaged += ui.OnPlayerDamaged;

            GameEvents.PlayerLeveledUp += audio.OnPlayerLeveledUp;
            GameEvents.PlayerLeveledUp += ui.OnPlayerLeveledUp;
            GameEvents.PlayerLeveledUp += achievements.OnPlayerLeveledUp;

            GameEvents.PlayerDied += audio.OnPlayerDied;
            GameEvents.PlayerDied += ui.OnPlayerDied;

            Enemy soldier = new Enemy("Hollow Soldier", 40, false);
            Enemy knight = new Enemy("Cursed Knight", 50, false);
            Enemy boss = new Enemy("Shadow Knight Malrik", 150, true);

            Console.WriteLine("--- Battle 1 ---");
            soldier.Die();
            Console.WriteLine();

            Console.WriteLine("--- Battle 2 ---");
            player.TakeDamage(30);
            knight.Die();
            Console.WriteLine();

            Console.WriteLine("--- Boss Fight ---");
            player.TakeDamage(40);
            boss.Die();
            Console.WriteLine();

            Console.WriteLine("--- Final Blow ---");
            player.TakeDamage(50);
            Console.WriteLine();

            GameEvents.EnemyDefeated -= player.OnEnemyDefeated;
            GameEvents.EnemyDefeated -= quest.OnEnemyDefeated;
            GameEvents.EnemyDefeated -= loot.OnEnemyDefeated;
            GameEvents.EnemyDefeated -= audio.OnEnemyDefeated;
            GameEvents.EnemyDefeated -= achievements.OnEnemyDefeated;
            GameEvents.PlayerDamaged -= ui.OnPlayerDamaged;
            GameEvents.PlayerLeveledUp -= audio.OnPlayerLeveledUp;
            GameEvents.PlayerLeveledUp -= ui.OnPlayerLeveledUp;
            GameEvents.PlayerLeveledUp -= achievements.OnPlayerLeveledUp;
            GameEvents.PlayerDied -= audio.OnPlayerDied;
            GameEvents.PlayerDied -= ui.OnPlayerDied;

            Console.WriteLine("All subscribers unsubscribed.");
            Console.WriteLine();
            Console.WriteLine("Lesson 10 completed.");
        }
    }
}