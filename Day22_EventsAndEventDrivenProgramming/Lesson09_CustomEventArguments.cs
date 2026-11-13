using System;

namespace Day22_Lesson09_CustomEventArguments
{
    public enum DamageType
    {
        Physical,
        Fire,
        Dark
    }

    public class PlayerDamagedEventArgs : EventArgs
    {
        public string AttackerName { get; private set; }
        public int DamageAmount { get; private set; }
        public DamageType Type { get; private set; }
        public bool IsCritical { get; private set; }
        public int RemainingHealth { get; private set; }

        public PlayerDamagedEventArgs(string attackerName, int damageAmount, DamageType type, bool isCritical, int remainingHealth)
        {
            AttackerName = attackerName;
            DamageAmount = damageAmount;
            Type = type;
            IsCritical = isCritical;
            RemainingHealth = remainingHealth;
        }
    }

    public class Player
    {
        private int health;

        public string Name { get; private set; }

        public event EventHandler<PlayerDamagedEventArgs> Damaged;

        public Player(string name, int maxHealth)
        {
            Name = name;
            health = maxHealth;
        }

        public void TakeDamage(string attackerName, int amount, DamageType type, bool isCritical)
        {
            if (isCritical)
            {
                amount = amount * 2;
            }

            health -= amount;
            if (health < 0)
            {
                health = 0;
            }

            if (Damaged != null)
            {
                Damaged(this, new PlayerDamagedEventArgs(attackerName, amount, type, isCritical, health));
            }
        }
    }

    public class HealthBarUI
    {
        public void OnPlayerDamaged(object sender, PlayerDamagedEventArgs e)
        {
            Console.WriteLine("[UI] Health bar: " + e.RemainingHealth + " HP left (-" + e.DamageAmount + ")");
        }
    }

    public class CombatLog
    {
        public void OnPlayerDamaged(object sender, PlayerDamagedEventArgs e)
        {
            Player player = sender as Player;
            string critical = e.IsCritical ? " (CRITICAL)" : "";

            Console.WriteLine("[Log] " + e.AttackerName + " hit " + player.Name + " with " + e.Type + " damage: " + e.DamageAmount + critical);
        }
    }

    public class EffectsSystem
    {
        public void OnPlayerDamaged(object sender, PlayerDamagedEventArgs e)
        {
            if (e.Type == DamageType.Fire)
            {
                Console.WriteLine("[Effects] Burning effect applied.");
            }

            if (e.Type == DamageType.Dark)
            {
                Console.WriteLine("[Effects] Dark curse effect applied.");
            }

            if (e.IsCritical)
            {
                Console.WriteLine("[Effects] Screen shake!");
            }

            if (e.RemainingHealth == 0)
            {
                Console.WriteLine("[Effects] Player death animation.");
            }
        }
    }

    public class Lesson09Runner
    {
        public static void Main()
        {
            Console.WriteLine("=== Lesson 09: Custom Event Arguments ===");
            Console.WriteLine();

            Player player = new Player("Knight Arthur", 100);

            HealthBarUI healthBar = new HealthBarUI();
            CombatLog combatLog = new CombatLog();
            EffectsSystem effects = new EffectsSystem();

            player.Damaged += healthBar.OnPlayerDamaged;
            player.Damaged += combatLog.OnPlayerDamaged;
            player.Damaged += effects.OnPlayerDamaged;

            Console.WriteLine("--- Attack 1 ---");
            player.TakeDamage("Skeleton Warrior", 20, DamageType.Physical, false);
            Console.WriteLine();

            Console.WriteLine("--- Attack 2 ---");
            player.TakeDamage("Fire Dragon", 25, DamageType.Fire, true);
            Console.WriteLine();

            Console.WriteLine("--- Attack 3 ---");
            player.TakeDamage("Dark Wraith", 40, DamageType.Dark, false);

            Console.WriteLine();
            Console.WriteLine("Lesson 09 completed.");
        }
    }
}