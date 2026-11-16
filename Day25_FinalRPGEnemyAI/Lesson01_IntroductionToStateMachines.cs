using System;

namespace Day25_Lesson01_IntroductionToStateMachines
{
    public enum EnemyState
    {
        Idle,
        Patrol,
        Chase,
        Attack,
        Dead
    }

    public class Enemy
    {
        public string Name { get; private set; }
        public EnemyState State { get; private set; }

        public Enemy(string name)
        {
            Name = name;
            State = EnemyState.Idle;
        }

        public void ChangeState(EnemyState newState)
        {
            Console.WriteLine("[State] " + Name + ": " + State + " -> " + newState);
            State = newState;
        }

        public void Update()
        {
            switch (State)
            {
                case EnemyState.Idle:
                    Console.WriteLine("[Enemy] " + Name + " is standing still.");
                    break;
                case EnemyState.Patrol:
                    Console.WriteLine("[Enemy] " + Name + " is walking along the patrol path.");
                    break;
                case EnemyState.Chase:
                    Console.WriteLine("[Enemy] " + Name + " is running towards the player.");
                    break;
                case EnemyState.Attack:
                    Console.WriteLine("[Enemy] " + Name + " is swinging a sword at the player.");
                    break;
                case EnemyState.Dead:
                    Console.WriteLine("[Enemy] " + Name + " is dead. Nothing happens.");
                    break;
            }
        }
    }

    public class Lesson01Runner
    {
        public static void Main()
        {
            Console.WriteLine("=== Lesson 01: Introduction to State Machines ===");
            Console.WriteLine();

            Enemy enemy = new Enemy("Hollow Soldier");

            Console.WriteLine("--- Idle ---");
            enemy.Update();
            Console.WriteLine();

            Console.WriteLine("--- Patrol ---");
            enemy.ChangeState(EnemyState.Patrol);
            enemy.Update();
            Console.WriteLine();

            Console.WriteLine("--- Chase ---");
            enemy.ChangeState(EnemyState.Chase);
            enemy.Update();
            Console.WriteLine();

            Console.WriteLine("--- Attack ---");
            enemy.ChangeState(EnemyState.Attack);
            enemy.Update();
            Console.WriteLine();

            Console.WriteLine("--- Dead ---");
            enemy.ChangeState(EnemyState.Dead);
            enemy.Update();

            Console.WriteLine();
            Console.WriteLine("Lesson 01 completed.");
        }
    }
}