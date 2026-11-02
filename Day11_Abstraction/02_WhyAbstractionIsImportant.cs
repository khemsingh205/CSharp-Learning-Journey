using System;

namespace Day11Lesson02
{
    class DarkMage
    {
        private int mana = 100;

        public void CastShadowBolt()
        {
            Console.WriteLine("Dark Mage prepares Shadow Bolt...");

            if (CheckMana())
            {
                ConsumeMana();
                ActivateShadowMagic();
                DamageEnemy();
            }
            else
            {
                Console.WriteLine("Not enough mana!");
            }
        }

        private bool CheckMana()
        {
            return mana >= 30;
        }

        private void ConsumeMana()
        {
            mana -= 30;

            Console.WriteLine("30 Mana consumed.");
        }

        private void ActivateShadowMagic()
        {
            Console.WriteLine("Shadow magic activated!");
        }

        private void DamageEnemy()
        {
            Console.WriteLine("Enemy takes 60 damage!");
            Console.WriteLine("Remaining Mana: " + mana);
        }
    }

    class AbstractionLesson02Runner
    {
        static void Main(string[] args)
        {
            DarkMage mage = new DarkMage();

            mage.CastShadowBolt();

            Console.ReadKey();
        }
    }
}