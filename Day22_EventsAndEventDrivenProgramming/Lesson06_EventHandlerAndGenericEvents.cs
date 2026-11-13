using System;

namespace Day22_Lesson06_EventHandlerAndGenericEvents
{

    public class DamageEventArgs : EventArgs
    {
        public int DamageAmount { get; private set; }
        public int RemainingHealth { get; private set; }

        public DamageEventArgs(int damageAmount, int remainingHealth)
        {
            DamageAmount = damageAmount;
            RemainingHealth = remainingHealth;
        }
    }


    public class BossFight
    {
        public string Name { get; private set; }
        private int health;


        public event EventHandler BossAwakened;


        public event EventHandler<DamageEventArgs> BossDamaged;

        public BossFight(string name, int maxHealth)
        {
            Name = name;
            health = maxHealth;
        }

        public void Awaken()
        {
            Console.WriteLine("[Boss] " + Name + " has awakened!");


            if (BossAwakened != null)
            {
                BossAwakened(this, EventArgs.Empty);
            }
        }

        public void TakeDamage(int amount)
        {
            health -= amount;
            if (health < 0)
            {
                health = 0;
            }

            Console.WriteLine("[Boss] " + Name + " takes " + amount + " damage.");


            if (BossDamaged != null)
            {
                BossDamaged(this, new DamageEventArgs(amount, health));
            }
        }
    }

    public class MusicSystem
    {
        public void OnBossAwakened(object sender, EventArgs e)
        {
            BossFight boss = sender as BossFight;
            if (boss != null)
            {
                Console.WriteLine("[Music] Boss theme started for: " + boss.Name);
            }
        }
    }


    public class BossHealthBar
    {
        public void OnBossDamaged(object sender, DamageEventArgs e)
        {
            Console.WriteLine("[UI] Health bar updated. Damage: " + e.DamageAmount
                + ", HP left: " + e.RemainingHealth);

            if (e.RemainingHealth == 0)
            {
                Console.WriteLine("[UI] BOSS DEFEATED!");
            }
        }
    }


    public class Lesson06Runner
    {
        public static void Main()
        {
            Console.WriteLine("=== Lesson 06: EventHandler and EventHandler<T> ===");
            Console.WriteLine();

            BossFight boss = new BossFight("Shadow Knight Malrik", 100);
            MusicSystem music = new MusicSystem();
            BossHealthBar healthBar = new BossHealthBar();


            boss.BossAwakened += music.OnBossAwakened;
            boss.BossDamaged += healthBar.OnBossDamaged;

            boss.Awaken();
            Console.WriteLine();

            boss.TakeDamage(30);
            boss.TakeDamage(50);
            boss.TakeDamage(40);

            Console.WriteLine();
            Console.WriteLine("Lesson 06 completed.");
        }
    }
}