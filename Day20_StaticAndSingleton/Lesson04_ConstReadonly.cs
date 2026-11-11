using System;

namespace Day20_Lesson04_ConstReadonly
{
    class Boss
    {
        public const int MaxLevel = 50;

        public readonly string Name;
        public readonly int MaxHealth;

        public Boss(string name, int maxHealth)
        {
            Name = name;
            MaxHealth = maxHealth;
        }

        public void ShowInfo()
        {
            Console.WriteLine(Name + " | Max health: " + MaxHealth + " | Max level: " + MaxLevel);
        }
    }

    class Lesson04Runner
    {
        static void Main()
        {
            Console.WriteLine("Dark Fantasy RPG - const and readonly");

            Boss dragon = new Boss("Ancient Dragon", 5000);
            Boss lich = new Boss("Lich King", 3000);

            dragon.ShowInfo();
            lich.ShowInfo();

            Console.WriteLine("Level cap for all bosses: " + Boss.MaxLevel);
        }
    }
}