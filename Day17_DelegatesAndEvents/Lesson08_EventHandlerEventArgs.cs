using System;

namespace Day17_Lesson08_EventHandlerEventArgs
{
    class HealthChangedEventArgs : EventArgs
    {
        public int CurrentHealth { get; private set; }
        public int Damage { get; private set; }

        public HealthChangedEventArgs(int currentHealth, int damage)
        {
            CurrentHealth = currentHealth;
            Damage = damage;
        }
    }

    class Player
    {
        public event EventHandler<HealthChangedEventArgs> HealthChanged;

        private int health = 100;

        public void TakeDamage(int damage)
        {
            health -= damage;

            if (HealthChanged != null)
            {
                HealthChanged(this, new HealthChangedEventArgs(health, damage));
            }
        }
    }

    class Lesson08Runner
    {
        static void UpdateHealthBar(object sender, HealthChangedEventArgs e)
        {
            Console.WriteLine("UI: Health bar now " + e.CurrentHealth + " (-" + e.Damage + ")");
        }

        static void Main()
        {
            Console.WriteLine("Dark Fantasy RPG - Health Event");

            Player player = new Player();
            player.HealthChanged += UpdateHealthBar;

            player.TakeDamage(30);
            player.TakeDamage(25);
        }
    }
}