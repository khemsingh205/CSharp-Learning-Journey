
using System;

namespace Day22.Lesson03
{
    class DarkKnight
    {

        public Action BossDefeatedDelegate;


        public event Action BossDefeatedEvent;

        public void DefeatBoss()
        {
            Console.WriteLine("Dark Knight has been defeated!");

            Console.WriteLine("\n--- Using Delegate ---");

            BossDefeatedDelegate?.Invoke();

            Console.WriteLine("\n--- Using Event ---");

            BossDefeatedEvent?.Invoke();
        }
    }

    class Lesson03Runner
    {
        static void Main(string[] args)
        {
            DarkKnight boss = new DarkKnight();


            boss.BossDefeatedDelegate += UnlockGate;


            boss.BossDefeatedEvent += ShowVictoryMessage;

            boss.DefeatBoss();

            Console.WriteLine("\nGame continues...");
        }

        static void UnlockGate()
        {
            Console.WriteLine("Ancient Gate Unlocked!");
        }

        static void ShowVictoryMessage()
        {
            Console.WriteLine("Victory Message Displayed!");
        }
    }
}
