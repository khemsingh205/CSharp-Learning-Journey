using System;

namespace Day25_Lesson02_EnumBasedStateMachine
{
    public enum EnemyState
    {
        Idle,
        Chase,
        Attack,
        Dead
    }

    public class Enemy
    {
        private int distanceToPlayer;
        private int health;

        public string Name { get; private set; }
        public EnemyState State { get; private set; }

        public Enemy(string name, int health, int distanceToPlayer)
        {
            Name = name;
            this.health = health;
            this.distanceToPlayer = distanceToPlayer;
            State = EnemyState.Idle;
        }

        public void SetDistance(int distance)
        {
            distanceToPlayer = distance;
        }

        public void TakeDamage(int amount)
        {
            health -= amount;
            if (health < 0)
            {
                health = 0;
            }

            Console.WriteLine("[Enemy] " + Name + " health: " + health);
        }

        private void ChangeState(EnemyState newState)
        {
            Console.WriteLine("[State] " + Name + ": " + State + " -> " + newState);
            State = newState;
        }

        public void Update()
        {
            switch (State)
            {
                case EnemyState.Idle:
                    Console.WriteLine("[Enemy] " + Name + " is idle. Distance: " + distanceToPlayer);
                    if (distanceToPlayer <= 10)
                    {
                        ChangeState(EnemyState.Chase);
                    }
                    break;

                case EnemyState.Chase:
                    distanceToPlayer -= 4;
                    if (distanceToPlayer < 0)
                    {
                        distanceToPlayer = 0;
                    }
                    Console.WriteLine("[Enemy] " + Name + " is running towards the player. Distance: " + distanceToPlayer);
                    if (distanceToPlayer <= 2)
                    {
                        ChangeState(EnemyState.Attack);
                    }
                    break;

                case EnemyState.Attack:
                    if (health <= 0)
                    {
                        ChangeState(EnemyState.Dead);
                    }
                    else
                    {
                        Console.WriteLine("[Enemy] " + Name + " is swinging a sword at the player.");
                    }
                    break;

                case EnemyState.Dead:
                    Console.WriteLine("[Enemy] " + Name + " is dead. Nothing happens.");
                    break;
            }
        }
    }

    public class Lesson02Runner
    {
        public static void Main()
        {
            Console.WriteLine("=== Lesson 02: Enum-Based State Machine with switch ===");
            Console.WriteLine();

            Enemy enemy = new Enemy("Hollow Soldier", 50, 20);

            for (int frame = 1; frame <= 7; frame++)
            {
                Console.WriteLine("--- Frame " + frame + " ---");

                if (frame == 2)
                {
                    Console.WriteLine("[Player] Player moves closer.");
                    enemy.SetDistance(10);
                }

                if (frame == 6)
                {
                    Console.WriteLine("[Player] Player strikes with 60 damage.");
                    enemy.TakeDamage(60);
                }

                enemy.Update();
                Console.WriteLine();
            }

            Console.WriteLine("Lesson 02 completed.");
        }
    }
}