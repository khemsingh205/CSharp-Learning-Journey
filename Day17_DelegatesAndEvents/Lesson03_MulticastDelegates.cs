using System;

namespace Day17_Lesson03_MulticastDelegates
{
    delegate void PlayerDiedDelegate();

    class Lesson03Runner
    {
        static void PlayDeathSound()
        {
            Console.WriteLine("Sound: You Died...");
        }

        static void ShowGameOverScreen()
        {
            Console.WriteLine("UI: Game Over screen shown.");
        }

        static void SaveProgress()
        {
            Console.WriteLine("System: Progress saved.");
        }

        static void Main()
        {
            Console.WriteLine("Dark Fantasy RPG - Player Died");

            PlayerDiedDelegate onDeath = PlayDeathSound;
            onDeath += ShowGameOverScreen;
            onDeath += SaveProgress;

            onDeath();

            Console.WriteLine("--- Removing the sound ---");

            onDeath -= PlayDeathSound;
            onDeath();
        }
    }
}