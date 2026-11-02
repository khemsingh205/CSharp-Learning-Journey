using System;

namespace Day11Lesson01
{
    class DarkKnight
    {
        public void Attack()
        {
            Console.WriteLine("Dark Knight prepares his sword...");
            PerformSwordAttack();
        }

        private void PerformSwordAttack()
        {
            Console.WriteLine("Dark Knight performs a powerful sword attack!");
            Console.WriteLine("Enemy takes 50 damage!");
        }
    }

    class AbstractionLesson01Runner
    {
        static void Main(string[] args)
        {
            DarkKnight knight = new DarkKnight();

            knight.Attack();

            Console.ReadKey();
        }
    }
}