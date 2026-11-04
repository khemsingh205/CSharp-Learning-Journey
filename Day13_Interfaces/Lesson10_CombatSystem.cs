using System;
using System.Collections.Generic;

namespace Day13_Lesson10_CombatSystem
{
    public interface IDamageable
    {
        string Name { get; }
        bool IsAlive { get; }
        void TakeDamage(int amount);
    }

    public interface IAttack
    {
        void Attack(IDamageable target);
    }

    public class Skeleton : IDamageable
    {
        private int health = 40;

        public string Name { get { return "Skeleton"; } }
        public bool IsAlive { get { return health > 0; } }

        public void TakeDamage(int amount)
        {
            health = health - amount;
            Console.WriteLine("Skeleton takes " + amount + " damage. Health: " + health);
        }
    }

    public class Dragon : IDamageable
    {
        private int health = 120;

        public string Name { get { return "Dragon"; } }
        public bool IsAlive { get { return health > 0; } }

        public void TakeDamage(int amount)
        {
            int reduced = amount - 10;
            health = health - reduced;
            Console.WriteLine("Dragon scales block 10. Takes " + reduced + " damage. Health: " + health);
        }
    }

    public class Player : IAttack
    {
        private int damage = 50;

        public void Attack(IDamageable target)
        {
            Console.WriteLine("Player attacks " + target.Name + "!");
            target.TakeDamage(damage);

            if (!target.IsAlive)
            {
                Console.WriteLine(target.Name + " is defeated!");
            }
        }
    }

    public class Lesson10Runner
    {
        static void Main()
        {
            Player player = new Player();

            List<IDamageable> enemies = new List<IDamageable>();
            enemies.Add(new Skeleton());
            enemies.Add(new Dragon());

            foreach (IDamageable enemy in enemies)
            {
                player.Attack(enemy);
            }

            Console.ReadLine();
        }
    }
}