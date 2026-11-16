using System;
using System.Collections.Generic;

namespace Day25_Lesson03_StateTransitionsAndRules
{
    public enum EnemyState
    {
        Idle,
        Patrol,
        Chase,
        Attack,
        Stunned,
        Dead
    }

    public class Enemy
    {
        private readonly Dictionary<EnemyState, EnemyState[]> allowedTransitions;

        public string Name { get; private set; }
        public EnemyState State { get; private set; }

        public Enemy(string name)
        {
            Name = name;
            State = EnemyState.Idle;

            allowedTransitions = new Dictionary<EnemyState, EnemyState[]>();
            allowedTransitions[EnemyState.Idle] = new EnemyState[] { EnemyState.Patrol, EnemyState.Chase, EnemyState.Dead };
            allowedTransitions[EnemyState.Patrol] = new EnemyState[] { EnemyState.Idle, EnemyState.Chase, EnemyState.Dead };
            allowedTransitions[EnemyState.Chase] = new EnemyState[] { EnemyState.Patrol, EnemyState.Attack, EnemyState.Stunned, EnemyState.Dead };
            allowedTransitions[EnemyState.Attack] = new EnemyState[] { EnemyState.Chase, EnemyState.Stunned, EnemyState.Dead };
            allowedTransitions[EnemyState.Stunned] = new EnemyState[] { EnemyState.Chase, EnemyState.Dead };
            allowedTransitions[EnemyState.Dead] = new EnemyState[0];
        }

        public bool CanTransition(EnemyState newState)
        {
            return Array.IndexOf(allowedTransitions[State], newState) >= 0;
        }

        public bool TryChangeState(EnemyState newState)
        {
            if (State == newState)
            {
                Console.WriteLine("[Rule] " + Name + " is already in " + State + ".");
                return false;
            }

            if (!CanTransition(newState))
            {
                Console.WriteLine("[Rule] Blocked: " + State + " -> " + newState);
                return false;
            }

            Console.WriteLine("[State] " + Name + ": " + State + " -> " + newState);
            State = newState;
            return true;
        }
    }

    public class Lesson03Runner
    {
        public static void Main()
        {
            Console.WriteLine("=== Lesson 03: State Transitions and Rules ===");
            Console.WriteLine();

            Enemy enemy = new Enemy("Cursed Knight");

            Console.WriteLine("--- Valid transitions ---");
            enemy.TryChangeState(EnemyState.Patrol);
            enemy.TryChangeState(EnemyState.Chase);
            enemy.TryChangeState(EnemyState.Attack);
            Console.WriteLine();

            Console.WriteLine("--- Blocked transitions ---");
            enemy.TryChangeState(EnemyState.Idle);
            enemy.TryChangeState(EnemyState.Attack);
            Console.WriteLine();

            Console.WriteLine("--- Stun and recovery ---");
            enemy.TryChangeState(EnemyState.Stunned);
            enemy.TryChangeState(EnemyState.Attack);
            enemy.TryChangeState(EnemyState.Chase);
            Console.WriteLine();

            Console.WriteLine("--- Death is final ---");
            enemy.TryChangeState(EnemyState.Dead);
            enemy.TryChangeState(EnemyState.Chase);
            bool moved = enemy.TryChangeState(EnemyState.Idle);
            Console.WriteLine("[Game] Transition succeeded: " + moved);
            Console.WriteLine("[Game] Final state: " + enemy.State);

            Console.WriteLine();
            Console.WriteLine("Lesson 03 completed.");
        }
    }
}