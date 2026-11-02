using System;

namespace Day11Lesson04
{
    abstract class RPGFighter
    {
        public string Name;

        public abstract void Attack();
    }

    class DarkKnightFighter : RPGFighter
    {
        public DarkKnightFighter()
        {
            Name = "Dark Knight";
        }

        public override void Attack()
        {
            Console.WriteLine(Name + " attacks with a powerful sword!");
            Console.WriteLine("Enemy takes 50 damage!");
        }
    }

    class SkeletonWarriorFighter : RPGFighter
    {
        public SkeletonWarriorFighter()
        {
            Name = "Skeleton Warrior";
        }

        public override void Attack()
        {
            Console.WriteLine(Name + " attacks with a bone weapon!");
            Console.WriteLine("Enemy takes 30 damage!");
        }
    }

    class AbstractMethodsLesson04Runner
    {
        static void Main(string[] args)
        {
            DarkKnightFighter knight = new DarkKnightFighter();

            SkeletonWarriorFighter skeleton =
                new SkeletonWarriorFighter();

            knight.Attack();

            Console.WriteLine();

            skeleton.Attack();

            Console.ReadKey();
        }
    }
}