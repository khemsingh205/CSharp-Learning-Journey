using System;

namespace Day13_Lesson09_InterfacePolymorphism
{
    public interface IAttack
    {
        void Attack();
    }

    public class Sword : IAttack
    {
        public void Attack()
        {
            Console.WriteLine("Sword slashes for 25 damage!");
        }
    }

    public class Bow : IAttack
    {
        public void Attack()
        {
            Console.WriteLine("Bow shoots an arrow for 18 damage!");
        }
    }

    public class Staff : IAttack
    {
        public void Attack()
        {
            Console.WriteLine("Staff casts a dark spell for 40 damage!");
        }
    }

    public class Lesson09Runner
    {
        static void PerformAttack(IAttack weapon)
        {
            Console.WriteLine("Player attacks...");
            weapon.Attack();
        }

        static void Main()
        {
            PerformAttack(new Sword());
            PerformAttack(new Bow());
            PerformAttack(new Staff());

            Console.ReadLine();
        }
    }
}