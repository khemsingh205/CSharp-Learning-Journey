using System;

namespace Day25_Lesson06_AbstractBaseStateClass
{
    public abstract class State
    {
        public abstract string StateName { get; }

        public virtual void Enter(Enemy enemy)
        {
            Console.WriteLine("[Enter] " + enemy.Name + " entered " + StateName + ".");
        }

        public abstract void Update(Enemy enemy);

        public virtual void Exit(Enemy enemy)
        {
            Console.WriteLine("[Exit] " + enemy.Name + " left " + StateName + ".");
        }
    }

    public class IdleState : State
    {
        public override string StateName
        {
            get { return "Idle"; }
        }

        public override void Update(Enemy enemy)
        {
            Console.WriteLine("[Idle:Update] " + enemy.Name + " is standing still. Distance: " + enemy.DistanceToPlayer);

            if (enemy.DistanceToPlayer <= 10)
            {
                enemy.ChangeState(new ChaseState());
            }
        }
    }

    public class ChaseState : State
    {
        public override string StateName
        {
            get { return "Chase"; }
        }

        public override void Enter(Enemy enemy)
        {
            base.Enter(enemy);
            enemy.Speed = 4;
            Console.WriteLine("[Chase:Enter] Speed set to " + enemy.Speed);
        }

        public override void Update(Enemy enemy)
        {
            enemy.MoveCloser(enemy.Speed);
            Console.WriteLine("[Chase:Update] " + enemy.Name + " is running. Distance: " + enemy.DistanceToPlayer);

            if (enemy.DistanceToPlayer <= 2)
            {
                enemy.ChangeState(new AttackState());
            }
        }

        public override void Exit(Enemy enemy)
        {
            base.Exit(enemy);
            enemy.Speed = 0;
            Console.WriteLine("[Chase:Exit] Speed reset to " + enemy.Speed);
        }
    }

    public class AttackState : State
    {
        public override string StateName
        {
            get { return "Attack"; }
        }

        public override void Update(Enemy enemy)
        {
            Console.WriteLine("[Attack:Update] " + enemy.Name + " is swinging a sword at the player.");
        }
    }

    public class Enemy
    {
        private State currentState;

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

        public void ChangeState(State newState)
        {
            Console.WriteLine("[State] " + Name + ": " + currentState.StateName + " -> " + newState.StateName);
            currentState.Exit(this);
            currentState = newState;
            currentState.Enter(this);
        }

        public void Update()
        {
            currentState.Update(this);
        }
    }

    public class Lesson06Runner
    {
        public static void Main()
        {
            Console.WriteLine("=== Lesson 06: Abstract Base State Class ===");
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

            Console.WriteLine("Lesson 06 completed.");
        }
    }
}