
using System;

namespace Day22.Lesson05
{
    class DarkFantasyBoss
    {
        public event Action BossDefeated;

        public void DefeatBoss()
        {
            Console.WriteLine("\nBoss has been defeated!");

            BossDefeated?.Invoke();
        }
    }

    class GateSystem
    {
        public void SubscribeToBoss(DarkFantasyBoss boss)
        {
            boss.BossDefeated += UnlockGate;

            Console.WriteLine("Gate System subscribed to Boss Event.");
        }

        public void UnsubscribeFromBoss(DarkFantasyBoss boss)
        {
            boss.BossDefeated -= UnlockGate;

            Console.WriteLine("Gate System unsubscribed from Boss Event.");
        }

        private void UnlockGate()
        {
            Console.WriteLine("Ancient Gate Unlocked!");
        }
    }

    class Lesson05Runner
    {
        static void Main(string[] args)
        {
            DarkFantasyBoss boss = new DarkFantasyBoss();

            GateSystem gate = new GateSystem();

            gate.SubscribeToBoss(boss);

            boss.DefeatBoss();

            gate.UnsubscribeFromBoss(boss);

            Console.WriteLine("\nTrying to trigger the event again...");

            boss.DefeatBoss();
        }
    }
}
