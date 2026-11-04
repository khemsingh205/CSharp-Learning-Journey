using System;

namespace Day13_Lesson01_IntroToInterfaces
{
    public interface IAttack
    {
        void Attack();
    }

    public class Sword : IAttack
    {
        public void Attack()
        {
            Console.WriteLine("Sword slashes the enemy!");
        }
    }

    public class Lesson01Runner
    {
        static void Main()
        {
            Sword sword = new Sword();
            sword.Attack();
            Console.ReadLine();
        }
    }
}