using System;

namespace Day14_Lesson04_EnemyState
{
    public enum EnemyState
    {
        Idle,
        Chasing,
        Attacking,
        Dead
    }

    public class Skeleton
    {
        private EnemyState state = EnemyState.Idle;

        public void ChangeState(EnemyState newState)
        {
            state = newState;
            Console.WriteLine("Skeleton state changed to: " + state);
        }

        public void Act()
        {
            switch (state)
            {
                case EnemyState.Idle:
                    Console.WriteLine("Skeleton stands still.");
                    break;
                case EnemyState.Chasing:
                    Console.WriteLine("Skeleton runs toward the player!");
                    break;
                case EnemyState.Attacking:
                    Console.WriteLine("Skeleton swings its rusty blade!");
                    break;
                case EnemyState.Dead:
                    Console.WriteLine("Skeleton collapses into bones.");
                    break;
            }
        }
    }

    public class Lesson04Runner
    {
        static void Main()
        {
            Skeleton skeleton = new Skeleton();

            skeleton.Act();

            skeleton.ChangeState(EnemyState.Chasing);
            skeleton.Act();

            skeleton.ChangeState(EnemyState.Attacking);
            skeleton.Act();

            skeleton.ChangeState(EnemyState.Dead);
            skeleton.Act();

            Console.ReadLine();
        }
    }
}