using System;

namespace Day25_Lesson04_StatePatternWithInterface
{
    public interface IState
    {
        void Execute(Enemy enemy);
    }

    public class IdleState : IState
    {
        public void Execute(Enemy enemy)
        {
            Console.WriteLine("[Idle] " + enemy.Name + " is standing still. Distance: " + enemy.DistanceToPlayer);

            if (enemy.DistanceToPlayer <= 10)
            {
                enemy.ChangeState(new ChaseState());
            }
        }
    }

    public class ChaseState : IState
    {
        public void Execute(Enemy enemy)
        {
            enemy.MoveCloser(4);
            Console.WriteLine("[Chase] " + enemy.Name + " is running towards the player. Distance: " + enemy.DistanceToPlayer);

            if (enemy.DistanceToPlayer <= 2)
            {
                enemy.ChangeState(new AttackState());
            }
        }
    }

    public class AttackState : IState
    {
        public void Execute(Enemy enemy)
        {
            Console.WriteLine("[Attack] " + enemy.Name + " is swinging a sword at the player.");
        }
    }

    public class Enemy
    {
        private IState currentState;

        public string Name { get; private set; }
        public int DistanceToPlayer { get; private set; }

        public Enemy(string name, int distanceToPlayer)
        {
            Name = name;
            DistanceToPlayer = distanceToPlayer;
            currentState = new IdleState();
        }

        public void MoveCloser(int amount)
        {
            DistanceToPlayer -= amount;
            if (DistanceToPlayer < 0)
            {
                DistanceToPlayer = 0;
            }
        }

        public void SetDistance(int distance)
        {
            DistanceToPlayer = distance;
        }

        public void ChangeState(IState newState)
        {
            Console.WriteLine("[State] " + Name + ": " + currentState.GetType().Name + " -> " + newState.GetType().Name);
            currentState = newState;
        }

        public void Update()
        {
            currentState.Execute(this);
        }
    }

    public class Lesson04Runner
    {
        public static void Main()
        {
            Console.WriteLine("=== Lesson 04: State Pattern with Interface (IState) ===");
            Console.WriteLine();

            Enemy enemy = new Enemy("Hollow Soldier", 20);

            for (int frame = 1; frame <= 6; frame++)
            {
                Console.WriteLine("--- Frame " + frame + " ---");

                if (frame == 2)
                {
                    Console.WriteLine("[Player] Player moves closer.");
                    enemy.SetDistance(10);
                }

                enemy.Update();
                Console.WriteLine();
            }

            Console.WriteLine("Lesson 04 completed.");
        }
    }
}