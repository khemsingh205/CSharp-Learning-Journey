
using System;

namespace Day22.Lesson04
{
    class AncientBoss
    {
        public event Action BossDefeated;

        public void DefeatBoss()
        {
            Console.WriteLine("The Ancient Boss has been defeated!");

            RaiseBossDefeatedEvent();
        }

        private void RaiseBossDefeatedEvent()
        {
            BossDefeated?.Invoke();
        }
    }

    class Lesson04Runner
    {
        static void Main(string[] args)
        {
            AncientBoss boss = new AncientBoss();

            boss.BossDefeated += UnlockAncientGate;

            boss.BossDefeated += DisplayVictoryMessage;

            Console.WriteLine("Player enters the boss arena.");

            boss.DefeatBoss();
        }

        static void UnlockAncientGate()
        {
            Console.WriteLine("The Ancient Gate is now unlocked!");
        }

        static void DisplayVictoryMessage()
        {
            Console.WriteLine("Congratulations! Boss defeated!");
        }
    }
}
