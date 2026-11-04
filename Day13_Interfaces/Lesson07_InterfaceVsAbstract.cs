using System;

namespace Day13_Lesson07_InterfaceVsAbstract
{
    public interface IAttack
    {
        void Attack();
    }

    public abstract class Enemy
    {
        public string Name = "Enemy";
        public int Health = 100;

        public void ShowStatus()
        {
            Console.WriteLine(Name + " health: " + Health);
        }
    }

    public class Skeleton : Enemy, IAttack
    {
        public Skeleton()
        {
            Name = "Skeleton";
        }

        public void Attack()
        {
            Console.WriteLine("Skeleton hits with a rusty blade!");
        }
    }

    public class Lesson07Runner
    {
        static void Main()
        {
            Skeleton skeleton = new Skeleton();

            skeleton.ShowStatus();
            skeleton.Attack();

            Console.ReadLine();
        }
    }
}