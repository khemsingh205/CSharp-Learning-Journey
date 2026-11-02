
using System;

namespace Day11Lesson05
{
    abstract class RPGCharacter
    {
        public abstract string CharacterName { get; set; }

        public abstract int Health { get; set; }

        public void ShowInfo()
        {
            Console.WriteLine("Character: " + CharacterName);
            Console.WriteLine("Health: " + Health);
        }
    }

    class DarkKnight : RPGCharacter
    {
        private string characterName;
        private int health;

        public override string CharacterName
        {
            get { return characterName; }
            set { characterName = value; }
        }

        public override int Health
        {
            get { return health; }
            set { health = value; }
        }

        public DarkKnight()
        {
            CharacterName = "Dark Knight";
            Health = 150;
        }
    }

    class ShadowMage : RPGCharacter
    {
        private string characterName;
        private int health;

        public override string CharacterName
        {
            get { return characterName; }
            set { characterName = value; }
        }

        public override int Health
        {
            get { return health; }
            set { health = value; }
        }

        public ShadowMage()
        {
            CharacterName = "Shadow Mage";
            Health = 100;
        }
    }

    class AbstractPropertiesLesson05Runner
    {
        static void Main(string[] args)
        {
            DarkKnight knight = new DarkKnight();
            ShadowMage mage = new ShadowMage();

            knight.ShowInfo();

            Console.WriteLine();

            mage.ShowInfo();

            Console.ReadKey();
        }
    }
}
