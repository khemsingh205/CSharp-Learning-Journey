using System;
using System.Collections.Generic;

namespace Day26.Lesson08
{
    public enum EnemyType
    {
        Goblin,
        Orc,
        Dragon
    }

    public abstract class Enemy
    {
        public string Name { get; private set; }
        public int Health { get; private set; }
        public int AttackPower { get; private set; }
        public int Level { get; private set; }

        protected Enemy(string name, int baseHealth, int baseAttack, int level)
        {
            Name = name;
            Level = level;
            Health = baseHealth + (level - 1) * 10;
            AttackPower = baseAttack + (level - 1) * 2;
        }

        public bool IsAlive
        {
            get { return Health > 0; }
        }

        public void TakeDamage(int damage)
        {
            Health -= damage;
            if (Health < 0)
            {
                Health = 0;
            }
            Console.WriteLine("  " + Name + " ko " + damage + " damage mila, HP bacha: " + Health);
        }

        public void Describe()
        {
            Console.WriteLine("  " + Name + " (Lv " + Level + ") | HP: " + Health + " | ATK: " + AttackPower);
        }

        public abstract string Attack();
    }

    public class Goblin : Enemy
    {
        public Goblin(int level) : base("Goblin", 40, 8, level)
        {
        }

        public override string Attack()
        {
            return Name + " ne chaaku se vaar kiya! (-" + AttackPower + " HP)";
        }
    }

    public class Orc : Enemy
    {
        public Orc(int level) : base("Orc", 90, 15, level)
        {
        }

        public override string Attack()
        {
            return Name + " ne gada ghumaya! (-" + AttackPower + " HP)";
        }
    }

    public class Dragon : Enemy
    {
        public Dragon(int level) : base("Dragon", 250, 40, level)
        {
        }

        public override string Attack()
        {
            return Name + " ne aag ugli! (-" + AttackPower + " HP)";
        }
    }

    public static class EnemyFactory
    {
        public static Enemy Create(EnemyType type, int level)
        {
            switch (type)
            {
                case EnemyType.Goblin:
                    return new Goblin(level);
                case EnemyType.Orc:
                    return new Orc(level);
                case EnemyType.Dragon:
                    return new Dragon(level);
                default:
                    throw new ArgumentOutOfRangeException("type", "Unknown enemy type");
            }
        }

        public static Enemy SpawnRandom(Random rng, int level)
        {
            Array values = Enum.GetValues(typeof(EnemyType));
            EnemyType type = (EnemyType)values.GetValue(rng.Next(values.Length));
            return Create(type, level);
        }

        public static List<Enemy> SpawnWave(Random rng, int count, int level)
        {
            List<Enemy> wave = new List<Enemy>();
            for (int i = 0; i < count; i++)
            {
                wave.Add(SpawnRandom(rng, level));
            }
            return wave;
        }
    }

    public static class Lesson08_EnemyFactorySystem
    {
        public static void Run()
        {
            Console.WriteLine("=== Lesson 08: Enemy Factory System ===\n");

            Console.WriteLine("Har enemy ek baar (Level 1):");
            foreach (EnemyType type in Enum.GetValues(typeof(EnemyType)))
            {
                EnemyFactory.Create(type, 1).Describe();
            }

            Console.WriteLine("\nLevel ka asar (Orc Lv 1 vs Lv 5):");
            EnemyFactory.Create(EnemyType.Orc, 1).Describe();
            EnemyFactory.Create(EnemyType.Orc, 5).Describe();

            Console.WriteLine("\nRandom wave (5 enemies, Level 3):");
            Random rng = new Random(7);
            List<Enemy> wave = EnemyFactory.SpawnWave(rng, 5, 3);
            foreach (Enemy enemy in wave)
            {
                enemy.Describe();
            }

            Console.WriteLine("\nPehle enemy se ladai:");
            Enemy target = wave[0];
            Console.WriteLine("  " + target.Attack());
            target.TakeDamage(30);
            Console.WriteLine("  Zinda hai? " + target.IsAlive);
        }
    }
}