using System;

namespace Day13_Lesson05_MultipleInterfaces
{
    public interface IAttack
    {
        void Attack();
    }

    public interface IDamageable
    {
        void TakeDamage(int amount);
    }

    public class Knight : IAttack, IDamageable
    {
        public void Attack()
        {
            Console.WriteLine("Knight swings his sword!");
        }

        public void TakeDamage(int amount)
        {
            Console.WriteLine("Knight takes " + amount + " damage.");
        }
    }

    public class Lesson05Runner
    {
        static void Main()
        {
            Knight knight = new Knight();

            knight.Attack();
            knight.TakeDamage(25);

            Console.ReadLine();
        }
    }
}