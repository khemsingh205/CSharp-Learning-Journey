using System;

namespace Day11Lesson03
{
    abstract class RPGCharacter
    {
        public string Name;
        public int Health;

        public void ShowCharacterInfo()
        {
            Console.WriteLine("Character: " + Name);
            Console.WriteLine("Health: " + Health);
        }
    }

    class DarkKnightCharacter : RPGCharacter
    {
        public DarkKnightCharacter()
        {
            Name = "Dark Knight";
            Health = 150;
        }
    }

    class AbstractClassesLesson03Runner
    {
        static void Main(string[] args)
        {
            DarkKnightCharacter knight = new DarkKnightCharacter();

            knight.ShowCharacterInfo();

            Console.ReadKey();
        }
    }
}