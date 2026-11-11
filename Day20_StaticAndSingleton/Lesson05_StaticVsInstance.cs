using System;

namespace Day20_Lesson05_StaticVsInstance
{
    class Player
    {
        public static int PlayersOnline = 0;

        public string Name;
        public int Gold;

        public Player(string name)
        {
            Name = name;
            Gold = 100;
            PlayersOnline++;
        }

        public void EarnGold(int amount)
        {
            Gold += amount;
            Console.WriteLine(Name + " now has " + Gold + " gold.");
        }

        public static void ShowOnline()
        {
            Console.WriteLine("Players online: " + PlayersOnline);
        }
    }

    class Lesson05Runner
    {
        static void Main()
        {
            Console.WriteLine("Dark Fantasy RPG - Static vs Instance");

            Player knight = new Player("Shadow Knight");
            Player mage = new Player("Ash Mage");

            knight.EarnGold(50);
            mage.EarnGold(20);

            Player.ShowOnline();
        }
    }
}
