
using System;

namespace Day11Lesson06
{
    interface ICombat
    {
        void Attack();

        void Defend();
    }

    class DarkKnight : ICombat
    {
        public void Attack()
        {
            Console.WriteLine("Dark Knight attacks with a sword!");
            Console.WriteLine("Enemy takes 50 damage!");
        }

        public void Defend()
        {
            Console.WriteLine("Dark Knight blocks the attack with a shield!");
        }
    }

    class ShadowMage : ICombat
    {
        public void Attack()
        {
            Console.WriteLine("Shadow Mage casts dark magic!");
            Console.WriteLine("Enemy takes 70 magic damage!");
        }

        public void Defend()
        {
            Console.WriteLine("Shadow Mage creates a magical shield!");
        }
    }

    class InterfacesIntroductionLesson06Runner
    {
        static void Main(string[] args)
        {
            DarkKnight knight = new DarkKnight();
            ShadowMage mage = new ShadowMage();

            knight.Attack();
            knight.Defend();

            Console.WriteLine();

            mage.Attack();
            mage.Defend();

            Console.ReadKey();
        }
    }
}
