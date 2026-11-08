using System;

namespace Day17_Lesson09_UnsubscribeEvents
{
    class Player
    {
        public event Action<int> OnDamaged;

        public void TakeDamage(int damage)
        {
            Console.WriteLine("Player takes " + damage + " damage.");

            if (OnDamaged != null)
            {
                OnDamaged(damage);
            }
        }
    }

    class Lesson09Runner
    {
        static void ShowDamageText(int damage)
        {
            Console.WriteLine("UI: -" + damage + " floating text.");
        }

        static void PlayHurtSound(int damage)
        {
            Console.WriteLine("Sound: Ouch!");
        }

        static void Main()
        {
            Console.WriteLine("Dark Fantasy RPG - Unsubscribe");

            Player player = new Player();

            player.OnDamaged += ShowDamageText;
            player.OnDamaged += PlayHurtSound;

            player.TakeDamage(20);

            Console.WriteLine("--- Sound system removed ---");
            player.OnDamaged -= PlayHurtSound;

            player.TakeDamage(15);

            Console.WriteLine("--- UI removed ---");
            player.OnDamaged -= ShowDamageText;

            player.TakeDamage(10);
        }
    }
}