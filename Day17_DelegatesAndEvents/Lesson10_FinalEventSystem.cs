using System;

namespace Day17_Lesson10_FinalEventSystem
{
    class HealthChangedEventArgs : EventArgs
    {
        public int CurrentHealth { get; private set; }
        public int MaxHealth { get; private set; }

        public HealthChangedEventArgs(int currentHealth, int maxHealth)
        {
            CurrentHealth = currentHealth;
            MaxHealth = maxHealth;
        }
    }

    class Player
    {
        public event EventHandler<HealthChangedEventArgs> HealthChanged;
        public event Action OnDeath;

        private int health = 100;
        private int maxHealth = 100;

        public void TakeDamage(int damage)
        {
            if (health <= 0)
            {
                return;
            }

            health -= damage;

            if (health < 0)
            {
                health = 0;
            }

            if (HealthChanged != null)
            {
                HealthChanged(this, new HealthChangedEventArgs(health, maxHealth));
            }

            if (health == 0 && OnDeath != null)
            {
                OnDeath();
            }
        }
    }

    class HealthBarUI
    {
        public void OnHealthChanged(object sender, HealthChangedEventArgs e)
        {
            Console.WriteLine("UI: Health " + e.CurrentHealth + "/" + e.MaxHealth);
        }
    }

    class Lesson10Runner
    {
        static void Main()
        {
            Console.WriteLine("Dark Fantasy RPG - Final Event System");

            Player player = new Player();
            HealthBarUI healthBar = new HealthBarUI();

            player.HealthChanged += healthBar.OnHealthChanged;
            player.HealthChanged += (sender, e) =>
            {
                if (e.CurrentHealth > 0 && e.CurrentHealth <= 30)
                {
                    Console.WriteLine("Sound: Heartbeat... low health!");
                }
            };
            player.OnDeath += () => Console.WriteLine("UI: You Died.");
            player.OnDeath += () => Console.WriteLine("System: Progress saved.");

            player.TakeDamage(40);
            player.TakeDamage(35);
            player.TakeDamage(50);

            Console.WriteLine("--- UI removed ---");
            player.HealthChanged -= healthBar.OnHealthChanged;

            player.TakeDamage(10);
            Console.WriteLine("The game keeps running!");
        }
    }
}