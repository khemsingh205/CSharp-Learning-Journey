using System;

namespace Day20_Lesson07_IntroToSingleton
{
    class AudioManager
    {
        private static AudioManager instance;

        public static AudioManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new AudioManager();
                }

                return instance;
            }
        }

        private AudioManager()
        {
            Console.WriteLine("AudioManager created (only once).");
        }

        public void PlaySound(string soundName)
        {
            Console.WriteLine("Playing sound: " + soundName);
        }
    }

    class Lesson07Runner
    {
        static void Main()
        {
            Console.WriteLine("Dark Fantasy RPG - Singleton");

            AudioManager.Instance.PlaySound("Sword Clash");
            AudioManager.Instance.PlaySound("Dragon Roar");

            AudioManager first = AudioManager.Instance;
            AudioManager second = AudioManager.Instance;

            Console.WriteLine("Same object? " + (first == second));
        }
    }
}