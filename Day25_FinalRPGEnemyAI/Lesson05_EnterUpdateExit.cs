using System;

namespace Day25_Lesson05_EnterUpdateExit
{
    public interface IState
    {
        void Enter(Enemy enemy);
        void Update(Enemy enemy);
        void Exit(Enemy enemy);
    }

    public class IdleState : IState
    {
        public void Enter(Enemy enemy)
        {
            Console.WriteLine("[Idle:Enter] " + enemy.Name + " plays the idle animation.");
        }

        public void Update(Enemy enemy)
        {
            Console.WriteLine("[Idle:Update] " + enemy.Name + " is standing still. Distance: " + enemy.DistanceToPlayer);

            if (enemy.DistanceToPlayer <= 10)
            {
                enemy.ChangeState(new ChaseState());
            }
        }

        public void Exit(Enemy enemy)
        {
            Console.WriteLine("[Idle:Exit] " + enemy.Name + " stops the idle animation.");
        }
    }

    public class ChaseState : IState
    {
        public void Enter(Enemy enemy)
        {
            enemy.Speed = 4;
            Console.WriteLine("[Chase:Enter] " + enemy.Name + " roars and starts running. Speed: " + enemy.Speed);
        }

        public void Update(Enemy enemy)
        {
            enemy.MoveCloser(enemy.Speed);
            Console.WriteLine("[Chase:Update] " + enemy.Name + " is running. Distance: " + enemy.DistanceToPlayer);

            if (enemy.DistanceToPlayer <= 2)
            {
                enemy.ChangeState(new AttackState());
            }
        }

        public void Exit(Enemy enemy)
        {
            enemy.Speed = 0;
            Console.WriteLine("[Chase:Exit] " + enemy.Name + " stops running. Speed: " + enemy.Speed);
        }
    }

    public class AttackState : IState
    {
        public void Enter(Enemy enemy)
        {
            Console.WriteLine("[Attack:Enter] " + enemy.Name + " raises the sword.");
        }

        public void Update(Enemy enemy)
        {
            Console.WriteLine("[Attack:Update] " + enemy.Name + " is swinging a sword at the player.");
        }

        public void Exit(Enemy enemy)
        {
            Console.WriteLine("[Attack:Exit] " + enemy.Name + " lowers the sword.");
        }
    }

    public class Enemy
    {
        private IState currentState;

        public string Name { get; private set; }
        public int DistanceToPlayer { get; private set; }
        public int Speed { get; set; }

        public Enemy(string name, int distanceToPlayer)
        {
            Name = name;
            DistanceToPlayer = distanceToPlayer;
            Speed = 0;
            currentState = new IdleState();
            currentState.Enter(this);
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
            currentState.Exit(this);
            currentState = newState;
            currentState.Enter(this);
        }

        public void Update()
        {
            currentState.Update(this);
        }
    }

    public class Lesson05Runner
    {
        public static void Main()
        {
            Console.WriteLine("=== Lesson 05: Enter, Update and Exit ===");
            Console.WriteLine();

            Enemy enemy = new Enemy("Hollow Soldier", 20);
            Console.WriteLine();

            for (int frame = 1; frame <= 5; frame++)
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

            Console.WriteLine("Lesson 05 completed.");
        }
    }
}